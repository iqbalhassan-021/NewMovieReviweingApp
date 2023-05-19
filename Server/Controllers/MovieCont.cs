using Microsoft.AspNetCore.Mvc;
using NewProject.Shared;

namespace NewProject.Server.Controllers
{
    public class MovieCont : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        


        [HttpGet("MovieCont")]
        public IEnumerable<Movie> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Movie
            {
            movie_name = "Maula Jutt",
            movie_Description = "Fighting",
            movie_rating = "fine"

               
            })
            .ToArray();
        }
    }
}
