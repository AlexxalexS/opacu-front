#pragma checksum "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7b797497f348c1e5fb40d937d1955c5bd69e9af"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontOPACU.Pages.Text
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
#line 13 "/Users/leha/projects/my/opacu-front/FrontOPACU/_Imports.razor"
using WYSIWYGTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-note")]
    public partial class AddNote : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "href", "/");
            __builder.OpenComponent<BlazorStrap.BSButton>(2);
            __builder.AddAttribute(3, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 8 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
                    Size.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 8 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
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
            __builder.AddMarkupContent(7, "\n<br>\n<br>\n\n");
            __builder.AddMarkupContent(8, "<h3>???????????????? ??????????????</h3>");
#nullable restore
#line 15 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
 if (isCreate)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "h1");
            __builder.AddAttribute(10, "class", "alert-success");
            __builder.AddMarkupContent(11, "?????????????? ??????????????\n    ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", "/notes");
            __builder.OpenComponent<BlazorStrap.BSButton>(14);
            __builder.AddAttribute(15, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 19 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
                        Size.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 19 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "????????????????????");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazored.TextEditor.BlazoredTextEditor>(19);
            __builder.AddAttribute(20, "ToolbarContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(21, "select");
                __builder2.AddAttribute(22, "class", "ql-header");
                __builder2.OpenElement(23, "option");
                __builder2.AddAttribute(24, "selected");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n            ");
                __builder2.OpenElement(26, "option");
                __builder2.AddAttribute(27, "value", "1");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n            ");
                __builder2.OpenElement(29, "option");
                __builder2.AddAttribute(30, "value", "2");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n            ");
                __builder2.OpenElement(32, "option");
                __builder2.AddAttribute(33, "value", "3");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n            ");
                __builder2.OpenElement(35, "option");
                __builder2.AddAttribute(36, "value", "4");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.OpenElement(38, "option");
                __builder2.AddAttribute(39, "value", "5");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n        ");
                __builder2.OpenElement(41, "span");
                __builder2.AddAttribute(42, "class", "ql-formats");
                __builder2.OpenElement(43, "select");
                __builder2.AddAttribute(44, "class", "ql-font");
                __builder2.OpenElement(45, "option");
                __builder2.AddAttribute(46, "selected");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n                ");
                __builder2.OpenElement(48, "option");
                __builder2.AddAttribute(49, "value", "serif");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n                ");
                __builder2.OpenElement(51, "option");
                __builder2.AddAttribute(52, "value", "monospace");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n            ");
                __builder2.OpenElement(54, "select");
                __builder2.AddAttribute(55, "class", "ql-size");
                __builder2.OpenElement(56, "option");
                __builder2.AddAttribute(57, "value", "small");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n                ");
                __builder2.OpenElement(59, "option");
                __builder2.AddAttribute(60, "selected");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\n                ");
                __builder2.OpenElement(62, "option");
                __builder2.AddAttribute(63, "value", "large");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n                ");
                __builder2.OpenElement(65, "option");
                __builder2.AddAttribute(66, "value", "huge");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n        ");
                __builder2.AddMarkupContent(68, "<span class=\"ql-formats\"><button class=\"ql-bold\"></button>\n            <button class=\"ql-italic\"></button>\n            <button class=\"ql-underline\"></button>\n            <button class=\"ql-strike\"></button></span>\n        ");
                __builder2.AddMarkupContent(69, "<span class=\"ql-formats\"><select class=\"ql-color\"></select>\n            <select class=\"ql-background\"></select></span>\n        ");
                __builder2.OpenElement(70, "span");
                __builder2.AddAttribute(71, "class", "ql-formats");
                __builder2.AddMarkupContent(72, "<button class=\"ql-list\" value=\"ordered\"></button>\n            <button class=\"ql-list\" value=\"bullet\"></button>\n            <button class=\"ql-indent\" value=\"-1\"></button>\n            <button class=\"ql-indent\" value=\"+1\"></button>\n            ");
                __builder2.OpenElement(73, "select");
                __builder2.AddAttribute(74, "class", "ql-align");
                __builder2.OpenElement(75, "option");
                __builder2.AddAttribute(76, "selected");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n                ");
                __builder2.OpenElement(78, "option");
                __builder2.AddAttribute(79, "value", "center");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n                ");
                __builder2.OpenElement(81, "option");
                __builder2.AddAttribute(82, "value", "right");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\n                ");
                __builder2.OpenElement(84, "option");
                __builder2.AddAttribute(85, "value", "justify");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\n        ");
                __builder2.AddMarkupContent(87, "<span class=\"ql-formats\"><button class=\"ql-link\"></button></span>");
            }
            ));
            __builder.AddAttribute(88, "EditorContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(89, "<h3>?????? ???? ???????????? ???????????? ?? ?????????????????????????????? ?????????? ??????????</h3><br>\n        ");
                __builder2.AddMarkupContent(90, "<h4>???????? ?????????? ???????????????? :)</h4>\n        ");
                __builder2.AddMarkupContent(91, "<a href=\"http://sut.ru/\">\n            ????????!\n        </a>");
            }
            ));
            __builder.AddComponentReferenceCapture(92, (__value) => {
#nullable restore
#line 24 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
                           QuillHtml = (Blazored.TextEditor.BlazoredTextEditor)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\n<br>\n");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "class", "btn btn-primary");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
                  CreateNote

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "\n    ??????????????\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n<br>\n");
            __builder.OpenElement(99, "div");
            __builder.AddMarkupContent(100, "<br>\n    ");
#nullable restore
#line 97 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
__builder.AddContent(101, (MarkupString)QuillHTMLContent);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(102, "\n    ");
#nullable restore
#line 98 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
__builder.AddContent(103, QuillHTMLContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
       

    BlazoredTextEditor QuillHtml;
    string QuillHTMLContent;

    public async void GetHTML()
    {
        QuillHTMLContent = await this.QuillHtml.GetHTML();
        StateHasChanged();
    }

    public async void SetHTML()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "/Users/leha/projects/my/opacu-front/FrontOPACU/Pages/Text/AddNote.razor"
                                                               
    string QuillContent =
            @"<a href='https://vk.com/alex_98'>" +
            "<img src='https://sun9-81.userapi.com/impf/5bGxcr1i52-NXgJ0XAiqMwlI8iQQGogXL93DQA/HLd3g6oGwyU.jpg?size=1440x2160&quality=96&sign=82e31dc387ef2fc60ebaf391440f8b58&type=album' /></a>";

    await this.QuillHtml.LoadHTMLContent(QuillContent);
    StateHasChanged();
}


private NewNote newNote = new();
private Boolean isCreate = false;

private async Task CreateNote()
{
    var content = await this.QuillHtml.GetHTML();
    newNote.Content = content;
    var serialized = JsonConvert.SerializeObject(newNote);
    var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
    var result = await Http.PostAsync($"{Program.apiURL}/note", stringContent).ConfigureAwait(false);

    try
    {
        isCreate = true;
        newNote = new();
        string QuillContent = "";
        await this.QuillHtml.LoadHTMLContent(QuillContent);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
    StateHasChanged();
}

private class NewNote
{
    public string Content { get; set; }
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
