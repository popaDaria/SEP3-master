#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8036ff5d54fd61d5496373273d47505f4b06a69"
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
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor"
using InputType = Syncfusion.Blazor.Inputs.InputType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor"
using RestSharp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor"
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
#line 103 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\AddDoctor.razor"
       
    User userToAdd { get; set; } = new User();
    string display = "display: none";
    string displayError = "display: none";
    bool isDisabled = false;
    string ErrorMessage;
    string idNR;

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
    
    private string textValue { get; set; }
    public class Gender
    {
        public string ID2 { get; set; }
        public string Text2 { get; set; }
    }
    private List<Gender> genders = new List<Gender>() {
        new Gender(){ ID2= "0", Text2= "--Select an option--" },
        new Gender(){ ID2= "1", Text2= "Male" },
        new Gender(){ ID2= "2", Text2= "Female" }
    };
    public string DropVal2 = "0";
    public string ChangeValue2 { get; set; } = "--Select an option--";
    public void OnChange2(ChangeEventArgs<string, Gender> args)
    {
        this.ChangeValue2 = args.ItemData.Text2;
    }
    
    
    private async Task Add()
    {
        try
        {
            string[] contents = hospital.Split(" ");
            int hosID = Int32.Parse(contents[0]);
            userToAdd.idNr = Int32.Parse(idNR);
            userToAdd.gender = ChangeValue2;
            
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
