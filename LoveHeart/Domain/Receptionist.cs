using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class Receptionist : Account, IAddNewAccount
    {
        public Receptionist(string firstName, string lastName, string userName, string password, string userType)
            : base(userName, password, "Receptionist", firstName, lastName)
        {

        }

        public void NewUser()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
