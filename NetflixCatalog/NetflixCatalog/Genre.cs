using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace NetflixCatalog
{
    public class Genre : IEnumerable
    {
        
        List<Title> Titles = new List<Title>();
       
        public Genre()
        {

        }

        public void GenreAll()
        {
            List<string> MediaCatalogue = new List<string>();
            MediaCatalogue.Add("Heat");
            MediaCatalogue.Add("Knocked Up");
            MediaCatalogue.Add("Titanic");
            MediaCatalogue.Add("Die Hard");
            MediaCatalogue.Add("Silver Lining's Playbook");
            MediaCatalogue.Add("Hot Fuzz");
            MediaCatalogue.Add("Dirty Dancing");
            MediaCatalogue.Add("Rush Hour");
            MediaCatalogue.Add("The Notebook");
            MediaCatalogue.Add("Mad Max");
            MediaCatalogue.Add("The Princess Bride");
            MediaCatalogue.Add("Mr and Mrs Smith");
            MediaCatalogue.Add("Zoolander");
            MediaCatalogue.Add("24");
            MediaCatalogue.Add("Seinfeld");
            MediaCatalogue.Add("Grey's Anatomy");
            MediaCatalogue.Add("Chuck");
            MediaCatalogue.Add("Gossip Girl");
            MediaCatalogue.Add("How I Met Your Mother");
            MediaCatalogue.Add("Buffy the Vampire Slayer");
            MediaCatalogue.Add("Its Always Sunny in Philadelphia");

            foreach(string s in MediaCatalogue)
            {
                Console.WriteLine(s);
            }
            
        }
        public void GenreAction()
        {
            List<string> ActionMovies = new List<string>();
            ActionMovies.Add("Heat");
            ActionMovies.Add("Die Hard");
            ActionMovies.Add("Hot Fuzz");
            ActionMovies.Add("Rush Hour");
            ActionMovies.Add("Mad Max");
            ActionMovies.Add("Mr and Mrs Smith");

            foreach (string s in ActionMovies)
            {
                Console.WriteLine(s);
            }
        }
        public void GenreComedy()
        {
            List<string> ComedyMovies = new List<string>();
            ComedyMovies.Add("Knocked Up");
            ComedyMovies.Add("Zoolander");
            ComedyMovies.Add("Silver Linings Playbook");
            ComedyMovies.Add("Hot Fuzz");
            ComedyMovies.Add("Rush Hour");
            ComedyMovies.Add("The Princess Bride");
            
            foreach (string s in ComedyMovies)
            {
                Console.WriteLine(s);
            }
        }
        public void GenreRomance()
        {
            List<string> RomanceMovies = new List<string>();
            RomanceMovies.Add("Titanic");
            RomanceMovies.Add("Silver Linings Playbook");
            RomanceMovies.Add("Dirty Dancing");
            RomanceMovies.Add("The Notebook");
            RomanceMovies.Add("The Princess Bride");
            RomanceMovies.Add("Mr and Mrs Smith");

        }
        public void GenreMovies()
        {
            List<string> Movies = new List<string>();
            Movies.Add("Heat");
            Movies.Add("Knocked Up");
            Movies.Add("Titanic");
            Movies.Add("Die Hard");
            Movies.Add("Silver Lining's Playbook");
            Movies.Add("Hot Fuzz");
            Movies.Add("Dirty Dancing");
            Movies.Add("Rush Hour");
            Movies.Add("The Notebook");
            Movies.Add("Mad Max");
            Movies.Add("The Princess Bride");
            Movies.Add("Mr and Mrs Smith");
            Movies.Add("Zoolander");
        }
        public void GenreTV()
        {
            List<string> TV = new List<string>();
            TV.Add("24");
            TV.Add("Seinfeld");
            TV.Add("Grey's Anatomy");
            TV.Add("Chuck");
            TV.Add("Gossip Girl");
            TV.Add("How I Met Your Mother");
            TV.Add("Buffy the Vampire Slayer");
            TV.Add("Its Always Sunny in Philadelphia");
        }
        public void GenreTVComedy()
        {
            List<string> TVComedy = new List<string>();
            TVComedy.Add("Seinfeld");
            TVComedy.Add("Chuck");
            TVComedy.Add("How I Met Your Mother");
            TVComedy.Add("It's Always Sunny in Philadelphia");
            
        }
        public void GenreTVAction()
        {
            List<string> TVAction = new List<string>();
            TVAction.Add("24");
            TVAction.Add("Chuck");
            TVAction.Add("Buffy the Vampire Slayer");
        }
        public void GenreTVRomance()
        {
            List<string> TVRomance = new List<string>();
            TVRomance.Add("Grey's Anatomy");
            TVRomance.Add("Gossip Girl");
            TVRomance.Add("How I Met Your Mother");
            TVRomance.Add("Buffy the Vampire Slayer");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Title t in Titles)
            {
                yield return t;
            }
        }
        

        public static Genre operator + (Genre Comedy, Genre Romantic)
        {
            Genre RomanticComedy = new Genre();
            RomanticComedy = Comedy + Romantic;
            return RomanticComedy;
        }
        public static Genre operator + (Genre genre, Title title)
        {
            Genre aggregate = new Genre();
            aggregate = genre + title;
            return aggregate;
        }
        
    }
}
