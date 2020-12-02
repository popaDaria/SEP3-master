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
#line 1 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEP3\SEP3-master-Bogdan\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3\SEP3-master-Bogdan\SEP3\Pages\Register.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3\SEP3-master-Bogdan\SEP3\Pages\Register.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3\SEP3-master-Bogdan\SEP3\Pages\Register.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3\SEP3-master-Bogdan\SEP3\Pages\Register.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3\SEP3-master-Bogdan\SEP3\Pages\Register.razor"
using InputType = Syncfusion.Blazor.Inputs.InputType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SEP3\SEP3-master-Bogdan\SEP3\Pages\Register.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SEP3\SEP3-master-Bogdan\SEP3\Pages\Register.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "D:\SEP3\SEP3-master-Bogdan\SEP3\Pages\Register.razor"
       
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

    public class Position
    {
        public string ID { get; set; }
        public string name { get; set; }
    }

    public List<Position> Positions = new List<Position>()
    {
        new Position() {name = "patient", ID = "1"},
        new Position() {name = "doctor", ID = "2"}
    };


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudUserService CloudUserService { get; set; }
    }
}
#pragma warning restore 1591
