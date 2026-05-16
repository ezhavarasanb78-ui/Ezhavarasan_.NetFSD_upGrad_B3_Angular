# Shopez Backend

This is the backend microservices application of the Shopez E-Commerce platform developed using ASP.NET Core Web API.

## Prerequisites

Make sure the following software is installed:

- Visual Studio 2022
- .NET SDK
- SQL Server
- SQL Server Management Studio (SSMS)

Steps to Run the Backend
 1. Navigate to Backend Folder


cd shopez-backend
2. Open the Solution

Open the `.sln` file in Visual Studio.

3. Configure Database

Update the connection string in:


appsettings.json


Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=ShopezDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```
4. Restore Dependencies

Build the solution to restore required NuGet packages.

dotnet restore

5. Run Database Migration


dotnet ef database update

6. Set Startup Projects

Set the following services as startup projects in Visual Studio:

- User Service
- Product Service
- Order Service
- API Gateway

7. Run the Backend Services

Press:


F5

OR run using terminal:

dotnet run

8. Verify API Endpoints

Open Swagger or test APIs using Postman.

Example:

https://localhost:5001/swagger
 Backend Workflow


Start
  
Open Backend Project
  
Configure Database
  
Run dotnet restore
  
Run Database Migration
  
Run Backend Services
  
Test APIs in Swagger/Postman
  
Backend Running Successfully
 
End


 Microservices Included

- User Service
- Product Service
- Order Service
- API Gateway

Tech Stack

- ASP.NET Core Web API
- C#
- SQL Server
- JWT Authentication
- Microservices Architecture