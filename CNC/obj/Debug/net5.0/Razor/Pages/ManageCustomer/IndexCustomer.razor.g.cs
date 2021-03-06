#pragma checksum "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed835ba7499f7a9751e9cfa0ba9d63dded2e0996"
// <auto-generated/>
#pragma warning disable 1591
namespace CNC.Pages.ManageCustomer
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Customer")]
    public partial class IndexCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Manage Customer</h3>");
#nullable restore
#line 6 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
 if ( _account.LongCount() == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
}
else 
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, @"<thead><tr><th>ID</th>
                <th>Name</th>
                <th>Phone</th>
                <th>Email</th>
                <th>Address</th>
                <th>Date</th>
                <th>Usename</th>
                <th>Block</th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 27 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
             foreach (var value in _account)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 30 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
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
#line 31 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
                         CustomerService.GetCustomerFromIdAccount(@value.Id).Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 32 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
                         CustomerService.GetCustomerFromIdAccount(@value.Id).Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
                         CustomerService.GetCustomerFromIdAccount(@value.Id).Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 34 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
                         CustomerService.GetCustomerFromIdAccount(@value.Id).Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
                         value.CreatedDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 36 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
                         value.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 37 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
                      if(@value.Status==0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "class", "btn btn-danger ");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
                                                                                       ()=>{AccountService.UpdateStatus(@value.Id,1);}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Block");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"

                    }else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "td");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-success");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
                                                                                       ()=>{AccountService.UpdateStatus(@value.Id,0);}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Action");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 45 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\Individual_Project\C#\cnc\CNC\Pages\ManageCustomer\IndexCustomer.razor"
       
    private IEnumerable<CNC.Entities.Customer> _customer;
    private IEnumerable<CNC.Entities.Account> _account;
    

    protected override void OnInitialized()
    {

        _account = AccountService.GetAllAccountCustomer();
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.IAccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.ICustomerService CustomerService { get; set; }
    }
}
#pragma warning restore 1591
