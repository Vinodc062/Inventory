using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ProTracker_UI.Services;
using ProTracker_TO;

namespace ProTracker_UI.Pages
{
    partial class VehicleMaster : ComponentBase
    {
        ProTracker_TO.VehicleMaster vehicleMaster = new ProTracker_TO.VehicleMaster();

        [Inject]
        IVehicle vehicle { get; set; }

        [Inject]
        NavigationManager navigationManager { get; set; }

        public ProTracker_TO.VehicleMaster[] vehicleMasters { get; set; }
        public string Filter { get; set; }
        public String SavedStatus;
        protected override async Task OnInitializedAsync()
        {
            this.vehicleMasters = await vehicle.Getvehicles();
        }

        public bool IsVisible(ProTracker_TO.VehicleMaster vehicle)
        {
            if (string.IsNullOrEmpty(Filter))
                return true;

            if (vehicle.vm_Vehicle_Number.Contains(Filter, StringComparison.OrdinalIgnoreCase))
                return true;

            if (vehicle.vm_Vehicle_desc.Contains(Filter, StringComparison.OrdinalIgnoreCase))
                return true;

            if (vehicle.vm_Vehicle_Id.ToString().Contains(Filter))
                return true;

            if (vehicle.vm_Status.Equals(Filter))
                return true;

            return false;
        }

        public async Task<int> Createvehicle()
        {
            int VehicleId = await vehicle.CreateVehicle(vehicleMaster);

            SavedStatus = "Saved Successfully";
            vehicleMaster = new ProTracker_TO.VehicleMaster();
            return VehicleId;
        }

        public void Displayrec(ProTracker_TO.VehicleMaster e)
        {
            vehicleMaster.vm_Vehicle_Id = e.vm_Vehicle_Id;
            vehicleMaster.vm_Vehicle_Number= e.vm_Vehicle_Number;
            vehicleMaster.vm_Vehicle_desc= e.vm_Vehicle_desc;
            vehicleMaster.vm_Status = e.vm_Status;
        }
        public void RedirectHomePage()
        {
            navigationManager.NavigateTo("/");
        }
    }
}
