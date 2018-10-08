using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class Costumer : Pet
    {
        public int SocialSecurityNumber { get; }
        public string FirstName { get; }
        public string LastName { get; set; }
        public List<Pet> CostumersPets { get; set; }

        public Pet OwnersPets { get; set; }

        public Costumer(string firstName, string lastName, int socialSecurityNumber, string petName, string nickName, DateTime dateOfBirth) :base(petName, nickName, dateOfBirth)
        {
            SocialSecurityNumber = socialSecurityNumber;
            OwnersPets = new Pet(petName, nickName, dateOfBirth);
        }
    }
}
