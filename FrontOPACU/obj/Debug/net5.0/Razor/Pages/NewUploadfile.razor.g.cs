#pragma checksum "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d70ddf0dd82dfd8154c3d8056c6aa4fda4453528"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontOPACU.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-new-file")]
    public partial class NewUploadfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Upload Files</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                  newFile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                                            HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n\n    ");
                __builder2.OpenElement(10, "label");
                __builder2.AddMarkupContent(11, "\n        Введите имя файла:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "input-group-text");
                __builder2.AddAttribute(14, "id", "title");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                                                                    newFile.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newFile.Title = __value, newFile.Title))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newFile.Title));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n    <br>\n    ");
                __builder2.OpenElement(19, "label");
                __builder2.AddMarkupContent(20, "\n        Введите описание файла файла:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", "input-group-text");
                __builder2.AddAttribute(23, "id", "description");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                                                                          newFile.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newFile.Description = __value, newFile.Description))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newFile.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n    <br>\n    ");
                __builder2.OpenElement(28, "label");
                __builder2.AddMarkupContent(29, "\n        Upload up to iles:\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(30);
                __builder2.AddAttribute(31, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 27 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                              OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(32, "multiple", true);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n    <br>\n    <br>\n    ");
                __builder2.AddMarkupContent(34, "<button class=\"btn btn-primary\" type=\"submit\">Создать</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 35 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
 if (files.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "card");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card-body");
            __builder.OpenElement(39, "ul");
#nullable restore
#line 40 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                 foreach (var file in files)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "li");
            __builder.AddMarkupContent(41, "\n                        File: ");
            __builder.AddContent(42, 
#nullable restore
#line 43 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                               file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\n                        <br>");
#nullable restore
#line 45 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                         if (FileUpload(uploadResults, file.Name,
                           out var result))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "span");
            __builder.AddMarkupContent(45, "\n                                Stored File Name: ");
            __builder.AddContent(46, 
#nullable restore
#line 49 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                                                   result.StoredFileName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 51 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "span");
            __builder.AddMarkupContent(48, "\n                                There was an error uploading the file\n                                (Error: ");
            __builder.AddContent(49, 
#nullable restore
#line 56 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                                         result.ErrorCode

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, ").\n                            ");
            __builder.CloseElement();
#nullable restore
#line 58 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 60 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "/Users/alexey/Projects/opacu-front/FrontOPACU/Pages/NewUploadfile.razor"
       
    private string idUser;
    private List<File> files = new();
    private List<UploadResult> uploadResults = new();
    private int maxAllowedFiles = 3;
    private bool shouldRender;
    private FileUploadModel newFile = new();
    
    private MultipartFormDataContent content = new MultipartFormDataContent();
    private bool upload = false;

    protected override bool ShouldRender() => shouldRender;

    protected override async Task OnInitializedAsync()
    {
        var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

        if(QueryHelpers.ParseQuery(uri.Query).TryGetValue("id", out var id))
        {
            idUser = id.First();
        }
    }

    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        shouldRender = false;
        upload = false;

        foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
        {
            if (uploadResults.SingleOrDefault(
                f => f.FileName == file.Name) is null)
            {
                try
                {
                    var fileContent =
                        new StreamContent(file.OpenReadStream());

                    fileContent.Headers.ContentType =
                        new MediaTypeHeaderValue(file.ContentType);

                    files.Add(new() { Name = file.Name });

                    content.Add(
                        content: fileContent,
                        name: "\"file\"",
                        fileName: file.Name);

                    


                    upload = true;
                }
                catch (Exception ex)
                {

                }
            }
        }

        shouldRender = true;
        
    }

    private async Task HandleValidSubmit()
    {
        content.Add(new StringContent(newFile.Title), "title");
        content.Add(new StringContent(newFile.Description), "description");
        
        if (upload)
        {
            var response = await Http.PostAsync($"{Program.apiURL}/users/" + idUser + "/files", content).ConfigureAwait(false);
        }
        
    }

    private static bool FileUpload(IList<UploadResult> uploadResults,
        string? fileName, out UploadResult result)
    {
        result = uploadResults.SingleOrDefault(f => f.FileName == fileName) ?? new();

        if (!result.Uploaded)
        {
        }

        return result.Uploaded;
    }

    private class File
    {
        public string? Name { get; set; }
    }

    public class UploadResult
    {
        public bool Uploaded { get; set; }
        public string FileName { get; set; }
        public string StoredFileName { get; set; }
        public int ErrorCode { get; set; }
    }

    private class FileUploadModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591