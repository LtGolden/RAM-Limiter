# RAM-Limiter
Limits Application Ram Usage(specifically browsers/discord)

This application is loosely based on 0vm's Ram Limiter, found here: (https://github.com/0vm/RAM-Limiter)


His tool hasn't been updated in a while, so I figured I'd alter it to my tastes and make it very simple to use. There are 2 versions:

The GUI Version: After launching, simply delete the programs you don't want to limit/what you don't have.

The Barebones: Launch it, and it literally just limits Chrome, Discord, Steam, and Overwolf.




Installers are labeled, follow directions in the installer after running them.



YOU HAVE TO RUN THE LIMITER AS ADMINISTRATOR

FYI:Some antiviruses mark this as dangerous due to "Unknown Publisher" or "Unknown/Suspicious Behavior"

I have tried to get rid of this, but with the exception of paying Microsoft to become a verified publisher, there is no way around this. 

The app does nothing but limit memory of the listed apps, which you can see if you look in the source code if that will ease your mind.

If you download it and can't find it, go to your Windows Defender/Other Antivirus and go to "Quarantined Threats"(or something similar), and restore the launcher if it flagged the download.

I apologize for the inconvenience.

# Self-Assembly

IF you want to make sure this warning doesn't pop up, you can build the app yourself from my provided source code.

1. First, download the code. Once you have it downloaded, extract the zip file.

2. Once you have it extracted, navigate to the source code and find the version you want to use("GUI" or "Barebones").

3. Find "DiscordRamLimiter.csproj", right click, and hit "copy as path".

4. Next go here and download .NET Framework 4.7.2 Developer Pack  [https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)

5. Once you downloaded that, run the exe, and follow instructions in their installer.

6. Once all that is done, open a command windows as administrator(hit the windows key, type cmd, and hit run as adminstrator).

7. In the command window, type dotnet build your path here

8. Replace "your path here" with the path you copied earlier(step 3)

9. Hit enter, and let it build.

10. Now, go to the Sourcecode folder, go to whatever version you picked(Barebones or GUI), and find a folder called "bin".

11. Go through that folder until you find RamLimiter.exe, right click, and hit create a shortcut(you might need to right click on it once, exit out, and then rightclick again to see this option).

12. Drag this shortcut onto your desktop.

AND YOUR DONE(theoretically, run it to be sure)

If somewhere along the line this failed, just ask chatGPT for help OR just download the installer on the Releases Page and deal with the antivirus issues the first time you set it up.
