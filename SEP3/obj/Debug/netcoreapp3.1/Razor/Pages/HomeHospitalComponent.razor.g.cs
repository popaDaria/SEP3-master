#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "203cbbd3ed58252e395021801fde41949f8acbf2"
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
#nullable restore
#line 1 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
    public partial class HomeHospitalComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "component ml-2 mr-2 overflow-auto");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 11 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                                       display

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddAttribute(6, "style", "width: 18rem;");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "class", "card-img-top");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 13 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                        imgSource

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "card-title");
            __builder.AddContent(18, 
#nullable restore
#line 15 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                    name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "p");
            __builder.AddAttribute(21, "class", "card-text");
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "span");
            __builder.AddAttribute(24, "class", "oi oi-location");
            __builder.AddContent(25, 
#nullable restore
#line 17 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                              address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                <br>\n                ");
            __builder.OpenElement(27, "span");
            __builder.AddAttribute(28, "class", "oi oi-star");
            __builder.AddContent(29, 
#nullable restore
#line 19 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                          postalCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                <br>\n                ");
            __builder.AddContent(31, 
#nullable restore
#line 21 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                 name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n            ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", "/hospital/" + (
#nullable restore
#line 23 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddContent(37, "View institution page");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n");
#nullable restore
#line 24 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
             if (page.Equals("validate"))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(40);
            __builder.AddAttribute(41, "Roles", "admin");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(43, "\n                    <br>\n                    <br>\n                    ");
                __builder2.OpenElement(44, "a");
                __builder2.AddAttribute(45, "class", "btn btn-success");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                                          Validate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "style", "color:white");
                __builder2.AddContent(48, "Validate");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n                    <br>\n                    <br>\n                    ");
                __builder2.OpenElement(50, "a");
                __builder2.AddAttribute(51, "class", "btn btn-danger");
                __builder2.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                                         Show

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "style", "color:white");
                __builder2.AddContent(54, "Remove");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\n");
#nullable restore
#line 34 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(61);
            __builder.AddAttribute(62, "Width", "335px");
            __builder.AddAttribute(63, "Target", "#target");
            __builder.AddAttribute(64, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                                                        Visibility

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Visibility = __value, Visibility))));
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(68, "\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(69);
                __builder2.AddAttribute(70, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(71, " Confirmation ");
                }
                ));
                __builder2.AddAttribute(72, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.AddMarkupContent(74, "<p>Are you sure you want to remove this hospital?</p>\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(76);
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(78, "\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(79);
                    __builder3.AddAttribute(80, "Content", "Yes");
                    __builder3.AddAttribute(81, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                               false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                                                Remove

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(84);
                    __builder3.AddAttribute(85, "Content", "Cancel");
                    __builder3.AddAttribute(86, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                                                  Hide

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogEvents>(90);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogAnimationSettings>(92);
                __builder2.AddAttribute(93, "Effect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Popups.DialogEffect>(
#nullable restore
#line 50 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
                                      DialogEffect.None

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(95, "\n\n\n");
            __builder.AddMarkupContent(96, "<style>\n    .component {\n    display: inline-block;\n    padding: 10px;\n    flex: 0 0 auto;\n    }\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\HomeHospitalComponent.razor"
       

    [Parameter]
    public string imgSource { get; set; }

    [Parameter]
    public string name { get; set; }

    [Parameter]
    public string address { get; set; }

    [Parameter]
    public string info { get; set; }

    [Parameter]
    public int postalCode { get; set; }

    [Parameter]
    public string id { get; set; }

    [Parameter]
    public string page { get; set; }
    
    /*[Parameter]
    public int managerId { get; set; }
    */

    string display = "display: inline;";


    public async void Validate()
    {
        await CloudHospitalService.ValidateHospital(Int32.Parse(id));
        display = "display: none;";
        NavigationManager.NavigateTo("/");
    }

    public async void Remove()
    {
        await CloudHospitalService.RemoveHospital(Int32.Parse(id));
        display = "display: none;";
        Hide();
    }

    private bool Visibility { get; set; } = false;

    private void Show()
    {
        this.Visibility = true;
    }

    private void Hide()
    {
        this.Visibility = false;
    }

    /*private void Manage()
    {
        NavigationManager.NavigateTo("/hospital/"+id);
    }*/
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudHospitalService CloudHospitalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudRatingService CloudRatingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
