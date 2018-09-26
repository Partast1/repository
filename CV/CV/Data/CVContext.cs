using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CV.Models
{
    public class CVContext : DbContext
    {
        public CVContext (DbContextOptions<CVContext> options)
            : base(options)
        {
        }

        public DbSet<CV.Models.Movies> Movies { get; set; }
    }
}
