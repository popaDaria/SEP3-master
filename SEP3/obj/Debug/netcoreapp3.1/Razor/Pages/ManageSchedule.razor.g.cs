#pragma checksum "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b9fbb5dddf3c6f67780197df88bd1b1a072ad1c"
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
#line 1 "D:\SEP3\SEP3-master\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEP3\SEP3-master\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEP3\SEP3-master\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEP3\SEP3-master\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using RenderMode = Syncfusion.Blazor.InPlaceEditor.RenderMode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using InputType = Syncfusion.Blazor.InPlaceEditor.InputType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using ChangeEventArgs = Syncfusion.Blazor.Navigations.ChangeEventArgs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using EventArgs = System.EventArgs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using System.Reflection.Metadata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
           [Authorize(Policy = "MustBeLoggedInAsDoctor")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManageSchedule")]
    public partial class ManageSchedule : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5 mb-5 ml-auto mr-auto");
            __builder.AddMarkupContent(2, "<br>\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "button");
            __builder.AddAttribute(5, "class", "btn btn-info");
            __builder.AddAttribute(6, "name", "btnAddMore");
            __builder.AddAttribute(7, "value", "Add Available Day");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                                                                     AddDay

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", 
#nullable restore
#line 26 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                 display

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 27 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                          availableDayToAdd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 27 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                            Add

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "label");
                __builder2.AddContent(21, "Date:");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "id", "datefield");
                __builder2.AddAttribute(24, "type", "date");
                __builder2.AddAttribute(25, "min", "2020-12-01");
                __builder2.AddAttribute(26, "max", "2021-12-31");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                                                                          availableDayToAdd.AvailableDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => availableDayToAdd.AvailableDate = __value, availableDayToAdd.AvailableDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            <br>\r\n            ");
                __builder2.OpenElement(30, "label");
                __builder2.AddContent(31, "Start Time:");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "type", "time");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                               availableDayToAdd.StartTime

#line default
#line hidden
#nullable disable
                , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => availableDayToAdd.StartTime = __value, availableDayToAdd.StartTime, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            <br>\r\n            ");
                __builder2.OpenElement(37, "label");
                __builder2.AddContent(38, "End Time:");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "type", "time");
                __builder2.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                             availableDayToAdd.EndTime

#line default
#line hidden
#nullable disable
                , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => availableDayToAdd.EndTime = __value, availableDayToAdd.EndTime, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            <br>\r\n            ");
                __builder2.OpenElement(44, "label");
                __builder2.AddContent(45, "Max Appointment nr.:");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "type", "number");
                __builder2.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                                          apptNrString

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => apptNrString = __value, apptNrString, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            <br>\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Submit\">\r\n            ");
                __builder2.OpenElement(51, "input");
                __builder2.AddAttribute(52, "type", "button");
                __builder2.AddAttribute(53, "class", "btn btn-danger");
                __builder2.AddAttribute(54, "value", "Cancel");
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                                                  Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "alert alert-success mt-2");
                __builder2.AddAttribute(59, "style", 
#nullable restore
#line 40 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                          display1

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(60, "Addition was successful!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "alert alert-danger mt-2");
                __builder2.AddAttribute(64, "style", 
#nullable restore
#line 41 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                         displayError

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(65, 
#nullable restore
#line 41 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                                        ErrorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "container ml-auto mr-auto");
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfTab>(69);
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.TabItems>(71);
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(73);
                    __builder3.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(75);
                        __builder4.AddAttribute(76, "Text", "Manage Schedule");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(77, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(78, "div");
                        __builder4.AddAttribute(79, "class", "d-flex");
                        __builder4.OpenElement(80, "div");
                        __builder4.AddAttribute(81, "class", "d-flex flex-column");
                        __builder4.AddMarkupContent(82, @"<div class=""d-flex flex-row  border border-success""><div class=""m-3""><label>Available Date</label></div>
                                <div class=""m-3 mr-5""><label>Start Time</label></div>
                                <div class=""m-3 mr-4""><label>End Time</label></div>
                                <div class=""m-3 ""><label>Max nr. of Appointments</label></div></div>");
#nullable restore
#line 69 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                             foreach (var availableDay in AvailableDays)
                            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(83, "div");
                        __builder4.AddAttribute(84, "class", "d-flex flex-row  border border-primary");
                        __builder4.OpenElement(85, "div");
                        __builder4.AddAttribute(86, "class", "m-3 mr-5");
                        __builder4.OpenElement(87, "label");
                        __builder4.AddContent(88, 
#nullable restore
#line 73 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                availableDay.AvailableDate.Day

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(89, "/");
                        __builder4.AddContent(90, 
#nullable restore
#line 73 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                                                availableDay.AvailableDate.Month

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(91, "/");
                        __builder4.AddContent(92, 
#nullable restore
#line 73 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                                                                                  availableDay.AvailableDate.Year

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(93, "\r\n                                    ");
                        __builder4.OpenElement(94, "div");
                        __builder4.AddAttribute(95, "class", "m-3 mr-5");
                        __builder4.OpenElement(96, "label");
                        __builder4.AddContent(97, 
#nullable restore
#line 76 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                availableDay.StartTime.TimeOfDay.ToString()

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(98, "\r\n                                    ");
                        __builder4.OpenElement(99, "div");
                        __builder4.AddAttribute(100, "class", "m-3 mr-5");
                        __builder4.OpenElement(101, "label");
                        __builder4.AddContent(102, 
#nullable restore
#line 79 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                availableDay.EndTime.TimeOfDay.ToString()

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(103, "\r\n                                    ");
                        __builder4.OpenElement(104, "div");
                        __builder4.AddAttribute(105, "class", "m-3 mr-5");
                        __builder4.OpenElement(106, "label");
                        __builder4.AddContent(107, 
#nullable restore
#line 82 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                availableDay.AppointmentNr

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(108, "\r\n                                    ");
                        __builder4.OpenElement(109, "div");
                        __builder4.AddAttribute(110, "class", "m-3");
                        __builder4.OpenElement(111, "button");
                        __builder4.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                                                            () => RemoveDay(availableDay)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddMarkupContent(113, "<i class=\"oi oi-trash\" style=\"color:darkred\"></i>");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
#nullable restore
#line 90 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
                            }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(115);
                    __builder3.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(117);
                        __builder4.AddAttribute(118, "Text", "See Appointments");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(119, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "D:\SEP3\SEP3-master\SEP3\Pages\ManageSchedule.razor"
       
    
    User user { get; set; }
    string idNr = "";
    IList<AvailableDay> AvailableDays { get; set; } = new List<AvailableDay>();
    string display { get; set; } = "display:none";
    
    AvailableDay availableDayToAdd { get; set; } = new AvailableDay();
    string apptNrString { get; set; }
    string display1 = "display: none";
    string displayError = "display: none";
    public string ErrorMessage { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        idNr = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetAuthenticationStateAsync().Result.User.Claims.ToList()[0].Value;
    //Console.WriteLine("Logged in as: "+idNr);
        display = "display :none";
        display1 = "display: none";
        displayError = "display: none";
        user = await CloudUserService.GetUser(idNr);
        AvailableDays = await CloudAvailableDayService.GetAvailableDays(user.idNr);
    }


    private void AddDay()
    {
        display = "display: block";
    }
    private void Cancel()
    {
        display = "display:none";
    }

    private async Task Add()
    {
        try
        {
            displayError = "display: none";
            display1 = "display: block";
            ErrorMessage = "";
            int apptNr = Int32.Parse(apptNrString);
            availableDayToAdd.AppointmentNr = apptNr;
            availableDayToAdd.DoctorId = user.idNr;
    //Console.WriteLine(availableDayToAdd.AvailableDate.ToString() + " " + availableDayToAdd.StartTime.TimeOfDay.ToString() + " " + availableDayToAdd.EndTime.TimeOfDay.ToString());
            await CloudAvailableDayService.AddAvailableDay(availableDayToAdd);
            List<AvailableDay> all =await CloudAvailableDayService.GetAvailableDays(user.idNr);
            AvailableDays.Clear();
            foreach (var av in all)
            {
                AvailableDays.Add(av);
            }
    // NavigationManager.NavigateTo("/ManageSchedule");
    //display = "display:none";
        }
        catch (Exception e)
        {
            displayError = "display:block";
            ErrorMessage = e.Message;
        }
    }
    

    private async Task RemoveDay(AvailableDay availableDay)
    {
        await CloudAvailableDayService.RemoveAvailableDay(availableDay);
        AvailableDays.Remove(availableDay);
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAvailableDayService CloudAvailableDayService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudUserService CloudUserService { get; set; }
    }
}
#pragma warning restore 1591
