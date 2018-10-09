using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.View
{
    class RegisterNewCostumerMenu : ConsoleView
    {
        public override string Display()
        {
            bool notSufficientInformation = true;

            do
            {
                base.Display();

                Console.WriteLine("# Register new costumer\n");
                Console.WriteLine("First name:");
                Console.WriteLine("Last name:");
                Console.WriteLine("Social security number");

                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                string socialSecurityNumber = Console.ReadLine();

                Console.WriteLine("Is this correct? (Y)es (N)o");
                var consoleKeyInfo = Console.ReadKey();

                if (consoleKeyInfo.Key == ConsoleKey.Y)
                {
                    notSufficientInformation = false;
                }
                else
                {

                }

            } while (notSufficientInformation);
            return "";
        }
    }
}
