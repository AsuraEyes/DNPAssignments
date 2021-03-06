#pragma checksum "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac09b80914da330f38b08010a7d0675976c9254"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
using BlazorClient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
           [Authorize(Policy = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UsersList")]
    public partial class UsersList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>UsersList</h3>");
#nullable restore
#line 9 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
          if (allUsers == null)
         {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Loading...</p>");
#nullable restore
#line 12 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
         }
         else
         {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, @"<thead><tr><th>User Id</th>
                     <th>UserName</th>
                     <th>Password</th>
                     <th>Role</th>
                     <th>Security Level</th>
                     <th>Remove</th>
                     <th>Edit</th></tr></thead>
                 ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 29 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
                  foreach (var item in allUsers)
                 {
                     if (!item.Role.Equals("admin"))
                     {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 34 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
                                  item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                             ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 35 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
                                  item.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                             ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 36 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
                                  item.Password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                             ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 37 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
                                  item.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                             ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 38 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
                                  item.SecurityLevel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                             ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
                                                     () => RemoveUser(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                             ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
                                                     () => Edit(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
                     }
                 }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
         }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/UsersList.razor"
       
           private IList<User> allUsers;
           
           protected override async Task OnInitializedAsync()
           {
               allUsers = await UserService.GetUsersAsync();
           }

           private async Task RemoveUser(int userId)
           {
               User userToRemove = allUsers.First(t => t.Id == userId);
               await UserService.RemoveUserAsync(userId);
               allUsers.Remove(userToRemove);
           }
    private void Edit(int id)
    {
        NavMgr.NavigateTo($"EditUser/{id}");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591
