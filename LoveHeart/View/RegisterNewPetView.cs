using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.View
{
    class RegisterNewPetView : ConsoleView
    {
        bool notSufficientInformation = true;

        public override string Display()
        {
            do
            {
                base.Display();

                Console.WriteLine("# Register new pet\n");
                Console.WriteLine("Name:");
                Console.WriteLine("Nickname");
                Console.WriteLine("Date of birth");

                WriteAt("", 15, 2);
                string petName = Console.ReadLine();
                WriteAt("", 15, 3);
                string nickName = Console.ReadLine();
                WriteAt("", 15, 4);
                string dateOfBirth = Console.ReadLine();

                Console.WriteLine("Is this correct? (Y)es (N)o");
                var consoleKeyInfo = Console.ReadKey();

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

            } while (!notSufficientInformation);

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
