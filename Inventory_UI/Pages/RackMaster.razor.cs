using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProTracker_UI.Services;
using ProTracker_TO;

namespace ProTracker_UI.Pages
{
    partial class RackMaster : ComponentBase
    {
        ProTracker_TO.RackMaster rackMaster = new ProTracker_TO.RackMaster();

        [Inject]
        public IRackMaster _rackMaster { get; set; }
        
        [Inject]
        NavigationManager navigationManager { get; set; }

        public String SavedStatus;
        public ProTracker_TO.RackMaster[] rackMasters { get; set; }
        public string Filter { get; set; }
        protected override async Task OnInitializedAsync()
        {
            this.rackMasters = await _rackMaster.GetRacks();
        }
        public bool IsVisible(ProTracker_TO.RackMaster Rack)
        {
            if (string.IsNullOrEmpty(Filter))
                return true;

            if (Rack.rak_Rack_Number.Contains(Filter, StringComparison.OrdinalIgnoreCase))
                return true;

            if (Rack.rak_Rack_Name.Contains(Filter, StringComparison.OrdinalIgnoreCase))
                return true;

            if (Rack.rak_Rack_Id.ToString().Contains(Filter))
                return true;

            return false;
        }

        public async Task<int> CreateRole()
        {
            int rackId = await _rackMaster.CreateRack(rackMaster);

            SavedStatus = "Saved Successfully";
            rackMaster = new ProTracker_TO.RackMaster();
            return rackId;
        }

        public void Displayrec(ProTracker_TO.RackMaster e)
        {
            rackMaster.rak_Rack_Id = e.rak_Rack_Id;
            rackMaster.rak_Rack_Name= e.rak_Rack_Name;
            rackMaster.rak_Rack_Number = e.rak_Rack_Number;
        }

        public void RedirectHomePage()
        {
            navigationManager.NavigateTo("/");
        }
    }
}
