using System.Diagnostics;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieApp.UI.Data;
using MovieApp.UI.Models;

namespace MovieApp.UI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMapper _mapper;

    public HomeController(ILogger<HomeController> logger, IMapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
    }

    public IActionResult Index(int? id)
    {
         var movies = MovieRepository.Movies;

        using (var ctx = new DataContext())
        {
            var movieEntities = ctx.MovieEntities.ToList();
            movies = _mapper.Map<List<Movie>>(movieEntities);
        }

        if (id.HasValue)
        {
            movies = movies.Where(x => x.CategoryID == id).ToList();
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
        return View(MovieRepository.GetById(id));
    }
}
