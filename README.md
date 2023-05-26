# DrSillyStringz.Solution_

#### _MVC web application to manage engineers and machines

#### By **Laura Hope**

## Technologies Used

* _C#_
* _.NET v6.0_
* _MySQLWorkbench_
* _MS EntityFrameworkCore v6.0.0_
* _Pomelo EntityFrameworkCore MySQL v6.0.0_
* _Git_
* _VSCode_

## Description

_This application showcases using EFCore and MySQL to create and link database schemas to the project models. Databases are generated via migrations using the command line. Application uses HTML helper methods, LINQ commands, and navigation properties to allow the owner of Dr. Sillystringz to add engineers and machiness and link these via many-to-many relationships._

## Setup/Installation Requirements

**Project Set-Up**
* _Clone "DrSillyStringz.Solution“ from the repository to your desktop_
* _Navigate to "DrSillyStringz.Solution" directory via your local terminal command line_
* _Create a file ".gitignore" in the "DrSillyStringz.Solution" directory_
```
$ touch .gitignore
```
* _Copy/paste the following in the .gitignore file:_
```
obj
bin
appsettings.json
```
* _Navigate to the production directory "Factory"_
* _Create a file within the "Factory" folder titled "appsettings.json"_
```
$ touch appsettings.json
```
* _Navigate to the appsettings.json file and copy/paste the following text within the file:_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=dr_silly_stringz;uid=[USER-ID];pwd=[USER-PW];"
  }
}
```
* _Remove the square brackets and replace **USER-ID** and **USER-PW** with your own ID and password_
* _Navigate to the command line within the "Factory" folder and execute command "dotnet build"_
* _To initialize and update the migrations database, type the following commands in the terminal:_
```
$ dotnet ef migrations add Initial 
$ dotnet ef database update
```
* _Add the EF Core packages by typing the following into the command line:_
```
$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
$ dotnet tool install --global dotnet-ef --version 6.0.0
$ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```
* _Return to the command line and type "dotnet watch run" - this should automatically open a browser to the LocalHost:5000 or LocalHost:5001_
* _This is where you can interact with the application via entering engineers, machines, etc._

## Known Bugs

* _No known bugs as of 5/26/23_

## License

MIT License

Copyright (c) [2023] [Laura Hope]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

_If you run into any issues or have questions, ideas or concerns, please reach out to me via email: lauramhope.dpt@gmail.com.  Contributions to the code are highly encouraged._