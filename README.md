Timesheet Management Application
This is a full-stack web application for managing employee timesheets, built with an ASP.NET Core Web API backend and a vanilla HTML, CSS, and JavaScript frontend.

Features
Employee Registration & Login: Secure user account creation and authentication.

JWT Authentication: The API is secured using JSON Web Tokens to protect endpoints.

Timesheet CRUD: Authenticated users can create, read, update, and delete their own timesheet entries.

Clean Architecture: The backend follows a repository-service pattern for a clear separation of concerns.

Database Migrations: The database schema is managed using Entity Framework Core migrations.

Tech Stack
Backend
ASP.NET Core 8 Web API

Entity Framework Core 8

SQL Server

JWT Bearer Authentication

Frontend
HTML5

CSS3 (with Bootstrap 5 for styling)

Vanilla JavaScript (ES6+)

Getting Started
1. Backend Setup
Open the Timesheet_Application_Backend.sln file in Visual Studio.

In appsettings.development.json, update the DefaultConnection string to point to your SQL Server instance.

Open the Package Manager Console and run Update-Database to apply the migrations and create the database schema.

Run the project (press F5).

2. Frontend Setup
Open the Timesheet_Application_Frontend folder in a code editor like VS Code.

In script.js, update the apiBaseUrl variable to match the URL of your running backend (e.g., https://localhost:7207/api).

Open the index.html file in a web browser.

How to Use
Register: Create a new employee account from the registration page.

Login: Use the registered credentials to log in. You will receive a JWT token which is stored in the browser's session storage.

Manage Timesheets: Once logged in, you can view, add, edit, and delete your timesheet entries. All requests to the timesheet API are authenticated using the stored token.
