// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        var result = await Http.PostAsync($"{Program.apiURL}User", stringContent).ConfigureAwait(false);

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
    
    public class NewUser
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
