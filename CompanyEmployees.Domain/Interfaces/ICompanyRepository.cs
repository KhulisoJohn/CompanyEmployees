using System;
using CompanyEmployees.Domain.Entities;

namespace CompanyEmployees.Domain.Interfaces;

public interface ICompanyRepository
{
    IEnumerable<Company> GetAllCompanies(bool trackChanges);
}
