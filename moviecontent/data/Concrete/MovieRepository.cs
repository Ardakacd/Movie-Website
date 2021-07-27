using entity;
using data.Abstract;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace data.Concrete
{
    public class MovieRepository : AllRepository<Movie, ShopContext>, IMovieRepository
    {
        public List<Movie> getMovieHome()
        {
              using(var context = new ShopContext()){
                var movies = context.movies.Where(i => i.isHome == true).ToList();

                return movies;
            }
        }

        public List<Movie> getMovieWithInclude()
        {
            using(var context = new ShopContext()){
                var movies = context.movies.Include(i => i.players).ThenInclude( i => i.player).Include(i => i.categories).ThenInclude( i => i.category).Include(i => i.director).ToList();

                return movies;
            }
        }

           public Movie getMovieWithInclude(int id)
        {
            using(var context = new ShopContext()){
                var movies = context.movies.Where(i => i.MovieId == id).Include(i => i.players).ThenInclude( i => i.player).Include(i => i.categories).ThenInclude( i => i.category).Include(i => i.director).FirstOrDefault();

                return movies;
            }
        }



        public List<Movie> GetPopular5Movie()
        {
            using(var context = new ShopContext()){

                var movies = context.movies.OrderByDescending(i => i.Imdb);

                return (List<Movie>)movies.Take(5);

            }
        }

            public List<Movie> searchMov(string name)
        {
                  using (var context = new ShopContext()){

                var movie = context.movies.Where( i => i.Name.ToLower().Contains(name.ToLower())).ToList();

                return movie;
            }
        }
    }
}