$ErrorActionPreference = 'Stop'
dotnet restore
dotnet build -c Release
$out = "artifacts/publish/win-x64"
dotnet publish -c Release -r win-x64 --self-contained true -o $out
$zip = "artifacts/HECUVoiceLab-win-x64.zip"
if (Test-Path $zip) { Remove-Item $zip }
Compress-Archive -Path "$out/*" -DestinationPath $zip
Write-Host "Portable release: $out"
Write-Host "Zip: $zip"
