#pragma checksum "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/AddNewUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43b6a47316875bf3b141eba782a6a71c38e32afc"
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
#nullable restore
#line 2 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/AddNewUser.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/AddNewUser.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-new-user")]
    public partial class AddNewUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Добавиление нового пользовтеля</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/AddNewUser.razor"
                  newUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/AddNewUser.razor"
                                           HandleValidSubmit

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
                __builder2.AddMarkupContent(8, "\n    \n    ");
                __builder2.OpenElement(9, "label");
                __builder2.AddMarkupContent(10, "\n        Введите имя:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "input-group-text");
                __builder2.AddAttribute(13, "id", "firstName");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/AddNewUser.razor"
                                                                        newUser.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.FirstName = __value, newUser.FirstName))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n    <br>\n    ");
                __builder2.OpenElement(18, "label");
                __builder2.AddMarkupContent(19, "\n        Введите фамилию:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "class", "input-group-text");
                __builder2.AddAttribute(22, "id", "lastName");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/AddNewUser.razor"
                                                                       newUser.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.LastName = __value, newUser.LastName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n    <br>\n    <br>\n    ");
                __builder2.AddMarkupContent(27, "<button class=\"btn btn-primary\" type=\"submit\">Создать</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n\n<br>");
#nullable restore
#line 28 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/AddNewUser.razor"
 if (isCreate)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<h1 class=\"alert-success\">Пользователь создан</h1>");
#nullable restore
#line 31 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/AddNewUser.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/AddNewUser.razor"
       

    private NewUser newUser = new();
    private Boolean isCreate = false;

    private async Task HandleValidSubmit()
    {
        var serialized = JsonConvert.SerializeObject(newUser);
        var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
        var result = await Http.PostAsync($"{Program.apiURL}/User", stringContent).ConfigureAwait(false);

        try
        {
            isCreate = true;
            newUser = new();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

    }
    
    private class NewUser
    {
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