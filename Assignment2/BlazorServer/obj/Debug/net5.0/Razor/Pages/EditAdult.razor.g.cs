#pragma checksum "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6729c602b24bdae6c5610782b663c3070915239b"
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
#line 1 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
using BlazorServer.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
using BlazorServer.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditAdult/{Id:int}")]
    public partial class EditAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EditAdult</h3>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                  _adult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                          SaveAdultAsync

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
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "\n        First name:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                            _adult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.FirstName = __value, _adult.FirstName))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\n        Last name:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "type", "text");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                            _adult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.LastName = __value, _adult.LastName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\n        Sex:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                            _adult.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Sex = __value, _adult.Sex))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.Sex));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "\n        Age:\n        ");
                __Blazor.BlazorServer.Pages.EditAdult.TypeInference.CreateInputNumber_0(__builder2, 39, 40, 
#nullable restore
#line 24 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                  _adult.Age

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Age = __value, _adult.Age)), 42, () => _adult.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "\n        Job Title:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "type", "text");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                            jobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => jobTitle = __value, jobTitle))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => jobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\n        Salary:\n        ");
                __Blazor.BlazorServer.Pages.EditAdult.TypeInference.CreateInputNumber_1(__builder2, 56, 57, 
#nullable restore
#line 32 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                  salary

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => salary = __value, salary)), 59, () => salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "\n        Height:\n        ");
                __Blazor.BlazorServer.Pages.EditAdult.TypeInference.CreateInputNumber_2(__builder2, 64, 65, 
#nullable restore
#line 36 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                  _adult.Height

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Height = __value, _adult.Height)), 67, () => _adult.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\n    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.AddMarkupContent(71, "\n        Weight:\n        ");
                __Blazor.BlazorServer.Pages.EditAdult.TypeInference.CreateInputNumber_3(__builder2, 72, 73, 
#nullable restore
#line 40 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                  _adult.Weight

#line default
#line hidden
#nullable disable
                , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Weight = __value, _adult.Weight)), 75, () => _adult.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n    ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "\n        Hair Color:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(80);
                __builder2.AddAttribute(81, "type", "text");
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                            _adult.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.HairColor = __value, _adult.HairColor))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddMarkupContent(88, "\n        Eye Color:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(89);
                __builder2.AddAttribute(90, "type", "text");
                __builder2.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
                                            _adult.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.EyeColor = __value, _adult.EyeColor))));
                __builder2.AddAttribute(93, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\n    ");
                __builder2.AddMarkupContent(95, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Save</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "/Users/shadow_asura/RiderProjects/Assignment2/BlazorServer/Pages/EditAdult.razor"
       
    private Adult _adult = new();

    [Parameter]
    public int id { get; set; }

    private string jobTitle { get; set; }
    private int salary { get; set; }

    private async Task SaveAdultAsync()
    {
        _adult.JobTitle = new Job
        {
            JobTitle = jobTitle,
            Salary = salary
        };
        await FileAdapter.UpdateAsync(_adult);
        NavigationManager.NavigateTo("Adults");
    }

    protected override async Task OnInitializedAsync()
    {
        _adult = await FileAdapter.GetAdultAsync(id);
        jobTitle = _adult.JobTitle.JobTitle;
        salary = _adult.JobTitle.Salary;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileAdapter FileAdapter { get; set; }
    }
}
namespace __Blazor.BlazorServer.Pages.EditAdult
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