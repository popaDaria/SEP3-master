#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bede13f6a252afd0fb258d781fc0cdd1d19d172a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SEP3.Shared
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
#line 1 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
       
    SfSidebar SidebarObj;
    public string Leftbtn = "Left";
    public string Hamburgerclass = "e-icons menu default";
    public SidebarPosition Position { get; set; } = SidebarPosition.Left;
    public bool SidebarToggle = false;

    public void Show()
    {
        SidebarToggle = true;
    }

    public void Close()
    {
        SidebarToggle = false;
    }

    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    void CollapseNavMenu()
    {
        collapseNavMenu = true;
    }

    Dictionary<string, object> HtmlAttribute = new Dictionary<string, object>()
    {
        {"class", "default-sidebar"}
    };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
