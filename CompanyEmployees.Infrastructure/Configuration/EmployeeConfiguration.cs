using System;
using CompanyEmployees.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyEmployees.Infrastructure.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasData
        (
            new Employee
            {
                Id = Guid.Parse("d1e2f3a4-b5c6-7d8e-9f0a-1b2c3d4e5f6a"),
                Name = "John Doe",
                Age = 30,
                Position = "Software Developer",
                CompanyId = new Guid("b3b1f6e2-5c4a-4d2a-9f3e-1c2d3e4f5a6b")
            },
            new Employee
            {
                Id = Guid.Parse("e2f3a4b5-c6d7-e8f9-0a1b-2c3d4e5f6a7b"),
                Name = "Jane Smith",
                Age = 28,
                Position = "Project Manager",
                CompanyId = new Guid("c4d2e3f4-6a7b-8c9d-0e1f-2a3b4c5d6e7f")
            },
            new Employee
            {
                Id = Guid.Parse("f3a4b5c6-d7e8-f9a0-1b2c-3d4e5f6a7b8c"),
                Name = "Alice Johnson",
                Age = 35,
                Position = "UX Designer",
                CompanyId = new Guid("b3b1f6e2-5c4a-4d2a-9f3e-1c2d3e4f5a6b")
            },
            new Employee
            {
                Id = Guid.Parse("a4b5c6d7-e8f9-a0b1-2c3d-4e5f6a7b8c9d"),
                Name = "Bob Brown",
                Age = 40,
                Position = "Data Analyst",
                CompanyId = new Guid("c4d2e3f4-6a7b-8c9d-0e1f-2a3b4c5d6e7f")
            }
        );
    }
}
