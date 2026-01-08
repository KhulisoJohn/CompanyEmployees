using System;
using CompanyEmployees.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyEmployees.Infrastructure.Configuration;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    { builder.HasData(
        new Company
        {
            Id = Guid.Parse("b3b1f6e2-5c4a-4d2a-9f3e-1c2d3e4f5a6b"),
            Name = "Tech Solutions",
            Address = "123 Innovation Drive",
            Country = "USA"
        },
        new Company
        {
            Id = Guid.Parse("c4d2e3f4-6a7b-8c9d-0e1f-2a3b4c5d6e7f"),
            Name = "Global Enterprises",
            Address = "456 Enterprise Ave",
            Country = "UK"
        }
    );

    }
}
