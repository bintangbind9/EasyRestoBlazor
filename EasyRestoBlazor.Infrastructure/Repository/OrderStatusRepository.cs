using EasyRestoBlazor.Application.Contracts.Request;
using EasyRestoBlazor.Application.Contracts.Response;
using EasyRestoBlazor.Application.Repository;
using System.Net.Http.Json;

namespace EasyRestoBlazor.Infrastructure.Repository
{
    public class OrderStatusRepository : IBaseRepository<CreateOrderStatusRequest, UpdateOrderStatusRequest, OrderStatusResponse>
    {
        private readonly HttpClient _http;
        private readonly string _url = "api/OrderStatus";
        private readonly string _objName = "Order Status";

        public OrderStatusRepository(HttpClient http)
        {
            _http = http;
        }

        public Task CreateAsync(CreateOrderStatusRequest obj)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DeletesAsync(DeleteItemsRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OrderStatusResponse>> GetAllAsync()
        {
            var response = await _http.GetAsync(_url);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<IEnumerable<OrderStatusResponse>>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : $"Failed Get All {_objName}!");
            }

            return baseResponse.Data;
        }

        public Task<OrderStatusResponse> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, UpdateOrderStatusRequest obj)
        {
            throw new NotImplementedException();
        }
    }
}
