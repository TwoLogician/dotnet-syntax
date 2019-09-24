## .NET Core 3.0

*Assembly linking*

```bash
# link
dotnet publish -r osx-x64 -c Release core/30x/C30AssemblyLinking

# single file
dotnet publish -r osx-x64 -c Release /p:PublishSingleFile=true core/30x/C30AssemblyLinking

# list
ls core/30x/C30AssemblyLinking/bin/Release/netcoreapp3.0/osx-x64
ls core/30x/C30AssemblyLinking/bin/Release/netcoreapp3.0/osx-x64/publish

# clean
rm -rf core/30x/C30AssemblyLinking/bin/Release/netcoreapp3.0/osx-x64/publish
dotnet clean -r osx-x64 -c Release core/30x/C30AssemblyLinking

# execute
./core/30x/C30AssemblyLinking/bin/Release/netcoreapp3.0/osx-x64/publish/C30AssemblyLinking
```

*Local tools*

```bash
dotnet tool restore
dotnet dotnetsay
dotnet tool run dotnetsay

dotnet tool install wk.IpAddress
```