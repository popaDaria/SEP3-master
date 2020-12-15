#pragma checksum "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40c12701818440899944d00edf57130ccb46d34f"
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
#line 3 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor"
using SEP3.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor"
using SEP3.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor"
           [Authorize(Roles = "patient, doctor")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/notifications")]
    public partial class Notifications : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/style.css\" type=\"text/css\" rel=\"stylesheet\">\n\n");
            __builder.AddMarkupContent(1, "<div class=\"m-auto\">\n    <p class=\"setPositionCenter WelcomeText\"><b>Notifications</b></p>\n</div>\n\n");
#nullable restore
#line 17 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor"
 foreach (var message in ToShow)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "alert alert-info mb-2");
            __builder.AddAttribute(5, "role", "alert");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddContent(7, 
#nullable restore
#line 20 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor"
         message.text

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\n        <br>\n        Sent by: ");
            __builder.AddContent(9, 
#nullable restore
#line 22 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor"
                  message.senderID

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\n        <br>\n        Timestamp: ");
            __builder.AddContent(11, 
#nullable restore
#line 24 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor"
                    message.timestamp

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
#nullable restore
#line 26 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\THIRD SEMESTER\SEP3\SEP3-master-Daria2\SEP3\Pages\Notifications.razor"
       
    IList<Message> Messages = new List<Message>();
    IList<Message> ToShow = new List<Message>();

string myID { get; set; }
    User user { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        Messages = await CloudMessageService.GetNotifications();
        myID = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetAuthenticationStateAsync().Result.User.Claims.ToList()[0].Value;
        user = await CloudUserService.GetUser(myID);
        if (user.userType.Equals("patient"))
        {
            foreach (var msg in Messages)
            {
                if (msg.recieverID == -1)
                {
                    ToShow.Add(msg);
                }
            }
        }
        else
        {
            foreach (var msg in Messages)
            {
                if (msg.recieverID == 0)
                {
                    ToShow.Add(msg);
                }
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudUserService CloudUserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudMessageService CloudMessageService { get; set; }
    }
}
#pragma warning restore 1591
