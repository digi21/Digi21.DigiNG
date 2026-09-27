# Digi21.DigiNG

This package provides a reference assembly with types to interact with the [Digi3D.AI](https://www.digi21.net/Digi3D) application.

The runtime assemblies are installed by Digi3D.AI. The package adds a source file to your C# project that locates them in the Digi3D.AI installation folder when the application starts, so your console application or extension can be installed in any folder. You do not have to add any other package or write any code.

Requirements:

- A C# project targeting .NET 10 on Windows. The source file is not added to Visual Basic or F# projects.
- Digi3D.AI installed. The installation folder is read from the `InstallDir` value of `HKEY_LOCAL_MACHINE\SOFTWARE\Digi21\Digi3D.NET\App\Configuration`. Set the `DIGI3D_INSTALLDIR` environment variable to use another folder.

Set the MSBuild property `Digi21DisableAssemblyResolver` to `true` to leave the source file out of your project.

A Digi3D.AI license is required to run applications that use the assemblies published by this package. [Rent](https://www.digi21.net/Tienda/Alquiler) or [buy](https://www.digi21.net/Tienda/Compra) a license.
