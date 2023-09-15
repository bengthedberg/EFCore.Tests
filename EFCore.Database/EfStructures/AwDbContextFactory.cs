using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Database.EfStructures;
public class AwDbContextFactory : IDesignTimeDbContextFactory<AwDbContext>
{
    //This is only used by the design time tooling CLI
    public AwDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AwDbContext>();
        var connectionString =
            @"server=localhost;Database=AdventureWorks;User Id=sa;Password=P@ssword01;Encrypt=True;TrustServerCertificate=True;";
        optionsBuilder
            .UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
        //Console.WriteLine(connectionString);
        return new AwDbContext(optionsBuilder.Options);
    }
}
