#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b01c7468d84d7d73462c65f01d465ba3126e361"
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
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
           [Authorize(Roles = "patient, doctor, manager")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
       
    public string idNr;
    public string type;
    private string searchFilter = "";
    //public List<Message> Messages = new List<Message>();
    public List<String> Users = new List<String>();
    User user { get; set; } = new User();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            idNr = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetAuthenticationStateAsync().Result.User.Claims.ToList()[0].Value;
            user = await CloudUserService.GetUser(idNr);
            type = user.userType;
    //type = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetAuthenticationStateAsync().Result.User.Claims.ToList()[1].Value;
            //Messages = await CloudMessageService.GetMessagesToMe(user.idNr);

            if (user.userType.Equals("patient"))
            {
                Users = await CloudUserService.getUsersByType("doctor");
                List<String> managers = await CloudUserService.getUsersByType("manager");
                foreach (var manager in managers)
                {
                    Users.Add(manager);
                }
            }
            else
            {
                Users = await CloudUserService.getUsersByType("patient");
            }
    //StateHasChanged();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    /*public String GetName(Message message)
    {
        String name = "";
        try
        {
            name = CloudUserService.GetName(message.senderID + "").Result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return name;
    }*/

    public async Task Search(string searchTerm)
    {
        if (user.userType.Equals("patient"))
            Users = await CloudUserService.getUsersByType("doctor");
        else
        {
            Users = await CloudUserService.getUsersByType("patient");
        }        
        Users = Users.Where(a => (a.Split("-")[1].ToLower()).Contains(searchTerm.ToLower())).ToList();
        //StateHasChanged();
    }

    private void FilterChangedAsync(ChangeEventArgs args)
    {
        try
        {
            if(searchFilter!=null)
                searchFilter = args.Value.ToString().Trim();
            Search(searchFilter);
            //StateHasChanged();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
    }

    public void OpenChat(string pair)
    {
        NavigationManager.NavigateTo("/message/" + pair.Split("-")[0]);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudUserService CloudUserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudMessageService CloudMessageService { get; set; }
    }
}
#pragma warning restore 1591
