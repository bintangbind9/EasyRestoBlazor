using EasyRestoBlazor.Application.Contracts.Request;

namespace EasyRestoBlazor.Application.Repository
{
    public interface IBaseRepository<TCreateRequest, TUpdateRequest, TResponse>
    {
        public Task<IEnumerable<TResponse>> GetAllAsync();
        public Task<TResponse> GetByIdAsync(Guid id);
        public Task CreateAsync(TCreateRequest obj);
        public Task UpdateAsync(Guid id, TUpdateRequest obj);
        public Task DeleteAsync(Guid id);
        public Task DeletesAsync(DeleteItemsRequest request);
    }
}
