// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/search")]
    public partial class MovieFilter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
       
    private List<Movie> Movies;
    string title = "";
    string selectedGenre = "0";
    bool upcomingReleases = false;
    bool inTheaters = false;
    private List<Genre> Genres = new List<Genre>() { new Genre() { Id = 1, Name = "Action"},
    new Genre(){Id = 2, Name = "Comedy"}};

    protected override void OnInitialized()
    {
        Movies = repository.GetMovies();
    }

    private void SearchForMovies()
    {
        Movies = repository.GetMovies().Where(x => x.Title.Contains(title)).ToList();
        Console.WriteLine($"title: {title}");
        Console.WriteLine($"selectedGenre: {selectedGenre}");
        Console.WriteLine($"upcomingReleases: {upcomingReleases}");
        Console.WriteLine($"inTheaters: {inTheaters}");
    }

    private void Clear()
    {
        Movies = repository.GetMovies();
        title = "";
        selectedGenre = "0";
        upcomingReleases = false;
        inTheaters = false;
    }

    private void TitleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            SearchForMovies();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
