#pragma checksum "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5695ec48a9bfd87670d78507aae5081637c5d33"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.People
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class IndexPeople : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Index People</h3>\n\n\n");
            __Blazor.BlazorMovies.Client.Pages.People.IndexPeople.TypeInference.CreateGenericList_0(__builder, 1, 2, 
#nullable restore
#line 7 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                   People

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table table-striped");
                __builder2.AddMarkupContent(6, "<thead><tr><th></th>\n                    <th>Name</th></tr></thead>\n            ");
                __builder2.OpenElement(7, "tbody");
#nullable restore
#line 17 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                 foreach (var item in People)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "tr");
                __builder2.OpenElement(9, "td");
                __builder2.AddMarkupContent(10, "<a class=\"btn btn-success\">Edit</a>\n                            ");
                __builder2.AddMarkupContent(11, "<button class=\"btn btn-danger\">Delete</button>\n                        ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 23 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                             item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 26 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.AddMarkupContent(14, "\n\n");
            __builder.AddMarkupContent(15, "<div class=\"form-group\"><a class=\"btn btn-info\" href=\"person/create\">New Person</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor"
       

    List<Person> People;

    protected override async Task OnInitializedAsync()
    {

        try
        {
            People = await personRepository.GetPeople();
        }
        catch (Exception ex)
        {

        }






    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepository personRepository { get; set; }
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.People.IndexPeople
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
