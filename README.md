# Pierre's Sweets

#### Description

## Contributors

* Brandon James Fenk

## Description
 This project is a simple web application for a business to keep track of Treats and their Flavors. Treats and Flavors have a many to many relationship meaning each treat can belongs to many flavors. A Treat can have many Flavors. The application allows the user to create, update, delete, and view lists of the Treats they're assigned corresponding Flavors.

## Technologies Used

* _C#_
* _Html_
* _CSS_
* _ASP .NET6_
* _MySQL_
* _MVC_
* _Entity Framework Core_
* _Identity_


## Setup/Installation Requirements

* Install MySQL Community Server and MySQL Workbench. Follow the instructions _[here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql/)_.
* Clone down the git repo ```https://github.com/BrandonF55/PierresSweets.Solutions.git``` to the ```desktop``` directory
* Open the project with VSCode or a different source code editor.
* Restore required packages: change directory to ```Bakery``` To use a tool called dontet-ef run ```$ dotnet tool install --global dotnet-ef --version 6.0.0
``` and in order to use dotnet-ef we also need to install ```$ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0``` then ```dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0``` for the log in and register side of the website. restore with ```$ dotnet restore```After restore do a database update with ```dotnet ef database update``` this will remake the database with the correct tables.
* While in the ```Bakery``` directory use ```$ dotnet build``` to build the program.
* While in the ```Bakery``` directory use ```$ dotnet watch run``` to run the program in the browser with a watcher.

## Database Setup

* To connect your database, create file ```appsettings.json``` in the production directory ```pierres_sweets```
* Fill in the file with the following code: Be sure to replace the required fields marked with ```[]``` that must contain the database name, user id, and password.
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DB-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```

## Known Bugs

<!-- * _On the client details page, the appointment link should route to appointment details instead it is routed back to client details_ -->
* If any bugs are found please email a brief description to: ```brandon.fenk99@gmail.com```

## License
Copyright (c) 2022 Brandon James Fenk
_[MIT](https://choosealicense.com/licenses/mit/)_