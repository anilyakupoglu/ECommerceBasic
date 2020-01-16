using ETicaretBasic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBasic.DAL.EntityFramework
{
    public class ETicaretDBContext : DbContext
    {
        public ETicaretDBContext() : base("Server=.;Database=ECommerceBasic;Trusted_Connection=True")
        {
      
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
       
        }

    }
}
