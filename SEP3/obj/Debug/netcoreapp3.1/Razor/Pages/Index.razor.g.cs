#pragma checksum "D:\SEP3-master\SEP3\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6477b171dbbbed615d855b7008718da707eb0369"
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
#line 1 "D:\SEP3-master\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEP3-master\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEP3-master\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEP3-master\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3-master\SEP3\Pages\Index.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/style.css\" type=\"text/css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""row""><div class=""col-3""></div>
    <div class=""col-6 row""><div class=""col-2 menu_button""><b>Home</b></div>
        <div class=""col-2 menu_button""><b>Hospital</b></div>
        <div class=""col-2 menu_button""><b>Clinic</b></div>
        <div class=""col-2 menu_button""><a href=""LogIn"" class=""button1""><b>Log in</b></a></div>
        <div class=""col-2 menu_button""><a href=""register""><b>Register</b></a></div></div>
    <div class=""col-3""></div></div>

<link href=""css/style.css"" type=""text/css"" rel=""stylesheet"">


");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid horizontal-scrollable py-2 pt-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "surroundBody");
            __builder.AddMarkupContent(6, "<h2>Hospitals</h2>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "d-flex flex-row flex-nowrap overflow-auto");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(11);
            __builder.AddAttribute(12, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(16);
            __builder.AddAttribute(17, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(21);
            __builder.AddAttribute(22, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(26);
            __builder.AddAttribute(27, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(31);
            __builder.AddAttribute(32, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(36);
            __builder.AddAttribute(37, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(41);
            __builder.AddAttribute(42, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "container-fluid horizontal-scrollable py-2");
            __builder.AddMarkupContent(46, "<br>\r\n    ");
            __builder.AddMarkupContent(47, "<h2>Clinics</h2>\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "d-flex flex-row flex-nowrap overflow-auto");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(52);
            __builder.AddAttribute(53, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(57);
            __builder.AddAttribute(58, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(62);
            __builder.AddAttribute(63, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(67);
            __builder.AddAttribute(68, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
