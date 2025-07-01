using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordRamLimiter
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll")]
        static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);

        private CancellationTokenSource cts;
        private List<string> targetProcesses = new List<string> { "discord", "chrome", "firefox", "edge", "thorium", "steam" };

        public MainForm()
        {
            InitializeComponent();
            txtProcesses.Text = string.Join(",", targetProcesses);
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            targetProcesses = txtProcesses.Text.Split(',').Select(p => p.Trim().ToLower()).ToList();
            cts = new CancellationTokenSource();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblStatus.Text = "Running...";

            await Task.Run(() => RamLimiter(cts.Token));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            lblStatus.Text = "Stopped.";
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void RamLimiter(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var processes = Process.GetProcesses()
                        .Where(p => targetProcesses.Any(name => p.ProcessName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0))
                        .ToList();

                    foreach (var process in processes)
                    {
                        try
                        {
                            if (!process.HasExited)
                                SetProcessWorkingSetSize(process.Handle, -1, -1);
                        }
                        catch { }
                    }

                    Invoke(new Action(() => lblStatus.Text = $"Trimmed {processes.Count} processes at {DateTime.Now:T}"));
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() => lblStatus.Text = $"Error: {ex.Message}"));
                }

                Thread.Sleep(1000);
            }
        }
    }
}
