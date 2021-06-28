using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_3_1.Models
{
    public class JaluziContext : DbContext
    {
        public DbSet<Jaluzi> Jaluzis { get; set; }
        public DbSet<Order> Orders { get; set; }
        public JaluziContext(DbContextOptions<JaluziContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

