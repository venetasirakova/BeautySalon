# Beauty Salon Management System

## Overview

**Beauty Salon Management System** is a full-featured web application built with ASP.NET Core MVC. The system provides an efficient and user-friendly interface for managing beauty salon services, service categories, and client appointments.

## Features

* **Service Management (CRUD):** Full Create, Read, Update, and Delete operations for salon services.

* **Category Filtering:** Categorize services (e.g., Hairdressing, Manicure, Facial Treatments) and filter services accordingly.

* **Client Appointments:** Schedule appointments linked to specific services and clients.

* **Validation:** Comprehensive server-side (Data Annotations) and client-side (jQuery Validation) data verification.

* **Responsive UI:** Clean, modern, and mobile-friendly design using Bootstrap 5.

## Architecture & Tech Stack

* **Framework:** ASP.NET Core 8.0 / .NET 6.0 (MVC)

* **Database:** Microsoft SQL Server

* **ORM:** Entity Framework Core (Code-First)

* **Frontend:** HTML5, CSS3, Razor Views, Bootstrap 5

* **Design Patterns & Principles:** Dependency Injection, MVC Architecture, SOLID principles

## Entity Models

1. **Category:** Represents service categories (`Id`, `Name`, `Services`).

2. **Service:** The main entity representing salon offerings (`Id`, `Name`, `Description`, `Price`, `DurationInMinutes`, `CategoryId`).

3. **Appointment:** Tracks client bookings (`Id`, `ClientName`, `ClientPhone`, `DateTime`, `ServiceId`, `Status`).

## Getting Started & Prerequisites

### Prerequisites

* [.NET 8.0 SDK](https://dotnet.microsoft.com/download) (or .NET 6.0+)

* [MS SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or SQL Express / LocalDB

* [Visual Studio 2022](https://visualstudio.microsoft.com/) (recommended) or VS Code

## Setup & Installation Instructions

1. **Clone the Repository:**

   ```
   git clone https://github.com/your-username/BeautySalon.git
   cd BeautySalon
   
   ```

2. **Configure Connection String:**
   Open `appsettings.json` and verify or update the connection string to match your local SQL Server instance:

   ```
   "ConnectionStrings": {
     "DefaultConnection": "Server=.;Database=BeautySalonDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
   }
   
   ```

3. **Apply Database Migrations:**
   Run the following command in the terminal / Package Manager Console to create the database and seed initial data:

   ```
   dotnet ef database update
   
   ```

4. **Run the Application:**

   ```
   dotnet run
   
   ```

   Open your browser and navigate to `https://localhost:7123` (or the URL provided in the console).

## Environment Variables & Credentials

No external API keys or environment variables are required for local testing. The default configuration uses local SQL Server Windows Authentication (`Trusted_Connection=True`).

## License & Project Submission

This project is created for the ASP.NET Fundamentals Course Assignment.