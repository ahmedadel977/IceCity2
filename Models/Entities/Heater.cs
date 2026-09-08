namespace IceCity.EFCore.Entities
{
    public class Heater
    {
        public Guid  HeaterId { get; set; }

        public Guid HouseId { get; set; }

        public string HeaterType { get; set; } = null!;

        public decimal PowerValue { get; set; }
        public byte[] RowVersion { get; set; }

        
        public House House { get; set; } = null!;

        public List<SensorReading> DailyUsages { get; set; } = new List<SensorReading>();
    }



}
