#pragma checksum "D:\SEP3-master\SEP3\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "644df95c897e260c8e0f762faa3fc01399ceb729"
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
            __builder.AddMarkupContent(0, @"<div class=""row""><div class=""col-3""></div>
    <div class=""col-6 row""><div class=""col-2 menu_button""><b>Home</b></div>
        <div class=""col-2 menu_button""><b>Hospital</b></div>
        <div class=""col-2 menu_button""><b>Clinic</b></div>
        <div class=""col-2 menu_button""><a href=""LogIn"" class=""button1""><b>Log in</b></a></div>
        <div class=""col-2 menu_button""><b>Register</b></div></div>
    <div class=""col-3""></div></div>

<link href=""css/style.css"" type=""text/css"" rel=""stylesheet"">


");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid horizontal-scrollable py-2 pt-4");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "surroundBody");
            __builder.AddMarkupContent(5, "<h2>Hospitals</h2>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex flex-row flex-nowrap overflow-auto");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(10);
            __builder.AddAttribute(11, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(15);
            __builder.AddAttribute(16, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(20);
            __builder.AddAttribute(21, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(25);
            __builder.AddAttribute(26, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(30);
            __builder.AddAttribute(31, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(35);
            __builder.AddAttribute(36, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(40);
            __builder.AddAttribute(41, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "container-fluid horizontal-scrollable py-2");
            __builder.AddMarkupContent(45, "<br>\r\n    ");
            __builder.AddMarkupContent(46, "<h2>Clinics</h2>\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "d-flex flex-row flex-nowrap overflow-auto");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(51);
            __builder.AddAttribute(52, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(56);
            __builder.AddAttribute(57, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(61);
            __builder.AddAttribute(62, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(66);
            __builder.AddAttribute(67, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n");
            __builder.AddMarkupContent(69, "<style>\r\n    row {\r\n    display: flex;\r\n    flex-wrap: nowrap;\r\n    overflow-x: auto;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
