#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ad7c390562c05e4973daf63c56bdf442429c02e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using RenderMode = Syncfusion.Blazor.InPlaceEditor.RenderMode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using InputType = Syncfusion.Blazor.InPlaceEditor.InputType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using ChangeEventArgs = Syncfusion.Blazor.Navigations.ChangeEventArgs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using EventArgs = System.EventArgs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using System.Reflection.Metadata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 179 "D:\THIRD SEMESTER\SEP3\SEP3-master-Bogdan - Copy\SEP3\Pages\ManageSchedule.razor"
       
    
    User user { get; set; }
    string idNr = "";
    IList<AvailableDay> AvailableDays { get; set; } = new List<AvailableDay>();
    string display { get; set; } = "display:none";
    
    AvailableDay availableDayToAdd { get; set; } = new AvailableDay();
    string apptNrString { get; set; }
    string display1 = "display: none";
    string display2 = "display:none";
    string display3 = "display:none";
    string display4 = "display:none";
    string displayError = "display: none";
    int apptId { get; set; }
    IList<Appointment> AllAppointments { get; set; } = new List<Appointment>();
    public string ErrorMessage { get; set; }
    string sameDateWarning { get; set; } = "";
    Appointment appointmentToModify = new Appointment();
    bool okDates { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        idNr = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetAuthenticationStateAsync().Result.User.Claims.ToList()[0].Value;
    //Console.WriteLine("Logged in as: "+idNr);
        display = "display :none";
        display1 = "display: none";
        display2 = "display:none";
        displayError = "display: none";
        user = await CloudUserService.GetUser(idNr);
        AvailableDays = await CloudAvailableDayService.GetAvailableDays(user.idNr);
        AllAppointments = await CloudAppointmentService.GetAllForDoctor(user.idNr);
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

    private async Task Remove()
    {
        try
        {
            Appointment appointment = new Appointment();
            foreach (var ap in AllAppointments)
            {
                if (ap.id == apptId)
                    appointment = ap;
            }
            await CloudAppointmentService.RemoveAppointment(appointment);
            display2 = "display:none";
            AllAppointments = await CloudAppointmentService.GetAllForDoctor(user.idNr);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    private async Task CancelAppt()
    {
        display2 = "display:block";
        AllAppointments = await CloudAppointmentService.GetAllForDoctor(user.idNr);
    }
    
    
    private void AddLabel(Microsoft.AspNetCore.Components.ChangeEventArgs e)
    {
        if (e.Value != null)
        {
            string result = (string) e.Value;
            string[] contents = result.Split("T");
            string[] dateContents = contents[0].Split("-");
            string[] timeContents = contents[1].Split(":");
            appointmentToModify.startTime = new DateTime(Int32.Parse(dateContents[0]),Int32.Parse(dateContents[1]),Int32.Parse(dateContents[2]), 
                Int32.Parse(timeContents[0]),Int32.Parse(timeContents[1]),0 );
        }
    }
    private void SelectEndTime(Microsoft.AspNetCore.Components.ChangeEventArgs e)
    {
        if (e.Value != null)
        {
            okDates = false;
            string result = (string) e.Value;
            string[] contents = result.Split("T");
            string[] dateContents = contents[0].Split("-");
            string[] timeContents = contents[1].Split(":");
            appointmentToModify.endTime = new DateTime(Int32.Parse(dateContents[0]),Int32.Parse(dateContents[1]),Int32.Parse(dateContents[2]), 
                Int32.Parse(timeContents[0]),Int32.Parse(timeContents[1]),0 );
            if (!appointmentToModify.endTime.Date.Equals(appointmentToModify.startTime.Date))
            {
                sameDateWarning = "End Time of appointment must have the same date as Start Time!";
                okDates = false;
            }
            else
            {
                if (appointmentToModify.startTime.TimeOfDay.TotalMinutes < appointmentToModify.endTime.TimeOfDay.TotalMinutes)
                {
                    sameDateWarning = "";
                    okDates = true;
                }
                else
                {
                    sameDateWarning = "End Time of appointment must be after Start Time of appointment!";
                    okDates = false;
                }
            }
        }    
    }

    private void RescheduleAppt()
    {
        display3 = "display:block";
        appointmentToModify = new Appointment();
    }

    private void SelectAppt()
    {
        foreach (var ap in AllAppointments)
        {
            if (ap.id == apptId)
                appointmentToModify = ap;
        }
        display4 = "display:block";
    }

    private async Task Reschedule()
    {
        if (okDates)
        {
            Console.WriteLine(appointmentToModify.startTime.ToString()+" "+appointmentToModify.endTime.ToString());
            await CloudAppointmentService.UpdateAppointment(appointmentToModify);
            display3 = "display:none";
            display4 = "display:none";
            appointmentToModify= new Appointment();
            AllAppointments = await CloudAppointmentService.GetAllForDoctor(user.idNr);
            NavigationManager.NavigateTo("ManageSchedule");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAppointmentService CloudAppointmentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAvailableDayService CloudAvailableDayService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudUserService CloudUserService { get; set; }
    }
}
#pragma warning restore 1591
