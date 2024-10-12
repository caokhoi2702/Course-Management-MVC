# Course Management MVC
Course Management Application built using .NET + Entity framework + SQL server.
# Step-by-step
1. Create database in SQL Server using the query file
2. Create a new project using ASP.NET Core Web APP (Model-View-Controller) on Visual Studio
3. Install NuGet Packages: EntityFrameworkCore.SqlServer, EntityFrameworkCore.Tools
4. Add `Connection String` from the database to appsettings.json
5. Create `ApplicationDBContext.cs` service then add it to `Program.cs` to connect to database.
6. Create `KhoaHoc` and `MonHoc` models respectively to `KhoaHoc` and `MonHoc` tables.
7. Create `CourseController` and `Course` View.
8. Edit and format `Index.cshtml` for `CourseController`.
