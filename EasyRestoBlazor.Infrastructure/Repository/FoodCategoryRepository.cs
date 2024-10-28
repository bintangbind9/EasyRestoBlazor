using EasyRestoBlazor.Application.Contracts.Request;
using EasyRestoBlazor.Application.Contracts.Response;
using EasyRestoBlazor.Application.Repository;
using System.Net.Http.Json;

namespace EasyRestoBlazor.Infrastructure.Repository
{
    public class FoodCategoryRepository : IBaseRepository<CreateFoodCategoryRequest, UpdateFoodCategoryRequest, FoodCategoryResponse>
    {
        private readonly HttpClient _http;
        private readonly string _url = "api/FoodCategory";

        public FoodCategoryRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task CreateAsync(CreateFoodCategoryRequest obj)
        {
            var jsonContent = JsonContent.Create(obj);
            var response = await _http.PostAsync(_url, jsonContent);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<string>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : "Failed Create Food Category!");
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            var response = await _http.DeleteAsync($"{_url}/{id}");

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<string>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : "Failed Delete Food Category!");
            }
        }

        public async Task DeletesAsync(DeleteItemsRequest request)
        {
            var jsonContent = JsonContent.Create(request);
            var response = await _http.PostAsync($"{_url}/Deletes", jsonContent);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<string>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : "Failed Delete Food Categories!");
            }
        }

        public async Task<IEnumerable<FoodCategoryResponse>> GetAllAsync()
        {
            var response = await _http.GetAsync(_url);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<IEnumerable<FoodCategoryResponse>>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : "Failed Get All Food Category!");
            }

            return baseResponse.Data;
        }

        public async Task<FoodCategoryResponse> GetByIdAsync(Guid id)
        {
            var response = await _http.GetAsync($"{_url}/{id}");

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<FoodCategoryResponse>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : "Failed Get Food Category!");
            }

            return baseResponse.Data;
        }

        public async Task UpdateAsync(Guid id, UpdateFoodCategoryRequest obj)
        {
            var jsonContent = JsonContent.Create(obj);
            var response = await _http.PutAsync($"{_url}/{id}", jsonContent);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<string>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : "Failed Update Food Category!");
            }
        }
    }
}
