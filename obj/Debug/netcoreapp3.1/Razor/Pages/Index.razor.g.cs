#pragma checksum "D:\SEP3\SEP3-master-Bogdan\SEP3\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cda5a0a4855bfc21f046c2d8098c738e56c7bab"
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
#line 1 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3\SEP3-master-Bogdan\SEP3\Pages\Index.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid horizontal-scrollable py-2 pt-4");
            __builder.AddMarkupContent(2, "<h2>Hospitals</h2>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "d-flex flex-row flex-nowrap overflow-auto");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(7);
            __builder.AddAttribute(8, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(12);
            __builder.AddAttribute(13, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(17);
            __builder.AddAttribute(18, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(22);
            __builder.AddAttribute(23, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(27);
            __builder.AddAttribute(28, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(32);
            __builder.AddAttribute(33, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(37);
            __builder.AddAttribute(38, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(42);
            __builder.AddAttribute(43, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(47);
            __builder.AddAttribute(48, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
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
            __builder.AddMarkupContent(69, "\r\n");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "container-fluid horizontal-scrollable py-2");
            __builder.AddMarkupContent(72, "<br>\r\n    ");
            __builder.AddMarkupContent(73, "<h2>Clinics</h2>\r\n    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "d-flex flex-row flex-nowrap overflow-auto");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(78);
            __builder.AddAttribute(79, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(83);
            __builder.AddAttribute(84, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(88);
            __builder.AddAttribute(89, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(93);
            __builder.AddAttribute(94, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(98);
            __builder.AddAttribute(99, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(103);
            __builder.AddAttribute(104, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(108);
            __builder.AddAttribute(109, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n        ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(113);
            __builder.AddAttribute(114, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n        ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(118);
            __builder.AddAttribute(119, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(123);
            __builder.AddAttribute(124, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n        ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(128);
            __builder.AddAttribute(129, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n        ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "col-xs-4");
            __builder.OpenComponent<SEP3.Pages.HomeHospitalComponent>(133);
            __builder.AddAttribute(134, "imgSource", "/images/weed.jpg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n\r\n");
            __builder.AddMarkupContent(136, "<style>\r\n    row {\r\n    display: flex;\r\n    flex-wrap: nowrap;\r\n    overflow-x: auto;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
