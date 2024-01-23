
![Logo](https://drive.google.com/uc?id=1MJtQjj8EHs8qJh-RcTQhHfD1kcaTnQEK)


# Smart Tenant Management

A **Smart Tenant Management** app is a mobile application that helps landlords and property managers manage their rental properties and tenants. It simplifies the process by automating the task of managing rental records and also generates a graph view to understand expense and gain for each property. 


## Tech Stack

[![MAUI Blazor](https://img.shields.io/badge/MAUI%20Blazor-v6.0-purple.svg)](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui?view=aspnetcore-6.0) &nbsp; [![MudBlazor](https://img.shields.io/badge/MudBlazor-v6.11.0-purple.svg)](https://mudblazor.com/) &nbsp; [![C#](https://img.shields.io/badge/C%23-v11.0-purple.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11) &nbsp; [![Dot Net](https://img.shields.io/badge/Dot%20Net-v6.0-purple.svg)](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-6) &nbsp; ![HTML](https://img.shields.io/badge/HTML-v5.0-d25837.svg) &nbsp; ![CSS](https://img.shields.io/badge/CSS-4e9cd3.svg) &nbsp; ![JavaScript](https://img.shields.io/badge/JavaScript-yellow.svg)


## Supported Platforms

 - Android 7.0 (API 24) or higher is required


## IDE

 - Visual Studio Community 2022 (Version :- 17.7.5).
 
	### Required packages for VS 2022
	- .NET Multi-platform App Ul development ([Installation Procedure](https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/install)).
	
	### About
	- Visual Studio 2022 Community edition is a free, fully-featured, and extensible integrated development environment (IDE) for creating modern applications for Android, iOS, Windows, as well as web applications and cloud services. It provides a wide range of tools, services, and features that can help C# or .NET developers to design, develop, test, and deploy their applications more efficiently and effectively.

	### Shortcuts
		- ```Ctrl + k + d```  Apply Indentation to current file
		- ```Ctrl + d```  Duplicate Line
		- ```Ctrl + Shift + w```  Closes all open documents and windows
		- ```Ctrl + Shift + b```  Builds the current solution
		- ```Ctrl + Shift + a```  Create new file in selected folder
		- ```Ctrl + Shift + N```  Creates a new project
		- ```Ctrl + f```  Search given text 
		- ```Ctrl + h```  Find & replace text
		- ```Ctrl + g```  Go to specific line number
		- ```Ctrl + Tab```  Display a list of open documents, and you can cycle through them by holding down the Ctrl key and pressing Tab repeatedly
 
## Git

Github used for maintaining ticket system and PR's
- [Github board](https://github.com/users/chethandvg/projects/1)
- [Commit history](https://github.com/chethandvg/tenant-management/pulls)

	### GUI Git Client
	- [Sourcetree](https://www.sourcetreeapp.com/) was used to make git operation much simple and also to get an easy view on previous git operation via various branches.
	
	### Stats

	![Alt](https://repobeats.axiom.co/api/embed/8ba1e3a688d2c36dcd99726fb3ccdef50474b534.svg "Repobeats analytics image")

##  Requirements Engineering
	
	GitHub board & Jira board is used in this project to record requirements and its progress

&rarr; [Git Board](https://github.com/users/chethandvg/projects/1/views/1)
&rarr; [Jira Board](https://chethandvg3.atlassian.net/jira/software/projects/KAN/boards/1)

## 3. DDD
Creation with Miro of Event Storming file and resulting Diagrams and DDD 

&rarr; [PDF-file with Event Storming, Diagram and DDD](https://github.com/chethandvg/tenant-management/tree/master/DDD.pdf)

## UML 
Unified Modeling Language (UML) diagrams are a visual representation of the structure and behavior of a system. UML diagrams provide a standardized way to communicate the different aspects of a system
UML Diagrams for this project is created with Planttext (Class, Component and User Diagrams)

- &rarr; [PNGs and Planttext-Files](https://github.com/chethandvg/tenant-management/tree/master/UML)

## Analysis Checklist

Checklist to standardize analysis for statup project in the future:
- [x] (Goals and Objectives)
- [x] (Targeted Audience)
- [x] (Market Research)
- [x] (Technical upgrades)
- [x] (Technical Resource Requirement)
- [x] (Risk Assessment)
- [x] (Timeline)
- [x] (Security)
- [x] (Budget Required)

Explantion for the above checklist can be found  using below link
- &rarr; [Analysis](https://github.com/chethandvg/tenant-management/tree/master/Analysis.pdf)

## CCD

Clean code is a set of principles for writing code that is easy to understand and modify
These are the few CCD principles used in this project

&rarr; [Dependency injection](https://github.com/chethandvg/tenant-management/blob/master/SMTApp/Pages/RentPage.razor#L3)

&rarr; [Exception Handling](https://github.com/chethandvg/tenant-management/blob/master/SMTApp/Pages/RentPage.razor#L312)

&rarr; [Doc strings](https://github.com/chethandvg/tenant-management/blob/master/SMTApp/Common/CommonMethods.cs#L10)

&rarr; [Explanatory variable names](https://github.com/chethandvg/tenant-management/blob/master/SMTApp/Pages/RoomPage.razor#L113)

&rarr; [Test Cases]([https://github.com/chethandvg/tenant-management/blob/master/SMTApp/Pages/RoomPage.razor#L113](https://github.com/chethandvg/tenant-management/blob/master/SMTTest/UnitTest1.cs))

The below Cheat Sheet gives the list of points that should be followed for upcoming projects 
&rarr; [Cheat Sheet](https://github.com/chethandvg/tenant-management/blob/master/CCD_CheatSheat.md)


## Metrices
Creation of SonarCloud account and connecting to repository (with advanced settings) for metric badges:

[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=chethandvg_tenant-management&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=chethandvg_tenant-management)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=chethandvg_tenant-management&metric=bugs)](https://sonarcloud.io/summary/new_code?id=chethandvg_tenant-management)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=chethandvg_tenant-management&metric=duplicated_lines_density)](https://sonarcloud.io/summary/new_code?id=chethandvg_tenant-management)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=chethandvg_tenant-management&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=chethandvg_tenant-management)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=chethandvg_tenant-management&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=chethandvg_tenant-management)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=chethandvg_tenant-management&metric=sqale_index)](https://sonarcloud.io/summary/new_code?id=chethandvg_tenant-management)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=chethandvg_tenant-management&metric=ncloc)](https://sonarcloud.io/summary/new_code?id=chethandvg_tenant-management)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=chethandvg_tenant-management&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=chethandvg_tenant-management)


[![Quality gate](https://sonarcloud.io/api/project_badges/quality_gate?project=chethandvg_tenant-management)](https://sonarcloud.io/summary/new_code?id=chethandvg_tenant-management)

## Functional Programming
The functional programming points that are f for it's understanding and adding a class for Recipe as learned in Prog. I for java

&rarr; [Final data structures](https://github.com/chethandvg/tenant-management/blob/master/SMTApp/Pages/MonthlyRentDialog.razor#L73)

&rarr; [(Side effect free functions](https://github.com/chethandvg/tenant-management/blob/master/SMTApp/Common/CommonMethods.cs#L60)

&rarr; [Use closures / anonymous functions](https://github.com/chethandvg/tenant-management/blob/master/SMTApp/Pages/AllTenantsPage.razor#L54)

&rarr; [Use of higher-order functions/functions as parameters and return values](https://github.com/chethandvg/tenant-management/blob/master/SMTApp/Pages/RentPage.razor#L142)

&rarr; [Functions as parameters and return values](https://github.com/chethandvg/tenant-management/blob/master/SMTApp/Pages/RentPage.razor#L169)

## Build Management
Buid process stats in the github is visualized in the below badge

[![.github/workflows/dotnet.yml](https://github.com/chethandvg/tenant-management/actions/workflows/dotnet.yml/badge.svg?branch=develop)](https://github.com/chethandvg/tenant-management/actions/workflows/dotnet.yml)

## Test cases
Test cases used in this project can be found using below link

&rarr; [Click here](https://github.com/chethandvg/tenant-management/blob/master/SMTTest/UnitTest1.cs)

## Acknowledgements

 - [C# Intro](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/).
 - [Dot Net](https://dotnet.microsoft.com/en-us/).
 - [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor).
 - [MudBlazor](https://mudblazor.com/).
 - [.Net MAUI](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui?view=aspnetcore-6.0).


## Authors

- [@chethan](https://github.com/chethandvg)


## 🚀 About Me
Hi there, I am Chethan. I'm a full-stack developer and also student at SRH Berlin University of Applied Sciences. Currently, I am pursuing my Masters in Computer Science | Big Data & Artificial Intelligence. 
    


## 🔗 Connect with me 😉

[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/chethan-d-v-aa4a55174/)<br />
[![gmail](https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white)](mailto:chethandvg3@gamil.com)



## 🛠 Skills
- Blazor
- .Net MAUI
- Azure
- C#
- Dot Net
- Contentful
- CommerceTools
- Algolia
- HTML, CSS, JavaScript

