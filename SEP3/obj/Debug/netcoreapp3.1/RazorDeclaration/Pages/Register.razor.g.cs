#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2b38febeebf6145180b688967953c79817ac29f"
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
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
using InputType = Syncfusion.Blazor.Inputs.InputType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
using RestSharp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Register.razor"
       
    User userToAdd { get; set; } = new User();
    string display = "display: none";
    string displayError = "display: none";
    bool isDisabled = false;
    string ErrorMessage;
    string idNR { get; set; }
    
    
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
    
    public class UserType
    {
        public string ID { get; set; }
        public string Text { get; set; }
    }
    private List<UserType> types = new List<UserType>() {
        new UserType(){ ID= "0", Text= "--Select an option--" },
        new UserType(){ ID= "1", Text= "patient" },
        new UserType(){ ID= "2", Text= "manager" }
    };
    public string DropVal = "0";
    public string ChangeValue { get; set; } = "--Select an option--";
    public void OnChange(ChangeEventArgs<string, UserType> args)
    {
        this.ChangeValue = args.ItemData.Text;
    }
    
    
    public DateTime DropVal3 { get; set; } = DateTime.Now;


    private async Task Add()
    {
        try
        {
            //Console.WriteLine(userToAdd.firstName+" "+userToAdd.lastName+" "+userToAdd.userType);
            userToAdd.userType = ChangeValue;
            userToAdd.gender = ChangeValue2;
            // userToAdd.birthday = DropVal3;
            userToAdd.idNr = Int32.Parse(idNR);
            userToAdd.password = getHashSha256(userToAdd.password);
            await CloudUserService.AddUser(userToAdd);
            displayError = "display: none";
            display = "display: block";
            isDisabled = true;
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(userToAdd.idNr+"", userToAdd.password).Wait(100);
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            ErrorMessage = e.Message;
            Console.WriteLine(e.InnerException + e.StackTrace + e.Message);
            displayError = "display: block";
        }
    }
    
    private static string getHashSha256(string text)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(text);
        SHA256Managed hashstring = new SHA256Managed();
        byte[] hash = hashstring.ComputeHash(bytes);
        string hashString = string.Empty;
        foreach (byte x in hash)
        {
            hashString += String.Format("{0:x2}", x);
        }
        return hashString;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudUserService CloudUserService { get; set; }
    }
}
#pragma warning restore 1591
