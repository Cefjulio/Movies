#pragma checksum "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a84f5b5221c2e9df4511f6ed29b8a48b5a37b314"
// <auto-generated/>
#pragma warning disable 1591
namespace InterviewApp_1._0.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using InterviewApp_1._0.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using InterviewApp_1._0.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\_Imports.razor"
using InterviewApp_1.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<InterviewApp_1._0.Client.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "<h3>Movie</h3>");
#nullable restore
#line 11 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\Pages\Index.razor"
     if (movies == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, " Loading....");
#nullable restore
#line 13 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\Pages\Index.razor"
                                 
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\Pages\Index.razor"
         foreach ( var movie in movies  )
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Title: ");
            __builder.OpenElement(9, "b");
            __builder.AddContent(10, 
#nullable restore
#line 19 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\Pages\Index.razor"
                           movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, " Release Date: ");
            __builder.OpenElement(14, "b");
            __builder.AddContent(15, 
#nullable restore
#line 20 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\Pages\Index.razor"
                                   movie.ReleaseDate.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\Pages\Index.razor"
         



    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\auyon.j6356\source\repos\InterviewApp_1.0\Client\Pages\Index.razor"
 
    string name = "Julia";

    List<Movie> movies;


    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(3000);

        movies = new List<Movie>()
        {
            new Movie(){ Title = "Spider Man: Far from Home", ReleaseDate = new DateTime(2019, 7, 2)  },
            new Movie(){ Title = "Moana", ReleaseDate = new DateTime(2019, 7, 2)  },
            new Movie(){ Title = "Pica Piedras", ReleaseDate = new DateTime(2019, 7, 2)  }
        };

    }










#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
