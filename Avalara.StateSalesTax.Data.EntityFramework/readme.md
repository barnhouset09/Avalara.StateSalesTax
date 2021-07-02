# Project: Data.EntityFramework

## Purpose

This project encompasses all configuration and object definitions for entity framework.

It uses a code-first approach, with migrations, to allow for versioned and testable database changes.

It relies on SQLLite, and will create the database (.db) file in your OS's designated temp folder.

## Usage

Once the project's nuget packages have been restored and project built successfully:

1. Right click this project in the Solution Explorer and then set it as the Start-up Project.
2. Open the Package Manager Console in Visual Studio
3. Set the "Default Project" drop down to Avalara.StateSalesTax.Data.EntityFramework
4. Enter the command ```update-database``` to generate the database.

This should generate the database and allow you to run the WebAPI project.