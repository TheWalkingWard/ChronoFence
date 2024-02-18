ChronoFence Installation Instructions
====================================

## Windows (x64: 7/8.0/8.1/10/11)
Requirements: 

- .NET 8.0 Desktop Runtime 
  (<https://download.visualstudio.microsoft.com/download/pr/84ba33d4-4407-4572-9bfa-414d26e7c67c/bb81f8c9e6c9ee1ca547396f6e71b65f/windowsdesktop-runtime-8.0.2-win-x64.exe>)

Installation:

1. Install .NET 8.0 Desktop Runtime
2. Execute ChronoFence.exe

## Linux (x64: Ubuntu 22.04)
Requirements:

- WINE
  (<https://wiki.winehq.org/Ubuntu>)
- Winetricks
  (<https://github.com/Winetricks/winetricks?tab=readme-ov-file#manual-install>)
- .NET 8.0 Desktop Runtime 
  (<https://download.visualstudio.microsoft.com/download/pr/84ba33d4-4407-4572-9bfa-414d26e7c67c/bb81f8c9e6c9ee1ca547396f6e71b65f/windowsdesktop-runtime-8.0.2-win-x64.exe>)

Installation:

1. Execute linux\_debian\_install.sh to install WINE and Winetricks
2. Install .NET 8.0 Desktop Runtime
3. Execute ChronoFence.exe or open terminal at file location and enter command: wine ./ChronoFence.exe

## MacOS
Requirements:

- Homebrew
  (<https://brew.sh/#install>)
- MacPorts
  (<https://www.macports.org/install.php>)
- WINE
  (<https://wiki.winehq.org/MacOS>)
- Winetricks
  (<https://github.com/Winetricks/winetricks?tab=readme-ov-file#installing>)
- .NET 8.0 Desktop Runtime
  (<https://download.visualstudio.microsoft.com/download/pr/84ba33d4-4407-4572-9bfa-414d26e7c67c/bb81f8c9e6c9ee1ca547396f6e71b65f/windowsdesktop-runtime-8.0.2-win-x64.exe>)

Installation:

1. Install Homebrew
   via the macOS Terminal, run this command: <br/>
   `/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)` <br/>
   or download and install via macOS package installer: <br/>
   <https://github.com/Homebrew/brew/releases>
2. Install MacPorts
   download and install package for appropriate macOS version:
   <https://www.macports.org/install.php>
3. Install WINE
   via the macOS Terminal, run this command: <br/>
   `brew tap homebrew/cask-versions` <br/>
   `brew install --cask --no-quarantine wine-stable`
4. Install Winetricks
   via the macOS Terminal, run this command:
   sudo port install winetricks
5. Install .NET 8.0 Desktop Runtime
6. Execute ChronoFence.exe
