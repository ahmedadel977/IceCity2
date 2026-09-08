namespace IceCity.EFCore.Entities
{
    public class MonthlyReport
    {
        public Guid ReportId { get; set; }

        public Guid HouseId { get; set; }

        public DateTime ReportMonth { get; set; }

        public decimal TotalWorkingHours { get; set; }

        public decimal MedianHeaterValue { get; set; }

        public decimal MonthlyAverageCost { get; set; }

        public DateTime CreatedAt { get; set; }

      
        public House House { get; set; } = null!;
    }



}
