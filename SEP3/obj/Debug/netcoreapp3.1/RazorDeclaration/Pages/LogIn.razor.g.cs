// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LoginComponent
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
#line 4 "D:\SEP3-master\SEP3\Pages\LogIn.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3-master\SEP3\Pages\LogIn.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3-master\SEP3\Pages\LogIn.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEP3-master\SEP3\Pages\LogIn.razor"
using Microsoft.AspNetCore.Mvc.Formatters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEP3-master\SEP3\Pages\LogIn.razor"
using InputType = Syncfusion.Blazor.Inputs.InputType;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class LogIn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "D:\SEP3-master\SEP3\Pages\LogIn.razor"
       
    
    private string idNr;
    private string Password;
    private string ErrorMessage;
    private string display = "display: none";

    public async Task PerformLogIn()
    {
        ErrorMessage = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(idNr, Password).Wait(100);
            // NavigationManager.NavigateTo("/");
            idNr = "";
            Password = "";
            display = "display: none";
        }
        catch (Exception e)
        {
            display = "display: block";
            ErrorMessage = e.Message;
        }
    }

    // Log out function moved to NavMenu
    
    // public async Task PerformLogOut()
    // {
    //     ErrorMessage = "";
    //     idNr = "";
    //     Password = "";
    //     try
    //     {
    //         ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
    //         NavigationManager.NavigateTo("/");
    //     }
    //     catch (Exception e)
    //     {
    //     }
    // }

    private void signUp(MouseEventArgs e)
    {
        NavigationManager.NavigateTo("/register");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
