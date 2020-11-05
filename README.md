# Razor Web Page
This project is created using Visual Studio. Prerequisites are: 
* [Visual Studio 2019 16.4 or later](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019) 
* [.NET Core 3.1 SDK or later](https://dotnet.microsoft.com/download/dotnet-core/3.1) 

Template for this project is ASP.NET Core Web Application and Web Application (because of razor pages content)
## Project files:
##Pages folders 
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
