using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierProject.CORE.Mapping;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.ENTITIES.Mapping
{
    public class UserMap : CoreMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Surname).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Username).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Password).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Address).IsRequired(false);
            builder.Property(x => x.PhoneNumber).IsRequired(false);
            builder.Property(x => x.BirthDate).HasColumnType("datetime2").IsRequired(false);


            //Silmiyoruz.
            base.Configure(builder);
        }
    }
}
