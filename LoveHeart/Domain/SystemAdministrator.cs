using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class SystemAdministrator : Account, IAddNewAccount
    {
        public SystemAdministrator(string firstName, string lastName, string userName, string password, string userType)
            : base(userName, password, "Admin", firstName, lastName)
        {

        }

        public void NewUser()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
