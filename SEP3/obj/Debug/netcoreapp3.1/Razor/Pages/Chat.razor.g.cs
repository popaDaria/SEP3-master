#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b01c7468d84d7d73462c65f01d465ba3126e361"
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
            __builder.AddMarkupContent(0, "<h3>Create a conversation</h3>\n\n");
#nullable restore
#line 17 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
 if (Users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>\n        <em>Loading...</em>\n    </p>\n");
#nullable restore
#line 22 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 26 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
                                   searchFilter

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 26 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
                                                            FilterChangedAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "placeholder", "Search here...");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "mt-4");
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(18, "\n            ");
            __builder.OpenElement(19, "thead");
            __builder.AddMarkupContent(20, "\n            ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\n                ");
            __builder.AddMarkupContent(23, "<th>\n                    ID\n                </th>\n                ");
            __builder.AddMarkupContent(24, "<th>\n                    Name\n                </th>\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(25);
            __builder.AddAttribute(26, "Policy", "MustBeLoggedIn");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(28, "\n                    ");
                __builder2.AddMarkupContent(29, "<th>Action</th>\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n            ");
            __builder.OpenElement(33, "tbody");
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 44 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
             foreach (String pair in Users)
            {
                Console.WriteLine(pair);

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 48 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
                         pair.Split("-")[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 49 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
                         pair.Split("-")[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(44);
            __builder.AddAttribute(45, "Policy", "MustBeLoggedIn");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(47, "\n                    ");
                __builder2.OpenElement(48, "td");
                __builder2.AddMarkupContent(49, "\n                        ");
                __builder2.AddMarkupContent(50, "<label>link : </label>\n                        ");
                __builder2.OpenElement(51, "span");
                __builder2.AddAttribute(52, "class", "btn btn-danger");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
                                                               () => OpenChat(pair)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(54, "New Chat");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n");
#nullable restore
#line 57 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n");
#nullable restore
#line 61 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Chat.razor"
}

#line default
#line hidden
#nullable disable
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
