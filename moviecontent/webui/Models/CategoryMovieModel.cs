using System.Collections.Generic;
using entity;

namespace webui.Models
{
    public class CategoryMovieModel
    {
        public Category category { get; set; }

        public List<Movie> movies { get; set; }
    }
}