// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/shadow_asura/RiderProjects/DNPAssignment1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shadow_asura/RiderProjects/DNPAssignment1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/shadow_asura/RiderProjects/DNPAssignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/shadow_asura/RiderProjects/DNPAssignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/shadow_asura/RiderProjects/DNPAssignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/shadow_asura/RiderProjects/DNPAssignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/shadow_asura/RiderProjects/DNPAssignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/shadow_asura/RiderProjects/DNPAssignment1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/shadow_asura/RiderProjects/DNPAssignment1/_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/shadow_asura/RiderProjects/DNPAssignment1/_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shadow_asura/RiderProjects/DNPAssignment1/Pages/DetailsAdult.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/shadow_asura/RiderProjects/DNPAssignment1/Pages/DetailsAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DetailsAdult/{Id:int}")]
    public partial class DetailsAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "/Users/shadow_asura/RiderProjects/DNPAssignment1/Pages/DetailsAdult.razor"
       

    [Parameter]
    public int Id { get; set; }

    private Adult adultToShow;

    protected override async Task OnInitializedAsync()
    {
        adultToShow = AdultService.GetAdultById(Id);
    }

    private void Back()
    {
        NavigationManager.NavigateTo("/ViewAdults");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
