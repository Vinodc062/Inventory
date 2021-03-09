using ProTracker_DAL.TableObjects;
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
        public String _userId { get; set; }
        public String _password { get; set; }

        private readonly HttpClient _httpClient;
        public clsLogin(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ProTrackerAPI");
        }
        public async Task<Int32> Authenticateuser(Authenticate authenticate)
        {
         //   String Jsonobj = JsonConvert.SerializeObject(authenticate); 
           // String Jsonobj = "{ \"UserName\": \"vinod.c062\",\"password\": \"vinod.c062\"}";

           Int32 i = await _httpClient.PostJsonAsync<Int32>("api/Login/AuthenticateUser", authenticate);
            return i;
        }
    }
}
