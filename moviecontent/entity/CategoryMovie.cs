namespace entity
{
    public class CategoryMovie
    {
        public int CategoryId { get; set; }

        public Category category { get; set; }

        public int MovieId { get; set; }

        public Movie movie { get; set; }
    }
}