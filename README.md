# TodoCQRS - Clean Architecture & CQRS Implementation

A professional, robust, and scalable Task Management System built with **.NET 8**. This project serves as a comprehensive demonstration of **Clean Architecture** principles and the **CQRS (Command Query Responsibility Segregation)** pattern.

## 🚀 Key Features

* **Clean Architecture:** Strict separation of concerns across Domain, Application, Infrastructure, and Web API layers to ensure maintainability and testability.
* **CQRS Pattern:** Implementation of the CQRS pattern using **MediatR** to decouple read (Queries) and write (Commands) operations.
* **Automated Validation Pipeline:** A global validation mechanism using **FluentValidation** that intercepts requests in the MediatR pipeline, ensuring data integrity before reaching any handler.
* **Modern C# Implementation:** Utilizing **Sealed Records** for DTOs/Commands/Queries for immutability, safety, and performance.
* **Database:** Lightweight **SQLite** integration with Entity Framework Core for a seamless development experience.

---

## 🏗️ Architecture Overview

The project is structured into four distinct layers, following the Onion Architecture/Clean Architecture principles:

1.  **Domain:** The core layer containing enterprise entities (e.g., `Todo`), marker interfaces, and domain-specific logic. It has zero dependencies on other layers.
2.  **Application:** The heart of the system. Contains the business logic, CQRS Features (Commands/Queries/Handlers), and MediatR Pipeline Behaviors (e.g., `ValidationBehavior`).
3.  **Infrastructure:** Handles data access, EF Core `DbContext` implementation, entity configurations, and database migrations.
4.  **API:** The entry point of the application. An ASP.NET Core Web API that manages HTTP requests and interacts with the application layer solely through MediatR.

---

## 🛠️ Tech Stack & Tools

* **Runtime:** .NET 8
* **ORM:** Entity Framework Core
* **Database:** SQLite
* **Mediator Pattern:** MediatR
* **Validation:** FluentValidation
* **API Documentation:** Swagger / OpenAPI

---

## 🚦 Getting Started

### Prerequisites
* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* A C# IDE (VS Code, Visual Studio 2022, or JetBrains Rider)

### Installation & Execution

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/AmrSameh02/TodoCQRS.git](https://github.com/AmrSameh02/TodoCQRS.git)
    cd TodoCQRS
    ```

2.  **Restore Packages:**
    ```bash
    dotnet restore
    ```

3.  **Database Migration:**
    Ensure you have the EF Core tools installed, then run:
    ```bash
    dotnet ef database update --project Infrastructure --startup-project api
    ```

4.  **Run the Application:**
    ```bash
    dotnet run --project api
    ```

5.  **Explore the API:**
    Once running, navigate to `https://localhost:[PORT]/swagger` to interact with the API via the Swagger UI.

---

## 📂 Project Structure

```text
TodoCQRS/
├── api/                # Web API (Controllers & Configuration)
├── Application/        # Business Logic & CQRS Features
├── Domain/             # Entities & Core Interfaces
└── Infrastructure/     # Data Access & EF Core Implementation
