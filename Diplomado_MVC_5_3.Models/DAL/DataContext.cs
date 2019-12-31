using Diplomado_MVC_5_3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomado_MVC_5_3.Models.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base ("defaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
