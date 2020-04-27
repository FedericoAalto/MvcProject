using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Bike
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Litri { get; set; }  
    }

    public class BikeDBContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set;  }
    }
}