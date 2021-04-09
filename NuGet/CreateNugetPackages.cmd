@echo off
nuget.exe pack Digi21.DigiNG.nuspec
nuget.exe sign Digi21.DigiNG.21.0.0.nupkg -CertificateSubjectName "DREAMING WITH OBJECTS" -TimeStamper http://tsa.starfieldtech.com

