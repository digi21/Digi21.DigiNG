@echo off
nuget.exe pack Digi21.DigiNG.nuspec
nuget.exe sign Digi21.DigiNG.22.3.0.nupkg -CertificateSubjectName "DREAMING WITH OBJECTS" -TimeStamper http://timestamp.comodoca.com?td=sha256.

