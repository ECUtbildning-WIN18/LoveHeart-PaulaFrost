using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.View
{
    class SearchCostumerView : ConsoleView
    {
        public override string Display()
        {
            base.Display();

            Console.WriteLine("Search costumer...");
            Console.ReadKey();
            return base.Display();
        }
    }
}
