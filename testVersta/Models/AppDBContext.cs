using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testVersta.Models
{
    public class AppDBContext : DbContext
    {
     public DbSet<Order> Orders { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {
            Database.EnsureCreated();
        }

    }
}
