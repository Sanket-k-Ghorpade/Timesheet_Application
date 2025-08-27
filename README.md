#### Timesheet Management Application
This repository contains the source code for a full-stack timesheet management system, built with a secure ASP.NET Core backend and a clean, responsive vanilla JavaScript frontend.

## Key Features
Secure User Management: Includes endpoints for employee registration and JWT-based authentication.

Full CRUD Operations: Authenticated users can create, read, update, and delete their own timesheet entries.

Protected API: Role-based access control is implicitly handled by ensuring users can only access their own data.

Clean Architecture: The backend is designed with a layered architecture to ensure separation of concerns and maintainability.

Database First Approach: The database schema is managed and versioned using Entity Framework Core migrations.

## Tech Stack & Architecture
This application is built using modern .NET practices and a decoupled architecture.

Framework: ASP.NET Core 8

Data Access: Entity Framework Core 8

Database: SQL Server

Architecture:

Layered Architecture (Controllers, Services, Repositories)

Repository Pattern

Dependency Injection

API Design: RESTful, using Data Transfer Objects (DTOs) to define a clear API contract.

Frontend:

Vanilla JavaScript (ES6+)

Bootstrap 5 for styling

HTML5

## Getting Started
Backend Setup
Open the Timesheet_Application_Backend.sln file in Visual Studio.

Update the DefaultConnection string in appsettings.development.json to point to your SQL Server instance.

In the Package Manager Console, run Update-Database to apply migrations.

Run the project (F5).

Frontend Setup
Open the Timesheet_Application_Frontend folder in a code editor.

In script.js, update the apiBaseUrl variable to match your running backend's URL.

Open index.html in a web browser.
