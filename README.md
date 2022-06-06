# ASP.Net - Intro MVC
MVC, Crud ASP.Net, .Net 6, Visual Studio 2022

```
Run Viaual Studio 2022.
New Project
ASP.NET Core Web App (Model-View-Controller)

```

## Dependencies

```
Mange NuGet Packages

Microsoft.EntityFrameworkCore.SqlServer 6.0.5
Microsoft.EntityFrameworkCore.Tools 6.0.5

```

## Mapping Database (Console)
* **https://docs.microsoft.com/en-us/ef/core/cli/powershell**
* **https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings**
* **https://docs.microsoft.com/en-us/ef/core/managing-schemas/scaffolding?tabs=dotnet-core-cli**

```
Package Manager Console (Mapping Data Base - Change name and instance data base)

Scaffold-DbContext "Server=DESKTOP-J68K3OO; Database=Pub; Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Context

Update Database:

Scaffold-DbContext "Server=DESKTOP-J68K3OO; Database=Pub; Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Context -Force


Connection string stored in appsettings.json:

Scaffold-DbContext "Name=ConnectionStrings:YourDatabaseAlias" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Context

Scaffold-DbContext "Name=ConnectionStrings:DevConnection" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Context

appsettings.json

appsettings.json

"ConnectionStrings": {
    "DevConnection": "Server=DESKTOP-J68K3OO; Database=Pub; Trusted_Connection=True;"
 }
 

"ConnectionStrings": {
    "DevConnection": "Server=(local)\\;Database=company_db_01;Trusted_Connection=True;MultipleActiveResultSets=True"
 }
 

Examples:

Scaffold-DbContext "Server=GEOLAP\SQLEXPRESS; Database=Pub; Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Scaffold-DbContext "Server=GEOLAP\SQLEXPRESS; Database=Pub; Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir

```

## Razor syntax reference for ASP.NET Core
* **https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-6.0**
* **https://docs.microsoft.com/es-es/aspnet/web-pages/overview/data/working-with-files**

```
*.cshtml
```
## Add Controller and view
```
Add controller mvc empty
Click derecho en el método del controlador (index) y seleccionar Agregar vista.

```

## Reference
* **https://www.youtube.com/watch?v=28LjewDjaz4**


