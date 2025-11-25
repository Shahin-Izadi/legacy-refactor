\# Legacy WebForms → ASP.NET Core 8 Migration



\### Real-world full-stack .NET migration demo – Shahin Izadi



![.NET 8.0](https://img.shields.io/badge/.NET-8.0-5C2D91?logo=.net&logoColor=white)
![Language C#](https://img.shields.io/badge/Language-C%23-007ACC?logo=csharp&logoColor=white)
![Auth JWT](https://img.shields.io/badge/Auth-JWT-61DAFB)
![ORM EF Core 8](https://img.shields.io/badge/ORM-EF%20Core%208-512BD4)
![Database SQL Server](https://img.shields.io/badge/Database-SQL%20Server-CC2927?logo=microsoft-sql-server&logoColor=white)
![Docs Swagger](https://img.shields.io/badge/Docs-Swagger-85EA2D?logo=swagger&logoColor=black)
![License MIT](https://img.shields.io/badge/License-MIT-yellow)

A complete migration project that shows:



\- Classic WebForms app (GridView + ViewState)



\- Modern ASP.NET Core 8 MVC + EF Core



From a classic ASP.NET WebForms app (GridView + ViewState bloat) to a clean, fast, production-ready ASP.NET Core 8 MVC + EF Core solution.



\## Features



\- Full migration from .NET Framework 4.8 WebForms to ASP.NET Core 8 MVC + Razor



\- Replaced in-memory data with EF Core + SQL Server (migrations + seeding)



\- Eliminated ViewState, session locking, and old pipeline overhead



\- Added unit tests + BenchmarkDotNet comparison



\- Fixed IIS Express port locking, virtual directory issues, and WebApplicationFactory top-level-statement quirks (real-world debugging experience)



\## Project Structure



legacy-refactor/



├── .github/workflows/        # CI/CD workflows



├── LegacyWebForms/           # Original .NET Framework 4.8 WebForms app



│   ├── App\_Start/            # Routing + bundles



│   ├── Content/              # CSS (Bootstrap + Site.css)



│   ├── Properties/           # AssemblyInfo.cs



│   ├── Scripts/              # JS (Bootstrap, jQuery, Modernizr, WebForms)



│   ├── About.aspx            # Example pages



│   ├── Products.aspx



│   ├── Site.Master



│   ├── Web.config



│   └── ...



├── ModernProducts/           # Modern ASP.NET Core 8 MVC app



│   ├── Controllers/          # HomeController.cs, ProductsController.cs



│   ├── Data/                 # ProductDbContext.cs



│   ├── Migrations/           # EF Core migrations



│   ├── Models/               # Product.cs, ErrorViewModel.cs



│   ├── Properties/           # launchSettings.json



│   ├── Views/                # Razor views (Home, Products, Shared)



│   ├── wwwroot/              # Static files (css, js, lib)



│   ├── appsettings.json



│   └── Program.cs



├── ModernProducts.Tests/     # Unit tests



│   └── ProductsControllerTests.cs



├── PerformanceDemo/          # BenchmarkDotNet comparison



│   └── Program.cs



├── benchmark-result.png      # Proof of 8.5× performance gain



└── legacy-refactor.sln



\## Performance Proof (BenchmarkDotNet – Release)



| Method  | Mean      | Ratio | Allocated | Alloc Ratio |



|---------|-----------|-------|-----------|-------------|



| Legacy  | 42.93 ms  | 1.00  | 9.69 KB   | 1.00        |



| Modern  | \*\*5.06 ms\*\* | \*\*0.12\*\* | \*\*7.96 KB\*\* | \*\*0.82\*\*    |



\*\*→ 8.5× faster + 18 % less memory\*\*



!\[Benchmark result](benchmark-result.png)



\## Tech Stack



\- ASP.NET Core 8 MVC



\- Entity Framework Core 8 (Code First)



\- SQL Server / SQLite (easy to switch)



\- BenchmarkDotNet



\- xUnit (for unit tests)



\## Credit



This project was built from scratch to demonstrate real-world .NET migration skills.



\## License



MIT © \[Shahin Izadi] – happy to connect on LinkedIn – feel free to star if you like it!

