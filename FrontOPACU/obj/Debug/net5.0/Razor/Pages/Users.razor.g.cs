#pragma checksum "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23c749dc60a7bacbba4d128d43f000285676589a"
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
#line 1 "/Users/alexey/Projects/opacu-front/FrontOPACU/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexey/Projects/opacu-front/FrontOPACU/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/alexey/Projects/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/alexey/Projects/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/alexey/Projects/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/alexey/Projects/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/alexey/Projects/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/alexey/Projects/opacu-front/FrontOPACU/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/alexey/Projects/opacu-front/FrontOPACU/_Imports.razor"
using FrontOPACU;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/alexey/Projects/opacu-front/FrontOPACU/_Imports.razor"
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
            __builder.AddMarkupContent(1, "<p>Это все пользователи сервиса</p>\n\n");
            __builder.AddMarkupContent(2, "<a class=\"nav-link\" href=\"add-new-user\"><span class=\"oi oi-plus\" aria-hidden=\"true\"></span>Добавить нового ользователя\n</a>\n\n<br>\n<hr>");
#nullable restore
#line 15 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
 if (allUsers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p><em>Загрузка...</em></p>");
#nullable restore
#line 18 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "<thead><tr><th>ID</th>\n                <th>Имя</th>\n                <th>Фамилия</th>\n                <th></th>\n                <th></th></tr></thead>\n        ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 32 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
             foreach (var user in allUsers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 35 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
                         user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 36 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
                         user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 37 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
                         user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", "/user-files?id=" + (
#nullable restore
#line 39 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
                                                 user.Id.ToString()

#line default
#line hidden
#nullable disable
            ) + "&name=" + (
#nullable restore
#line 39 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
                                                                          user.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<span class=\"oi oi-file\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.AddMarkupContent(23, "<td><span class=\"oi oi-delete\"></span></td>");
            __builder.CloseElement();
#nullable restore
#line 43 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/Users.razor"
       
    private List<User> allUsers;

    protected override async Task OnInitializedAsync()
    {
        allUsers = await Http.GetFromJsonAsync<List<User>>("https://localhost:5000/api/User");
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
