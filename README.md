# ASP.NET CORE DataGrid - User Role Based Operations

## Repository Description

This repository contains an ASP.NET Core sample that demonstrates how to enable or disable grid operations such as editing, column editing, and column visibility based on the current user role using a Syncfusion ASP.NET Core DataGrid.

## Project Overview

This sample explains how to control DataGrid behavior dynamically from the server side based on user roles. Instead of hardcoding grid capabilities on the client, the application determines permissions in the controller and passes them to the view using the `ViewBag`. Based on the assigned role, operations such as adding, editing, deleting records, editing specific columns, and toggling column visibility can be allowed or restricted.

The approach is useful in real-world applications where different users require different access levels. For example, an administrator may be allowed to edit and manage all fields, while a standard user may only be permitted to view limited information. This sample focuses on implementing that logic cleanly using ASP.NET Core MVC and Syncfusion DataGrid configuration.

## Key Features

- User role–based control of DataGrid editing operations
- Enables or disables add, edit, and delete actions
- Configures column visibility and column-level editing permissions
- Server-side control using ASP.NET Core controller logic

## Prerequisites

- Visual Studio 2022
- ASP.NET Core compatible .NET SDK

## Running the Application

Follow the steps below to clone the repository, restore dependencies, and run the application.

1. Clone the repository and navigate to the project directory:

   ```bash
   git clone https://github.com/SyncfusionExamples/EJ2-DataGrid-Core-user-role-based-operations.git
   cd EJ2-DataGrid-Core-user-role-based-operations
   ```

2. Restore the required NuGet packages:

   ```bash
   dotnet restore
   ```

3. Run the application using the .NET CLI or Visual Studio:

   ```bash
   dotnet run
   ```

Once the application starts, launch the displayed application URL in a browser. The DataGrid will load with editing, column visibility, and column editing permissions applied based on the user role values configured in the controller.

## Usage Notes

Modify the role-based values in the controller to simulate different user permissions. The grid behavior will update automatically based on the assigned ViewBag values without requiring changes to the client-side markup.

## Additional Resources

- [Syncfusion ASP.NET Core Grid - Show or hide columns](https://ej2.syncfusion.com/aspnetcore/documentation/grid/columns/columns#show-or-hide-columns)
- [Syncfusion ASP.NET Core Grid Columns](https://ej2.syncfusion.com/aspnetcore/documentation/grid/columns/columns)
- [Syncfusion ASP.NET Core Grid Editing](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/)
- [Syncfusion ASP.NET Core Grid Documentation](https://ej2.syncfusion.com/aspnetcore/documentation/grid)
- [Syncfusion ASP.NET Core Demos](https://ej2.syncfusion.com/aspnetcore)
