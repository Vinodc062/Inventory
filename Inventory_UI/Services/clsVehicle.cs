using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ProTracker_TO;
using Microsoft.AspNetCore.Components;

namespace ProTracker_UI.Services
{
    public class clsVehicle : IVehicle
    {

        HttpClient _httpClient;

        public clsVehicle(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ProTrackerAPI");
        }
        public async Task<int> CreateVehicle(VehicleMaster vehicleMaster)
        {
            Int32 i = await _httpClient.PostJsonAsync<Int32>("api/VehicleMaster/CreateVehicle", vehicleMaster);
            return i;
        }

        public async Task<VehicleMaster[]> Getvehicles()
        {
            return await _httpClient.GetJsonAsync<VehicleMaster[]>("api/VehicleMaster/GetVehicles");
        }
    }
}
