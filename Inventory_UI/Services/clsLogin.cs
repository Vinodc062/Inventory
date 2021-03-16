using ProTracker_TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Components;

namespace ProTracker_UI.Services
{
    public class clsLogin : ILogin
    {
        private readonly HttpClient _httpClient;
        public clsLogin(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ProTrackerAPI");
        }
        public async Task<Int32> Authenticateuser(Authenticate authenticate)
        {
           Int32 i = await _httpClient.PostJsonAsync<Int32>("api/Login/AuthenticateUser", authenticate);
            return i;
        }
    }
}
