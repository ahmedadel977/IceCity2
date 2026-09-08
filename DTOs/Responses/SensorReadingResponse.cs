using IceCity.EFCore.Entities;

namespace IceCity.DTOs;

public class SensorReadingResponse
{
    public Guid SensorReadingId { get; set; }

    public Guid HeaterId { get; set; }

    public Guid HouseId { get; set; }

    public DateTime UsageDate { get; set; }

    public decimal HoursWorked { get; set; }

    public decimal HeaterValue { get; set; }
    private SensorReadingResponse() { }
    public static SensorReadingResponse FromModel(SensorReading sensorReading)
    {
        if (sensorReading == null)
            throw new ArgumentNullException(nameof(sensorReading), "Cannot create a response from a null sensorReading");
        SensorReadingResponse response = new SensorReadingResponse()
        {
            SensorReadingId = sensorReading.SensorReadingId,
            HeaterId = sensorReading.HeaterId,
            HouseId = sensorReading.HouseId,
            UsageDate = sensorReading.UsageDate,
            HoursWorked = sensorReading.HoursWorked,
            HeaterValue = sensorReading.HeaterValue,

        };
        return response;

    }
    public static IEnumerable<SensorReadingResponse> FromModels(IEnumerable<SensorReading> sensorReading)
    {
        if (sensorReading == null)
            throw new ArgumentNullException(nameof(sensorReading), "Cannot create a response from a null sensorReading");

        return sensorReading.Select(p => FromModel(p));



    }
}