using System;
using System.Collections.Generic;

namespace LINQSamples.Data;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Title { get; set; }

    public string? TitleOfCourtesy { get; set; }

    public DateTime? BirthDate { get; set; }

    public DateTime? HireDate { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Extension { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public byte[]? Photo { get; set; }

    public byte[]? Notes { get; set; }

    public int? MgrId { get; set; }

    public string? PhotoPath { get; set; }

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
