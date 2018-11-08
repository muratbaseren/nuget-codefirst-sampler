# Code First Sampler

| Build server| Platform       | Status      |
|-------------|----------------|-------------|
| AppVeyor    | Windows        |[![Build status](https://ci.appveyor.com/api/projects/status/c42xi7pbqa601bto?svg=true)](https://ci.appveyor.com/project/muratbaseren/nuget-codefirst-sampler) |

This project includes sample controllers, models, views for asp.net mvc codefirst project. Also it will generate sample data for database. This project is applied [SampleCodeFirstCodes](https://www.nuget.org/packages/SampleCodeFirstCodes/) from nuget.org.

Firstly, you should create **Empty Aspnet MVC Project** and install package from Nuget on Visual Studio. 

> **Package includes;** 
> 
>  1. Models of Customer, Category and Product.
>  2. Controllers of Customer, Category and Product.
>  3. Views of Customer, Category and Product.
>  4. Also DatabaseContext and Initializer that has generate sample data
>     when database created.

**Views are modified.** They have bootstrap 4 icons for create, edit, delete. Page links are added to layout menu and have modal.

# Nuget

You can use **Nuget Package Manager**. Write the below code to package manager console after created project on visual studio.

> Install-Package **SampleCodeFirstCodes**

# ScreenShots

### Home page : Migration tricks

![](https://github.com/muratbaseren/Nuget-CodeFirst-Sampler/blob/master/screenshots/01_home-page-how-i-do-migration.png?raw=true)

### Index page

![](https://github.com/muratbaseren/Nuget-CodeFirst-Sampler/blob/master/screenshots/02_index-page.png?raw=true)

### Modal Details into Index Page
![](https://github.com/muratbaseren/Nuget-CodeFirst-Sampler/blob/master/screenshots/03_index-page-details-modal.png?raw=true)

### Create Page
![](https://github.com/muratbaseren/Nuget-CodeFirst-Sampler/blob/master/screenshots/04_create-page.png?raw=true)

### Edit Page
![](https://github.com/muratbaseren/Nuget-CodeFirst-Sampler/blob/master/screenshots/05_edit-page.png?raw=true)

### Details Page
![](https://github.com/muratbaseren/Nuget-CodeFirst-Sampler/blob/master/screenshots/06_details-page.png?raw=true)

### Delete Page
![](https://github.com/muratbaseren/Nuget-CodeFirst-Sampler/blob/master/screenshots/07_delete-page.png?raw=true)
