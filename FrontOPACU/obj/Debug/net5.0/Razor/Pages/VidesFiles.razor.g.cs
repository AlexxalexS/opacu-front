#pragma checksum "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b8490f551a637bc6cfce15c54a9cb8e78fc50b"
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
#line 2 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
using Blazored.Video;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
using Blazored.Video.Support;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/videos")]
    public partial class VidesFiles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "href", "/user-files?id=" + (
#nullable restore
#line 8 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
                         idPars

#line default
#line hidden
#nullable disable
            ) + "&name=" + (
#nullable restore
#line 8 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
                                      nameParse

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<BlazorStrap.BSButton>(2);
            __builder.AddAttribute(3, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 9 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
                    Size.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 9 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
                                       Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "<span class=\"oi oi-arrow-thick-left\"></span> ??????????");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n<br><br>\n\n");
            __builder.OpenElement(8, "h3");
            __builder.AddMarkupContent(9, "?????????? ???????????????????????? ");
#nullable restore
#line 13 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
__builder.AddContent(10, nameParse);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 15 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
 if (videoFiles == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<p><em>????????????????...</em></p>");
#nullable restore
#line 18 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
     if (videoFiles.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
#nullable restore
#line 24 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
             foreach (var video in videoFiles)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.OpenElement(14, "span");
            __builder.AddMarkupContent(15, "????????????????: ");
            __builder.OpenElement(16, "h3");
            __builder.AddAttribute(17, "style", "text-decoration: underline");
#nullable restore
#line 27 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
__builder.AddContent(18, video.File.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ??????????????????: ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "style", "font-style: italic");
#nullable restore
#line 28 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
__builder.AddContent(22, video.File.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                ");
            __builder.OpenComponent<Blazored.Video.BlazoredVideo>(24);
            __builder.AddAttribute(25, "Play", (System.Action<Blazored.Video.Support.VideoState>)(
#nullable restore
#line 30 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
                                     OnPlay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "class", "w-100");
            __builder.AddAttribute(27, "style", "max-height: 300px; border: 2px");
            __builder.AddAttribute(28, "controls", "controls");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(30, "source");
                __builder2.AddAttribute(31, "src", "https://localhost:5000/" + (
#nullable restore
#line 34 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
                                                         video.File.Path

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "type", "video/mp4");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddMarkupContent(35, "\n                    ????????????????????????????:\n                    ");
            __builder.OpenElement(36, "ul");
            __builder.OpenElement(37, "li");
            __builder.AddMarkupContent(38, "??????????????: ");
#nullable restore
#line 39 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
__builder.AddContent(39, video.Bitrate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                        ");
            __builder.OpenElement(41, "li");
            __builder.AddMarkupContent(42, "????????????????????: ");
#nullable restore
#line 40 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
__builder.AddContent(43, video.Resolution);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                        ");
            __builder.OpenElement(45, "li");
            __builder.AddMarkupContent(46, "????????????: ");
#nullable restore
#line 41 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
__builder.AddContent(47, video.File.Size);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                        ");
            __builder.OpenElement(49, "li");
            __builder.AddContent(50, "ID: ");
#nullable restore
#line 42 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
__builder.AddContent(51, video.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                <hr>\n                <br>");
#nullable restore
#line 47 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 49 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<h1>???? ?????? ???? ?????????????????? ??????????</h1>");
#nullable restore
#line 53 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/VidesFiles.razor"
       
    private string idPars;
    private string nameParse;
    private List<VideoFile> videoFiles;

    void OnPlay(VideoState state)
    {
        // var url = state.CurrentSrc;
    // do something with this
    }
    void OnTimeUpdate(VideoState state)
    {
        var url = state.CurrentSrc;
        var currentTime = state.CurrentTime;
    // do something with this
    }
    
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
        
        string url = $"{Program.apiURL}/users/" + idPars + "/video-files";
        
        videoFiles = await Http.GetFromJsonAsync<List<VideoFile>>(url);
    }
    
    
    public class VideoFile
    {
        public Guid Id { get; set; }

        public string Resolution { get; set; }
        
        public int Length { get; set; }
        
        public int Bitrate { get; set; }
        
        public string Encoding { get; set; }
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
