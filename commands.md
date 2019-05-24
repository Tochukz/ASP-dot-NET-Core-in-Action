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

Worthy of Note
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
