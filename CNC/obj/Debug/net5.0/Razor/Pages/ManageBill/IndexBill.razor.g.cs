#pragma checksum "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40d233e617253dd7ab657f173570cfa8bffa881a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Bill")]
    public partial class IndexBill : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Manage Bill</h3>");
#nullable restore
#line 5 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
 if (_bill.LongCount() == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>ID</th>\n                <th>Create date</th>\n                <th>Total</th>\n                <th>Voucher</th>\n                <th>User</th>\n                <th>Status</th>\n                <th>Detail</th></tr></thead>\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 24 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
             foreach (var value in _bill)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 27 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
                         value.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 28 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
                         value.CreatedDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
                         value.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
                         value.Voucher

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
                         CustomerService.GetCustomerFromIdUser(@value.UserId).Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
                     if(@value.StatusBill==0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "class", "btn btn-danger ");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
                                                                                       ()=>{BillService.UpdateStatus(@value.Id,1);}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "Chưa xác nhận");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"

                    }else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<td><button type=\"button\" class=\"btn btn-success \" disabled>Đã xác nhận</button></td>");
#nullable restore
#line 37 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", "Bill/BillDetail/" + (
#nullable restore
#line 39 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
                                                  value.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "detail");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageBill\IndexBill.razor"
       
    private IEnumerable<CNC.Entities.Bill> _bill;
    private IEnumerable<CNC.Entities.Voucher> _voucher;
    int _status = 0;
    protected override void OnInitialized()
    {
        _bill = BillService.getAllBills();
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.ICustomerService CustomerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.IBillService BillService { get; set; }
    }
}
#pragma warning restore 1591
