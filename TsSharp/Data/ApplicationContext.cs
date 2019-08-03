using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsSharp.Models;

namespace TsSharp.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }



        public DbSet<Product> Products { get; set; }

        public DbSet<Cat> Cats { get; set; }

        public DbSet<Prop> Props { get; set; }


    }
}
