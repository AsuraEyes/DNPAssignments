// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 4 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/AddAdult.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/AddAdult.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/AddAdult.razor"
using BlazorClient.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/shadow_asura/Downloads/DNPAssignment3-master/BlazorClient/Pages/AddAdult.razor"
 
    private Adult newAdult = new Adult();
    private  string errorMessage = "";

    // protected override async Task OnInitializedAsync()
    // {
    //     newAdult = new Adult();
    //     // newAdult.Sex = "M";
    //     // newAdult.EyeColor = "Brown";
    // }

    private async Task AddAdultAsync()
    {
        try
        {
            await AdultData.AddAdultAsync(newAdult);
            NavigationManager.NavigateTo("/AdultsList");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
