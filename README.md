\# Legacy WebForms → ASP.NET Core 8 MVC Migration

\*\*Real-world full-stack .NET migration demo\*\* – Shahin Izadi



From a classic ASP.NET WebForms app (GridView + ViewState bloat) to a clean, fast, production-ready ASP.NET Core 8 MVC + EF Core solution.



\### Live Demo (run locally)

\- Legacy WebForms → http://localhost:5001/Products.aspx

\- Modern ASP.NET Core 8 → http://localhost:5000/Products



\### Performance Proof (BenchmarkDotNet – Release)



| Method  | Mean      | Ratio | Allocated | Alloc Ratio |

|---------|-----------|-------|-----------|-------------|

| Legacy  | 42.93 ms  | 1.00  | 9.69 KB   | 1.00        |

| Modern  | \*\*5.06 ms\*\* | \*\*0.12\*\* | 7.96 KB | \*\*0.82\*\*    |



\*\*→ 8.5× faster + 18 % less memory\*\*



!\[Benchmark result](benchmark-result.png)



\### What I did

\- Migrated 15-year-old WebForms to modern ASP.NET Core 8 MVC + Razor

\- Replaced in-memory data with EF Core + SQL Server (migrations + seeding)

\- Eliminated ViewState, session locking, and old pipeline overhead

\- Added unit tests + BenchmarkDotNet comparison

\- Fixed IIS Express port locking, virtual directory issues, and WebApplicationFactory top-level-statement quirks (real-world debugging experience)



\### Tech stack

\- .NET Framework 4.8 → .NET 8

\- WebForms → ASP.NET Core 8 MVC + EF Core

\- SQL Server + migrations

\- BenchmarkDotNet



\### About me – Shahin Izadi

\- Bachelor of Computer Engineering – Tehran University (2018-2024)  

\- Recently moved to Yerevan, Armenia  

\- Looking for my first full-time .NET (Backend / Full-Stack) role – junior or mid-level  

\- English fluent (IELTS Academic Band 7.0)



\*\*Contact\*\*  

Email → meushahin8@gmail.com (fastest reply)  

LinkedIn → linkedin.com/in/shahin-izadi  

instagram → @Shahin\_eaz



Open to Yerevan or remote opportunities. Happy to jump on a call anytime.

