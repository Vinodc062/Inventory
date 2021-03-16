using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProTracker_UI.Services;
using ProTracker_TO;

namespace ProTracker_UI.Pages
{
    public partial class LoginForm : ComponentBase
    {
        public String _userId { get; set; }
        public String _password { get; set; }

        [Inject]
        public ILogin login { get; set; }

        public LoginForm() { }

        public async Task<Int32> Login()
        {
            Int32 i;
            try
            {
                Authenticate authenticate = new Authenticate();
                authenticate.UserName = _userId;
                authenticate.Password = _password;
                
                i = await login.Authenticateuser(authenticate);
            }
            catch (Exception ex)
            {
                 throw ex;
            }
            return i;
        }
    }
}
