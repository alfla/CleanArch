# CleanArch
My practice of the course Clean Architecture
.
    ├── CleanArch.Application
    ├── CleanArch.Domain
    ├── CleanArch.Infra.Data 
    ├── CleanArch.Infra.IoC
    ├── CleanArch.UI.Mvc
    ├── README.md
    └── .gitignore
        ├── app.js


CleanArch.Application: Take care of our interfaces and our services.
CleanArch.Domain: Here, you can find business or domain rules.
CleanArch.Infra.Data: Here's the back-end data and how to get access to these data.
CleanArch.Infra.IoC: Class in IoC folder help us to create static class that allow us to register our services using core dependency Injection.
CleanArch.UI.MVC: It's our presentation layer.


The command above help you to migrate or update your database
add-migration "InitialMigration" -Context ApplicationDbContext
Update-database

