using AccountManagement.Application.Contract.CustomerCon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Application
{
    public class CustomerApplication : ICustomerApplication
    {

        public void CreateCustome(CreateCustomer command)
        {
            if (command == null) throw new ArgumentNullException();

        }
    }
}
