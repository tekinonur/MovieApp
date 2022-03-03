using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.UI.Data;

namespace MovieApp.UI.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //RouteData.Values["controller"] => home
            //RouteData.Values["action"] => index
            //RouteData.Values["id"] => 3
            if(RouteData.Values["action"].ToString() == "Index")
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}