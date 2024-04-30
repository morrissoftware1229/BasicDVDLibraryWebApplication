# BasicDVDLibraryWebApplication

## Description of Project
Begins with the ASP.NET Core Web Application (MVC) template
Basic CRUD application which connects to SQL Server Db to persist entered data
Uses .NET 8.0 which is currently in long-term support
Currently doesn't use authentication, logging, or Docker

## Progress by Date
20240430 - Added DVD model properties 

## What I've Learned
I learned how to load a project to a repo using the Visual Studio GUI.
I had to learn a bit more about the various level of headings to use this README file properly.
Begin by creating Models. They should use a singular noun as a name. For instance, I added the DVD model, not the DVDs model. Then,
  connect a database. Then, scaffold a controller. Then, scaffold views.
I learned to add attributes to model properties to make them required.

## Questions I Still Have
A Required attribute tag doesn't get rid of the tip to consider making string properties nullable, so they don't require a Name or
  Genre when they exit the constructor. When does the Required attribute require the string to be passed in by? Is it after
  initialization?