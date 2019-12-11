using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestDemo.Models
{
    public class TestDemoContext : DbContext
    {
        public TestDemoContext (DbContextOptions<TestDemoContext> options)
            : base(options)
        {
        }

        public DbSet<TestDemo.Models.Movie> Movie { get; set; }
    }
}
