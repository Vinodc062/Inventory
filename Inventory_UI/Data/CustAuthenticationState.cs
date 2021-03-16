using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace ProTracker_UI.Data
{
    public class CustAuthenticationState //: AuthenticationStateProvider
    {
        //public override Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
        //    var Identity = new ClaimsIdentity();
        //    var user = new ClaimsPrincipal(Identity);

        //    return Task.FromResult(new AuthenticationState(user));
        //}

        //public void NotifyUserAuthenticated(int userId)
        //{
        //    var identity = new ClaimsIdentity(new[]
        //    {
        //        new Claim("UserId",userId.ToString())
        //    });
        //}
    }
}
