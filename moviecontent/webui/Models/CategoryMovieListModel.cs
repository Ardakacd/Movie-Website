using System.Collections.Generic;
using entity;

namespace webui.Models
{
    public class CategoryMovieListModel
    {
        public List<Category> categories { get; set; }

        public List<Movie> movies { get; set; }

    }
}