#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "117f4d10abdb0af4a141b195215d206f89f9a4a1"
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
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/schedule")]
    public partial class Scheduler : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "control-section");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content-wrapper");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Schedule.SfSchedule<ScheduleData.DoctorsEventData>>(6);
            __builder.AddAttribute(7, "Width", "100%");
            __builder.AddAttribute(8, "Height", "650px");
            __builder.AddAttribute(9, "SelectedDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 13 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
                                                                                                            CurrentDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "SelectedDateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentDate = __value, CurrentDate))));
            __builder.AddAttribute(11, "SelectedDateExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.DateTime>>>(() => CurrentDate));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Schedule.ScheduleTemplates>(14);
                __builder2.AddAttribute(15, "EditorTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(16, "\r\n                    ");
                    __builder3.OpenElement(17, "input");
                    __builder3.AddAttribute(18, "type", "hidden");
                    __builder3.AddAttribute(19, "name", "Id");
                    __builder3.AddAttribute(20, "class", "e-field");
                    __builder3.AddAttribute(21, "value", 
#nullable restore
#line 16 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
                                                                            (context as ScheduleData.DoctorsEventData).Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(22, "\r\n                    ");
                    __builder3.OpenElement(23, "table");
                    __builder3.AddAttribute(24, "class", "custom-event-editor");
                    __builder3.AddAttribute(25, "width", "100%");
                    __builder3.AddAttribute(26, "cellpadding", "5");
                    __builder3.AddMarkupContent(27, "\r\n                        ");
                    __builder3.OpenElement(28, "tbody");
                    __builder3.AddMarkupContent(29, "\r\n                            ");
                    __builder3.OpenElement(30, "tr");
                    __builder3.AddMarkupContent(31, "\r\n                                ");
                    __builder3.AddMarkupContent(32, "<td class=\"e-textlabel\">Summary</td>\r\n                                ");
                    __builder3.OpenElement(33, "td");
                    __builder3.AddAttribute(34, "colspan", "4");
                    __builder3.AddMarkupContent(35, "\r\n                                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(36);
                    __builder3.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
                                                              (context as ScheduleData.DoctorsEventData).Subject

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (context as ScheduleData.DoctorsEventData).Subject = __value, (context as ScheduleData.DoctorsEventData).Subject))));
                    __builder3.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => (context as ScheduleData.DoctorsEventData).Subject));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n                            ");
                    __builder3.OpenElement(43, "tr");
                    __builder3.AddMarkupContent(44, "\r\n                                ");
                    __builder3.AddMarkupContent(45, "<td class=\"e-textlabel\">Status</td>\r\n                                ");
                    __builder3.OpenElement(46, "td");
                    __builder3.AddAttribute(47, "class", "dropdown");
                    __builder3.AddAttribute(48, "colspan", "4");
                    __builder3.AddMarkupContent(49, "\r\n                                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, EventFields>>(50);
                    __builder3.AddAttribute(51, "ID", "EventType");
                    __builder3.AddAttribute(52, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<EventFields>>(
#nullable restore
#line 28 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
                                                                                                                    StatusData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "Placeholder", "Choose status");
                    __builder3.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 28 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
                                                                                                                                                                           (context as ScheduleData.DoctorsEventData).EventType

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (context as ScheduleData.DoctorsEventData).EventType = __value, (context as ScheduleData.DoctorsEventData).EventType))));
                    __builder3.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => (context as ScheduleData.DoctorsEventData).EventType));
                    __builder3.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(58, "\r\n                                        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(59);
                        __builder4.AddAttribute(60, "Value", "Id");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(61, "\r\n                                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\r\n                            ");
                    __builder3.OpenElement(65, "tr");
                    __builder3.AddMarkupContent(66, "\r\n                                ");
                    __builder3.AddMarkupContent(67, "<td class=\"e-textlabel\">From</td>\r\n                                ");
                    __builder3.OpenElement(68, "td");
                    __builder3.AddAttribute(69, "colspan", "4");
                    __builder3.AddMarkupContent(70, "\r\n                                    ");
                    __Blazor.SEP3.Pages.Scheduler.TypeInference.CreateSfDateTimePicker_0(__builder3, 71, 72, 
#nullable restore
#line 36 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
                                                                     (context as ScheduleData.DoctorsEventData).StartTime

#line default
#line hidden
#nullable disable
                    , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (context as ScheduleData.DoctorsEventData).StartTime = __value, (context as ScheduleData.DoctorsEventData).StartTime)), 74, () => (context as ScheduleData.DoctorsEventData).StartTime);
                    __builder3.AddMarkupContent(75, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n                            ");
                    __builder3.OpenElement(78, "tr");
                    __builder3.AddMarkupContent(79, "\r\n                                ");
                    __builder3.AddMarkupContent(80, "<td class=\"e-textlabel\">To</td>\r\n                                ");
                    __builder3.OpenElement(81, "td");
                    __builder3.AddAttribute(82, "colspan", "4");
                    __builder3.AddMarkupContent(83, "\r\n                                    ");
                    __Blazor.SEP3.Pages.Scheduler.TypeInference.CreateSfDateTimePicker_1(__builder3, 84, 85, 
#nullable restore
#line 42 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
                                                                     (context as ScheduleData.DoctorsEventData).EndTime

#line default
#line hidden
#nullable disable
                    , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (context as ScheduleData.DoctorsEventData).EndTime = __value, (context as ScheduleData.DoctorsEventData).EndTime)), 87, () => (context as ScheduleData.DoctorsEventData).EndTime);
                    __builder3.AddMarkupContent(88, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n                            ");
                    __builder3.OpenElement(91, "tr");
                    __builder3.AddMarkupContent(92, "\r\n                                ");
                    __builder3.AddMarkupContent(93, "<td class=\"e-textlabel\">Reason</td>\r\n                                ");
                    __builder3.OpenElement(94, "td");
                    __builder3.AddAttribute(95, "colspan", "4");
                    __builder3.AddMarkupContent(96, "\r\n                                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(97);
                    __builder3.AddAttribute(98, "Multiline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
                                                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
                                                                               (context as ScheduleData.DoctorsEventData).Description

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(100, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (context as ScheduleData.DoctorsEventData).Description = __value, (context as ScheduleData.DoctorsEventData).Description))));
                    __builder3.AddAttribute(101, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => (context as ScheduleData.DoctorsEventData).Description));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(103, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(105, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Schedule.ScheduleEventSettings<ScheduleData.DoctorsEventData>>(108);
                __builder2.AddAttribute(109, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ScheduleData.DoctorsEventData>>(
#nullable restore
#line 55 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
                                                                                       DataSource

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(111, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
            __builder.AddMarkupContent(114, "<style>\r\n    .custom-event-editor td {\r\n        padding: 7px;\r\n        padding-right: 16px;\r\n    }\r\n    .dropdown .e-dropdownlist {\r\n        color: inherit !important;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\Scheduler.razor"
      
    private DateTime CurrentDate = DateTime.Now;
    public class EventFields
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }
    List<EventFields> StatusData = new List<EventFields>() {
            new EventFields(){ Id= "New", Text= "New" },
            new EventFields(){ Id= "Requested", Text= "Requested" },
            new EventFields(){ Id= "Confirmed", Text= "Confirmed" },
        };

    List<ScheduleData.DoctorsEventData> DataSource;
    //CloudAppointmentService.GetAppointmentData();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAppointmentService CloudAppointmentService { get; set; }
    }
}
namespace __Blazor.SEP3.Pages.Scheduler
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfDateTimePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Calendars.SfDateTimePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateSfDateTimePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Calendars.SfDateTimePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591