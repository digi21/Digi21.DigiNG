[![NuGet](https://img.shields.io/nuget/v/Digi21.DigiNG?style=flat)](https://www.nuget.org/packages/Digi21.DigiNG/)

# Digi21.DigiNG

This repository contains the source code of the [reference assembly](https://docs.microsoft.com/en-us/dotnet/standard/assembly/reference-assemblies): [Digi21.DigiNG](https://ayuda.digi21.net/digi3d-net/programacion/.net/referencia/digi21.diging) that is distributed through NuGet package to make applications that interact with Digi3D.AI.

It provides mathematical types, types to instantiate the different types of geometries supported by Digi3D.AI, types related to importers/exporters of drawing files, types related to code tables, databases, cameras, etc.

The package also adds [`Digi3DAssemblyResolver.cs`](NuGet/contentFiles/cs/any/Digi3DAssemblyResolver.cs) to the C# projects that reference it, directly or through any other `Digi21.DigiNG.*` package. It loads the runtime assemblies from the Digi3D.AI installation folder, so the application can be installed in any folder.
