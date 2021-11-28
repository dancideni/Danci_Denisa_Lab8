using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Danci_Denisa_Lab8.Models;

namespace Danci_Denisa_Lab8.Data
{
    public class Danci_Denisa_Lab8Context : DbContext
    {
        public Danci_Denisa_Lab8Context (DbContextOptions<Danci_Denisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Danci_Denisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Danci_Denisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Danci_Denisa_Lab8.Models.Category> Category { get; set; }
    }
}
