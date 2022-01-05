using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlightManager.Models;

namespace FlightManager.Data
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext (DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }

        public DbSet<FlightManager.Models.Reservations> Reservations { get; set; }
    }
}
