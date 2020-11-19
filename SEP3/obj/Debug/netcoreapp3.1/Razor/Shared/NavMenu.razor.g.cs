#pragma checksum "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11f124b5839ae8a7c42162a1bc47a624e59aa189"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-sm navbar-toggleable-sm navbar-custom navbar-light border-bottom box-shadow mb-3 fixed-top");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand text-light\" asp-area asp-page=\"/Index\">Medical Yelp</a>\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "navbar-toggler");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Shared\NavMenu.razor"
                                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "data-toggle", "collapse");
            __builder.AddAttribute(12, "data-target", ".navbar-collapse");
            __builder.AddAttribute(13, "aria-controls", "navbarSupportedContent");
            __builder.AddAttribute(14, "aria-expanded", "false");
            __builder.AddAttribute(15, "aria-label", "Toggle navigation");
            __builder.AddMarkupContent(16, "\r\n            <span class=\"navbar-toggler-icon\"></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", (
#nullable restore
#line 8 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " navbar-collapse" + " d-sm-inline-flex" + " flex-sm-row");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Shared\NavMenu.razor"
                                                                                             CollapseNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "ul");
            __builder.AddAttribute(23, "class", "navbar-nav");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.AddMarkupContent(25, "<li class=\"nav-item\">\r\n                    <a class=\"nav-link pl-4 pr-4\" href Match=\"NavLinkMatch.All\">Home</a>\r\n                </li>\r\n                ");
            __builder.AddMarkupContent(26, "<li class=\"nav-item\">\r\n                    <a class=\"nav-link pl-4 pr-4\" href=\"login\">Log In</a>\r\n                </li>\r\n                ");
            __builder.AddMarkupContent(27, "<li class=\"nav-item\">\r\n                    <a class=\"nav-link pl-4 pr-4\" href=\"register\">Register</a>\r\n                </li>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(28);
            __builder.AddAttribute(29, "Policy", "MustBeLoggedIn");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.AddMarkupContent(32, "<li class=\"nav-item\">\r\n                        <a class=\"nav-link pl-4 pr-4\" href=\"profile\">Profile</a>\r\n                    </li>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Shared\NavMenu.razor"
       
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


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
