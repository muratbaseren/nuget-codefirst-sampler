# Nuget-CodeFirst-Sampler
This project includes sample controllers, models, views for asp.net mvc codefirst project. Also it will generate sample data for database. This project is applied [SampleCodeFirstCodes](https://www.nuget.org/packages/SampleCodeFirstCodes/) from nuget.org.

Firstly, you should create **Empty Aspnet MVC Project** and install package from Nuget on Visual Studio. 

> **Package includes;** 
> 
>  1. Models of Customer, Category and Product.
>  2. Controllers of Customer, Category and Product.
>  3. Views of Customer, Category and Product.
>  4. Also DatabaseContext and Initializer that has generate sample data
>     when database created.

**Views are modified.** They have bootstrap icons for create, edit, delete. Page links are added to layout menu.

You can use **Nuget Package Manager**. Write the below code to package manager console after created project on visual studio.

> Install-Package **SampleCodeFirstCodes**
