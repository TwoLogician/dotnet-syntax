## .NET Core 3.0

*Trim*

```bash
dotnet publish -r osx-x64 -c Release core/30x/C30AssemblyLinking
```

*Single file*

```bash
dotnet publish -r osx-x64 -c Release /p:PublishSingleFile=true core/30x/C30AssemblyLinking
```

*List*

```
ls core/30x/C30AssemblyLinking/bin/Release/netcoreapp3.0/osx-x64
ls core/30x/C30AssemblyLinking/bin/Release/netcoreapp3.0/osx-x64/publish
rm -rf core/30x/C30AssemblyLinking/bin/Release/netcoreapp3.0/osx-x64/publish
```

*Clean*

```bash
dotnet clean -r osx-x64 -c Release core/30x/C30AssemblyLinking
```

*Execute*

```
./core/30x/C30AssemblyLinking/bin/Release/netcoreapp3.0/osx-x64/publish/C30AssemblyLinking
```