SalesAnalyticsAPI
Overview
SalesAnalyticsAPI is a .NET Core Web API designed to ingest sales data from CSV files, store it in a relational database, and provide RESTful endpoints for revenue, customer, and product analytics. This API supports easy data loading, querying, and reporting for sales insights.

Features
CSV data import service for bulk sales data ingestion

Entity Framework Core with SQL Server (or SQLite) for data persistence

RESTful API endpoints to query sales analytics (e.g., total revenue, top products, customer segmentation)

OpenAPI (Swagger) documentation for API exploration

Designed with modular architecture — Models, Data, Services, Controllers, DTOs

Prerequisites
.NET 6 SDK or later

SQL Server or SQLite database

(Optional) Visual Studio 2022 or later for development and debugging

Getting Started
1. Clone the Repository
bash
Copy
Edit
git clone https://github.com/kumaresh-rgb/Lumel_Task
cd SalesAnalyticsAPI
2. Configure Database Connection
Update the connection string in appsettings.json or appsettings.Development.json:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=SalesAnalyticsDb;Trusted_Connection=True;"
}
For SQLite, use:

json
Copy
Edit
"DefaultConnection": "Data Source=sales.db"
3. Build the Project
bash
Copy
Edit
dotnet build
4. Apply Migrations and Create Database
bash
Copy
Edit
dotnet ef database update
5. Run the API
bash
Copy
Edit
dotnet run
The API will be accessible at: http://localhost:5000 (or configured ports).

API Endpoints
Route	Method	Description
/api/data/load	POST	Load sales data from CSV file
/api/revenue/total	GET	Get total revenue
/api/products/top	GET	Get top-selling products
/api/customers/top	GET	Get top customers by purchase

Explore the full API documentation via Swagger UI at http://localhost:5000/swagger

Project Structure
Models/ — Entity classes representing database tables

Data/ — EF Core DbContext and database configurations

Services/ — Business logic, including CSV import service

Controllers/ — API endpoint controllers

DTOs/ — Data transfer objects for API responses

Helpers/ — Utility and helper classes

Contribution
Feel free to fork, raise issues, or submit pull requests. Please ensure code quality and add appropriate tests.

License
This project is licensed under the MIT License.

RESULT SCREENSHOT: 
![image](https://github.com/user-attachments/assets/fffae3b7-3bc3-453c-b697-da5b063fe1ef)
![image](https://github.com/user-attachments/assets/3b355998-f598-4a98-881d-2ad6002b5951)


![image](https://github.com/user-attachments/assets/5e572ea1-26e2-4a7f-ab5e-01f05aac18f6)

![image](https://github.com/user-attachments/assets/c4f5e3eb-8639-43be-8eb0-ef61c24b3cc5)
