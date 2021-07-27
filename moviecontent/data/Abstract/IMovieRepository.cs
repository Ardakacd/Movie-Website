using System.Collections.Generic;
using entity;

namespace data.Abstract
{

    
    public interface IMovieRepository:IRepository<Movie>
    {

        List<Movie> GetPopular5Movie();

        List<Movie> getMovieWithInclude();

        Movie getMovieWithInclude(int id);

        List<Movie> getMovieHome();

        public List<Movie> searchMov(string name);

        



        
         
    }
}