using System.Collections.Generic;

namespace AccountManagement.Domain.TechnicianAgg
{
    public class AaccessRole
    {
        public long AaccessRoleID { get; private set; }
        public string AaccessName { get; private set; }
        public List<Role> Role { get; private set; }
    }

}
