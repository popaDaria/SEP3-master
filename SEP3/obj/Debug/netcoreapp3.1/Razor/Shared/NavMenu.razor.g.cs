#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bede13f6a252afd0fb258d781fc0cdd1d19d172a"
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
            __builder.AddMarkupContent(0, "<link href=\"css/sidebar.css\" type=\"text/css\" rel=\"stylesheet\">\n");
            __builder.OpenElement(1, "span");
            __builder.AddAttribute(2, "id", "hamburger");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
                                Show

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", 
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
                                              Hamburgerclass

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfSidebar>(6);
            __builder.AddAttribute(7, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.SidebarPosition>(
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
                                        Position

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "HtmlAttributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
                                                                   HtmlAttribute

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.SidebarType>(
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
                                                                                        SidebarType.Over

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "CloseOnDocumentClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
                                                                                                                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
                                                                                                                         SidebarToggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SidebarToggle = __value, SidebarToggle))));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "title-header");
                __builder2.AddMarkupContent(17, "\n            ");
                __builder2.AddMarkupContent(18, "<div style=\"display:inline-block\"> Online Clinic </div>\n            ");
                __builder2.OpenElement(19, "span");
                __builder2.AddAttribute(20, "id", "close");
                __builder2.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
                                        Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "class", "oi oi-x text-black-50");
                __builder2.AddAttribute(23, "style", "fill: black;");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "sub-title");
                __builder2.AddMarkupContent(28, "\n            ");
                __builder2.OpenElement(29, "ul");
                __builder2.AddAttribute(30, "class", "list-unstyled");
                __builder2.AddMarkupContent(31, "\n                ");
                __builder2.AddMarkupContent(32, "<li class=\"pl-4 pr-4\">\n                    <a class=\"pl-4 pr-4 p-4\" href>Home</a>\n                </li>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(33);
                __builder2.AddAttribute(34, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(35, "\n                        ");
                    __builder3.AddMarkupContent(36, "<li>\n                            <a class=\"pl-4 pr-4 p-4\" href=\"login\">Log In</a>\n                        </li>\n                    ");
                }
                ));
                __builder2.AddAttribute(37, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(38, "\n                        ");
                    __builder3.AddMarkupContent(39, "<li>\n                            <a class=\"pl-4 pr-4 p-4\" href=\"login\">Log Out</a>\n                        </li>\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(41);
                __builder2.AddAttribute(42, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(43, "\n                        ");
                    __builder3.AddMarkupContent(44, "<li>\n                            <a class=\"pl-4 pr-4 p-4\" href=\"register\">Register</a>\n                        </li>\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(46);
                __builder2.AddAttribute(47, "Policy", "MustBeLoggedIn");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(49, "\n                    ");
                    __builder3.AddMarkupContent(50, "<li>\n                        <a class=\"pl-4 pr-4 p-4\" href=\"profile\">Profile</a>\n                    </li>\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(52);
                __builder2.AddAttribute(53, "Policy", "MustBeLoggedInAsValidatedManager");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(55, "\n                    ");
                    __builder3.AddMarkupContent(56, "<li>\n                        <a class=\"pl-4 pr-4 p-4\" href=\"addHospital\">Add Hospital</a>\n                    </li>\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(58);
                __builder2.AddAttribute(59, "Policy", "MustBeLoggedInAsAdmin");
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(61, "\n                    ");
                    __builder3.AddMarkupContent(62, "<li>\n                        <a class=\"pl-4 pr-4 p-4\" href=\"validate\">Validate</a>\n                    </li>\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(64);
                __builder2.AddAttribute(65, "Roles", "patient");
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(67, "\n                    ");
                    __builder3.AddMarkupContent(68, "<li>\n                        <a class=\"pl-4 pr-4 p-4\" href=\"MakeAppointment\">Make Appointment</a>\n                    </li>\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(70);
                __builder2.AddAttribute(71, "Roles", "doctor");
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(73, "\n                    ");
                    __builder3.AddMarkupContent(74, "<li>\n                        <a class=\"pl-4 pr-4 p-4\" href=\"ManageSchedule\">Manage Schedule</a>\n                    </li>\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(78, (__value) => {
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Shared\NavMenu.razor"
                 SidebarObj = (Syncfusion.Blazor.Navigations.SfSidebar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
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
