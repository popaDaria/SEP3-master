#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ec2bc3b817c0f41b6d8101a682b9058380ed19"
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
#line 1 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
           [Authorize(Roles = "patient")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MakeAppointment")]
    public partial class MakeAppointment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"font-size: 56px; font-weight: bold; color: #0B4E58\">Schedule a new Appointment</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                  appointmentToAdd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                   Add

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "formBlock");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "label");
                __builder2.AddMarkupContent(14, "Hospital:\r\n            ");
                __Blazor.SEP3.Pages.MakeAppointment.TypeInference.CreateInputSelect_0(__builder2, 15, 16, 
#nullable restore
#line 20 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                       hospitalString

#line default
#line hidden
#nullable disable
                , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => hospitalString = __value, hospitalString)), 18, () => hospitalString, 19, (__builder3) => {
                    __builder3.AddMarkupContent(20, "\r\n                <option></option>\r\n");
#nullable restore
#line 22 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                 foreach (var hos in @allHospitals)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(21, "                    ");
                    __builder3.OpenElement(22, "option");
                    __builder3.AddContent(23, 
#nullable restore
#line 24 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                             hos.id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(24, " : ");
                    __builder3.AddContent(25, 
#nullable restore
#line 24 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                       hos.name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(26, "\r\n");
#nullable restore
#line 25 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(27, "            ");
                }
                );
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "type", "button");
                __builder2.AddAttribute(32, "class", "btn btn-info");
                __builder2.AddAttribute(33, "name", "selectHospital");
                __builder2.AddAttribute(34, "value", "Confirm Hospital");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                                                                            SelectHospital

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        \r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "style", 
#nullable restore
#line 31 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                     display1

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "label");
                __builder2.AddMarkupContent(41, "Department:\r\n                ");
                __Blazor.SEP3.Pages.MakeAppointment.TypeInference.CreateInputSelect_1(__builder2, 42, 43, 
#nullable restore
#line 33 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                           deptString

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => deptString = __value, deptString)), 45, () => deptString, 46, (__builder3) => {
                    __builder3.AddMarkupContent(47, "\r\n                    <option></option>\r\n");
#nullable restore
#line 35 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                     foreach (var hos in @allDepartments)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(48, "                        ");
                    __builder3.OpenElement(49, "option");
                    __builder3.AddContent(50, 
#nullable restore
#line 37 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                 hos

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\r\n");
#nullable restore
#line 38 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(52, "                ");
                }
                );
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            \r\n            ");
                __builder2.OpenElement(55, "input");
                __builder2.AddAttribute(56, "type", "button");
                __builder2.AddAttribute(57, "class", "btn btn-info");
                __builder2.AddAttribute(58, "name", "selectDepartment");
                __builder2.AddAttribute(59, "value", "Confirm Department");
                __builder2.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                                                                                    SelectDepartment

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n        \r\n        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "style", 
#nullable restore
#line 45 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                     display2

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenElement(66, "label");
                __builder2.AddMarkupContent(67, "Doctor:\r\n                ");
                __Blazor.SEP3.Pages.MakeAppointment.TypeInference.CreateInputSelect_2(__builder2, 68, 69, 
#nullable restore
#line 47 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                           docString

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => docString = __value, docString)), 71, () => docString, 72, (__builder3) => {
                    __builder3.AddMarkupContent(73, "\r\n                    <option></option>\r\n");
#nullable restore
#line 49 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                     foreach (var hos in @allDoctors)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(74, "                        ");
                    __builder3.OpenElement(75, "option");
                    __builder3.AddContent(76, 
#nullable restore
#line 51 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                 hos.idNr

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(77, " : ");
                    __builder3.AddContent(78, 
#nullable restore
#line 51 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                             hos.firstname

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(79, " ");
                    __builder3.AddContent(80, 
#nullable restore
#line 51 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                            hos.lastname

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n");
#nullable restore
#line 52 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(82, "                ");
                }
                );
                __builder2.AddMarkupContent(83, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                        \r\n            ");
                __builder2.OpenElement(85, "input");
                __builder2.AddAttribute(86, "type", "button");
                __builder2.AddAttribute(87, "class", "btn btn-info");
                __builder2.AddAttribute(88, "name", "selectDoctor");
                __builder2.AddAttribute(89, "value", "Confirm Doctor");
                __builder2.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                                                                            SelectDoctor

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n        \r\n        ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "style", 
#nullable restore
#line 59 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                     display3

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.OpenElement(96, "label");
                __builder2.AddContent(97, "Date:");
                __builder2.OpenElement(98, "input");
                __builder2.AddAttribute(99, "type", "date");
                __builder2.AddAttribute(100, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 61 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                       AddLabel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n            <br>\r\n            ");
                __builder2.OpenElement(102, "label");
                __builder2.AddAttribute(103, "style", "color: #0f6674");
                __builder2.AddAttribute(104, "class", "oi oi-bell");
                __builder2.AddMarkupContent(105, "\r\n                ");
                __builder2.AddContent(106, 
#nullable restore
#line 64 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                 labelContent

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n            <br>\r\n            ");
                __builder2.OpenElement(109, "label");
                __builder2.AddContent(110, "Time:");
                __builder2.OpenElement(111, "input");
                __builder2.AddAttribute(112, "type", "time");
                __builder2.AddAttribute(113, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                         appointmentToAdd.appointmentTime

#line default
#line hidden
#nullable disable
                , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(114, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => appointmentToAdd.appointmentTime = __value, appointmentToAdd.appointmentTime, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n            <br>\r\n            ");
                __builder2.OpenElement(116, "label");
                __builder2.AddContent(117, "Summary:");
                __builder2.OpenElement(118, "input");
                __builder2.AddAttribute(119, "type", "text");
                __builder2.AddAttribute(120, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                            appointmentToAdd.summary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => appointmentToAdd.summary = __value, appointmentToAdd.summary));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n            <br>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n        \r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Submit\">\r\n    ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "alert alert-success mt-2");
                __builder2.AddAttribute(127, "style", 
#nullable restore
#line 75 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                  display

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(128, "Registration was successful!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n    ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "alert alert-danger mt-2");
                __builder2.AddAttribute(132, "style", 
#nullable restore
#line 76 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                 displayError

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(133, 
#nullable restore
#line 76 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
                                                                ErrorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan\SEP3\Pages\MakeAppointment.razor"
       
    
    Appointment appointmentToAdd { get; set; }
    
    string hospitalString { get; set; }
    int hosId { get; set; }
    List<Hospital> allHospitals { get; set; } = new List<Hospital>();
    List<string> allDepartments { get; set; } = new List<string>();
    string deptString { get; set; } 
    
    string display1 { get; set; }= "display: none";
    string display2 { get; set; }= "display: none";
    string display3 { get; set; }= "display: none";
    string display = "display: none";
    string displayError = "display: none";
    public string ErrorMessage { get; set; }
    string labelContent { get; set; } = "";
    
    IList<User> allDoctors { get; set; } = new List<User>();
    string docString { get; set; }
    int docId { get; set; }
    int patId { get; set; }
    List<AvailableDay> AvailableDays { get; set; } = new List<AvailableDay>();
    AvailableDay DoctorDay { get; set; }
    bool ok { get; set; } = false;
    
    List<Appointment> ApptForPatient { get; set; } = new List<Appointment>();
    List<Appointment> ApptForDoctor { get; set; } = new List<Appointment>();

    protected override async Task OnInitializedAsync()
    {
        appointmentToAdd = new Appointment();
        allHospitals = await CloudHospitalService.GetAllHospitals();
        display1 = "display: none";
        display2 = "display: none";
        display3 = "display: none";
        patId = Int32.Parse(AuthenticationStateProvider.GetAuthenticationStateAsync().Result.User.Claims.ToList()[0].Value);
        ApptForPatient = await CloudAppointmentService.GetAllForPatient(patId);
    }

    private async Task SelectHospital()
    {
        hosId = Int32.Parse(hospitalString.Split(" ")[0]);
        allDepartments = await CloudHospitalService.GetAllDepartments(hosId);
        display1 = "display: block";
    }

    private async Task SelectDepartment()
    {
        allDoctors = await CloudDoctorHospitalService.GetAllDoctorsForDepartment(hosId, deptString);
        display2 = "display: block";
    }

    private async Task SelectDoctor()
    {
        docId = Int32.Parse(docString.Split(" ")[0]);
        AvailableDays = await CloudAvailableDayService.GetAvailableDays(docId);
        ApptForDoctor = await CloudAppointmentService.GetAllForDoctor(docId);
        display3 = "display: block";
    //labelContent = "Doctor's schedule:";
        if (AvailableDays.Count == 0)
        {
            displayError = "display : block";
            ErrorMessage = "Warning: The doctor you have selected has no available days registered in the system!";
            ok = true;
        }
        else
        {
            displayError = "display : none";
        }
    }
    
    private void AddLabel(ChangeEventArgs e)
    {
        bool found = false;
        //appointmentToAdd.appointmentDate = (DateTime)e.Value;
        Console.WriteLine(e.Value);
        if (e.Value != null)
        {
            string result = (string) e.Value;
            string[] contents = result.Split("-");
            appointmentToAdd.appointmentDate = new DateTime(Int32.Parse(contents[0]),Int32.Parse(contents[1]),Int32.Parse(contents[2]));
        }
        foreach (var availableDay in AvailableDays)
        {
            if (availableDay.AvailableDate.Day == appointmentToAdd.appointmentDate.Day &&
                availableDay.AvailableDate.Month == appointmentToAdd.appointmentDate.Month &&
                availableDay.AvailableDate.Year == appointmentToAdd.appointmentDate.Year)
            {
                labelContent = "The Working hours are: " + availableDay.StartTime.TimeOfDay.ToString() + " - " + availableDay.EndTime.TimeOfDay.ToString();
                found = true;
            }
        }
        if (!found)
        {
            labelContent = "Not an available date!";
        }
    }

    private async Task Add()
    {
        try
        {
            appointmentToAdd.doctorId = docId;
            appointmentToAdd.patientId = patId;

            foreach (var availableDay in AvailableDays)
            {
                if (availableDay.AvailableDate.Day == appointmentToAdd.appointmentDate.Day &&
                    availableDay.AvailableDate.Month == appointmentToAdd.appointmentDate.Month &&
                    availableDay.AvailableDate.Year == appointmentToAdd.appointmentDate.Year)
                {
                    ok = true;
                    DoctorDay = availableDay;
                }
            }
            if (ok)
            {
                if (AvailableDays.Count != 0)
                {
                    if (DoctorDay.AppointmentNr != 0)
                    {
                        if (appointmentToAdd.appointmentTime.Hour >= DoctorDay.StartTime.Hour && appointmentToAdd.appointmentTime.Hour < DoctorDay.EndTime.Hour)
                        {
                            await AddAppointment();
                        }
                        else
                        {
                            displayError = "display : block";
                            ErrorMessage = "Selected time does not conform to doctor's schedule. Please select another time.";
                        }
                    }
                    else
                    {
                        displayError = "display : block";
                        ErrorMessage = "Doctor has no more available appointment slots for the selected date. Please select another date.";
                    }
                }
                else
                {
                    await AddAppointment();
                }
            }
            else
            {
                displayError = "display : block";
                ErrorMessage = "Selected date is not an available date for the doctor. Please select another date.";
            }
        }
        catch (Exception e)
        {
            ErrorMessage = e.Message;
            Console.WriteLine(e.InnerException + e.StackTrace + e.Message);
            displayError = "display: block";
        }
    }

    private async Task AddAppointment()
    {
        List<Appointment> SameDateAppts = new List<Appointment>();
        foreach (var ad in ApptForDoctor)
        {
            if (appointmentToAdd.appointmentDate.Day == ad.appointmentDate.Day || appointmentToAdd.appointmentDate.Month == ad.appointmentDate.Month ||
                appointmentToAdd.appointmentDate.Year == ad.appointmentDate.Year)
            {
                SameDateAppts.Add(ad);
            }
        }
        
        bool validTime = true;
        foreach (var sameDateAppt in SameDateAppts)
        {
            if (sameDateAppt.appointmentTime.Hour == appointmentToAdd.appointmentTime.Hour &&
                sameDateAppt.appointmentTime.Minute == appointmentToAdd.appointmentTime.Minute)
            {
                validTime = false;
            }
        }
        
        bool found = false;
        foreach (var ap in ApptForPatient)
        {
            if (ap.doctorId == appointmentToAdd.doctorId && ap.appointmentTime.Hour == appointmentToAdd.appointmentTime.Hour &&
                ap.appointmentTime.Minute == appointmentToAdd.appointmentTime.Minute &&
                ap.appointmentDate.Day == appointmentToAdd.appointmentDate.Day &&
                ap.appointmentDate.Month == appointmentToAdd.appointmentDate.Month &&
                ap.appointmentDate.Year == appointmentToAdd.appointmentDate.Year)
            {
                found = true;
            }
        }

        if (!found)
        {
            if (validTime)
            {
                displayError = "display: none";
                display = "display: block";
                labelContent = "";
                await CloudAppointmentService.MakeAppointment(appointmentToAdd);
                --DoctorDay.AppointmentNr;
                await CloudAvailableDayService.UpdateAvailableDay(DoctorDay);
                NavigationManager.NavigateTo("/");
            }
            else
            {
                displayError = "display : block";
                ErrorMessage = "Appointment time reserved! Pick another time!";
            }
        }
        else
        {
            displayError = "display : block";
            ErrorMessage = "Appointment already added!";
    //NavigationManager.NavigateTo("/");
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAvailableDayService CloudAvailableDayService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudUserService CloudUserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAppointmentService CloudAppointmentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudDoctorHospitalService CloudDoctorHospitalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudHospitalService CloudHospitalService { get; set; }
    }
}
namespace __Blazor.SEP3.Pages.MakeAppointment
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
