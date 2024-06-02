# ApplicationVisitorLog .NET 9.0 Preview Project

An ASP.NET Core project, created in Visual Studio 2022, that uses .NET 9.0.100-preview.4 to demonstrate how to create a minimal Api. The project simply creates the minimal Api layer for a non functional visitor log application.

Although the Program.cs file can be built without being opininated, there is some flexibility with adding necessary services and then minimal Api routes into separate files. 

With Microsoft also moving away from using the services and extension methods of AddEndpointsApiExplorer, AddSwaggerGen, UseSwagger, and UseSwaggerUI; this project uses [Scalar](https://github.com/scalar/scalar) for testing the OpenApi documentation.

## How to Use

Install the preview version of the .NET 9.0 SDK. Create a top level global.json file with the following:

```
{
  "sdk": {
    "version": "9.0.100-preview.4.24267.66"
  }
}
```

Restore NuGet packages.

Debug profile is set to open automatically at the OpenApi 3.0 endpoint http://localhost:5000/openapi/v1.json and Scalar is available at http://localhost:5000/scalar/v1

## Copyright and Ownership

All terms used are copyright to their original authors.

## .NET 9.0 Preview 4

.NET 9.0.100-preview.4 is available May 21, 2024 and should work with the latest versions of Visual Studio 2022. 