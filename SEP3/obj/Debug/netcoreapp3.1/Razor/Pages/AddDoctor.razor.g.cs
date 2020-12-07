#pragma checksum "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39dcfe4fb5f67c620798290e94882871dda53b87"
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
#line 2 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
           [Authorize(Roles = "manager", Policy = "MustBeLoggedInAsValidated")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addDoctor/{id}")]
    public partial class AddDoctor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"font-size: 56px; font-weight: bold; color: #0B4E58\">Add New Doctor</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                  userToAdd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
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
                __builder2.AddContent(14, "First Name:");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "disabled", 
#nullable restore
#line 17 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                                                          isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                          userToAdd.firstname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userToAdd.firstname = __value, userToAdd.firstname));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(21, "label");
                __builder2.AddContent(22, "Last Name:");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "text");
                __builder2.AddAttribute(25, "disabled", 
#nullable restore
#line 19 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                                                        isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                         userToAdd.lastname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userToAdd.lastname = __value, userToAdd.lastname));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(29, "label");
                __builder2.AddContent(30, "ID Number:");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "type", "number");
                __builder2.AddAttribute(33, "disabled", 
#nullable restore
#line 21 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                                                      isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                           userToAdd.idNr

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userToAdd.idNr = __value, userToAdd.idNr, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(37, "label");
                __builder2.AddContent(38, "Password:");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "type", "password");
                __builder2.AddAttribute(41, "disabled", 
#nullable restore
#line 23 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                                                           isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                            userToAdd.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userToAdd.password = __value, userToAdd.password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(45, "label");
                __builder2.AddMarkupContent(46, "Gender:\r\n            ");
                __Blazor.SEP3.Pages.AddDoctor.TypeInference.CreateInputSelect_0(__builder2, 47, 48, 
#nullable restore
#line 26 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                      userToAdd.gender

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userToAdd.gender = __value, userToAdd.gender)), 50, () => userToAdd.gender, 51, (__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                <option></option>\r\n                ");
                    __builder3.AddMarkupContent(53, "<option>Male</option>\r\n                ");
                    __builder3.AddMarkupContent(54, "<option>Female</option>\r\n            ");
                }
                );
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(57, "label");
                __builder2.AddContent(58, "Email:");
                __builder2.OpenElement(59, "input");
                __builder2.AddAttribute(60, "type", "text");
                __builder2.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                     userToAdd.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userToAdd.email = __value, userToAdd.email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(64, "label");
                __builder2.AddContent(65, "Phone Number:");
                __builder2.OpenElement(66, "input");
                __builder2.AddAttribute(67, "type", "text");
                __builder2.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                            userToAdd.telNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userToAdd.telNo = __value, userToAdd.telNo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(71, "label");
                __builder2.AddContent(72, "Address:");
                __builder2.OpenElement(73, "input");
                __builder2.AddAttribute(74, "type", "text");
                __builder2.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                       userToAdd.address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userToAdd.address = __value, userToAdd.address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(78, "label");
                __builder2.AddContent(79, "Birthday:");
                __builder2.OpenElement(80, "input");
                __builder2.AddAttribute(81, "type", "date");
                __builder2.AddAttribute(82, "min", "1900-01-01");
                __builder2.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                                         userToAdd.birthday

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userToAdd.birthday = __value, userToAdd.birthday, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(86, "label");
                __builder2.AddMarkupContent(87, " Hospital/Clinic:\r\n            ");
                __Blazor.SEP3.Pages.AddDoctor.TypeInference.CreateInputSelect_1(__builder2, 88, 89, 
#nullable restore
#line 42 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                       hospital

#line default
#line hidden
#nullable disable
                , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => hospital = __value, hospital)), 91, () => hospital, 92, (__builder3) => {
                    __builder3.AddMarkupContent(93, "\r\n                <option></option>\r\n");
#nullable restore
#line 44 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                 foreach(var hos in @hospitals)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(94, "                    ");
                    __builder3.OpenElement(95, "option");
                    __builder3.AddContent(96, 
#nullable restore
#line 46 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                             hos.id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(97, " : ");
                    __builder3.AddContent(98, 
#nullable restore
#line 46 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                       hos.name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\r\n");
#nullable restore
#line 47 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(100, "            ");
                }
                );
                __builder2.AddMarkupContent(101, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(103, "label");
                __builder2.AddContent(104, "Department:");
                __builder2.OpenElement(105, "input");
                __builder2.AddAttribute(106, "type", "text");
                __builder2.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                           department

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => department = __value, department));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n        <br>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Submit\">\r\n    ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "alert alert-success mt-2");
                __builder2.AddAttribute(113, "style", 
#nullable restore
#line 55 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                  display

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(114, "Registration was successful!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "alert alert-danger mt-2");
                __builder2.AddAttribute(118, "style", 
#nullable restore
#line 56 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                 displayError

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(119, 
#nullable restore
#line 56 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
                                                                ErrorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\AddDoctor.razor"
       
    User userToAdd { get; set; } = new User();
    string display = "display: none";
    string displayError = "display: none";
    bool isDisabled = false;
    string ErrorMessage;
    
    string department { get; set; }
    string hospital { get; set; }
    
    DoctorHospital doctorHospital { get; set; } = new DoctorHospital();
    
    [Parameter]
    public string id { get; set; }
    
    public List<Hospital> hospitals = new List<Hospital>();

    protected override async Task OnInitializedAsync()
    {
        int i = Int32.Parse(id);
        hospitals = await CloudHospitalService.GetAllHospitalsForManager(i);
    }
    
    private async Task Add()
    {
        try
        {
            string[] contents = hospital.Split(" ");
            int hosID = Int32.Parse(contents[0]);
            
            doctorHospital.deptName = department;
            doctorHospital.doctorId = userToAdd.idNr;
            doctorHospital.hospitalId = hosID;

            userToAdd.userType = "doctor";
            if (userToAdd.gender == null)
                userToAdd.gender = "Male";
            userToAdd.validated = true;
            await CloudUserService.AddDoctor(userToAdd);
            await CloudDoctorHospitalService.AddDoctorHospital(doctorHospital);
            
            displayError = "display: none";
            display = "display: block";
            isDisabled = true;
            NavigationManager.NavigateTo("/manage/"+id);
        }
        catch (Exception e)
        {
            ErrorMessage = e.Message;
            Console.WriteLine(e.InnerException + e.StackTrace + e.Message);
            displayError = "display: block";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudDoctorHospitalService CloudDoctorHospitalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudHospitalService CloudHospitalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudUserService CloudUserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.SEP3.Pages.AddDoctor
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
    }
}
#pragma warning restore 1591
