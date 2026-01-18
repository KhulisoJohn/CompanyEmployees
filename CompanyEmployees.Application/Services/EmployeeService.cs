using System;
using CompanyEmployees.Application.Interfaces;
using CompanyEmployees.Domain.Interfaces;

namespace CompanyEmployees.Application.Services;

internal sealed class EmployeeService : IEmployeeService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public EmployeeService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}
