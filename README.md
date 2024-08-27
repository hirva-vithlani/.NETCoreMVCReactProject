In this web application we are using ASP.NET core 8.0 and react.js along with MVC, Entity framework and LinQ for CRUD operations on Employee DATA.

To run the application we need to download all files, along with it install Visual Studio 2022 and SQL Server 2014.

Steps to follow:
1) Install .NET Core 8.0.0 or above SDK from here.
2) Install the latest version of Visual Studio 2022 Community Edition from here.
3) Download and install the latest version of Node.js from here.
4) SQL Server 2014 or above.
5) Download all the files from Git repository from main branch and open EmployeeManagementSystem solution in visula studio.
6) Open visual studio cli and run command: Install-Package Microsoft.EntityFrameworkCore.SqlServer, Install-Package Microsoft.EntityFrameworkCore.Tools
7) Open CMD and navigate to the path where project solution is, and run command: npm install
8) Go to NuGet package manager for unit test project named EmployeeManagementXUnitTest and install 'Micrsoft.AspNetCore.MVC.Testing' if not already installed.
9) Build the project and see if there are any errors or missing packages still which needs to installed.
10) Run the EmployeeManagementSystem (Press f5 if set as start up project) and see CRUD fucntionality.
11) To perform unit tests, go to 'test' in toolbar and click on 'Run all tests' to test unit testing.

Happy Testing!
