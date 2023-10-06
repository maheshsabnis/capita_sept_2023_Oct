using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core_API.Models;

public partial class Department
{
    [Required(ErrorMessage ="DeptNo is required")]
    [NonNegative(ErrorMessage = "DeptNo cannot be -Ve")]
    public int DeptNo { get; set; }
    [Required(ErrorMessage = "DeptName is required")]
    public string DeptName { get; set; } = null!;
    [Required(ErrorMessage = "Location is required")]
    public string Location { get; set; } = null!;
    [Required(ErrorMessage = "Capacity is required")]
    [NonNegative(ErrorMessage = "Capacity cannot be -Ve")]
    public int Capacity { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
