#pragma checksum "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8a3a338f8ca2c0d10649c6ad8d1e0d92eaeb01f"
// <auto-generated/>
#pragma warning disable 1591
namespace CNC.Pages.ManageBill
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Individual_Project\C#\cnc\CNC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Individual_Project\C#\cnc\CNC\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Individual_Project\C#\cnc\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Individual_Project\C#\cnc\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Individual_Project\C#\cnc\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Individual_Project\C#\cnc\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Individual_Project\C#\cnc\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Individual_Project\C#\cnc\CNC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Individual_Project\C#\cnc\CNC\_Imports.razor"
using CNC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Individual_Project\C#\cnc\CNC\_Imports.razor"
using CNC.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Bill/BillDetail/{BillId}")]
    public partial class BillDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Manage Bill</h3>");
#nullable restore
#line 5 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
 if (_billdetail.LongCount() == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>ID Bill</th>\n                <th>Name product</th>\n                <th>Amout</th>\n                <th>Price</th>\n                <th>Total</th></tr></thead>\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 23 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
             foreach (var value in _billdetail)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 26 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
                         value.BillId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 27 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
                         ProductService.getProductFromId(@value.ProductId).Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 28 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
                         value.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 29 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
                         ProductService.getProductFromId(@value.ProductId).Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 30 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
                          value.Amount * ProductService.getProductFromId(@value.ProductId).Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\BillDetail.razor"
       
    [Parameter]
    public int BillId { get; set; }
    private IEnumerable<CNC.Entities.BillDetail> _billdetail;
    private IEnumerable<CNC.Entities.Product> _product;
   
    protected override void OnInitialized()
    {
        _billdetail =BillDetailService.GetBillDetailFromId(BillId);
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.IBillDetailService BillDetailService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
