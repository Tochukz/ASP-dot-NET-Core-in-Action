# ASP.NET CORE in Action
## Chapter 1: Getting Started with MVC
The [OmniSharp project](http://www.omnisharp.net/) is a set of libraries and editor plugins that provide code suggestions and autocomplete(IntelliSense) across a wide range of editors and operating systems.  

__See the list of project template offered by .NET CLI__  
`$ dotnet new --list`  

## Chapter 2: Building Complete Applications
__Create a new ASP.NET Core MVC project__  
* Generate the scaffolding  
`$ dotnet new mvc -o  MyApp`  
* Restore dependency `dotnet restore`. Froom .NET CLI 2.0, this is done automatically for you.
* Build or compile the application  
`$ dotnet build`  
* Run the application  
`$ dotnet run`  
The most common commands during development are:    
`dotnet restore` `dotnet build` and `dotnet run`

A metapackage is a NuGet package that contains no code, referencing one or more other NuGet packages instead. By adding the metapackage to your app, you can conveniently and implicitly add all of the packages it references. e.g Microsoft.AspNetCore.App  

Note Worthy  
* Partial type/partial method  
  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/partial-method  
* Extension method  
  https://www.c-sharpcorner.com/uploadfile/puranindia/extension-methods-in-C-Sharp-3-0/  

## Chapter 3: Extending Your Applications
Create and Empty Web Applications  
`$ dotnet new web -d learning-middleware`  
Build and run the application  
`$ dotnet build`   
`$ dotnet run`   

Make your error handling page a simple as possible to reduce the possibility of errors reoccuring. Use static error pages instead of dynamic error pages.

Note Worthy:
* Middleware has a similar role to HTTP modules and handlers in ASP.NET but
is more easily reasoned about.  

Highlights:
* How to override the StatusCodePagesMiddleware in an action method. See learning_middleware.HomeController.OffStatusPage

## Chapter 4: Creatin Web Pages with MVC Controllers  
Create new web application without mvc middleware
`$ dotnet new web -o MyMvcApp`  
If you are targetig the full .NET Framework instead of .NET Core, yoou can't use the Microsoft.AspNetCore.All metapackage, so you 'll need to add the Micosoft.AspNetCore.Mvc package to your project explicitly.   
`dotnet add package Microsoft.AspNetCore.Mvc`

Note Worthey:  
It’s also worth bearing in mind that action methods should generally not be performing business logic directly. Instead, they should call appropriate services in the application model to handle requests.  
