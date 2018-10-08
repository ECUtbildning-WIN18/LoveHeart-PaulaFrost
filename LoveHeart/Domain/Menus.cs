using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class Menus : IAddNewAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static int xCoord, yCoord, y;
        public static ConsoleKey choice;

        public void NewUser()
        {
            var users = new List<IAddNewAccount>
            {
                new SystemAdministrator("Edward", "Snowbear", "EdwardSnowden", "password", "Admin"),
                new Receptionist("Uma", "Furrman", "UmaFurrman", "password", "Receptionist"),
                new Veterinarian("Josef", "Mengele", "JosefMengele", "password", "Veterinarian"),
                new Veterinarian("Ivan", "Pavlov", "IvanPavlov", "password", "Veterinarian"),
                new Veterinarian("Erwin", "Schrödinger", "ErwinSchrödinger", "password", "Veterinarian")
            };
        }



        public static void ReceptionistMenu(string username, string password)
        {
            Console.Clear();
            Console.WriteLine("1. Register new customer");
            Console.WriteLine("2. Search customer");
            Console.WriteLine("3. Exit");
            Console.WriteLine("> <menu option>");
        }

        public static void VeterinarianMenu(string username, string password)
        {
            Console.WriteLine("View todays appointment");

            Console.WriteLine("View details on one appointment");
            Console.WriteLine("Write Journal");
        }

        public static void SystemAdministratorMenu(string username, string password)
        {
            Console.WriteLine("View all users");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Remove user");
            Console.WriteLine("> <menu option>");
        }

        public static void RegCostumer()
        {
            Console.WriteLine("# Register new customer");
            Console.WriteLine("First name:");
            Console.WriteLine("Last name:");
            Console.WriteLine("Social Security Number:");
            Console.WriteLine(" ");

            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Is this correct? (Y)es (N)o");
        }

        public static void RegPet()
        {
            Console.WriteLine("Register new pet");
            Console.WriteLine("Name:");
            Console.WriteLine("Nickname:");
            Console.WriteLine("Date of birth:");
            Console.WriteLine(" ");

            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Is this correct? (Y)es (N)o");
        }

        public static void RegAppointment()
        {
            Console.WriteLine("# Register appointment");
            Console.WriteLine(" ");
            Console.WriteLine("Name: ");
            Console.WriteLine("Veterinarian:");
            Console.WriteLine("Date:");
            Console.WriteLine(" ");
            Console.WriteLine("Reason:");
            Console.WriteLine(" ");
            Console.WriteLine("(A)ccept (C)ancel");
            //if Accepted, write: Appointment succefully registered
        }

        public static void SearchCostumer()
        {
            Console.WriteLine("# Search costumer#");
            Console.WriteLine(" ");
            Console.WriteLine("Search (SSN):");
            Console.WriteLine(" ");
            Console.WriteLine("Is this correct? (Y)es (N)o");
        }

        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(xCoord + x, yCoord + y);
            Console.Write(s);
        }
    }
}
