using AccountManagement.Domain.TechnicianAgg;
using System;

public class Customer
{
    public long CustomerID { get; private set; }
    public string CustomerName { get; private set; }
    public string CustomerFamily { get; private set; }
    public string PhoneNumber { get; private set; }
    public long RoleID { get; private set; }
    public Role Role { get; private set; }


}
