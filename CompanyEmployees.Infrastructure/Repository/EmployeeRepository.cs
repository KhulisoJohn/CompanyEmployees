using System;
using CompanyEmployees.Domain.Entities;
using CompanyEmployees.Domain.Interfaces;
using CompanyEmployees.Infrastructure.Persistence;

namespace CompanyEmployees.Infrastructure.Repository;

public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
{
    public EmployeeRepository(CompanyEmployeeDbContext companyEmployeeDbContext)
        : base(companyEmployeeDbContext)
    {
    }
}
