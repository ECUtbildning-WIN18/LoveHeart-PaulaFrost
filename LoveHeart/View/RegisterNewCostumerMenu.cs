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
            bool notSufficientInformation = false;

            do
            {
                base.Display();

                Console.WriteLine("# Register new costumer\n");
                Console.WriteLine("First name:");
                Console.WriteLine("Last name:");
                Console.WriteLine("Social security number:");

                WriteAt(" ", 24, 2);
                string firstName = Console.ReadLine();
                WriteAt(" ", 24, 3);
                string lastName = Console.ReadLine();
                WriteAt(" ", 24, 4);
                string socialSecurityNumber = Console.ReadLine();

                Console.WriteLine("Is this correct? (Y)es (N)o");
                var consoleKeyInfo = Console.ReadKey(true);

                if (consoleKeyInfo.Key == ConsoleKey.Y)
                {
                    notSufficientInformation = false;
                }
                else if (consoleKeyInfo.Key == ConsoleKey.N)
                {

                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }

            } while (notSufficientInformation);

            return "";
        }

        public static int xCoord, yCoord, y;
        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(xCoord + x, yCoord + y);
            Console.Write(s);
        }
    }
}
