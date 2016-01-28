﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Title
    {
        public string name;
        int? rating;

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
    }
}