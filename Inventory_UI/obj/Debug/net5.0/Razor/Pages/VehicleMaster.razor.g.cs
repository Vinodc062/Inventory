#pragma checksum "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "439cf22fea0448e8f44c87804212ad0cca596f95"
// <auto-generated/>
#pragma warning disable 1591
namespace ProTracker_UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\_Imports.razor"
using ProTracker_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\_Imports.razor"
using ProTracker_UI.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/VehicleMaster")]
    public partial class VehicleMaster : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Vehicle Master</h3>\r\n");
            __builder.OpenElement(1, "body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                     vehicleMaster

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group row");
                __builder2.AddMarkupContent(11, "<label for=\"lblVehicleId\" class=\"col-sm-2 col-form-label\">Vehicle Id</label>\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-sm-5");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "readonly");
                __builder2.AddAttribute(17, "class", "form-control-plaintext border");
                __builder2.AddAttribute(18, "id", "txtVehicleId");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                          vehicleMaster.vm_Vehicle_Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vehicleMaster.vm_Vehicle_Id = __value, vehicleMaster.vm_Vehicle_Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group row");
                __Blazor.ProTracker_UI.Pages.VehicleMaster.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 16 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                     () => vehicleMaster.vm_Vehicle_Number

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.AddMarkupContent(27, "<label for=\"lblVehicleNumber\" class=\"col-sm-2 col-form-label\">Vehicle Number</label>\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-sm-5");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "class", "form-control-plaintext border");
                __builder2.AddAttribute(33, "id", "txtVehicleNumber");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                          vehicleMaster.vm_Vehicle_Number

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vehicleMaster.vm_Vehicle_Number = __value, vehicleMaster.vm_Vehicle_Number));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group row");
                __Blazor.ProTracker_UI.Pages.VehicleMaster.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#nullable restore
#line 24 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                     () => vehicleMaster.vm_Vehicle_desc

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.AddMarkupContent(42, "<label for=\"lblVehicleDesc\" class=\"col-sm-2 col-form-label\">Vehicle Desc</label>\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-sm-5");
                __builder2.OpenElement(45, "input");
                __builder2.AddAttribute(46, "type", "text");
                __builder2.AddAttribute(47, "class", "form-control-plaintext border");
                __builder2.AddAttribute(48, "id", "txtVehicleDesc");
                __builder2.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                          vehicleMaster.vm_Vehicle_desc

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vehicleMaster.vm_Vehicle_desc = __value, vehicleMaster.vm_Vehicle_desc));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group row");
                __builder2.AddMarkupContent(54, "<label for=\"lblVehicleStatus\" class=\"col-sm-2 col-form-label\">Status</label>\r\n            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-sm-5");
                __builder2.OpenElement(57, "input");
                __builder2.AddAttribute(58, "type", "checkbox");
                __builder2.AddAttribute(59, "class", "form-control-plaintext border align-content-lg-start");
                __builder2.AddAttribute(60, "id", "chkVehicleStatus");
                __builder2.AddAttribute(61, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                              vehicleMaster.vm_Status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vehicleMaster.vm_Status = __value, vehicleMaster.vm_Status));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group row");
                __builder2.OpenElement(66, "button");
                __builder2.AddAttribute(67, "type", "submit");
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                             Createvehicle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "class", "btn btn-primary");
                __builder2.AddContent(70, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.AddMarkupContent(72, "<div class=\"col-sm-5\"><button class=\"btn btn-danger\">Cancel</button></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.OpenElement(74, "div");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group");
                __builder2.OpenElement(77, "input");
                __builder2.AddAttribute(78, "class", "form-control");
                __builder2.AddAttribute(79, "type", "text");
                __builder2.AddAttribute(80, "placeholder", "Filter...");
                __builder2.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                              Filter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filter = __value, Filter));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n            ");
                __builder2.OpenElement(84, "table");
                __builder2.AddAttribute(85, "class", "table table-striped");
                __builder2.AddMarkupContent(86, @"<thead class=""thead-light""><tr><th scope=""col"">Vehicle Id</th>
                        <th scope=""col"">Vehicle Number</th>
                        <th scope=""col"">Vehicle Desc</th>
                        <th scope=""col"">Vehicle Status</th></tr></thead>
                ");
                __builder2.OpenElement(87, "tbody");
#nullable restore
#line 58 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                     if (vehicleMasters != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                         foreach (ProTracker_TO.VehicleMaster Vehicle in vehicleMasters)
                        {
                            if (!IsVisible(Vehicle))
                                continue;

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(88, "tr");
                __builder2.AddAttribute(89, "class", "pointer");
                __builder2.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                                            (e) => Displayrec(Vehicle)

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(91, "td");
                __builder2.AddContent(92, 
#nullable restore
#line 65 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                     Vehicle.vm_Vehicle_Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                                ");
                __builder2.OpenElement(94, "td");
                __builder2.AddContent(95, 
#nullable restore
#line 66 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                     Vehicle.vm_Vehicle_Number

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                                ");
                __builder2.OpenElement(97, "td");
                __builder2.AddContent(98, 
#nullable restore
#line 67 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                     Vehicle.vm_Vehicle_desc

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                                ");
                __builder2.OpenElement(100, "td");
                __builder2.AddContent(101, 
#nullable restore
#line 68 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                                     Vehicle.vm_Status

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 70 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Vinod\Personal\InventoryGIT\Inventory\Inventory_UI\Pages\VehicleMaster.razor"
                         
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ProTracker_UI.Pages.VehicleMaster
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
