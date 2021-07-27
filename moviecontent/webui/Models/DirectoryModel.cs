using System;
using System.Collections.Generic;
using entity;

namespace webui.Models
{
    public class DirectoryModel
    {
         public int DirectorId { get; set; }

        public String Name { get; set; }

        public int Age { get; set; }

        public DateTime Birthday { get; set; }

        public double Imdb { get; set; }
        public string PhotoUrl { get; set; }

        public List<Movie> movies { get; set; }
    }
}