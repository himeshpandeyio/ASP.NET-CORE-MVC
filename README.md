# MyMvcApp 🛒

**MyMvcApp** is a **work-in-progress e-commerce project** that I am building while learning **ASP.NET Core MVC** and **.NET 10**.

The purpose of this project is to learn and practice the fundamentals of building web applications with ASP.NET Core MVC, including MVC architecture, Razor Views, Entity Framework Core, and SQL Server.

> 🚧 **Status: In Development**
>
> This project is not finished yet. Features and functionality are being added as I continue learning ASP.NET Core MVC.

## 🎯 Project Goal

The goal of MyMvcApp is to build a basic e-commerce application while gaining practical experience with ASP.NET Core MVC.

Through this project, I am learning how different parts of a web application work together, from handling requests with controllers to working with databases and displaying information through views.

## 🧑‍💻 What I'm Learning

* ASP.NET Core MVC
* .NET 10
* C#
* MVC architecture
* Controllers and Actions
* Models and ViewModels
* Razor Views
* Entity Framework Core
* SQL Server
* Database migrations
* CRUD operations
* Dependency Injection
* Model validation
* HTML and CSS
* Bootstrap
* JavaScript
* Git and GitHub

## 🛠️ Technologies

| Technology            | Purpose                   |
| --------------------- | ------------------------- |
| C#                    | Programming language      |
| .NET 10               | Development platform      |
| ASP.NET Core MVC      | Web framework             |
| Entity Framework Core | Database access           |
| SQL Server            | Database                  |
| Razor                 | Views                     |
| HTML/CSS              | Frontend                  |
| Bootstrap             | UI styling                |
| JavaScript            | Client-side functionality |

## 📂 Project Structure

The project follows the ASP.NET Core MVC structure:

```text
MyMvcApp/
│
├── Controllers/
├── Models/
├── Views/
├── Data/
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── images/
│
├── appsettings.json
├── Program.cs
└── MyMvcApp.csproj
```

The structure may change as the project develops.

## 🚧 Current Progress

This project is currently under development.

I am building it step by step as I learn ASP.NET Core MVC. Some parts of the application may be incomplete, experimental, or subject to change.

### Completed

* [x] Created ASP.NET Core MVC project
* [x] Set up the basic MVC structure
* [x] Connected the project to SQL Server
* [ ] Build product functionality
* [ ] Implement CRUD operations
* [ ] Add shopping cart
* [ ] Add user authentication
* [ ] Add order management
* [ ] Improve UI
* [ ] Complete the e-commerce workflow

> The checklist will be updated as development continues.

## ⚙️ Requirements

To work with this project, you will need:

* [.NET 10 SDK](https://dotnet.microsoft.com/download)
* SQL Server
* Git
* Visual Studio or Visual Studio Code

## 🚀 Running the Project

Clone the repository:

```bash
git clone https://github.com/himeshpandeyio/ASP.NET-CORE-MVC.git
```

Navigate into the project:

```bash
cd ASP.NET-CORE-MVC
```

Restore the dependencies:

```bash
dotnet restore
```

Build the project:

```bash
dotnet build
```

Run the application:

```bash
dotnet run
```

## 🗄️ Database

The project uses **SQL Server** for database storage.

The database connection is configured through `appsettings.json`.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=MyMvcApp;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

> Make sure your local SQL Server configuration matches the connection string used by the project.

If Entity Framework Core migrations are being used, the database can be updated with:

```bash
dotnet ef database update
```

## 📖 Why I Built This

I created this project primarily as a **learning exercise**.

Rather than following only tutorials, I want to understand how ASP.NET Core MVC works by building a project from the ground up and gradually adding features.

As I learn more, I will continue improving and expanding MyMvcApp.

## 🔮 Future Plans

Some features I may add as I continue learning:

* Product management
* Shopping cart
* User registration and login
* Authentication and authorization
* Product search and filtering
* Order management
* Checkout functionality
* Admin functionality
* Better UI/UX
* Validation and error handling
* Testing
* Deployment

These are learning goals and are **not necessarily implemented yet**.

## 👨‍💻 Author

**Himesh Pandey**

GitHub: https://github.com/himeshpandeyio

## 🔗 Repository

https://github.com/himeshpandeyio/ASP.NET-CORE-MVC

---

⭐ **This project is a work in progress. I'm learning, experimenting, and improving it step by step.**
