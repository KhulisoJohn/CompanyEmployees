using System;
using System.Linq.Expressions;
using CompanyEmployees.Domain.Interfaces;
using CompanyEmployees.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployees.Infrastructure.Repository;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected CompanyEmployeeDbContext companyEmployeeDbContext;

    public RepositoryBase(CompanyEmployeeDbContext companyEmployeeDbContext)
    {
        this.companyEmployeeDbContext = companyEmployeeDbContext;
    }

    public IQueryable<T> FindAll(bool trackChanges) =>
        !trackChanges ?
        companyEmployeeDbContext.Set<T>()
            .AsNoTracking() :
        companyEmployeeDbContext.Set<T>();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
        !trackChanges ?
        companyEmployeeDbContext.Set<T>()
            .Where(expression)
            .AsNoTracking() :
        companyEmployeeDbContext.Set<T>()
            .Where(expression);

    public void Create(T entity) => companyEmployeeDbContext.Set<T>().Add(entity);
    public void Update(T entity) => companyEmployeeDbContext.Set<T>().Update(entity);
    public void Delete(T entity) => companyEmployeeDbContext.Set<T>().Remove(entity);
}
