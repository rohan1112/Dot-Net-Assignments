# To Run this project install the following dependencies

# To install packages in VS CODE run this commands in terminal window

    dotnet add package Microsoft.Extensions.Configuration
    dotnet add package Microsoft.Extensions.Configuration.json
    dotnet add package Microsoft.Extensions.Configuration.FileExtensions
    dotnet add package System.Data.SqlClient

# For Visual Studio this can be downloaded from NuGet Package Manager

    Tools->NuGet Package->Manage NuGet Packages for solution->Browse(Search for the Dependencies)

# Creating Table

    CREATE TABLE [dbo].[EmployeeTB] (
        [Id]     INT            IDENTITY (1, 1) NOT NULL,
        [NAME]   NVARCHAR (MAX) NULL,
        [SALARY] FLOAT (53)     NULL,
        PRIMARY KEY CLUSTERED ([Id] ASC)
    );

# Note: appsettings.json file contains the connection string and file path is bin/Debug/net8.0/appsettings.json

        Replace the value of [Initial Catalog=EmployeeDB(Databse Name)]with your actual database name;
