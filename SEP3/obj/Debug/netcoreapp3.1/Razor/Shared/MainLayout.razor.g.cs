#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3e0bbd69072045a3ec9e1d71c76561343163fd8"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<SEP3.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid pl-5 pr-5");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.AddContent(7, 
#nullable restore
#line 6 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
