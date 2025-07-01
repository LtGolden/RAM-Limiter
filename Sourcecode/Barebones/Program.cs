using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;

namespace RamLimiter
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);

        static string[] targetProcessNames = { "discord", "chrome" };

        static void Main(string[] args)
        {
            if (!IsAdministrator())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ ERROR: This program must be run as Administrator.");
                Console.ResetColor();

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("✅ Running as Administrator.");
            RamLimiter(-1, -1);
        }

        static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                var principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        static void RamLimiter(int min, int max)
        {
            List<Process> processBuffer = new List<Process>();
            bool isWindows = Environment.OSVersion.Platform == PlatformID.Win32NT;

            while (true)
            {
                if (isWindows)
                {
                    processBuffer.Clear();
                    processBuffer.AddRange(Process.GetProcesses()
                        .Where(process =>
                            targetProcessNames.Any(name => process.ProcessName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) &&
                            !process.HasExited && process.Responding));

                    foreach (Process process in processBuffer)
                    {
                        try
                        {
                            if (!process.HasExited)
                                SetProcessWorkingSetSize(process.Handle, min, max);
                        }
                        catch
                        {
                            // Optional: log or ignore access issues
                        }
                    }

                    Console.WriteLine($"Limited {processBuffer.Count} processes at {DateTime.Now:T}");
                }

                Thread.Sleep(1000);
            }
        }
    }
}
