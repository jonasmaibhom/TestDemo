using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDemo.Data;

namespace TestDemo.Models
{
    public class Movie : IEntity
    {
        public int Id { get; set;}

        public string Title { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
