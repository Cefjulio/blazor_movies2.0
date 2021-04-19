#pragma checksum "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e49d6d52ff9b8a7e1f07da4f591e4b3c8833d938"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
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
#nullable restore
#line 3 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class CustomTypeahead<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "blazored-typeahead");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "blazored-typeahead__controls");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "blazored-typeahead__input");
            __builder.AddAttribute(7, "autocomplete", "off");
            __builder.AddAttribute(8, "placeholder", 
#nullable restore
#line 11 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
                             Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
                          ShowSuggestions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
                            onfocusout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
                             SearchText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchText = __value, SearchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
     if (IsSearching)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<div class=\"blazored-typeahead__results\"><div class=\"blazored-typeahead__result\"><span>Loading...</span></div></div>");
#nullable restore
#line 24 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
    }
    else if (ShouldShowSuggestions())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "blazored-typeahead__results");
#nullable restore
#line 28 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
             foreach (var item in Suggestions)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "blazored-typeahead__result");
            __builder.AddAttribute(18, "tabindex", "0");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
                                              () => SelectSuggestion(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
                                   OnmouseoverSuggestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
                                                                       OnmouseoutSuggestion

#line default
#line hidden
#nullable disable
            ));
            __builder.SetKey(
#nullable restore
#line 30 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
                           item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, 
#nullable restore
#line 33 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
                     ResultTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
    }
    else if (ShowNotFound())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "blazored-typeahead__results");
#nullable restore
#line 41 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
             if (NotFoundTemplate != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "blazored-typeahead__notfound");
            __builder.AddContent(27, 
#nullable restore
#line 44 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
                     NotFoundTemplate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<div class=\"blazored-typeahead__notfound\">\n                    No Results Found\n                </div>");
#nullable restore
#line 52 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\auyon.j6356\source\repos\Start\BlazorMovies\BlazorMovies\Client\Shared\CustomTypeahead.razor"
       
    [Parameter] public string Placeholder { get; set; }
    [Parameter] public int MinimumLength { get; set; } = 3;
    [Parameter] public int Debounce { get; set; } = 300;
    [Parameter] public Func<string, Task<IEnumerable<TItem>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<TItem> ResultTemplate { get; set; }
    [Parameter] public RenderFragment NotFoundTemplate { get; set; }
    [Parameter] public EventCallback<TItem> ValueChanged { get; set; }

    private bool IsSearching = false;
    private bool IsShowingSuggestions = false;
    private string _searchText = string.Empty;
    private Timer _debounceTimer;
    protected TItem[] Suggestions { get; set; } = new TItem[0];

    protected override void OnInitialized()
    {
        _debounceTimer = new Timer();
        _debounceTimer.Interval = Debounce;
        _debounceTimer.AutoReset = false;
        _debounceTimer.Elapsed += Search;

        base.OnInitialized();
    }

    private bool ShowNotFound()
    {
        return !Suggestions.Any() && IsShowingSuggestions;
    }

    private async Task SelectSuggestion(TItem item)
    {
        SearchText = "";
        await ValueChanged.InvokeAsync(item);
    }

    protected async void Search(Object source, ElapsedEventArgs e)
    {
        IsSearching = true;
        IsShowingSuggestions = false;
        await InvokeAsync(StateHasChanged);

        Suggestions = (await SearchMethod.Invoke(_searchText)).ToArray();

        IsSearching = false;
        IsShowingSuggestions = true;
        await InvokeAsync(StateHasChanged);
    }

    private string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;

            if (value.Length == 0)
            {
                IsShowingSuggestions = false;
                _debounceTimer.Stop();
                Suggestions = new TItem[0];
            }
            else if (value.Length >= MinimumLength)
            {
                _debounceTimer.Stop();
                _debounceTimer.Start();
            }
        }
    }

    private bool ShouldShowSuggestions()
    {
        return IsShowingSuggestions && Suggestions.Any();
    }

    private void ShowSuggestions()
    {
        if (Suggestions.Any())
        {
            IsShowingSuggestions = true;
        }
    }

    private void onfocusout()
    {
        if (!IsMouseInSuggestion)
        {
            IsShowingSuggestions = false;
        }
    }

    bool IsMouseInSuggestion = false;

    private void OnmouseoverSuggestion()
    {
        IsMouseInSuggestion = true;
    }

    private void OnmouseoutSuggestion()
    {
        IsMouseInSuggestion = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
