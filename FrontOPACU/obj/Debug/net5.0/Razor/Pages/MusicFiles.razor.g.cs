#pragma checksum "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138b2fcdfd577011b16044e0a37ba2ce34bc4c8c"
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
            __builder.AddMarkupContent(0, @"<style>
    button {
        margin-right: 10px;
        background: lightgray;
        border-radius: 25px;
        outline: none; 
        border: none;   
    }
    button:focus {
        background: green;
    }
    .icon__style {
        padding: 8px;
    }
</style>

");
            __builder.OpenElement(1, "a");
            __builder.AddAttribute(2, "href", "/user-files?id=" + (
#nullable restore
#line 22 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                         idPars

#line default
#line hidden
#nullable disable
            ) + "&name=" + (
#nullable restore
#line 22 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                                      nameParse

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<BlazorStrap.BSButton>(3);
            __builder.AddAttribute(4, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 23 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                    Size.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 23 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                                       Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "<span class=\"oi oi-arrow-thick-left\"></span> Назад");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n<br><br>\n\n");
            __builder.OpenElement(9, "h3");
            __builder.AddMarkupContent(10, "Музыка пользователя ");
#nullable restore
#line 27 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
__builder.AddContent(11, nameParse);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 29 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
 if (musicFiles == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<p><em>Загрузка...</em></p>");
#nullable restore
#line 32 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
     if (musicFiles.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorStrap.BSTable>(13);
            __builder.AddAttribute(14, "IsBordered", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "table");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, @"<thead><tr><th>Название</th>
                <th>Описиание</th>
                <th>Длина</th>
                <th>ID</th>
                <th>Битрейт</th>
                <th>Размер файла</th>
                <th>Усправление музыкой</th></tr></thead>
            ");
                __builder2.OpenElement(18, "tbody");
#nullable restore
#line 51 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
             foreach (var sound in musicFiles)
            {
       

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "audio");
                __builder2.AddAttribute(20, "id", "sound+" + (
#nullable restore
#line 54 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                                  sound.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "src", "https://localhost:5000/" + (
#nullable restore
#line 54 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                                                                         sound.File.Path

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.OpenElement(22, "tr");
                __builder2.OpenElement(23, "td");
#nullable restore
#line 57 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
__builder2.AddContent(24, sound.File.Title);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n                    ");
                __builder2.OpenElement(26, "td");
#nullable restore
#line 58 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
__builder2.AddContent(27, sound.File.Description);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n                    ");
                __builder2.OpenElement(29, "td");
#nullable restore
#line 59 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
__builder2.AddContent(30, sound.Length);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n                    ");
                __builder2.OpenElement(32, "td");
#nullable restore
#line 60 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
__builder2.AddContent(33, sound.Id);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n                    ");
                __builder2.OpenElement(35, "td");
#nullable restore
#line 61 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
__builder2.AddContent(36, sound.Bitrate);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n                    ");
                __builder2.OpenElement(38, "td");
#nullable restore
#line 62 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
__builder2.AddContent(39, sound.File.Size);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n                    \n                    ");
                __builder2.OpenElement(41, "td");
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "onclick", "document.getElementById(\'sound+" + (
#nullable restore
#line 65 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                                                                         sound.Id

#line default
#line hidden
#nullable disable
                ) + "\').play()");
                __builder2.AddMarkupContent(44, "<span class=\"icon__style oi oi-media-play\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\n                        \n                        ");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "onclick", "document.getElementById(\'sound+" + (
#nullable restore
#line 69 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                                                                         sound.Id

#line default
#line hidden
#nullable disable
                ) + "\').pause()");
                __builder2.AddMarkupContent(48, "<span class=\"icon__style oi oi-media-pause\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n                        ");
                __builder2.OpenElement(50, "button");
                __builder2.AddAttribute(51, "onclick", "document.getElementById(\'sound+" + (
#nullable restore
#line 72 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                                                                         sound.Id

#line default
#line hidden
#nullable disable
                ) + "\').pause();document.getElementById(\'sound+" + (
#nullable restore
#line 72 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
                                                                                                                            sound.Id

#line default
#line hidden
#nullable disable
                ) + "\').currentTime=0;");
                __builder2.AddMarkupContent(52, "<span class=\"icon__style oi oi-media-stop\"></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 77 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 80 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
    } 
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<h1>Вы еще не загрузили музыку</h1>");
#nullable restore
#line 84 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/MusicFiles.razor"
     
}

#line default
#line hidden
#nullable disable
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
