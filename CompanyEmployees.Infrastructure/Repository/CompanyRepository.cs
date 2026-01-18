using System;
using CompanyEmployees.Domain.Entities;
using CompanyEmployees.Domain.Interfaces;
using CompanyEmployees.Infrastructure.Persistence;

namespace CompanyEmployees.Infrastructure.Repository;

public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
{
    public CompanyRepository(CompanyEmployeeDbContext companyEmployeeDbContext)
        : base(companyEmployeeDbContext)
    {
    }
}
