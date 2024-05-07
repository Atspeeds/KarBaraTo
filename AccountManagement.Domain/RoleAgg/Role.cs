using System.Collections.Generic;

namespace AccountManagement.Domain.TechnicianAgg
{
    public class Role
    {
        public long RoleID { get; private set; }
        public string RoleName { get; private set; }
        //Relation 
        public List<AaccessRole> AaccessRoles { get; private set; }
        public Customer Customer { get; private set; }

    }

}
