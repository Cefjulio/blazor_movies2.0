#pragma checksum "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df9535ef7ce268c9e9a28cbeff424bd239adfe50"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Repository;

#line default
#line hidden
#nullable disable
    public partial class MovieForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                 Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                       OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "<label>Title:</label>\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                          Movie.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Title = __value, Movie.Title))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n            ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 7 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                      () => Movie.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>In Theaters</label>\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(23);
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                        Movie.InTheaters

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.InTheaters = __value, Movie.InTheaters))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Movie.InTheaters));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n            ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateValidationMessage_1(__builder2, 28, 29, 
#nullable restore
#line 14 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                      () => Movie.InTheaters

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label>Trailer:</label>\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                          Movie.Trailer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Trailer = __value, Movie.Trailer))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Trailer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\n            ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateValidationMessage_2(__builder2, 41, 42, 
#nullable restore
#line 21 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                      () => Movie.Trailer

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "<label>Release Date:</label>\n        ");
                __builder2.OpenElement(47, "div");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateInputDate_3(__builder2, 48, 49, "form-control", 50, 
#nullable restore
#line 27 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                          Movie.ReleaseDate

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.ReleaseDate = __value, Movie.ReleaseDate)), 52, () => Movie.ReleaseDate);
                __builder2.AddMarkupContent(53, "\n            ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateValidationMessage_4(__builder2, 54, 55, 
#nullable restore
#line 28 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                      () => Movie.ReleaseDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.OpenComponent<BlazorMovies.Client.Shared.InputImg>(59);
                __builder2.AddAttribute(60, "Label", "Picture");
                __builder2.AddAttribute(61, "OnSelectedImage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 32 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                   PosterSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(62, "ImageURL", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                                              imageURL

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\n\n    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group form-markdown");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateInputMarkdown_5(__builder2, 66, 67, "Summary", 68, 
#nullable restore
#line 38 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                              () => Movie.Summary

#line default
#line hidden
#nullable disable
                , 69, 
#nullable restore
#line 36 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                    Movie.Summary

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Summary = __value, Movie.Summary)), 71, () => Movie.Summary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n\n    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.AddMarkupContent(75, "<label>Genres:</label>\n        ");
                __builder2.OpenElement(76, "div");
                __builder2.OpenComponent<BlazorMovies.Client.Shared.MultipleSelector>(77);
                __builder2.AddAttribute(78, "Selected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Client.Helpers.MultipleSelectorModel>>(
#nullable restore
#line 44 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                        Selected

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "NoSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Client.Helpers.MultipleSelectorModel>>(
#nullable restore
#line 44 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                              NotSelected

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "<label>Actors:</label>\n        ");
                __builder2.OpenElement(84, "div");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateMultipleSelectorTypeahead_6(__builder2, 85, 86, 
#nullable restore
#line 52 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                     SearchMethod

#line default
#line hidden
#nullable disable
                , 87, 
#nullable restore
#line 52 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                                                     SelectedActors

#line default
#line hidden
#nullable disable
                , 88, (person) => (__builder3) => {
                    __builder3.OpenElement(89, "img");
                    __builder3.AddAttribute(90, "style", "width: 50px;");
                    __builder3.AddAttribute(91, "src", 
#nullable restore
#line 54 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                    person.Picture

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\n                    ");
                    __builder3.AddContent(93, 
#nullable restore
#line 55 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                     person.Name

#line default
#line hidden
#nullable disable
                    );
                }
                , 94, (person) => (__builder3) => {
                    __builder3.AddContent(95, 
#nullable restore
#line 58 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                     person.Name

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\n\n    ");
                __builder2.AddMarkupContent(97, "<button class=\"btn btn-primary\" type=\"submit\">Save Changes</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Genre> SelectedGenres { get; set; } = new List<Genre>();
    [Parameter] public List<Genre> NotSelectedGenres { get; set; } = new List<Genre>();
    [Parameter] public List<Person> SelectedActors { get; set; } = new List<Person>();

    private List<MultipleSelectorModel> Selected = new List<MultipleSelectorModel>();
    private List<MultipleSelectorModel> NotSelected = new List<MultipleSelectorModel>();

    private string imageURL;

    protected override void OnInitialized()
    {
        Selected = SelectedGenres.Select(x => new MultipleSelectorModel(x.Id.ToString(), x.Name)).ToList();
        NotSelected = NotSelectedGenres.Select(x => new MultipleSelectorModel(x.Id.ToString(), x.Name)).ToList();

        if (!string.IsNullOrEmpty(Movie.Poster))
        {
            imageURL = Movie.Poster;
            Movie.Poster = null;
        }
    }

    private void PosterSelected(string imageBase64)
    {
        Movie.Poster = imageBase64;
        imageURL = null;
        Console.WriteLine(imageBase64);
    }

    private async Task<IEnumerable<Person>> SearchMethod(string searchText)
    {
        return new List<Person>() {
            new Person() { Id= 1, Name = "Tom Holland", Picture = "https://m.media-amazon.com/images/M/MV5BNTAzMzA3NjQwOF5BMl5BanBnXkFtZTgwMDUzODQ5MTI@._V1_UY317_CR23,0,214,317_AL_.jpg" },
             new Person() {Id = 2, Name = "Tom Hanks", Picture = "https://m.media-amazon.com/images/M/MV5BMTQ2MjMwNDA3Nl5BMl5BanBnXkFtZTcwMTA2NDY3NQ@@._V1_UY317_CR2,0,214,317_AL_.jpg" }
        };
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputMarkdown_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<global::System.String>> __arg4)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.InputMarkdown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMultipleSelectorTypeahead_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<T>>> __arg0, int __seq1, global::System.Collections.Generic.List<T> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.MultipleSelectorTypeahead<T>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "SelectedElements", __arg1);
        __builder.AddAttribute(__seq2, "MyResultTemplate", __arg2);
        __builder.AddAttribute(__seq3, "MyListTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
