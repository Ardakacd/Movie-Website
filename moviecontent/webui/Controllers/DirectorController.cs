using data.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webui.Models;

namespace webui.Controllers
{

    [Authorize]
    public class DirectorController:BaseController
    {
           private IMovieRepository movieRep;

        private IPlayerRepository playerRep;

        private IDirectorRepository directorRep;
        

        public DirectorController(ICategoryRepository categoryRep,IMovieRepository movieRep,IPlayerRepository playerRep,IDirectorRepository directorRep):base(categoryRep){
            
            
            this.movieRep = movieRep;
            this.playerRep = playerRep;
            this.directorRep = directorRep;
        }

        public IActionResult list(){
            var model = new DirectorListModel(){
                directors = directorRep.GetAll()
            };

            return View(model);

        }

        public IActionResult detail(int id){
            var director = directorRep.getDirectorInclude(id);

            var model = new DirectoryModel(){
                Name = director.Name,
                PhotoUrl = director.PhotoUrl,
                Age = director.Age,
                Imdb = director.Imdb,
                Birthday = director.Birthday,
                movies = director.movies
                
            };

            return View(model);
        }
    }
}