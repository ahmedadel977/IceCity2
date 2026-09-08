using IceCity.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IceCity.EFCore.Data.conf
{
    public class MonthlyReportConfiguration : IEntityTypeConfiguration<MonthlyReport>
    {
        public void Configure(EntityTypeBuilder<MonthlyReport> builder)
        {
            builder.HasKey(x => x.ReportId);
            builder.Property(x => x.ReportId).ValueGeneratedNever();

            builder.Property(x => x.TotalWorkingHours)
                .HasPrecision(10, 2);

            builder.Property(x => x.MedianHeaterValue)
                .HasPrecision(10, 2);

            builder.Property(x => x.MonthlyAverageCost)
                .HasPrecision(10, 2);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.HasOne(x => x.House)
                .WithMany(x => x.monthlyReports)
                .HasForeignKey(x => x.HouseId);
            builder.ToTable("MonthlyReports");
        }
    }


}
    