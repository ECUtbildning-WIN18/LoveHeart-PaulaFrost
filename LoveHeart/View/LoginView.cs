using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoveHeart.View
{
    class LoginView : ConsoleView
    {
        public static int xCoord, yCoord, y;

        public override string Display()
        {
            bool loginSucceded = false;

            do
            {
                base.Display();

                Console.WriteLine("Please log in\n\t");
                Console.WriteLine("Username:");
                Console.WriteLine("Password:\n\t");
                WriteAt(" ", 9, 2);
                string username = Console.ReadLine();
                WriteAt(" ", 9, 3);
                string password = Console.ReadLine();

                Console.WriteLine("Is this correct? (Y)es (N)o");
                var keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Y)
                {
                    if (username == "john" && password == "secret")
                    {
                        loginSucceded = true;
                    }
                    else if (username == "" && password == "")
                    {

                    }
                    else
                    {
                        Console.WriteLine("\nWrong! Try again");
                        Thread.Sleep(2000);
                    }
                }
                else if(keyInfo.Key == ConsoleKey.N)
                {

                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            } while (!loginSucceded);
            Console.WriteLine("\nLogin Succeded!");
            Console.ReadKey();
            return "";
        }

        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(xCoord + x, yCoord + y);
            Console.Write(s);
        }
    }
}
