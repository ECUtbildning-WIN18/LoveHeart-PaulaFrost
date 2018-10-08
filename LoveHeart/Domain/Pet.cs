using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class Pet
    {
        string PetName { get; }
        string NickName { get; }
        DateTime DateOfBirth { get; }
        
        //En lista for journal... ska skapa en class där man kan skriva text

        public Pet(string petName, string nickName, DateTime dateOfBirth)
        {
            PetName = petName;
            NickName = nickName;
            DateOfBirth = dateOfBirth;
        }
    }
}
