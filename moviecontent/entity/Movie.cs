using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class Movie
    {
         public int MovieId { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseTime { get; set; }

        public double Imdb { get; set; }
        public string PhotoUrl { get; set; }
        [Required]
        public Director director { get; set; }

        public List<MoviePlayer>  players { get; set; }

        public List<CategoryMovie>  categories { get; set; }

        public Boolean? isHome {get; set;}
    }
}