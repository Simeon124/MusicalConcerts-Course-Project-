﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Performers { get; set; }
        public Genre Genre { get; set; }
        public string Location { get; set;}
        public DateTime ConcertStartDate { get; set; }

    }
}
