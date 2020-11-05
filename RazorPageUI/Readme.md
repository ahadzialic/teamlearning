## In this section will be described adding a data model and scaffolding that model. Also, adding initial migration. 
### Add a data model
After creating project with name RazorPageUI, right-click the RazorPagesUI project > Add > New Folder. Name the folder Models.

Right click the Models folder. Select Add > Class. Name the class Bill.
See Bill.cs for data model properties. The app's model classes use [Entity Framework Core (EF Core)](https://docs.microsoft.com/en-us/ef/core/) to work with the database. 

## Scaffolding data model 
The scaffolding tool produces pages for Create, Read, Update, and Delete (CRUD) operations for the bill model.
Create a Pages/Bills folder: 
*Right click on the Pages folder > Add > New Folder.
*Name the folder Bills
Right click on the Pages/Bills folder > Add > New Scaffolded Item. In the Add Scaffold dialog, select Razor Pages using Entity Framework (CRUD) > Add.
Complete the Add Razor Pages using Entity Framework (CRUD) dialog:
*Model class : Bill 
*In the Data context class row, select the + (plus) sign and change the generated name from RazorPageUI.Models.RazorPagesBillContext to RazorPageUI.Data.RazorPagesBillContext. It creates the database context class with the correct namespace.

## Initial migration 
This is for working in local database. Creating local database-schema. We will use Package Manager Console (PMC) for: 
* Add initial migration
* Update the database with the initial migration.
For navigate to PMC, click Tools, select NuGet Package Manager > Package Manager Console.

Commands are:

`Add-Migration InitialCreate`

`Update-Database.`

The migrations command generates code to create the initial database schema. The schema is based on the model specified in DbContext. Navigate to View > SQL Server Object Explorer to see your database schema.

