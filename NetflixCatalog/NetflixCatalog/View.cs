using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class View
    {
        public View()
        {
            
        }
        public string Start()
        {
            Console.WriteLine("Type in the letter that corresponds to the movie genre you would like to view.");
            Console.WriteLine("A: Action");
            Console.WriteLine("B: Comedy");
            Console.WriteLine("C: Romance");
            Console.WriteLine("D: View All");
            string response = Console.ReadLine();
            return response;
        }
        public void Display()
        {
            string response = Start();
            Genre genre = new Genre();
            switch (response)
            {
                case "A":
                case "a":
                    Console.WriteLine();
                    break;
                case "B":
                case "b":
                    Console.WriteLine();
                    break;
                case "C":
                case "c":
                    Console.WriteLine();
                    break;
                case "D":
                case "d":
                    genre.GenreAll();
                    break;
                default:
                    Console.WriteLine();
                    break;
                   
            }

        }
    }
}
