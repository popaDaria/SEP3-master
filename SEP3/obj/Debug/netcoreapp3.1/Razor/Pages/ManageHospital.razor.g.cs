#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ec91e9acc121e4cdda257fa9707c448839fea3"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
           [Authorize(Roles = "manager", Policy = "MustBeLoggedInAsValidated")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/manage/{id}")]
    public partial class ManageHospital : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
 if (hospitals == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 15 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid horizontal-scrollable py-2 pt-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h2>Your Hospitals</h2>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "d-flex flex-row flex-nowrap overflow-auto");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 21 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
             foreach (var hospital in hospitals)
            {
                string pageCont = "/manage/" + id;

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-xs-4");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(14);
            __builder.AddAttribute(15, "imgSource", "/images/weed.jpg");
            __builder.AddAttribute(16, "name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
                                                                               hospital.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "address", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
                                                                                                        hospital.address

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "info", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
                                                                                                                                 hospital.info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "postalCode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
                                                                                                                                                             hospital.postalCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
                                                                                                                                                                                       hospital.id.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "page", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
                                                                                                                                                                                                                      pageCont

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 27 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 30 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageHospital.razor"
       
    [Parameter]
    public string id { get; set; }
    
    public List<Hospital> hospitals = new List<Hospital>();

    protected override async Task OnInitializedAsync()
    {
        int i = Int32.Parse(id);
        hospitals = await CloudHospitalService.GetAllHospitalsForManager(i);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudHospitalService CloudHospitalService { get; set; }
    }
}
#pragma warning restore 1591
