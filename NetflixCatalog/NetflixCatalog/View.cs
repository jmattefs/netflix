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
                    Console.WriteLine("---Type in a title to see more information---");
                    break;
                case "B":
                case "b":
                    Console.WriteLine("---Type in a title to see more information---");
                    genre.GenreComedy();
                    string input = Console.ReadLine();
                    break;
                case "C":
                case "c":
                    Console.WriteLine("---Type in a title to see more information---");
                    break;
                case "D":
                case "d":
                    genre.
                    Console.WriteLine("---Type in a title to see more information---");
                    genre.GenreAll();
                    string input = Console.ReadLine();           //return input for all... new function with switch case for movies.. tv..
                    break;
                default:
                    Console.WriteLine();
                    break;
                   
            }

        }
        public void Info()
        {
            string response = Display();

        }
    }
}
