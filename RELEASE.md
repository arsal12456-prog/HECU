# Release

Create a portable Windows x64 release:

```powershell
dotnet publish -c Release -r win-x64 --self-contained true -o artifacts/publish/win-x64
```

The publish folder can be zipped and copied to another Windows machine.
