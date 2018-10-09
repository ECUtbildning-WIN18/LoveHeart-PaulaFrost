using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.View
{
    class RegisterAppointmentView : ConsoleView
    {
        public override string Display()
        {
            bool notSufficientInformation = true;

            do
            {
                base.Display();

                Console.WriteLine("# Register appointment\n");
                Console.WriteLine("Name:");
                Console.WriteLine("Veterinarian:");
                Console.WriteLine("Date:\n");
                Console.WriteLine("Reason");

                WriteAt("", 14, 2);
                string petName = Console.ReadLine();
                WriteAt("", 14, 3);
                string firstNamme = Console.ReadLine();
                WriteAt("", 14, 4);
                DateTime appointmentDateTime = Convert.ToDateTime(Console.ReadLine());
                WriteAt("\n", 14, 5);
                string reason = Console.ReadLine();

                Console.WriteLine("(A)ccept (C)ancel");

                var consoleKeyInfo = Console.ReadKey(true);

                if (consoleKeyInfo.Key == ConsoleKey.A)
                {
                    notSufficientInformation = false;
                }
                else if (consoleKeyInfo.Key == ConsoleKey.C)
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
