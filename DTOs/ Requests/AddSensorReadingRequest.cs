namespace ice_city.DTOs.REGUEST
{

    public class AddSensorReadingRequest
    {
        public Guid HeaterId { get; set; }

        public Guid HouseId { get; set; }

        public DateTime UsageDate { get; set; }

        public decimal HoursWorked { get; set; }

        public decimal HeaterValue { get; set; }
    }
}
