using IceCity.EFCore.Data;
using IceCity2.DTOs.Responses;
using IceCity2.Interfaces;
using M01.BaselineAPIProjectController.Exceptions;
using Microsoft.EntityFrameworkCore;

public class CostService : ICostService
{
    private readonly AppDbContext _context;

    public CostService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<HouseCostResponse> GetHouseCostAsync(
        Guid houseId,
        CancellationToken cancellationToken = default)
    {
        var fromDate = DateTime.UtcNow.AddDays(-30);

        var readings = _context.SensorReadings.AsNoTracking()
            .Where(x =>
                x.HouseId == houseId &&
                x.UsageDate >= fromDate &&
                x.UsageDate <= DateTime.UtcNow);

        var exists = await readings.AnyAsync(cancellationToken);

        if (!exists)
        {
            throw new BusinessRuleException($"No sensor readings found for house with ID {houseId} in the last 30 days.", StatusCodes.Status404NotFound);
        }

        var totalHoursWorked = await readings.AsNoTracking ()
            .SumAsync(x => x.HoursWorked, cancellationToken);

        var averageHeaterValue = await readings.AsNoTracking()
            .AverageAsync(x => x.HeaterValue);

        var averageMonthlyCost = await readings.AsNoTracking()
            .Select(x => x.HoursWorked * x.HeaterValue)
            .AverageAsync(cancellationToken);

        return new HouseCostResponse
        {
            HouseId = houseId,
            TotalHoursWorked = totalHoursWorked,
            AverageHeaterValue = averageHeaterValue,
            AverageMonthlyCost = averageMonthlyCost
        };
    }
}