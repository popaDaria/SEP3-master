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
#line 2 "D:\SEP3-master\SEP3\Pages\AddDoctor.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3-master\SEP3\Pages\AddDoctor.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3-master\SEP3\Pages\AddDoctor.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SEP3-master\SEP3\Pages\AddDoctor.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\SEP3-master\SEP3\Pages\AddDoctor.razor"
       
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
#pragma warning restore 1591
