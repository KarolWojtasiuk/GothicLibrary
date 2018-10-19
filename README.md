![GothicLibrary](https://i.imgur.com/IKBPYV4.jpg)

# Description
A class library for reading and writing variables from games Gothic and Gothic 2 NotR.

# Using
1. Create instance of class GothicProcess.
```csharp
GothicProcess myGothic = new GothicProcess(GothicVersion.Gothic2, "Gothic2");
```
2. Get value of variable from game.
```csharp
int hp = myGothic.ReadVariable(AddressList.HERO_ATR_HITPOINTS);
```

You can view the list of added addresses by using IntelliSense or by browsing the Address.cs file.
![IntelliSense](https://i.imgur.com/8zg8Cls.png)

# Requirements
### For **Gothic**:
Game in version 1.08k

[Playerkit v1.08k](https://www.worldofgothic.de/dl/download_34.htm)

### For **Gothic 2 NotR**:
Game in version 2.6

[Report-Version rev-2](https://www.worldofgothic.de/dl/download_34.htm)

# Installation
**Package Manager**: 
>`Install-Package GothicLibrary`

**.NET CLI**:
>`dotnet add package GothicLibrary`

# License
This project is licensed under the GNU GPL v3 License - see the LICENSE.md file for details

# Acknowledgments
[Matiszp](https://themodders.org/index.php?action=profile;u=20573) for graphics
