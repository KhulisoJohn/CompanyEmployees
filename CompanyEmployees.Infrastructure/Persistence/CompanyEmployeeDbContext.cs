using System.Dynamic;
using CompanyEmployees.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployees.Infrastructure.Persistence;

public class CompanyEmployeeDbContext : DbContext
{
    public CompanyEmployeeDbContext(DbContextOptions<CompanyEmployeeDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Company> Companies => Set<Company>();
}
