using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("b3b1f6e2-5c4a-4d2a-9f3e-1c2d3e4f5a6b"), "123 Innovation Drive", "USA", "Tech Solutions" },
                    { new Guid("c4d2e3f4-6a7b-8c9d-0e1f-2a3b4c5d6e7f"), "456 Enterprise Ave", "UK", "Global Enterprises" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("a4b5c6d7-e8f9-a0b1-2c3d-4e5f6a7b8c9d"), 40, new Guid("c4d2e3f4-6a7b-8c9d-0e1f-2a3b4c5d6e7f"), "Bob Brown", "Data Analyst" },
                    { new Guid("d1e2f3a4-b5c6-7d8e-9f0a-1b2c3d4e5f6a"), 30, new Guid("b3b1f6e2-5c4a-4d2a-9f3e-1c2d3e4f5a6b"), "John Doe", "Software Developer" },
                    { new Guid("e2f3a4b5-c6d7-e8f9-0a1b-2c3d4e5f6a7b"), 28, new Guid("c4d2e3f4-6a7b-8c9d-0e1f-2a3b4c5d6e7f"), "Jane Smith", "Project Manager" },
                    { new Guid("f3a4b5c6-d7e8-f9a0-1b2c-3d4e5f6a7b8c"), 35, new Guid("b3b1f6e2-5c4a-4d2a-9f3e-1c2d3e4f5a6b"), "Alice Johnson", "UX Designer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("a4b5c6d7-e8f9-a0b1-2c3d-4e5f6a7b8c9d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("d1e2f3a4-b5c6-7d8e-9f0a-1b2c3d4e5f6a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("e2f3a4b5-c6d7-e8f9-0a1b-2c3d4e5f6a7b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("f3a4b5c6-d7e8-f9a0-1b2c-3d4e5f6a7b8c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("b3b1f6e2-5c4a-4d2a-9f3e-1c2d3e4f5a6b"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("c4d2e3f4-6a7b-8c9d-0e1f-2a3b4c5d6e7f"));
        }
    }
}
