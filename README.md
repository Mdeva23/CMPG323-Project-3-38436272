# CMPG 323 Project 3 - 38436272

# Overview:

This project, part of the CMPG 323 course, enhances an existing web application by implementing architectural patterns, coding principles, and design patterns. The application manages CRUD (Create, Read, Update, Delete) functionality for project and client data.

The solution leverages repository classes for data access, ensuring scalability, maintainability, and adherence to good software practices. The project is hosted on Microsoft Azure, utilizing cloud services for deployment and management.

# Prerequisites
Before working on this project, ensure the following tools and services are set up:

Azure Access: Access to the NWU Azure tenant using your MS account.
Azure Resource Group: A resource group in Azure with the appropriate naming convention.
Development Environment: Visual Studio 2022 Community Edition installed with .NET 8.
Code Base: The code base from the eFundi portal under "Projects > Project 3 Resources."
Solution Structure.
The project is organized into the following layers, following best practices:

1. Data Access Layer
TechtrendsContext: The DbContext class responsible for database interactions.
ProjectsRepository: Manages CRUD operations for Project entities.
ClientsRepository: Manages CRUD operations for Client entities.
2. Business Logic Layer
Encapsulated within the repository classes, ensuring data operations are separated from the controllers.
3. Presentation Layer
ProjectController: Handles HTTP requests related to projects and interacts with ProjectsRepository.
ClientController: Handles HTTP requests related to clients and interacts with ClientsRepository.
Features
Project Management: Create, view, edit, and delete projects.
Client Management: Create, view, edit, and delete clients.
Azure Integration: Hosted on Microsoft Azure using App Services, with database integration via the connection string in appsettings.json.
Repository Pattern: Implements repository classes to handle data access, improving code maintainability and testability.
Secure Hosting: The application is hosted securely with HTTPS enforced.
Installation and Setup
Clone the Repository
Clone the repository using Git:
git clone https://github.com/Mdeva23/CMPG323-Project-3.git

Open the Solution in Visual Studio
Double-click the .sln file to open the project in Visual Studio 2022.
Configure Database Connection
Open appsettings.json in the project.
Update the DefaultConnection string to match your SQL Server instance:

"ConnectionStrings": {
  "DefaultConnection": "Data Source=<your-server>;Initial Catalog=<your-database>;User ID=<your-username>;Password=<your-password>;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
}

# Run the Application
Press F5 in Visual Studio to build and run the application locally.
Publish to Azure
Use the Publish feature in Visual Studio:
Right-click on the project in Solution Explorer.
Select "Publish".
Choose "Azure" and follow the prompts to deploy the web app to your Azure App Service.

# Usage
Web Interface
Home Page: Navigate to the application's home page to view an overview of projects and clients.
Manage Projects: Use the Projects menu to create, view, edit, or delete project entries.
Manage Clients: Use the Clients menu to create, view, edit, or delete client entries.
API Endpoints
GET /Project: Returns a list of all projects.
GET /Client: Returns a list of all clients.
POST /Project/Create: Creates a new project.
POST /Client/Create: Creates a new client.


# References:

CMPG323-IT Developments .2023. 31 August CMPG323 weekly virtual class Patterns Introduction. 31 August CMPG323 weekly virtual class Patterns introduction (youtube.com) Date of Access: 15 Aug. 2024.

CMPG323-IT Developments .2023. 5 September Patterns background + Web app demo. 5 September Patterns background +Web app demo (youtube.com) Date of Access: 15 Aug. 2024.

CMPG323-IT Developments .2023. 6 September CMPG323 weekly virtual class Patterns demo. 6 September CMPG323 weekly virtual class Patterns demo (youtube.com) Date of Access: 15 Aug. 2024.

Microsoft. 2023. ASP.NET MVC Overview.  ASP.NET MVC Overview | Microsoft Learn Date of Access: 18 Aug. 2024.

Muller, J. 2024. 03A Introduction to Patterns, 10 July 2024. https://efundi.nwu.ac.za/access/content/group/4493dc23-83c1-4f78-aaa6-89a19cd28d5f/Slides/03A%20Introduction%20to%20Patterns.pptx Date of Access: 17 Aug. 2024.

Muller, J. 2024. 03B Application of Design Patterns, 10 Jul 2024. https://efundi.nwu.ac.za/access/content/group/4493dc23-83c1-4f78-aaa6-89a19cd28d5f/Slides/03B%20Application%20of%20Design%20Patterns.pptx Date of Access: 17 Aug. 2024.

Naik, K. 2023. Design Patterns in C# .NET (2023). Design Patterns In C# .NET (2023) (c-sharpcorner.com) Date of Access: 18 Aug. 2024.
OpenAI. (2024). ChatGPT [ChatGPT model]. https://chat.openai.com/ Date of Access: 18 Aug. 2024. 

Soucoup, M .2022. Publish an ASP.NET Core web API to Azure API Management with Visual Studio. Publish an ASP.NET Core web API to Azure API Management with Visual Studio | Microsoft Learn Date of access: 18 Aug. 2024.

Velayutham, M. 2012. Architectural Patterns in .NET. Architectural Patterns in .NET (c-sharpcorner.com) Date of Access: 18 Aug. 2024.

