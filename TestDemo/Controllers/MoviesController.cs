using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDemo.Data.EFCore;
using TestDemo.Models;

namespace TestDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : testdemoController<Movie, EfCoreMovieRepository>
    {
        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {
        }
    }
}
