dotnet tool restore
dotnet format -w -s info -a info "$PSScriptRoot\..\src\MedioClinic.sln"
dotnet build "$PSScriptRoot\..\src\MedioClinic.sln"
