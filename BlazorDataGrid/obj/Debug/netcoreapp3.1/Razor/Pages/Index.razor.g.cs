#pragma checksum "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1881bcf96cbad82cb5dc93dc2c0548b48c9a57d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDataGrid.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using BlazorDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using BlazorDataGrid.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\_Imports.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
using Blazored.Menu;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Blazored Menu Demo</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-2");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<h3>Menu - 1:</h3>\r\n    ");
            __builder.OpenComponent<Blazored.Menu.BlazoredMenu>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Blazored.Menu.BlazoredMenuItem>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
                    __builder3.AddAttribute(12, "href", "/");
                    __builder3.AddAttribute(13, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(15, "Home");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Blazored.Menu.BlazoredSubMenu>(18);
                __builder2.AddAttribute(19, "Header", "Sub Menu");
                __builder2.AddAttribute(20, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(21, "\r\n                Sub Menu\r\n            ");
                }
                ));
                __builder2.AddAttribute(22, "MenuTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(23, "\r\n                ");
                    __builder3.OpenComponent<Blazored.Menu.BlazoredMenuItem>(24);
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(26, "\r\n                    ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
                        __builder4.AddAttribute(28, "href", "counter");
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(30, "Counter");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(31, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n                ");
                    __builder3.OpenComponent<Blazored.Menu.BlazoredMenuItem>(33);
                    __builder3.AddAttribute(34, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(36, "\r\n                    ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
                        __builder4.AddAttribute(38, "href", "fetchdata");
                        __builder4.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(40, "Fetch Data");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n\r\n    ");
            __builder.AddMarkupContent(45, "<h3>Menu - 2:</h3>\r\n    ");
            __builder.OpenComponent<Blazored.Menu.BlazoredMenu>(46);
            __builder.AddAttribute(47, "MenuBuilder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Menu.MenuBuilder>(
#nullable restore
#line 28 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                menuBuilder

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n");
            __builder.AddMarkupContent(50, "<h1>Blazor Date Range Picker Demo</h1>\r\n");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col-3");
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.OpenComponent<BlazorDateRangePicker.DateRangePicker>(54);
            __builder.AddAttribute(55, "OnRangeSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorDateRangePicker.DateRange>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorDateRangePicker.DateRange>(this, 
#nullable restore
#line 33 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                    OnRangeSelect

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n    <br>\r\n    ");
            __builder.OpenComponent<BlazorDateRangePicker.DateRangePicker>(57);
            __builder.AddAttribute(58, "placeholder", "Select dates...");
            __builder.AddAttribute(59, "OnRangeSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorDateRangePicker.DateRange>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorDateRangePicker.DateRange>(this, 
#nullable restore
#line 35 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                                                  OnRangeSelect

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n    <br>\r\n    ");
            __builder.OpenComponent<BlazorDateRangePicker.DateRangePicker>(61);
            __builder.AddAttribute(62, "MinDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 37 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                              DateTimeOffset.Now.AddYears(-10)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "MaxDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 37 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                                                         DateTimeOffset.Now

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n    <br>\r\n    ");
            __builder.OpenComponent<BlazorDateRangePicker.DateRangePicker>(65);
            __builder.AddAttribute(66, "StartDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 39 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                      StartDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "StartDateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTimeOffset?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTimeOffset?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StartDate = __value, StartDate))));
            __builder.AddAttribute(68, "EndDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 39 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                                                EndDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "EndDateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTimeOffset?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTimeOffset?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EndDate = __value, EndDate))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n    <br>\r\n    ");
            __builder.OpenComponent<BlazorDateRangePicker.DateRangePicker>(71);
            __builder.AddAttribute(72, "OnRangeSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorDateRangePicker.DateRange>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorDateRangePicker.DateRange>(this, 
#nullable restore
#line 41 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                    OnRangeSelect

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(73, "PickerTemplate", (Microsoft.AspNetCore.Components.RenderFragment<BlazorDateRangePicker.DateRangePicker>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "id", 
#nullable restore
#line 43 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                      context.ParentId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                                  context.Toggle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "style", "background:#fff;cursor:pointer;padding:5px 10px; width:250px; border:1px solid #ccc;");
                __builder2.AddMarkupContent(79, "\r\n                <i class=\"oi oi-calendar\"></i>&nbsp;\r\n                ");
                __builder2.OpenElement(80, "span");
                __builder2.AddContent(81, 
#nullable restore
#line 45 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                       context.FormattedRange

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(82, " ");
                __builder2.AddContent(83, 
#nullable restore
#line 45 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
                                                string.IsNullOrEmpty(context.FormattedRange)?"Choose dates...":""

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                <i class=\"oi oi-chevron-bottom float-right\"></i>\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\kouge\source\repos\Blazor\BlazorDataGrid\BlazorDataGrid\Pages\Index.razor"
      
    MenuBuilder menuBuilder = new MenuBuilder();

    protected override async Task OnInitializedAsync()
    {
        menuBuilder.AddItem(1, "Home", "/")
            .AddSubMenu(2, "Sub Menu", new MenuBuilder()
            .AddItem(1, "Counter", "counter")
            .AddItem(2, "FetchData", "fetchdata"));
    }

    DateTimeOffset? StartDate { get; set; } = DateTime.Today.AddMonths(-1);
    DateTimeOffset? EndDate { get; set; } = DateTime.Today.AddDays(1).AddTicks(-1);

    public void OnRangeSelect(DateRange range)
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
