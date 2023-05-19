using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewProject.Shared;

namespace NewProject.Server.Data
{
    public class NewProjectServerContext : DbContext
    {
        public NewProjectServerContext (DbContextOptions<NewProjectServerContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Customer { get; set; } 
    }
}
