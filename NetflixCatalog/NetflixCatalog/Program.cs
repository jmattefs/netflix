using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View();

            // view.Display();




            Title DieHard = new Movie(131);
            DieHard.name = "Die Hard";
            DieHard.rating = 5;
            Console.WriteLine(DieHard.ToString());
        }
    }
}
