using System.Collections.Generic;
using data.Abstract;
using entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using webui.Models;

namespace webui.Controllers
{
    public class BaseController:Controller
    {
    protected ICategoryRepository categoryRep;

    public BaseController(ICategoryRepository categoryRep)
    {
        this.categoryRep = categoryRep;
    }

    public override void OnActionExecuting(ActionExecutingContext     
        filterContext)
    {
        ViewBag.LayoutViewModel = new MyLayoutViewModel(){
        categories =   categoryRep.GetAll()
        };
    }

        
    }
}