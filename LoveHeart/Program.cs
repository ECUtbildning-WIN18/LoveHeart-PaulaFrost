using LoveHeart.Domain;
using LoveHeart.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginView = new LoginView();
            var receptionistMainView = new ReceptionistMainMenu();
            var registerNewCostumer = new RegisterNewCostumerMenu();
            var searchCostumerView = new SearchCostumerView();
            var registerNewPetView = new RegisterNewPetView();
            var registerAppointmentView = new RegisterNewPetView();

            loginView.Display();

            var result = receptionistMainView.Display();

            if (result == "1")
            {
                registerNewCostumer.Display();
            }
            else if (result == "2")
            {
                searchCostumerView.Display();
            }
            else if (result == "3")
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Wazzup my Nagas!");
        }
    }
} 

