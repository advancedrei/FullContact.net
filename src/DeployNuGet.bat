@echo off
echo Would you like to push the debug or production version?
set /p choice="Enter d/p: "

del *.nupkg
@echo on

if /i %choice% equ d (
    ".nuget/nuget.exe" push FullContactApi.NuGetPackage\bin\Debug\FullContact.*.nupkg
)
else (
    ".nuget/nuget.exe" push FullContactApi.NuGetPackage\bin\Release\FullContact.*.nupkg
)
pause