#pragma checksum "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54e6743f3f1f261480c96948da53e6a5a10777c5"
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
#line 1 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/_Imports.razor"
using FrontOPACU;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/_Imports.razor"
using FrontOPACU.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Пользователи</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Это все пользователи сервиса</p>");
#nullable restore
#line 8 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
 if (allUsers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Загрузка...</em></p>");
#nullable restore
#line 11 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>ID</th>\n                <th>Имя</th>\n                <th>Фамилия</th>\n                <th></th>\n                <th></th></tr></thead>\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 25 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
             foreach (var user in allUsers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 28 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
                         user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 29 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
                         user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 30 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
                         user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "/user-files?id=" + (
#nullable restore
#line 32 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
                                                 user.Id.ToString()

#line default
#line hidden
#nullable disable
            ) + "&name=" + (
#nullable restore
#line 32 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
                                                                          user.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "<span class=\"oi oi-file\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.AddMarkupContent(22, "<td><span class=\"oi oi-delete\"></span></td>");
            __builder.CloseElement();
#nullable restore
#line 36 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/alexey/Projects/FrontOPACU/FrontOPACU/Pages/Users.razor"
       
    private List<User> allUsers;

    protected override async Task OnInitializedAsync()
    {
        allUsers = await Http.GetFromJsonAsync<List<User>>("http://localhost:5000/api/User");
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