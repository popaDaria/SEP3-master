#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\Pages\HomeHospitalComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "953bd08d4e800f37d64a2c8809eaf926f3012281"
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
#line 1 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
    public partial class HomeHospitalComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "component");
            __builder.AddMarkupContent(2, "\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.AddAttribute(5, "style", "width: 18rem;");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "card-img-top");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\Pages\HomeHospitalComponent.razor"
                                    imgSource

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.AddMarkupContent(12, @"<div class=""card-body"">
        <h5 class=""card-title"">Mary Jane Hospital</h5>
        <p class=""card-text"">
            <span class=""oi oi-location"">Christiania, Copenhagen</span>
            <br>
            <span class=""oi oi-star"">5</span>
            <br>
            Mary Jane Hospital provides state-of-the-art medical care to ensure our patients are cared for medically and cared about personally and to ensure a medically ready force, prepared to accomplish their mission. We're committed to operational readiness, outstanding customer service, and world-class health care delivery for our beneficiaries.
        </p>
        <a href=""#"" class=""btn btn-primary"">View hospital page</a>
    </div>
");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n");
            __builder.AddMarkupContent(15, "<style>\n    .component {\n    display: inline-block;\n    padding: 10px;\n    flex: 0 0 auto;\n    }\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\THIRD SEMESTER\SEP3\SEP3-master\SEP3\Pages\HomeHospitalComponent.razor"
       

    [Parameter]
    public string imgSource { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
