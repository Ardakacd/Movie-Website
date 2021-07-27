using System.Linq;
using data.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webui.Models;

namespace webui.Controllers
{

    [Authorize]
    public class PlayerController:BaseController
    {
        
        private IMovieRepository movieRep;

        private IPlayerRepository playerRep;

        private IDirectorRepository directorRep;
        

        public PlayerController(ICategoryRepository categoryRep,IMovieRepository movieRep,IPlayerRepository playerRep,IDirectorRepository directorRep):base(categoryRep){
            
            
            this.movieRep = movieRep;
            this.playerRep = playerRep;
            this.directorRep = directorRep;
        }

        public IActionResult list(){

            var model = new PlayerListModel(){
                players = playerRep.getAllPlayersInclude()
            };

            return View(model);
        }

        public IActionResult detail(int id){
            var player = playerRep.getAllPlayersInclude(id);

            var model = new PlayerModel(){
                Name = player.Name,
                PhotoUrl = player.PhotoUrl,
                Age = player.Age,
                Imdb = player.Imdb,
                Birthday = player.Birthday,
                movies = player.movies.Select( i => i.movie).ToList()
            };

            return View(model);
        }
    }
}