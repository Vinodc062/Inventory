using ProTracker_TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace ProTracker_UI.Services
{
    public class clsRoles : IRoles
    {
        HttpClient _httpClient;

        public clsRoles(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ProTrackerAPI");
        }

        public async Task<int> CreateRole(RoleMaster roleMaster)
        {
            Int32 i = await _httpClient.PostJsonAsync<Int32>("api/RoleMaster/CreateRole", roleMaster);
            return i;
        }

        public async Task<RoleMaster[]> GetRoles()
        {
            return await _httpClient.GetJsonAsync<RoleMaster[]>("api/RoleMaster/GetRoles");
        }
    }
}
