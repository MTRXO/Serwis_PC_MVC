# 🖥️ PC Service Mszczonów

**PC Service Mszczonów** is a simple web application designed for a **computer repair service**.  
The project focuses on providing an easy and convenient way for customers to:
- **Learn about the company and services** through a business card-style website.
- **Submit computer repair requests online** 

---

## 🚀 Features

### **Business Card Website**
- Clear presentation of services provided by the computer repair shop.  
- Company contact information and location.  
- Simple contact form for inquiries.

### **Repair Request System**
- Customers can:
  - Submit a repair request through a web form.
  - Recive information about service


> ⚠️ **Note:**  
> This version is **client-only** and does not include roles or an admin panel.

---

## 🛠️ Tech Stack

| Technology           | Purpose                                 |
|----------------------|-----------------------------------------|
| **ASP.NET Core MVC** | Core framework for backend and application structure |
| **Entity Framework Core (Code First)** | Object-relational mapping (ORM) and database handling |
| **SQL Server**       | Relational database for data storage |
| **HTML5, CSS3, Bootstrap** | Frontend structure, styling, and responsive design |
| **JavaScript**       | Dynamic content and client-side interactivity |
| **Azure**            | Cloud hosting for the application and database |
| **Git & GitHub**     | Version control and code collaboration |


⚙️ Running the Application Locally

1. Clone the repository
-----------------------
Copy the repository from GitHub and navigate to the project folder:

git clone https://github.com/YOUR-USERNAME/pc-service-mszczonow.git
cd pc-service-mszczonow


2. Install .NET SDK
-------------------
Make sure you have .NET 8 SDK installed (or the version specified in the project).

Check your version:

dotnet --version

If you don't have the SDK, download it here:
https://dotnet.microsoft.com/download

3. Configure the database
-------------------------
Create a file named appsettings.json in the project root folder.  
It will contain your connection string and will **not** be uploaded to GitHub.

Example:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=PcSerwisMszczonow;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}

4. Create the database
----------------------
Apply the existing migrations to create the database schema:

dotnet ef database update

If you don’t have the EF Core tools installed, install them:

dotnet tool install --global dotnet-ef

Then run again:

dotnet ef database update

5. Run the application
----------------------
Start the project:

dotnet run

Default application URL:
https://localhost:5001

Open it in your browser to view the website.




