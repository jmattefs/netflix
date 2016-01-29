using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Title
    {
        public string name;
        public int? rating;
        

        public Title(string name, int rating)
        {
            this.name = name;
            this.rating = rating;
        }
        public Title()
        {
            name = null;
            rating = null;

        }
        public void Genres()
        {
            List<string> genres = new List<string>();
            genres.Add("Action");
            genres.Add("Comedy");
            genres.Add("Romance");


        }
    }
}
