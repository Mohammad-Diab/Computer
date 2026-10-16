# Computer

A Windows app that helps you price a PC: pick the processor, motherboard, memory, graphics card, hard disk, case and accessories, and it shows each part's price and the total. Written in VB.NET on .NET Framework 4.0, first with Windows Forms and later with WPF.

## Features

- Log in, then choose the parts one by one: Intel or AMD processor and its model, the motherboard that fits it, memory type and size, an Nvidia, AMD or built-in graphics card, hard disk, optical drive and case.
- Tick the accessories you want (monitor, keyboard, mouse, speakers, printer, scanner, camera and more) and pick a model for each.
- **I've Finished** opens the result window with every part, its price and the total.
- **New** starts over; **About** shows the app's name and copyright.

## Versions

The program has three lines, all in this repository:

- **Computer** (v1.0 to v1.1): Windows Forms, English interface. In 2018 it was reopened in Visual Studio 2017 and became **Computer 1 v1.10**, the current version.
- **Computer 1 v1.5**: a rewrite in Windows Forms with an Arabic interface.
- **Computer v1.6**: the WPF version, Arabic interface, with an intro video (removed again in v1.6.1).

| Version | Date | What's new |
|---|---|---|
| [v1.0.0](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.0.0) | 2011-10-11 | First version: login, part pickers and the price result |
| [v1.0.1](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.0.1) | 2011-10-11 | Parts left as None count as zero in the total |
| [v1.1.0](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.1.0) | 2011-10-15 | Reworked forms, no database settings |
| [v1.1.1](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.1.1) | 2012-09-03 | A picture in the About box |
| [v1.5.0-beta.1](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.5.0-beta.1) | 2012-09-04 | Pre-release: an earlier build of v1.5.0 (its source was not saved) |
| [v1.5.0](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.5.0) | 2012-09-04 | Computer 1 v1.5: new Main, Result, Login, Confirm and About windows, in Arabic |
| [v1.5.1-beta.1](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.5.1-beta.1) | 2012-09-04 | Pre-release: an earlier build of v1.5.1 (its source was not saved) |
| [v1.5.1](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.5.1) | 2012-09-25 | New login and icon, fixed keyboard and mouse lists |
| [v1.6.0-beta.1](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.6.0-beta.1) | 2012-09-25 | First WPF draft |
| [v1.6.0](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.6.0) | 2012-09-27 | WPF version with intro video, price, part picker and help windows |
| [v1.6.1](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.6.1) | 2015-03-28 | New About window, no intro video |
| [v1.10.0-beta.1](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.10.0-beta.1) | 2018-02-04 | v1.1 reopened in Visual Studio 2017 |
| [v1.10.0-beta.2](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.10.0-beta.2) | 2018-02-04 | Simpler menus, toolbar and dialogs |
| [v1.10.0](https://github.com/Mohammad-Diab/Computer/releases/tag/v1.10.0) | 2018-02-04 | Computer 1 v1.10: new Visual Studio 2017 project, prices kept in the resources |

The next idea, **Computer 2** (WPF Ribbon drafts and a Windows Store app), lives in its own repository: [Computer-2](https://github.com/Mohammad-Diab/Computer-2).

## Requirements

Windows with .NET Framework 4.0 or later. Windows 8, 10 and 11 already include it.

## Usage

Download `Computer-v<version>.7z` from [Releases](https://github.com/Mohammad-Diab/Computer/releases) (not sure? take the latest, v1.10.0), extract it and run the exe. There is no installer. Every version above has its own Release. v1.6.0 plays an intro video, `Legend.avi`, from the exe's folder; it is in the same archive.

The app opens with a login window. The demo user name and password are written in the code, in `Computer 1\LoginForm1.vb` (in older versions, in their `LoginForm1.vb` or `Login.vb`).

The exe is not signed, so Windows SmartScreen may warn the first time you run it: click **More info**, then **Run anyway**.

## Building

```
git clone https://github.com/Mohammad-Diab/Computer.git
```

Open `Computer 1.sln` in Visual Studio and build, or run:

```
MSBuild "Computer 1.sln" /p:Configuration=Release
```

The exe is written to `Computer 1\bin\Release`.

The project targets .NET Framework 4.0. Recent Visual Studio versions don't ship its reference assemblies; if the build stops with `MSB3644`, extract the [Microsoft.NETFramework.ReferenceAssemblies.net40](https://www.nuget.org/packages/Microsoft.NETFramework.ReferenceAssemblies.net40) NuGet package and point MSBuild at its `build` folder:

```
MSBuild "Computer 1.sln" /p:Configuration=Release /p:TargetFrameworkRootPath=<package>\build
```

To build an older version, check out its tag and build the `.sln` at the root the same way. v1.5 and v1.6 were published with ClickOnce, and their signing key is not in the repository; turn ClickOnce signing off when you build them:

```
MSBuild <solution>.sln /p:Configuration=Release /p:TargetFrameworkRootPath=<package>\build /p:SignManifests=false /p:GenerateManifests=false
```

## Author

Mohammad Diab

## License

[Apache 2.0](LICENSE)
