﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace NetflixCatalog
{
    class Genre
    {
        string genre;
    
        public Genre(string Genre)
        {
            this.genre = Genre;
        }
        public void GenreAll()
        {
            List<string> Catalogue = new List<string>();
            Catalogue.Add("Heat");
            Catalogue.Add("Knocked Up");
            Catalogue.Add("Titanic");
            Catalogue.Add("Die Hard");
            Catalogue.Add("Silver Lining's Playbook");
            Catalogue.Add("Hot Fuzz");
            Catalogue.Add("Dirty Dancing");
            Catalogue.Add("Rush Hour");
            Catalogue.Add("The Notebook");
            Catalogue.Add("Mad Max");
            Catalogue.Add("The Princess Bride");
            Catalogue.Add("Mr and Mrs Smith");
            Catalogue.Add("Zoolander");
            Catalogue.Add("24");
            Catalogue.Add("Seinfeld");
            Catalogue.Add("Grey's Anatomy");
            Catalogue.Add("Chuck");
            Catalogue.Add("Gossip Girl");
            Catalogue.Add("How I Met Your Mother");
            Catalogue.Add("Buffy the Vampire Slayer");
            Catalogue.Add("Its Always Sunny in Philadelphia");

            foreach(string s in Catalogue)
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
        }
        public static Genre operator +(Genre Comedy, Genre Romantic)
        {
           
        }
    }
}
