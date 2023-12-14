@echo off
nuget.exe pack Digi21.DigiNG.nuspec
nuget.exe sign Digi21.DigiNG.22.4.0.nupkg -CertificateSubjectName "DREAMING WITH OBJECTS S.L." -TimeStamper http://timestamp.comodoca.com?td=sha256.

