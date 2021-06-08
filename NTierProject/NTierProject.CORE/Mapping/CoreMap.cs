using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierProject.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.CORE.Mapping
{
    public class CoreMap<T> : IEntityTypeConfiguration<T> where T : CoreEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)//temelde kullan, üzerine yazarsam yazdıklarımı geçerli kıl
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasColumnName("ID");
            builder.Property(x => x.Status).IsRequired(true);//boş bırakılır olması için false, olmaması için true


            builder.Property(x => x.CreatedComputerName).HasColumnName("CreatedComputerName").IsRequired(false);
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate").IsRequired(false);
            builder.Property(x => x.CreatedADUserName).HasColumnName("CreatedADUserName").IsRequired(false);
            builder.Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsRequired(false);
            builder.Property(x => x.CreatedIP).HasColumnName("CreatedIP").IsRequired(false);


            builder.Property(x => x.ModifiedComputerName).HasColumnName("ModifiedComputerName").IsRequired(false);
            builder.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired(false);
            builder.Property(x => x.ModifiedADUserName).HasColumnName("ModifiedADUserName").IsRequired(false);
            builder.Property(x => x.ModifiedBy).HasColumnName("ModifiedBy").IsRequired(false);
            builder.Property(x => x.ModifiedIP).HasColumnName("ModifiedIP").IsRequired(false);
        }
    }
}
