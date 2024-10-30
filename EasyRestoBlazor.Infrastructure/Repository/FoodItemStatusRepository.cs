using EasyRestoBlazor.Application.Contracts.Request;
using EasyRestoBlazor.Application.Contracts.Response;
using EasyRestoBlazor.Application.Repository;
using System.Net.Http.Json;

namespace EasyRestoBlazor.Infrastructure.Repository
{
    public class FoodItemStatusRepository : IBaseRepository<CreateFoodItemStatusRequest, UpdateFoodItemStatusRequest, FoodItemStatusResponse>
    {
        private readonly HttpClient _http;
        private readonly string _url = "api/FoodItemStatus";
        private readonly string _objName = "Food Item Status";

        public FoodItemStatusRepository(HttpClient http)
        {
            _http = http;
        }

        public Task CreateAsync(CreateFoodItemStatusRequest obj)
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

        public async Task<IEnumerable<FoodItemStatusResponse>> GetAllAsync()
        {
            var response = await _http.GetAsync(_url);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<IEnumerable<FoodItemStatusResponse>>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : $"Failed Get All {_objName}!");
            }

            return baseResponse.Data;
        }

        public Task<FoodItemStatusResponse> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, UpdateFoodItemStatusRequest obj)
        {
            throw new NotImplementedException();
        }
    }
}
