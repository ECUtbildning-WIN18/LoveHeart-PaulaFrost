using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.View
{
    class LoginView : ConsoleView
    {
        public static int xCoord, yCoord, y;

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Please log in\n\t");
            Console.WriteLine("Username:");
            Console.WriteLine("Password:\n\t");
            WriteAt(" ", 9, 2);
            string username = Console.ReadLine();
            WriteAt(" ", 9, 3);
            string password = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("Is this correct? (Y)es (N)o");
            var keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Y)
            {
                if (username == "john" && password == "secret")
                {

                }
                else
                {
                    Console.WriteLine("Wrong! Try again");
                }
            }
        }

        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(xCoord + x, yCoord + y);
            Console.Write(s);
        }
    }
}
