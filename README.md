# HotelPmsCore

A Windows desktop Hotel Property Management System (PMS) built with C#, WinForms, and Entity Framework Core.

## Features

- *Customer Management:*  
  - Add, edit, delete, search, and filter customers.
- *Room Management:*  
  - Manage rooms, capacity, types, and seasonal pricing.
- *Category Management:*  
  - Manage categories for room types, roles, etc., with dynamic filtering.
- *Staff & User Management:*  
  - Add/edit/delete/search staff and users with role support.
- *Period Management:*  
  - Define seasonal periods for pricing (e.g., Winter/Summer).
- *Reservation Management:*  
  - Create new reservations:  
    - Select date range and capacity, search available rooms, choose customer, and price calculation (seasonal).
  - Check-in/Check-out workflow.
- *Search/Filter:*  
  - Each module supports advanced search/filter dialogs.
- *Pagination:*  
  - Paginated data display for all lists (page size configurable).
- *Dependency Injection:*  
  - All forms and services injected for modularity and testability.


## Getting Started

1. *Clone the repo:*
    bash
    git clone https://github.com/YOUR_GITHUB_USERNAME/HotelPmsCore.git
    

2. *Set up the database:*
    - Create a SQL database.
    - Update your connection string in appsettings.json or directly in your context.
    - Use Entity Framework migrations or let the app create tables.

3. *Run the application:*
    - Open the solution in Visual Studio.
    - Restore NuGet packages.
    - Build and run!

## Structure

- /Forms - WinForms UI forms for each module (Customers, Rooms, Reservations, etc.)
- /Models - Entity classes (Customer, Room, Reservation, etc.)
- /Services - Business logic and data services for each module.
- /Data - DbContext and database configuration.

## Customization

- To add fields, edit the Models and corresponding Forms.
- For custom filters, extend the Filter forms and update the ApplyFilters logic in the relevant service.

## Contributing

Pull requests are welcome! Please open an issue first for major changes.
