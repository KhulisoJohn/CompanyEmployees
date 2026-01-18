using System;
using CompanyEmployees.Domain.Interfaces;
using CompanyEmployees.Infrastructure.Persistence;

namespace CompanyEmployees.Infrastructure.Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly CompanyEmployeeDbContext _companyEmployeeDbContext;
    private readonly Lazy<ICompanyRepository> _companyRepository;
    private readonly Lazy<IEmployeeRepository> _employeeRepository;

    public RepositoryManager(CompanyEmployeeDbContext companyEmployeeDbContext)
    {
        _companyEmployeeDbContext = companyEmployeeDbContext;

        _companyRepository = new Lazy<ICompanyRepository>(() =>
            new CompanyRepository(_companyEmployeeDbContext));

        _employeeRepository = new Lazy<IEmployeeRepository>(() =>
            new EmployeeRepository(_companyEmployeeDbContext));
    }

    public ICompanyRepository Company => _companyRepository.Value;
    public IEmployeeRepository Employee => _employeeRepository.Value;

    public void Save() => _companyEmployeeDbContext.SaveChanges();
}
