using CurriculumReviewSystem.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DotNetEnv;
using CompanyEmployees.Infrastructure.Persistence;

namespace CurriculumReviewSystem.Infrastructure.Persistance
{
    // This is the design-time factory EF Core CLI uses
    public class CompanyEmployeeDbContextFactory : IDesignTimeDbContextFactory<CompanyEmployeeDbContext>
    {
        public CompanyEmployeeDbContext CreateDbContext(string[] args)
        {
            // Load environment variables from .env file
             Env.Load("../.env"); // Requires DotNetEnv package in Infrastructure

            var optionsBuilder = new DbContextOptionsBuilder<CompanyEmployeeDbContext>();

            // Read the Supabase connection string from the env
            var connectionString = Environment.GetEnvironmentVariable("SUPABASE_CONNECTION_STRING")
                                   ?? throw new InvalidOperationException("Connection string not found in environment");

            // Configure EF Core to use PostgreSQL
            optionsBuilder.UseNpgsql(connectionString);

            return new CompanyEmployeeDbContext(optionsBuilder.Options);
        }
    }
}

