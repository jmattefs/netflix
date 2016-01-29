using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class TV : Title
    {
        int episodes;
        public override int? rating { get; set; }

        public TV(int episodes)
        {
            this.episodes = episodes;
        }
        
        public override string ToString()
        {
            return name + ": " + episodes + " episodes and the Average Episode Rating is " + rating ;
        }

    }
}
