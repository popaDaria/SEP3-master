#pragma checksum "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\ProfileMedical.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee399ab1811592b126e6dec4ae8631f1b1a74999"
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
#line 1 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profilemed")]
    public partial class ProfileMedical : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/profile.css\" type=\"text/css\" rel=\"stylesheet\">\r\n");
            __builder.AddMarkupContent(1, "<div class=\"container emp-profile\">\r\n    <form method=\"post\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <div class=\"profile-img\">\r\n                    <img src=\"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS52y5aInsxSm31CvHOFHWujqUx_wWTS9iM6s7BAm21oEN_RiGoog\" alt>\r\n                    <div class=\"file btn btn-lg btn-primary\">\r\n                        Change Photo\r\n                        <input type=\"file\" name=\"file\">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"profile-head\">\r\n                    <h5>\r\n                        Lorena Ciocotoiu\r\n                    </h5>\r\n                    <h6>\r\n                        Patient\r\n                    </h6>\r\n                    <p class=\"proile-rating\">Address : <span>Aleea Binevointei</span></p>\r\n                    <ul class=\"nav nav-tabs\" id=\"myTab\" role=\"tablist\">\r\n                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\" id=\"home-tab\" data-toggle=\"tab\" href=\"profile\" role=\"tab\" aria-controls=\"home\" aria-selected=\"true\">About</a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link active\" id=\"profile-tab\" data-toggle=\"tab\" href=\"profilemed\" role=\"tab\" aria-controls=\"profile\" aria-selected=\"false\">Medical History</a>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <input type=\"submit\" class=\"profile-edit-btn\" name=\"btnAddMore\" value=\"Edit Profile\">\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n            </div>\r\n            <div class=\"col-md-8\">\r\n                <div class=\"tab-content profile-tab\" id=\"myTabContent\">\r\n                    <div class=\"tab-pane fade show active\" id=\"profile\" role=\"tabpanel\" aria-labelledby=\"profile-tab\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                <label>Treatment</label>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <p>COVID-19 - Bleach</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </form>           \r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
