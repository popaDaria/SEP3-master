#pragma checksum "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4791fa8d6a5c7ba508348c668d6f91ea6104367"
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
#nullable restore
#line 1 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Shared\NavMenu.razor"
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
#line 56 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Shared\NavMenu.razor"
       
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
