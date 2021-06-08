using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierProject.CORE.Mapping;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.ENTITIES.Mapping
{
    public class ProductMap : CoreMap<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Price).IsRequired(false);
            builder.Property(x => x.Stock).IsRequired(false);
            builder.Property(x => x.QuantityPerUnit).HasMaxLength(50).IsRequired(false);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryID).OnDelete(DeleteBehavior.NoAction);//ondelete ile bağlı olduğu tablodaki yapması gerekenler belirtilir.

            //Silmiyoruz.
            base.Configure(builder);
        }
    }
}
