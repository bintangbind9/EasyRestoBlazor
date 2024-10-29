﻿using EasyRestoBlazor.Application.Contracts.Request;
using EasyRestoBlazor.Application.Contracts.Response;
using EasyRestoBlazor.Application.Repository;
using System.Net.Http.Json;

namespace EasyRestoBlazor.Infrastructure.Repository
{
    public class RoleRepository : IBaseRepository<CreateRoleRequest, UpdateRoleRequest, RoleResponse>
    {
        private readonly HttpClient _http;
        private readonly string _url = "api/Role";
        private readonly string _objName = "Role";

        public RoleRepository(HttpClient http)
        {
            _http = http;
        }

        public Task CreateAsync(CreateRoleRequest obj)
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

        public async Task<IEnumerable<RoleResponse>> GetAllAsync()
        {
            var response = await _http.GetAsync(_url);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<IEnumerable<RoleResponse>>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : $"Failed Get All {_objName}s!");
            }

            return baseResponse.Data;
        }

        public Task<RoleResponse> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, UpdateRoleRequest obj)
        {
            throw new NotImplementedException();
        }
    }
}