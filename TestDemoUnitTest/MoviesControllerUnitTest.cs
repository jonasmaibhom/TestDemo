using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using TestDemo.Controllers;
using TestDemo.Data;
using TestDemo.Data.EFCore;
using TestDemo.Models;
using Xunit;


namespace TestDemoUnitTest
{
    public class MoviesControllerUnitTest
    {
        //[Fact]
        //public void Get_All_Movies()
        //{
        //    //Arrange
            
        //}

        //private List<Movie> GetTestMovies()
        //{
        //    var testMovies = new List<Movie>();
        //    testMovies.Add(new Movie { Id = 1, Genre = "Horror", ReleaseDate = DateTime.Now, Title = "Deadpool"});
        //    testMovies.Add(new Movie { Id = 1, Genre = "Horror", ReleaseDate = DateTime.Now, Title = "Deadpool" });
        //    testMovies.Add(new Movie { Id = 1, Genre = "Horror", ReleaseDate = DateTime.Now, Title = "Deadpool" });
        //    testMovies.Add(new Movie { Id = 1, Genre = "Horror", ReleaseDate = DateTime.Now, Title = "Deadpool" });

        //    return testMovies;
        //}
    }
}
