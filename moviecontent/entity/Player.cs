using System;
using System.Collections.Generic;

namespace entity
{
    public class Player
    {
         public int PlayerId { get; set; }

        public String Name { get; set; }

        public int Age { get; set; }

        public DateTime Birthday { get; set; }

        public double Imdb { get; set; }
        public string PhotoUrl { get; set; }

        public List<MoviePlayer> movies { get; set; }
    }
}