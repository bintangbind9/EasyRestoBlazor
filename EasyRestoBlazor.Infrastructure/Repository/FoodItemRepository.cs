using EasyRestoBlazor.Application.Contracts.Request;
using EasyRestoBlazor.Application.Contracts.Response;
using EasyRestoBlazor.Application.Repository;
using System.Net.Http.Json;

namespace EasyRestoBlazor.Infrastructure.Repository
{
    public class FoodItemRepository : IBaseRepository<CreateFoodItemRequest, UpdateFoodItemRequest, FoodItemResponse>
    {
        private readonly HttpClient _http;
        private readonly string _url = "api/FoodItem";
        private readonly string _objName = "Food";

        public FoodItemRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task CreateAsync(CreateFoodItemRequest obj)
        {
            var jsonContent = JsonContent.Create(obj);
            var response = await _http.PostAsync(_url, jsonContent);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<string>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : $"Failed Create {_objName}!");
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            var response = await _http.DeleteAsync($"{_url}/{id}");

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<string>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : $"Failed Delete {_objName}!");
            }
        }

        public async Task DeletesAsync(DeleteItemsRequest request)
        {
            var jsonContent = JsonContent.Create(request);
            var response = await _http.PostAsync($"{_url}/Deletes", jsonContent);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<string>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : $"Failed Delete {_objName}s!");
            }
        }

        public async Task<IEnumerable<FoodItemResponse>> GetAllAsync()
        {
            var response = await _http.GetAsync(_url);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<IEnumerable<FoodItemResponse>>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : $"Failed Get All {_objName}!");
            }

            return baseResponse.Data;
        }

        public async Task<FoodItemResponse> GetByIdAsync(Guid id)
        {
            var response = await _http.GetAsync($"{_url}/{id}");

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<FoodItemResponse>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : $"Failed Get {_objName}!");
            }

            return baseResponse.Data;
        }

        public async Task UpdateAsync(Guid id, UpdateFoodItemRequest obj)
        {
            var jsonContent = JsonContent.Create(obj);
            var response = await _http.PutAsync($"{_url}/{id}", jsonContent);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<string>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : $"Failed Update {_objName}!");
            }
        }
    }
}
