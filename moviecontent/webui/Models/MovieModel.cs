using System;
using System.Collections.Generic;
using entity;
namespace webui.Models
{
    public class MovieModel
    {
         public int MovieId { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseTime { get; set; }

        public double Imdb { get; set; }
        public string PhotoUrl { get; set; }

        public Director director { get; set; }

        public List<Player>  players { get; set; }

        public List<Category>  categories { get; set; }

        public Boolean? isHome {get; set;}
    }
}