## Project files:
Here's an overview of the main project folders and files
## Pages folders 
Contains Razor pages and supporting files. Each Razor page is a pair of files:
* A .cshtml file that contains HTML markup with C# code using Razor syntax.
* A .cshtml.cs file that contains C# code that handles page events.

Supporting files have names that begin with an underscore. For example, the _Layout.cshtml file configures UI elements common to all pages. This file sets up the navigation menu at the top of the page and the copyright notice at the bottom of the page. For more information, see [Layout in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/layout?view=aspnetcore-3.1)
## wwwroot folder
Contains static files, such as HTML files, JavaScript files, and CSS files. For more information, see [Static files in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-3.1)
## appSettings.json
Contains the entry point for the program. For more information, see [.NET Generic Host in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-3.1) 
## Startup.cs
Contains code that configures app behavior. For more information, see [App startup in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/startup?view=aspnetcore-3.1) 


## In this section will be described adding a data model and scaffolding that model. Also, adding initial migration. 
### Add a data model
After creating project with name RazorPageUI, right-click the RazorPagesUI project > Add > New Folder. Name the folder Models.

Right click the Models folder. Select Add > Class. Name the class Bill.
See Bill.cs for data model properties. The app's model classes use [Entity Framework Core (EF Core)](https://docs.microsoft.com/en-us/ef/core/) to work with the database. 

### Scaffolding data model 
The scaffolding tool produces pages for Create, Read, Update, and Delete (CRUD) operations for the bill model.
Create a Pages/Bills folder: 
* Right click on the Pages folder > Add > New Folder.
* Name the folder Bills

Right click on the Pages/Bills folder > Add > New Scaffolded Item. In the Add Scaffold dialog, select Razor Pages using Entity Framework (CRUD) > Add.

Complete the Add Razor Pages using Entity Framework (CRUD) dialog:

* Model class : Bill 
* In the Data context class row, select the + (plus) sign and change the generated name from RazorPageUI.Models.RazorPagesBillContext to RazorPageUI.Data.RazorPagesBillContext. It creates the database context class with the correct namespace.

### Initial migration 
This is for working in local database. Creating local database-schema. We will use Package Manager Console (PMC) for: 
* Add initial migration
* Update the database with the initial migration.
For navigate to PMC, click Tools, select NuGet Package Manager > Package Manager Console.

Commands are:

`Add-Migration InitialCreate`

`Update-Database.`

The migrations command generates code to create the initial database schema. The schema is based on the model specified in DbContext. Navigate to View > SQL Server Object Explorer to see your database schema.

