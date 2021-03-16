using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ProTracker_TO;
using Microsoft.AspNetCore.Components;

namespace ProTracker_UI.Services
{
    public class clsRackMaster : IRackMaster
    {
        HttpClient _httpClient;

        public clsRackMaster(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ProTrackerAPI");
        }

        public async Task<int> CreateRack(RackMaster roleMaster)
        {
            Int32 i = await _httpClient.PostJsonAsync<Int32>("api/RackMaster/CreateRack", roleMaster);
            return i;
        }

        public async Task<RackMaster[]> GetRacks()
        {
            return await _httpClient.GetJsonAsync<RackMaster[]>("api/RackMaster/GetRacks");
        }
    }
}
