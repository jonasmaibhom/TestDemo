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

namespace TestDemoIntegrationTest
{
    public class MoviesControllerIntegrationTest
    {


        [Fact]
        public void Assert_GetById_ReturnsOkResult_IfIdExists()
        {
            //Arrange

            var options = new DbContextOptionsBuilder<TestDemoContext>()
                .UseInMemoryDatabase(databaseName: "Add_Movies_To_database")
                .Options;


            //Act
            using (var context = new TestDemoContext(options))
            {
                context.Movie.Add(new Movie { Genre = "Horror", Id = 1, ReleaseDate = DateTime.Now, Title = "Batman" });
                context.SaveChanges();
            }


            //Assert
            using (var context = new TestDemoContext(options))
            {
                var repo = new EfCoreMovieRepository(context);
                var controller = new MoviesController(repo);
                var Movie = controller.Get(1);
                Assert.IsType<OkResult>(Movie.Result.Result);
            }

        }
        [Fact]
        public void Assert_GetById_ReturnsNotFound_IfIdDoesntExist()
        {
            //Arrange

            var options = new DbContextOptionsBuilder<TestDemoContext>()
                .UseInMemoryDatabase(databaseName: "Add_Movies_To_database")
                .Options;


            //Act
            using (var context = new TestDemoContext(options))
            {
                context.Movie.Add(new Movie { Genre = "Thriller", Id = 2, ReleaseDate = DateTime.Now, Title = "Superman" });
                context.SaveChanges();
            }


            //Assert
            using (var context = new TestDemoContext(options))
            {
                var repo = new EfCoreMovieRepository(context);
                var controller = new MoviesController(repo);
                var Movie = controller.Get(3);
                Assert.IsType<NotFoundResult>(Movie.Result.Result);
            }

        }

    }
}
