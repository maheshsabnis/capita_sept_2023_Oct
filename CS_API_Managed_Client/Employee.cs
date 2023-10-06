using System;
using System.Collections.Generic;

namespace CS_API_Managed_Client;

public partial class Employee
{
    public int EmpNo { get; set; }

    public string EmpName { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int DeptNo { get; set; }

    // Nullable Reference Type will make sure that
    // the Reference type won't be set from the CLient in
    // HttpPost and HttpPut Request 
    public virtual Department? DeptNoNavigation { get; set; }
}
