using IceCity.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCity.EFCore.Data.conf
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
            public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.Name).HasColumnType("VARCHAR")
                .HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).HasColumnType("VARCHAR")
             .HasMaxLength(50).IsRequired();
            builder.Property(x => x.Phone).HasColumnType("VARCHAR").HasMaxLength(11).IsRequired(); 
            builder.HasQueryFilter(p => p.IsDeleted == false);
            builder.ToTable("Owners");
            builder.HasOne(x => x.User)
                .WithOne(x => x.Owner)
                .HasForeignKey<Owner>(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    
    }


}
    