using data.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webui.Models;

namespace webui.Controllers
{

    [Authorize]
    public class SearchController:BaseController
    {
         private IMovieRepository movieRep;

        private IPlayerRepository playerRep;

        private IDirectorRepository directorRep;
        

        public SearchController(ICategoryRepository categoryRep,IMovieRepository movieRep,IPlayerRepository playerRep,IDirectorRepository directorRep):base(categoryRep){
            
            
            this.movieRep = movieRep;
            this.playerRep = playerRep;
            this.directorRep = directorRep;
        }

        public IActionResult index(string name){



            var model = new AllModel(){
             movies = movieRep.searchMov(name),
             players = playerRep.searchPlay(name),
             directors = directorRep.searchDir(name),
             categories = categoryRep.searchCat(name)  
            };

            return View(model);

        }
    }
}