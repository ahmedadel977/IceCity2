using IceCity2.DTOs.Responses;

namespace IceCity2.Interfaces
{
    public interface ICostService
    {
        Task<HouseCostResponse> GetHouseCostAsync(
            Guid houseId,
            CancellationToken cancellationToken = default);
    }

}