using System.Linq;
using data.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webui.Models;

namespace webui.Controllers
{

    [Authorize]
    public class MovieController:BaseController
    {
        

        private IMovieRepository movieRep;

        private IPlayerRepository playerRep;

        private IDirectorRepository directorRep;
        

        public MovieController(ICategoryRepository categoryRep,IMovieRepository movieRep,IPlayerRepository playerRep,IDirectorRepository directorRep):base(categoryRep){
            
            
            this.movieRep = movieRep;
            this.playerRep = playerRep;
            this.directorRep = directorRep;
        }


        public IActionResult List(){

            var model = new MovieListModel(){
                movies = movieRep.getMovieWithInclude()

                
            };

          


        return View(model);
        }


        public IActionResult detail(int id){

            var movie = movieRep.getMovieWithInclude(id);

           


            var model = new MovieModel(){
                Name = movie.Name,
                Imdb = movie.Imdb,
                ReleaseTime = movie.ReleaseTime,
                PhotoUrl = movie.PhotoUrl,
                director = movie.director,
                categories = movie.categories.Select( i => i.category).ToList(),
                players = movie.players.Select(i => i.player).ToList()


            };

            return View(model);
        }

    }
}