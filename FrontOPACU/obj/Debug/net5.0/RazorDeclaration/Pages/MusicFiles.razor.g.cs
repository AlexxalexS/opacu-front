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
#nullable restore
#line 2 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/music")]
    public partial class MusicFiles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
       
    private string idPars;
    private string nameParse;
    private List<AudioFile> musicFiles;

    
    protected override async Task OnInitializedAsync()
    {
        
        var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);
        
        if(QueryHelpers.ParseQuery(uri.Query).TryGetValue("id", out var id))
        {
            idPars = id.First();
        }

        if(QueryHelpers.ParseQuery(uri.Query).TryGetValue("name", out var name))
        {
            nameParse = name.First();
        }
        
        string url = $"{Program.apiURL}/users/" + idPars + "/audio-files";
        
        musicFiles = await Http.GetFromJsonAsync<List<AudioFile>>(url);
    }
    
    
    public class AudioFile
    {
        public Guid Id { get; set; }
        
        public int Length { get; set; }
        
        public int Bitrate { get; set; }
        
        public UserFiles.File File { get; set; }
        
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
