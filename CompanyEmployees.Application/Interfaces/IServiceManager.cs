using System;

namespace CompanyEmployees.Application.Interfaces;

public interface IServiceManager
{
     ICompanyService CompanyService {get;}
    IEmployeeService EmployeeService {get;}
}
