# Tidal.surge (WinUI 3)

Native Windows desktop UI prototype for Tidal.surge.

## Build (Windows 11)
1. Install .NET SDK 8.0 and Windows App SDK (VS 2022 with "Windows App SDK C#" workload).
2. Open a Developer PowerShell and run:
```
dotnet restore TidalSurge/TidalSurge.csproj
dotnet build TidalSurge/TidalSurge.csproj -c Release
```
3. Run from Visual Studio (F5) or:
```
dotnet run --project TidalSurge/TidalSurge.csproj
```

Note: Effects use WinUI 3. This is a UI scaffold; hook backend/licensing as needed.

## Structure
- App.xaml: resources and dictionaries
- MainWindow: Dynamic Island + left navigation
- Views: Splash, Auth, Dashboard, Macros, CustomMacros, Settings
- Resources: Colors, Styles

## License
For internal prototyping; replace assets with production-ready branding.