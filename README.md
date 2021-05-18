![NuGet](https://img.shields.io/nuget/dt/GothicLibrary?style=for-the-badge)
```diff
- Deprecated! Don't use in future projects. New version in plans.
- Code is really bad quality because this was one of my first projects in C#.
```
![GothicLibrary](https://i.imgur.com/IKBPYV4.jpg)
# Description
A class library for reading and writing variables from games Gothic and Gothic 2 NotR.

# Using
1. Create instance of class GothicProcess.
```csharp
GothicProcess myGothic1 = new GothicProcess(GothicVersion.Gothic1, "GothicMod"); //Gothic 1
GothicProcess myGothic2 = new GothicProcess(GothicVersion.Gothic2, "Gothic2"); //Gothic 2 NotR
```
2. Get value of variable from game.
```csharp
int hp1 = myGothic1.ReadVariable(AddressList.HERO_ATR_HITPOINTS); //Gothic 1
int hp2 = myGothic2.ReadVariable(AddressList.HERO_ATR_HITPOINTS); //Gothic 2 NotR
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
