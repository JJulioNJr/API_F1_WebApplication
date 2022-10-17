using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationF1.Models;

namespace WebApplicationF1.Data
{
    public class WebApplicationF1Context : DbContext
    {
        public WebApplicationF1Context (DbContextOptions<WebApplicationF1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationF1.Models.Car> Car { get; set; }

        public DbSet<WebApplicationF1.Models.Driver> Driver { get; set; }

        public DbSet<WebApplicationF1.Models.Team> Team { get; set; }

        public DbSet<WebApplicationF1.Models.DriverCar> DriverCar { get; set; }
    }
}
