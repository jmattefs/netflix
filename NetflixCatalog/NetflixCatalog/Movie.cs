using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Movie : Title
    {
        public int duration;
        public Movie(int duration)
        {
            this.duration = duration;
        }

        public override string ToString()
        {
            return name + ": " + duration + " minutes long and "+ rating +" thumbs up!" ;
        }
        
    }
}
