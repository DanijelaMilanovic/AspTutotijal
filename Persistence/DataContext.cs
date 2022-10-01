using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;
using Microsoft.Extensions.Configuration;

namespace Persistence
{
    public class DataContext : DbContext
    {
            public DbSet<Activity> Activities { get; set; }

            public DataContext(DbContextOptions options) : base(options)
            {
                
            }
    }
}