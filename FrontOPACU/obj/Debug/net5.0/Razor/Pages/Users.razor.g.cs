#pragma checksum "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a66c0e99d976643462810d4c5d7337773d3e3aa"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontOPACU.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using FrontOPACU;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using FrontOPACU.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using WYSIWYGTextEditor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n.button__link {\n    padding: 10px;\n    background: lightgray;\n    border-radius: 16px;\n }\n \n .button__add {\n     padding: 10px 20px;\n     background: #b1a9ff;\n     color: #ffffff;\n     border-radius: 12px;\n }\n</style>\n\n");
            __builder.AddMarkupContent(1, "<h1>????????????????????????</h1>\n\n");
            __builder.AddMarkupContent(2, "<p>?????? ?????? ???????????????????????? ??????????????</p>\n\n");
            __builder.AddMarkupContent(3, "<a class=\"button__add\" href=\"add-new-user\"><span class=\"oi oi-plus\" aria-hidden=\"true\"></span> ???????????????? ???????????? ????????????????????????\n</a>\n\n<br>\n\n<hr>");
#nullable restore
#line 34 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
 if (allUsers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>????????????????...</em></p>");
#nullable restore
#line 37 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorStrap.BSTable>(5);
            __builder.AddAttribute(6, "IsBordered", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "class", "table");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "<thead><tr><th>??????</th>\n                <th>??????????????</th>\n                <th>ID</th>\n                <th>?????????? ????????????????????????</th>\n                <th>?????????????????? ????????</th></tr></thead>\n        ");
                __builder2.OpenElement(10, "tbody");
#nullable restore
#line 51 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
             foreach (var user in allUsers)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(11, "tr");
                __builder2.OpenElement(12, "td");
#nullable restore
#line 54 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
__builder2.AddContent(13, user.FirstName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n                    ");
                __builder2.OpenElement(15, "td");
#nullable restore
#line 55 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
__builder2.AddContent(16, user.LastName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n                    ");
                __builder2.OpenElement(18, "td");
#nullable restore
#line 56 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
__builder2.AddContent(19, user.Id);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n                    ");
                __builder2.OpenElement(21, "td");
                __builder2.OpenElement(22, "a");
                __builder2.AddAttribute(23, "class", "button__link");
                __builder2.AddAttribute(24, "href", "/user-files?id=" + (
#nullable restore
#line 58 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
                                                                      user.Id.ToString()

#line default
#line hidden
#nullable disable
                ) + "&name=" + (
#nullable restore
#line 58 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
                                                                                               user.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-file\"></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n                    ");
                __builder2.OpenElement(27, "td");
                __builder2.OpenElement(28, "a");
                __builder2.AddAttribute(29, "class", "button__link");
                __builder2.AddAttribute(30, "href", "/add-new-file?id=" + (
#nullable restore
#line 61 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
                                                                         user.Id.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(31, "<span class=\"oi oi-cloud-upload\"></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 64 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 67 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Users.razor"
       
    private List<User> allUsers;

    protected override async Task OnInitializedAsync()
    {
        allUsers = await Http.GetFromJsonAsync<List<User>>($"{Program.apiURL}/User");
    }
    
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
