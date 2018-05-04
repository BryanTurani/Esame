using AssociazioneSportiva.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.DataAccess
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }

        public DbSet<Società> Società { get; set; }
        public DbSet<Persona> Persone { get; set; }
        public DbSet<Tessera> Tessere { get; set; }
    }
}
