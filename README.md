# Weather.NET
A simple .NET library that uses OpenWeatherMap API to get the weather of different places and cities.

## How to use
To start using this library, you can do this in multiple ways:
1. Download the library as a package in https://nuget.org/packages/Weather.NET. (Recommended)
2. Download the source code and use it as a class library.

### How to use as a package
Using the .NET CLI (you just need to download .NET), in your command line, type the command:
```cd projectFolder```
With "projectFolder" being the path of the project you are working on, then, the next command is:
```dotnet add package Weather.NET```
This will download the package and add the package as a reference. Now you can use the library in your code by just typing:
```using Weather.NET;```
At the beginning of the C# code.

### How to use as a class library.
This is the harder, and more memory heavy way to do it, but you can edit the code of the library yourself, which can be useful.
To download the source code you can easily go to this repository (https://github.com/EloyEspinosa/Weather.NET), then click on the green button that says "Code", and then click on "Download ZIP" and then the download should start.
After the download ends, decompress the .zip file on the path that you prefer, and then type the following commands on the command line:
```cd projectFolder```
With "projectFolder" being the folder of the original project you are working on, and then:
```dotnet add reference libraryFolder/Weather.NET.csproj```
With "libraryFolder" being the folder where you saved the source code.
After this you can finally start using the library by just writing:
```using Weather.NET;```
At the top of your C# code.