#pragma checksum "D:\SEP3-master\SEP3\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8300a9ac1df90b53de877990182ecdec5d683d9"
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
#line 2 "D:\SEP3-master\SEP3\Pages\Register.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3-master\SEP3\Pages\Register.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3-master\SEP3\Pages\Register.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3-master\SEP3\Pages\Register.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3-master\SEP3\Pages\Register.razor"
using InputType = Syncfusion.Blazor.Inputs.InputType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SEP3-master\SEP3\Pages\Register.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\SEP3-master\SEP3\Pages\Register.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/style.css\" type=\"text/css\" rel=\"stylesheet\">\r\n<link href=\"css/bootstrap/bootstrap.min.css\" type=\"text/css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "D:\SEP3-master\SEP3\Pages\Register.razor"
                  userToAdd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                            Add

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "surround");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-lg-12 control-section");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "content-wrapper");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "formBlock");
                __builder2.OpenElement(17, "label");
                __builder2.AddMarkupContent(18, "\r\n                        Register as:\r\n                        ");
                __Blazor.SEP3.Pages.Register.TypeInference.CreateInputSelect_0(__builder2, 19, 20, 
#nullable restore
#line 31 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                  userToAdd.userType

#line default
#line hidden
#nullable disable
                , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userToAdd.userType = __value, userToAdd.userType)), 22, () => userToAdd.userType, 23, (__builder3) => {
                    __builder3.AddMarkupContent(24, "<option></option>\r\n                            ");
                    __builder3.AddMarkupContent(25, "<option>patient</option>\r\n                            ");
                    __builder3.AddMarkupContent(26, "<option>manager</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n                    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "row material2");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-xs-8 col-sm-8 col-lg-8 col-md-8 formStyle");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(32);
                __builder2.AddAttribute(33, "Placeholder", "First Name");
                __builder2.AddAttribute(34, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 40 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                 FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "disabled", 
#nullable restore
#line 40 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                                   isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(36, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 40 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                                                     InputType.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "value", 
#nullable restore
#line 40 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                   userToAdd.firstname

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(38, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userToAdd.firstname = __value, userToAdd.firstname));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-xs-8 col-sm-8 col-lg-8 col-md-8 formStyle");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(44);
                __builder2.AddAttribute(45, "Placeholder", "Last Name");
                __builder2.AddAttribute(46, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 48 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "disabled", 
#nullable restore
#line 48 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                                 isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(48, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 48 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                                                   InputType.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "value", 
#nullable restore
#line 48 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                  userToAdd.lastname

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(50, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userToAdd.lastname = __value, userToAdd.lastname));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n                    ");
                __builder2.OpenElement(52, "label");
                __builder2.AddContent(53, "ID Number:");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "type", "number");
                __builder2.AddAttribute(56, "disabled", 
#nullable restore
#line 60 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                  isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                       userToAdd.idNr

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userToAdd.idNr = __value, userToAdd.idNr, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                    <br>\r\n\r\n                    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-xs-8 col-sm-8 col-lg-8 col-md-8 formStyle");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(62);
                __builder2.AddAttribute(63, "CssClass", "e-outline");
                __builder2.AddAttribute(64, "Placeholder", "Password");
                __builder2.AddAttribute(65, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 64 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 64 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                           InputType.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "disabled", 
#nullable restore
#line 64 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                                                                           isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(68, "value", 
#nullable restore
#line 64 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                                            userToAdd.password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(69, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userToAdd.password = __value, userToAdd.password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n                    ");
                __builder2.OpenElement(71, "label");
                __builder2.AddMarkupContent(72, "\r\n                        Gender:\r\n                        ");
                __Blazor.SEP3.Pages.Register.TypeInference.CreateInputSelect_1(__builder2, 73, 74, 
#nullable restore
#line 72 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                  userToAdd.gender

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userToAdd.gender = __value, userToAdd.gender)), 76, () => userToAdd.gender, 77, (__builder3) => {
                    __builder3.AddMarkupContent(78, "<option></option>\r\n                            ");
                    __builder3.AddMarkupContent(79, "<option>Male</option>\r\n                            ");
                    __builder3.AddMarkupContent(80, "<option>Female</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                    <br>\r\n\r\n                    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "col-xs-8 col-sm-8 col-lg-8 col-md-8 formStyle");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(84);
                __builder2.AddAttribute(85, "CssClass", "e-outline");
                __builder2.AddAttribute(86, "Placeholder", "Email");
                __builder2.AddAttribute(87, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 81 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                             FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "disabled", 
#nullable restore
#line 81 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                                           isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(89, "value", 
#nullable restore
#line 81 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                               userToAdd.email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(90, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userToAdd.email = __value, userToAdd.email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n\r\n                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "col-xs-8 col-sm-8 col-lg-8 col-md-8 formStyle");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(94);
                __builder2.AddAttribute(95, "CssClass", "e-outline");
                __builder2.AddAttribute(96, "Placeholder", "Phone number");
                __builder2.AddAttribute(97, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 87 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                    FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "disabled", 
#nullable restore
#line 87 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                                                  isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(99, "value", 
#nullable restore
#line 87 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                      userToAdd.telNo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(100, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userToAdd.telNo = __value, userToAdd.telNo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n\r\n                    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-xs-8 col-sm-8 col-lg-8 col-md-8 formStyle");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(104);
                __builder2.AddAttribute(105, "CssClass", "e-outline");
                __builder2.AddAttribute(106, "Placeholder", "Address");
                __builder2.AddAttribute(107, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 93 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                               FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "disabled", 
#nullable restore
#line 93 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                                               isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(109, "value", 
#nullable restore
#line 93 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                                                                                 userToAdd.address

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(110, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userToAdd.address = __value, userToAdd.address));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n\r\n                    ");
                __builder2.OpenElement(112, "label");
                __builder2.AddContent(113, "Birthday:");
                __builder2.OpenElement(114, "input");
                __builder2.AddAttribute(115, "type", "date");
                __builder2.AddAttribute(116, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 105 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                                    userToAdd.birthday

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(117, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userToAdd.birthday = __value, userToAdd.birthday, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                    <br>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                \r\n                <input type=\"submit\" class=\"btn btn-primary button2\" value=\"Submit\">\r\n                ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "alert alert-success mt-2");
                __builder2.AddAttribute(122, "style", 
#nullable restore
#line 111 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                              display

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(123, "\r\n                    Registration was successful!\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "alert alert-danger mt-2");
                __builder2.AddAttribute(127, "style", 
#nullable restore
#line 114 "D:\SEP3-master\SEP3\Pages\Register.razor"
                                                             displayError

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(128, 
#nullable restore
#line 115 "D:\SEP3-master\SEP3\Pages\Register.razor"
                     ErrorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "D:\SEP3-master\SEP3\Pages\Register.razor"
       
    
    SfTextBox date;
    User userToAdd { get; set; } = new User();
    string display = "display: none";
    string displayError = "display: none";
    bool isDisabled = false;
    string ErrorMessage;

    // public string formatString { get; set; } = "dd-MM-yyyy";

    private async Task Add()
    {
        try
        {
    //Console.WriteLine(userToAdd.firstName+" "+userToAdd.lastName+" "+userToAdd.userType);
            await CloudUserService.AddUser(userToAdd);
            displayError = "display: none";
            display = "display: block";
            isDisabled = true;
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(userToAdd.idNr + "", userToAdd.password).Wait(100);
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            ErrorMessage = e.Message;
            displayError = "display: block";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudUserService CloudUserService { get; set; }
    }
}
namespace __Blazor.SEP3.Pages.Register
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
