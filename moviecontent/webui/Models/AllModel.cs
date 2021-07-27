using System.Collections.Generic;
using entity;

namespace webui.Models
{
    public class AllModel
    {
        public List<Movie> movies {get;set;}

        public List<Player> players {get;set;}

        public List<Category> categories {get;set;}

        public List<Director> directors {get;set;}
    }
}