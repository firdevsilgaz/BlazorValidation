#pragma checksum "D:\Repositories\BlazorValidation\BlazorValidation\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01c4bf6fd50a6ff8be4e263c88b9e02d6a9b9b7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorValidation.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using BlazorValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using BlazorValidation.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using BlazorValidation.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using BlazorValidation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Repositories\BlazorValidation\BlazorValidation\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "<span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 3 "D:\Repositories\BlazorValidation\BlazorValidation\Shared\SurveyPrompt.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2137813\">brief survey</a></span>\r\n    and tell us what you think.\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Repositories\BlazorValidation\BlazorValidation\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
