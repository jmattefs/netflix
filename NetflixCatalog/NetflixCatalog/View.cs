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

        public string Initial()
        {
            Console.WriteLine("  Would you like to view...");
            Console.WriteLine("A:  Movies");
            Console.WriteLine("B:  TV");
            Console.WriteLine("C:  Both");
            Console.WriteLine("Please type A, B, or C");
            string read = Console.ReadLine();
            Console.Clear();
            return read;
        }
        public void Sort()
        {
            Genre g = new Genre();
            string input = Initial();
            switch (input)
            {
                case "A":
                case "a":
                    LinkMovie();
                    break;
                case "B":
                case "b":
                    LinkTV();
                    break;
                case "C":
                case "c":
                    LinkAll();
                    break;
                default:
                    Sort();
                    break;

            }
        }

        public string StartMovies()
        {
            Console.WriteLine("Type in the letter that corresponds to the movie genre you would like to view.");
            Console.WriteLine("A: Action");
            Console.WriteLine("B: Comedy");
            Console.WriteLine("C: Romance");
            Console.WriteLine("D: View All");
            string movieResponse = Console.ReadLine();
            Console.Clear();
            return movieResponse;
        }
        public string DisplayMovies()
        {
            string response = StartMovies();
            Genre genre = new Genre();
            switch (response)
            {
                case "A":
                case "a":
                    Console.WriteLine("---Type in a title to see more information---");
                    genre.GenreAction();
                    
                    string input = Console.ReadLine();
                    return input;
                case "B":
                case "b":
                    Console.WriteLine("---Type in a title to see more information---");

                    genre.GenreComedy();
                    string input2 = Console.ReadLine();
                    return input2;
                case "C":
                case "c":
                    Console.WriteLine("---Type in a title to see more information---");

                    genre.GenreRomance();
                    string input3 = Console.ReadLine();
                    return input3;
                    
                case "D":
                case "d":
                    Console.WriteLine("---Type in a title to see more information---");

                    genre.GenreAll();
                    string input4 = Console.ReadLine();
                    return input4;
                default:
                    return DisplayMovies();
                    
                   
            }

        }
        public void LinkMovie()
        {
            string choice = DisplayMovies();
            Catalogue c = new Catalogue();

            switch (choice)
            {
                case "Heat":
                case "heat":
                    Console.Clear();
                    c.Heat();
                    break;
                case "Die Hard":
                case "die hard":
                    Console.Clear();
                    c.DieHard();
                    break;
                case "Hot Fuzz":
                case "hot fuzz":
                    Console.Clear();
                    c.HotFuzz();
                    break;
                case "Rush Hour":
                case "rush hour":
                    Console.Clear();
                    c.RushHour();
                    break;
                case "Mad Max":
                case "mad max":
                    Console.Clear();
                    c.MadMax();
                    break;
                case "Mr and Mrs Smith":
                case "mr and mrs smith":
                    Console.Clear();
                    c.MrMrsSmith();
                    break;
                case "Knocked Up":
                case "knocked up":
                    Console.Clear();
                    c.KnockedUp();
                    break;
                case "Silver Linings Playbook":
                case "silver linings playbook":
                    Console.Clear();
                    c.SLP();
                    break;
                case "The Princess Bride":
                case "the princess bride":
                    Console.Clear();
                    c.PrincessBride();
                    break;
                case "Zoolander":
                case "zoolander":
                    Console.Clear();
                    c.Zoolander();
                    break;
                case "Titanic":
                case "titanic":
                    Console.Clear();
                    c.Titanic();
                    break;
                case "Dirty Dancing":
                case "dirty dancing":
                    Console.Clear();
                    c.DirtyDancing();
                    break;
                case "The Notebook":
                case "the notebook":
                    Console.Clear();
                    c.Notebook();
                    break;
            }

        }
        public void LinkTV()
        {
            string choice = DisplayTV();
            Catalogue c = new Catalogue();
            switch (choice)
            {
                case "24":
                    Console.Clear();
                    c.TwentyFour();
                    break;
                case "seinfeld":
                case "Seinfeld":
                    Console.Clear();
                    c.Seinfeld();
                    break;
                case "chuck":
                case "Chuck":
                    Console.Clear();
                    c.Chuck();
                    break;
                case "Grey's Anatomy":
                case "Greys Anatomy":
                case "greys anatomy":
                case "grey's anatomy":
                    Console.Clear();
                    c.Greys();
                    break;
                case "Gossip Girl":
                case "gossip girl":
                    Console.Clear();
                    c.GossipGirl();
                    break;
                case "How I Met Your Mother":
                case "how i met your mother":
                    Console.Clear();
                    c.HIMYM();
                    break;
                case "Buffy the Vampire Slayer":
                case "buffy the vampire slayer":
                    Console.Clear();
                    c.Buffy();
                    break;
                case "Its Always Sunny in Philadelphia":
                case "its always sunny in philadelphia":
                    Console.Clear();
                    c.IASIP();
                    break;
            }
        }
        public string DisplayAll()
        {
            Genre g = new Genre();
            Console.WriteLine("---Type in a title to see more information---");

            g.GenreAll();
            string title;
            title = Console.ReadLine();
            return title;
        }
        public void LinkAll()
        {
            string display = DisplayAll();
            Catalogue c = new Catalogue();
            switch (display)
            {
                case "Heat":
                case "heat":
                    Console.Clear();
                    c.Heat();
                    break;
                case "Die Hard":
                case "die hard":
                    Console.Clear();
                    c.DieHard();
                    break;
                case "Hot Fuzz":
                case "hot fuzz":
                    Console.Clear();
                    c.HotFuzz();
                    break;
                case "Rush Hour":
                case "rush hour":
                    Console.Clear();
                    c.RushHour();
                    break;
                case "Mad Max":
                case "mad max":
                    Console.Clear();
                    c.MadMax();
                    break;
                case "Mr and Mrs Smith":
                case "mr and mrs smith":
                    Console.Clear();
                    c.MrMrsSmith();
                    break;
                case "Knocked Up":
                case "knocked up":
                    Console.Clear();
                    c.KnockedUp();
                    break;
                case "Silver Linings Playbook":
                case "silver linings playbook":
                    Console.Clear();
                    c.SLP();
                    break;
                case "The Princess Bride":
                case "the princess bride":
                    Console.Clear();
                    c.PrincessBride();
                    break;
                case "Zoolander":
                case "zoolander":
                    Console.Clear();
                    c.Zoolander();
                    break;
                case "Titanic":
                case "titanic":
                    Console.Clear();
                    c.Titanic();
                    break;
                case "Dirty Dancing":
                case "dirty dancing":
                    Console.Clear();
                    c.DirtyDancing();
                    break;
                case "The Notebook":
                case "the notebook":
                    Console.Clear();
                    c.Notebook();
                    break;
                case "24":
                    Console.Clear();
                    c.TwentyFour();
                    break;
                case "seinfeld":
                case "Seinfeld":
                    Console.Clear();
                    c.Seinfeld();
                    break;
                case "chuck":
                case "Chuck":
                    Console.Clear();
                    c.Chuck();
                    break;
                case "Grey's Anatomy":
                case "Greys Anatomy":
                case "greys anatomy":
                case "grey's anatomy":
                    Console.Clear();
                    c.Greys();
                    break;
                case "Gossip Girl":
                case "gossip girl":
                    Console.Clear();
                    c.GossipGirl();
                    break;
                case "How I Met Your Mother":
                case "how i met your mother":
                    Console.Clear();
                    c.HIMYM();
                    break;
                case "Buffy the Vampire Slayer":
                case "buffy the vampire slayer":
                    Console.Clear();
                    c.Buffy();
                    break;
                case "Its Always Sunny in Philadelphia":
                case "its always sunny in philadelphia":
                    Console.Clear();
                    c.IASIP();
                    break;

            }
        }
        public string StartTV()
        {
            Console.WriteLine("Type in the letter that corresponds to the TV genre you would like to view.");
            Console.WriteLine("A: Action");
            Console.WriteLine("B: Comedy");
            Console.WriteLine("C: Romance");
            Console.WriteLine("D: View All");
            string TVresponse = Console.ReadLine();
            Console.Clear();
            return TVresponse;
        }
        public string DisplayTV()
        {
            string response = StartTV();
            Genre genre = new Genre();
            switch (response)
            {
                case "A":
                case "a":
                    Console.WriteLine("---Type in a title to see more information---");

                    genre.GenreTVAction();
                    string input = Console.ReadLine();
                    return input;
                case "B":
                case "b":
                    Console.WriteLine("---Type in a title to see more information---");

                    genre.GenreTVComedy();
                    string input2 = Console.ReadLine();
                    return input2;
                case "C":
                case "c":
                    Console.WriteLine("---Type in a title to see more information---");

                    genre.GenreTVRomance();
                    string input3 = Console.ReadLine();
                    return input3;
                case "D":
                case "d":
                    Console.WriteLine("---Type in a title to see more information---");

                    genre.GenreTV();
                    string input4 = Console.ReadLine();           
                    return input4;
                default:
                    DisplayTV();
                    return null;

            }

        }
        public void Info()
        {
            //string response = Display();

        }
    }
}
