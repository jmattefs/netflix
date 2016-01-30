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

            view.Sort();

           /* List<Title> Titles = new List<Title>();
            Titles.Add(new Title("Die Hard", 5));
            test t = new test(Titles);
            foreach(Title title in t)
            {
                Console.WriteLine(title.name);
            }
            
            
            /*Genre g = new Genre();

            foreach(Title t in g)
            {
                Console.WriteLine(t.name);
            }
            */

            
        }
    }
}
