namespace IceCity2.DTOs.Responses
{
    public class HouseCostResponse
    {
        public Guid HouseId { get; set; }

        public decimal TotalHoursWorked { get; set; }

        public decimal AverageHeaterValue { get; set; }

        public decimal AverageMonthlyCost { get; set; }
     
    }
}