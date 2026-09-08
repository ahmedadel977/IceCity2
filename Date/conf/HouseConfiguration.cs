using IceCity.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IceCity.EFCore.Data.conf
{
    public class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.HasKey (x=>x.HouseId);
            builder.Property(x => x.HouseId).ValueGeneratedNever();


            builder.Property(x => x.Address).HasColumnType("VARCHAR")
                .HasMaxLength(100).IsRequired();
            builder.Property(x => x.CityZone).HasColumnType("VARCHAR")
               .HasMaxLength(100).IsRequired();
            builder.HasOne(x => x.owner).WithMany(x => x.Houses).HasForeignKey(x => x.OwnerId);
            builder.ToTable("Houses");



        }

    }


}
    