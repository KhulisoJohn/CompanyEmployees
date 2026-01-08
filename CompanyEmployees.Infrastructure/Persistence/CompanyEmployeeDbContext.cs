using System.Dynamic;
using CompanyEmployees.Domain.Entities;
using CompanyEmployees.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployees.Infrastructure.Persistence;

public class CompanyEmployeeDbContext : DbContext
{
    public CompanyEmployeeDbContext(DbContextOptions<CompanyEmployeeDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }

    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Company> Companies => Set<Company>();
}
