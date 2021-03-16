using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ProTracker_UI.Services;
using ProTracker_TO;

namespace ProTracker_UI.Pages
{
    partial class RolesMaster : ComponentBase
    {

        RoleMaster rm = new RoleMaster();

        [Inject]
        public IRoles roles { get; set; }

        [Inject]
        NavigationManager navigationManager { get; set; }

        public RoleMaster[] roleMasters { get; set; }
        public string Filter { get; set; }
        public String SavedStatus;
        protected override async Task OnInitializedAsync()
        {
           this.roleMasters = await roles.GetRoles();
        }

        public bool IsVisible(RoleMaster role)
        {
            if (string.IsNullOrEmpty(Filter))
                return true;

            if (role.rm_RoleName.Contains(Filter, StringComparison.OrdinalIgnoreCase))
                return true;

            if (role.rm_RoleId.ToString().Contains(Filter))
                return true;

            if (role.rm_Status.Equals(Filter))
                return true;

            return false;
        }

        public async Task<int> CreateRole()
        {
          int roleId =  await roles.CreateRole(rm);

            SavedStatus = "Saved Successfully";
            rm = new RoleMaster();
            return roleId;
        }

        public void Displayrec(RoleMaster e)
        {
            rm.rm_RoleId = e.rm_RoleId;
            rm.rm_RoleName = e.rm_RoleName;
            rm.rm_Status = e.rm_Status;
        }

        public void RedirectHomePage()
        {
            navigationManager.NavigateTo("/"); 
        }
    }
}
