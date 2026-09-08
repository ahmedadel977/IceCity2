using ice_city.DTOs.REGUEST;
using IceCity.DTOs;
using IceCity.EFCore.Data;
using IceCity.EFCore.Entities;

public class SensorService : ISensorService
{
    private readonly AppDbContext _context;

    public SensorService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<SensorReadingResponse> AddReadingAsync(
        AddSensorReadingRequest request,
        CancellationToken cancellationToken = default)
    {
        // Business Logic هنا

       var reading = new SensorReading
        {
            SensorReadingId = Guid.NewGuid(),
            HeaterId = request.HeaterId,
            HouseId = request.HouseId,
            UsageDate = request.UsageDate,
            HoursWorked = request.HoursWorked,
            HeaterValue = request.HeaterValue
        };

        _context.SensorReadings.Add(reading);

        await _context.SaveChangesAsync(cancellationToken);

        return SensorReadingResponse.FromModel(reading);

    }
}