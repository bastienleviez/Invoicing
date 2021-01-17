#pragma checksum "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59d7b18278bfd551cc42d245bdc176f48f7ff45f"
// <auto-generated/>
#pragma warning disable 1591
namespace Invoicing.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Invoicing.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Invoicing.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Invoicing.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/invoices")]
    public partial class InvoiceList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Invoices</h1>");
#nullable restore
#line 7 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
 if (allInvoices == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Interrogation du serveur...</p>");
#nullable restore
#line 10 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Reference</th>\r\n            <th>Date</th>\r\n            <th>Customer</th>\r\n            <th>Amount</th>\r\n            <th>Paid</th></tr></thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 25 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
         foreach (var invoice in allInvoices)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.AddAttribute(7, "onclick", "window.location.href=\'/api/Invoices/B1345\'");
            __builder.AddAttribute(8, "class", "table-" + (
#nullable restore
#line 27 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
                                                                               ColorFromInvoiceState(invoice)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 28 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
                 invoice.Reference

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 29 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
                 invoice.Created.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 30 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
                 invoice.Customer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "align", "right");
            __builder.AddContent(20, 
#nullable restore
#line 31 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
                               invoice.Amount.ToString("€ 0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "align", "right");
            __builder.AddContent(24, 
#nullable restore
#line 32 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
                               invoice.Paid.ToString("€ 0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n<button onclick=\"window.location.href=\'/api/Invoices/\'\"></button>");
#nullable restore
#line 38 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\InvoiceList.razor"
       

    static string ColorFromInvoiceState(Invoice invoice)
    {
        if (invoice.IsLate)
        {
            return "danger";
        }
        else if (invoice.IsPaid)
        {
            return "success";
        }
        else
        {
            return "default";
        }
    }

    private IEnumerable<Invoice> allInvoices = null;

    protected override async Task OnInitializedAsync()
    {
        allInvoices = await http.GetFromJsonAsync<IEnumerable<Invoice>>("api/invoices");        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
