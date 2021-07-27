namespace entity
{
    public class MoviePlayer
    {
        public int MovieId { get; set; }

        public Movie movie { get; set; }

        public int PlayerId { get; set; }

        public Player player { get; set; }
    }
}