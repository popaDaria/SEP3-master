#pragma checksum "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114493f7fd392ae5af22bc7f54b51b2a96b31cc8"
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
#line 1 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create a conversation</h3>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
 if (Users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 20 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 25 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
                                   searchFilter

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
                                                            FilterChangedAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "placeholder", "Search here...");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "mt-4");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "thead");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<th>\r\n                    ID\r\n                </th>\r\n                ");
            __builder.AddMarkupContent(24, "<th>\r\n                    Name\r\n                </th>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(25);
            __builder.AddAttribute(26, "Policy", "MustBeLoggedIn");
            __builder.AddAttribute(27, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.AddMarkupContent(29, "<th>Action</th>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "tbody");
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 45 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
             foreach (var pair in Users)
            {
                Console.WriteLine(pair.Split(" ")[0]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 49 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
                         pair.Split(" ")[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 50 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
                          pair.Split(" ")[1] + " " + pair.Split(" ")[2]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "span");
            __builder.AddAttribute(47, "class", "btn btn-danger");
            __builder.AddAttribute(48, "href", 
#nullable restore
#line 52 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
                                                             "/message/" + pair.Split(" ")[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(49, "New Chat");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 55 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 59 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\bogda\RiderProjects\SEP3-master\SEP3\Pages\Chat.razor"
       
    public string type;
    public string searchFilter = "";
    public List<String> Users = new List<String>();

    protected async override Task OnInitializedAsync()
    {
        type = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetAuthenticationStateAsync().Result.User.Claims.ToList()[1].Value;
        if(type.Equals("patient"))
            Users = await CloudUserService.getUsersByType("doctor");
        else
            Users = await CloudUserService.getUsersByType("patient");
    }

    public async Task Search(string searchTerm)
    {
        Users = Users.Where(a => (a.Split(" ")[1] + " " + a.Split(" ")[2]).StartsWith(searchTerm.ToLower())).ToList();
    }

    public async Task FilterChangedAsync(ChangeEventArgs args)
    {
        searchFilter = args.Value.ToString().Trim();
        Search(searchFilter);
    }

    public void OpenChat(string pair)
    {
        NavigationManager.NavigateTo("/message/" + pair.Split(" ")[0]);
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