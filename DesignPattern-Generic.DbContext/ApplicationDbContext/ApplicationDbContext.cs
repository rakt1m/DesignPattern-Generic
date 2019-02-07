using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

using DesignPattern_Generic.Models.EntityModels;

namespace DesignPattern_Generic.DbContext.ApplicationDbContext
{
    public class ApplicationDbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext()
        {
            
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = RAKTIM - PC; Database = DesignPattern; Trusted_Connection = true");
        }
        public virtual DbSet<DemoModel> DemoModels { get; set; }
        public  DbSet<EntityModel> EntityModels { get; set; }
    }
}
