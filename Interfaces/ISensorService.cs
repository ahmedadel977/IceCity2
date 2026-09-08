using ice_city.DTOs.REGUEST;
using IceCity.DTOs;

public interface ISensorService
{
    Task<SensorReadingResponse> AddReadingAsync(AddSensorReadingRequest request, CancellationToken cancellationToken = default);
}