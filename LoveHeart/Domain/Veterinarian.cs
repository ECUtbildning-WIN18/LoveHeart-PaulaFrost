using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class Veterinarian : Account, IAddNewAccount
    {
        public Veterinarian(string firstName, string lastName, string userName, string password, string userType)
            : base(userName, password, "Veterinarian", firstName, lastName)
        {

        }

        public void NewUser()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
