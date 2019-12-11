using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDemo.Models;

namespace TestDemo.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, TestDemoContext>
    {
        public EfCoreMovieRepository(TestDemoContext context) : base(context)
        {
        }
    }
}
