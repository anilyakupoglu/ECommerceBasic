using ETicaretBasic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBasic.DAL.EntityFramework.Mapping
{
    public class CategoryMapping:EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            this.HasMany(a => a.Products)
                .WithRequired(a => a.Category)
                .HasForeignKey(a => a.CategoryID)
                .WillCascadeOnDelete(false);
        }
    }
}
