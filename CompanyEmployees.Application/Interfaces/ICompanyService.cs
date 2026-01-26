using System;
using CompanyEmployees.Domain.Entities;

namespace CompanyEmployees.Application.Interfaces;

public interface ICompanyService 
{
   IEnumerable<Company> GetAllCompanies(bool trackChanges);
}
