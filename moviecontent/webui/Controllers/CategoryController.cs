using System.Linq;
using data.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webui.Models;

namespace webui.Controllers
{

    [Authorize]
    public class CategoryController:BaseController
    {
          private IMovieRepository movieRep;

        private IPlayerRepository playerRep;

        private IDirectorRepository directorRep;
        

        public CategoryController(ICategoryRepository categoryRep,IMovieRepository movieRep,IPlayerRepository playerRep,IDirectorRepository directorRep):base(categoryRep){
            
            
            this.movieRep = movieRep;
            this.playerRep = playerRep;
            this.directorRep = directorRep;
        }

        public IActionResult wanted(int id){


            

            var model = new CategoryMovieModel(){
                category = categoryRep.GetCategoryWithIdInclude(id),
                movies = categoryRep.GetCategoryWithIdInclude(id).movies.Select(i => i.movie).ToList()
            };

            

            return View(model);

        }

    }
}