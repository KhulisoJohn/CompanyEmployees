using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CompanyEmployees.Domain.Entities.Models;

namespace CompanyEmployees.Domain.Entities.Models;

public class Company
{
    [Column("CompanyId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Company name is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for the Name is 50 characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Company address is a required field.")]
    [MaxLength(100, ErrorMessage = "Maximum length for the Address is 100 characters.")]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Company country is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for the Country is 50 characters.")]
    public string? Country { get; set; }

    public ICollection<Employee>? Employees { get; set; }
}
