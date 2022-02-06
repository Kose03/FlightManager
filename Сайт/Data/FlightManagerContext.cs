using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlightManager.Areas.Identity.Data;

namespace FlightManager.Data
{
    public class FlightManagerContext : DbContext
    {
        public FlightManagerContext (DbContextOptions<FlightManagerContext> options)
            : base(options)
        {
        }

        public DbSet<FlightManager.Areas.Identity.Data.Reservations> Reservations { get; set; }
    }
}
