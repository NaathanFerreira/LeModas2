using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LeModas_2.Models
{
    public class LeModas_2Context : DbContext
    {
        public LeModas_2Context (DbContextOptions<LeModas_2Context> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}
