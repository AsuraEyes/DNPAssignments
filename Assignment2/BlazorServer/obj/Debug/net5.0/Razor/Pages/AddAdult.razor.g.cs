#pragma checksum "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf0f56deea84b7a317a72447cdfc6da0f79b7459"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
using BlazorServer.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
using BlazorServer.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Adult Here</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                  adult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                         AddAdultAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "style", "color:red");
                __builder2.AddContent(11, 
#nullable restore
#line 12 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                            errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "\n        First name:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "type", "text");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                            adult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adult.FirstName = __value, adult.FirstName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adult.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\n        Last name:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "type", "text");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                            adult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adult.LastName = __value, adult.LastName))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adult.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.OpenElement(33, "p");
                __builder2.AddMarkupContent(34, "\n            Sex:\n            ");
                __builder2.OpenElement(35, "select");
                __builder2.AddAttribute(36, "class", "form-control selectpicker");
                __builder2.AddAttribute(37, "style", "width: 75px");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                                                                 adult.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adult.Sex = __value, adult.Sex));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(40, "option");
                __builder2.AddContent(41, "M");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n                ");
                __builder2.OpenElement(43, "option");
                __builder2.AddContent(44, "F");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\n    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "\n        Age:\n        ");
                __Blazor.BlazorServer.Pages.AddAdult.TypeInference.CreateInputNumber_0(__builder2, 49, 50, 
#nullable restore
#line 32 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                  adult.Age

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adult.Age = __value, adult.Age)), 52, () => adult.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, "\n        Job Title:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "type", "text");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                            jobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => jobTitle = __value, jobTitle))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => jobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\n    ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "\n        Salary:\n        ");
                __Blazor.BlazorServer.Pages.AddAdult.TypeInference.CreateInputNumber_1(__builder2, 66, 67, 
#nullable restore
#line 40 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                  salary

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => salary = __value, salary)), 69, () => salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n    ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group");
                __builder2.AddMarkupContent(73, "\n        Height:\n        ");
                __Blazor.BlazorServer.Pages.AddAdult.TypeInference.CreateInputNumber_2(__builder2, 74, 75, 
#nullable restore
#line 44 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                  adult.Height

#line default
#line hidden
#nullable disable
                , 76, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adult.Height = __value, adult.Height)), 77, () => adult.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\n    ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.AddMarkupContent(81, "\n        Weight:\n        ");
                __Blazor.BlazorServer.Pages.AddAdult.TypeInference.CreateInputNumber_3(__builder2, 82, 83, 
#nullable restore
#line 48 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                  adult.Weight

#line default
#line hidden
#nullable disable
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adult.Weight = __value, adult.Weight)), 85, () => adult.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\n    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group");
                __builder2.AddMarkupContent(89, "\n        Hair Color:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(90);
                __builder2.AddAttribute(91, "type", "text");
                __builder2.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                            adult.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adult.HairColor = __value, adult.HairColor))));
                __builder2.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adult.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n    ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group");
                __builder2.OpenElement(98, "p");
                __builder2.AddMarkupContent(99, "\n            Eye Color:\n            ");
                __builder2.OpenElement(100, "select");
                __builder2.AddAttribute(101, "class", "form-control selectpicker");
                __builder2.AddAttribute(102, "style", "width: 150px");
                __builder2.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
                                                                                  adult.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adult.EyeColor = __value, adult.EyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(105, "option");
                __builder2.AddContent(106, "Brown");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\n                ");
                __builder2.OpenElement(108, "option");
                __builder2.AddContent(109, "Blue");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\n                ");
                __builder2.OpenElement(111, "option");
                __builder2.AddContent(112, "Amber");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\n                ");
                __builder2.OpenElement(114, "option");
                __builder2.AddContent(115, "Gray");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\n                ");
                __builder2.OpenElement(117, "option");
                __builder2.AddContent(118, "Green");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\n                ");
                __builder2.OpenElement(120, "option");
                __builder2.AddContent(121, "Other");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\n    ");
                __builder2.AddMarkupContent(123, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Create</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "/Users/shadow_asura/RiderProjects/DNPAssignments/Assignment2/BlazorServer/Pages/AddAdult.razor"
 
    private readonly Adult adult = new();
    private string jobTitle;
    private int salary;
    private readonly string errorMessage = "";

    protected override async Task OnInitializedAsync()
    {
        adult.Sex = "M";
        adult.EyeColor = "Brown";
    }

    private async Task AddAdultAsync()
    {
        adult.JobTitle = new Job
        {
            JobTitle = jobTitle,
            Salary = salary
        };
        await Adapter.AddAdultAsync(adult);
        NavigationManager.NavigateTo("/Adults");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileAdapter Adapter { get; set; }
    }
}
namespace __Blazor.BlazorServer.Pages.AddAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
