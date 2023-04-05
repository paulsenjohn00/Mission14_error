using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Controllers.MovieData;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private MovieDbContext context;

        public MoviesController(MovieDbContext temp)
        {
            context = temp;
        }

        public IEnumerable<MovieInfo> Get()
        {
            return context.Movies.ToArray()
                .Where(x => x.Edited == "Yes");
        }
    }
}

