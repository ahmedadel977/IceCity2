using IceCity.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IceCity.EFCore.Data.conf
{
    public class HeaterConfiguration : IEntityTypeConfiguration<Heater>
    {
        public void Configure(EntityTypeBuilder<Heater> builder)
        {
            builder.HasKey(x => x.HeaterId);
            builder .Property (x => x.HeaterId).ValueGeneratedNever();

            builder.Property(x => x.HeaterType)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(x => x.RowVersion).IsRowVersion();
            builder.Property(x => x.PowerValue)
                .HasPrecision(10, 2);

            builder.HasOne(x => x.House)
                .WithMany(x => x.heaters)
                .HasForeignKey(x => x.HouseId);
               

            builder.ToTable("Heaters");
        }
    }


}
    