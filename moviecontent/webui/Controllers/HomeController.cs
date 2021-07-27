using Microsoft.AspNetCore.Mvc;
using System;
using data.Abstract;
using data.Concrete;
using webui.Models;
using Microsoft.AspNetCore.Authorization;

namespace webui.Controllers
{

    [Authorize]
    public class HomeController:BaseController
    {


        private IMovieRepository movieRep;

        private IPlayerRepository playerRep;

        private IDirectorRepository directorRep;
        

        public HomeController(ICategoryRepository categoryRep,IMovieRepository movieRep,IPlayerRepository playerRep,IDirectorRepository directorRep):base(categoryRep){
            
            
            this.movieRep = movieRep;
            this.playerRep = playerRep;
            this.directorRep = directorRep;
        }
        public IActionResult Main(){

            
            var model = new CategoryMovieListModel(){
                categories = categoryRep.GetCategoryLimit4(),
                movies = movieRep.getMovieHome()
            };

            

            
            
            
            return View(model);
        }


    }
}