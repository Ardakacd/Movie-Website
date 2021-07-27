using System.Collections.Generic;

namespace entity
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public List<CategoryMovie> movies { get; set; }


        
    }
}