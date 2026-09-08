namespace IceCity2.Interfaces
{
    public interface IOwnerService
    {
        Task<OwnerResponse> CreateOwnerAsync(
            CreateOwnerRequest request,
            CancellationToken cancellationToken = default);
    }

}