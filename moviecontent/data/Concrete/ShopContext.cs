using entity;
using Microsoft.EntityFrameworkCore;

namespace data.Concrete
{
    public class ShopContext:DbContext
    {

    public DbSet<Category> categories { get; set; }

    public DbSet<Player> players { get; set; }

    public DbSet<Movie> movies { get; set; }

    public DbSet<Director> directors { get; set; }

    public DbSet<CategoryMovie> catmov { get; set; }

    public DbSet<MoviePlayer> movplay { get; set; }
    



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
            optionsBuilder.UseMySQL(@"server=localhost;port=3306;database=movie;user=root;password=arda1602");
    }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoviePlayer>().HasKey(i => new {i.MovieId,i.PlayerId});

            modelBuilder.Entity<MoviePlayer>().
            HasOne(i => i.movie).WithMany(i => i.players).HasForeignKey(i => i.MovieId);

            modelBuilder.Entity<MoviePlayer>().
            HasOne(i => i.player).WithMany(i => i.movies).HasForeignKey(i => i.PlayerId);

            modelBuilder.Entity<CategoryMovie>().HasKey(i => new {i.MovieId,i.CategoryId});

            modelBuilder.Entity<CategoryMovie>().
            HasOne(i => i.movie).WithMany(i => i.categories).HasForeignKey(i => i.MovieId);

            modelBuilder.Entity<CategoryMovie>().
            HasOne(i => i.category).WithMany(i => i.movies).HasForeignKey(i => i.CategoryId);

            modelBuilder.Entity<Movie>().HasOne(i => i.director).WithMany(i => i.movies);



        }
        
    }
}