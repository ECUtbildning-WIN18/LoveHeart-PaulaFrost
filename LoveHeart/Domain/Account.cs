using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class Account
    {
        public string UserName { get; }
        public string Password { get; }
        public string UserType { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Account(string userName, string password, string userType, string firstName, string lastName)
        {
            UserName = userName;
            Password = password;
            UserType = userType;
            FirstName = firstName;
            LastName = lastName;
        }

        public Account(string firstName, string lastName)
        {

        }
    }
}
