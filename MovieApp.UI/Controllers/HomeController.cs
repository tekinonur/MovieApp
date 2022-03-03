using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieApp.UI.Data;
using MovieApp.UI.Models;

namespace MovieApp.UI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int? id)
    {
        var movies = MovieRepository.Movies;
        if(id.HasValue){
            movies = movies.Where(x=>x.CategoryID == id).ToList();
        }

        return View(movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Details(int id)
    {
        return View( MovieRepository.GetById(id));
    }
}
