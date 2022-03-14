dotnet tool restore
& 'C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\Common7\IDE\devenv.exe' "$PSScriptRoot\..\src\WebApp.sln" /Build /
# dotnet format -w -s info -a info "$PSScriptRoot\..\src\MedioClinic.sln"
dotnet build "$PSScriptRoot\..\src\MedioClinic.sln"
