# EF Core with database first 

### Pre-requisite

**Scaffolding tools**

Install tool :    
`dotnet tool install --global dotnet-ef`  

or update to latest:    
`dotnet tool update --global dotnet-ef`


## Setup Steps

Create Project:   
`dotnet new sln`   
`dotnet new gitignore`    
`dotnet new console -n EFCore.Database`   
`dotnet sln add (dir -r **/*.csproj)`    

Add required nuget packages:   
`dotnet add .\EFCore.Database\EFCore.Database.csproj package Microsoft.EntityFrameworkCore.Design`    
`dotnet add .\EFCore.Database\EFCore.Database.csproj package Microsoft.EntityFrameworkCore.SqlServer`   

Scaffold the db context

`cd .\EFCore.Database\`   
`dotnet ef dbcontext scaffold "server=localhost;Database=AdventureWorks;User Id=sa;Password=P@ssword01;Encrypt=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -d -c AwDbContext --context-dir EfStructures -o Entities`

