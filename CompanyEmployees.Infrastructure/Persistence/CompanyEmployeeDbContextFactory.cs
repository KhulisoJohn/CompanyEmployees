using CurriculumReviewSystem.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DotNetEnv;
using System;
using System.IO;
using CompanyEmployees.Infrastructure.Persistence;

namespace CurriculumReviewSystem.Infrastructure.Persistance
{
    // Design-time factory for EF Core CLI
    public class CompanyEmployeeDbContextFactory : IDesignTimeDbContextFactory<CompanyEmployeeDbContext>
    {
        public CompanyEmployeeDbContext CreateDbContext(string[] args)
        {
            // Determine the absolute path to the API project's root folder
            // Adjust this relative to your solution structure
            var apiRoot = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "CompanyEmployees.API");
            var envFile = Path.Combine(apiRoot, ".env");

            // Load the .env file safely
            if (File.Exists(envFile))
            {
                Env.Load(envFile);
                Console.WriteLine($".env loaded from: {envFile}");
            }
            else
            {
                Console.WriteLine($"Warning: .env file not found at {envFile}. Make sure SUPABASE_CONNECTION_STRING is set in the environment.");
            }

            // Get the connection string from environment variable
            var connectionString = Environment.GetEnvironmentVariable("SUPABASE_CONNECTION_STRING")
                                   ?? throw new InvalidOperationException("SUPABASE_CONNECTION_STRING not found in environment.");

            // Build DbContext options
            var optionsBuilder = new DbContextOptionsBuilder<CompanyEmployeeDbContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new CompanyEmployeeDbContext(optionsBuilder.Options);
        }
    }
}
