# csharp_notes
A collection of my notes about c#

## General commands TODO: title

### Create a new project

```console
dotnet new x -o name
```

fx

```console
dotnet new console -o MyConsoleApp
```

### References and sln

Creating the solution (sln) file

```console
dotnet new sln
```

Adding a reference

```console
dotnet sln add name
```

Making to projects reference each other

```console
dotnet add name1 reference name2
```

fx 

```console
dotnet add MyApp.Tests reference MyApp
```
