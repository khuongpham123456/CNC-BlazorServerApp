#pragma checksum "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "029735dd2eb21c08f36102cd7115ba22af1fd29f"
// <auto-generated/>
#pragma warning disable 1591
namespace CNC.Pages.ManageEmployee
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\_Imports.razor"
using CNC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\_Imports.razor"
using CNC.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
using CNC.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employee")]
    public partial class IndexEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Manage Employee</h3>");
#nullable restore
#line 7 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
 if (_employee.LongCount() == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, @"<thead><tr><th>ID Employee</th>
                <th>Name</th>
                <th>Phone</th>
                <th>Email</th>
                <th>Address</th>
                <th>Create date</th>
                <th>Account Id</th>
                <th>user name</th>
                <th>Delete</th>
                <th>decentralization</th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 29 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
             foreach (var value in _employee)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 32 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
__builder.AddContent(8, value.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 33 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
__builder.AddContent(11, value.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 34 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
__builder.AddContent(14, value.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 35 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
__builder.AddContent(17, value.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 36 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
__builder.AddContent(20, value.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 37 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
__builder.AddContent(23, value.CreatedDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 38 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
__builder.AddContent(26, value.AccountId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
#nullable restore
#line 39 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
__builder.AddContent(29, AccountService.GetAccountFromAccountId(@value.AccountId).Username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-danger");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
                                                                 (()=> DeleteAccount(value))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "./Employee/Decentralization/" + (
#nullable restore
#line 41 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
                                                              value.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "decentralization");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\DELL\Documents\GitHub\CNC-BlazorServerApp\CNC\Pages\ManageEmployee\IndexEmployee.razor"
       
    private IEnumerable<CNC.Entities.Employee> _employee;
    private IEnumerable<CNC.Entities.Account> _account;
    int message = 0;

    protected override void OnInitialized()
    {
        _employee = EmployeeService.getAllEmployees();
        message++;
    }
    private async void DeleteAccount(Employee Employee)
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are You Delete Account {AccountService.GetAccountFromAccountId(Employee.AccountId).Username}"))
            return;/*nut huy*/
        AccountService.DeleteAccount(AccountService.GetAccountFromAccountId(Employee.AccountId));
        EmployeeService.DeleteEmployee(Employee);
        _employee = EmployeeService.getAllEmployees();

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.IAccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.IEmployeeService EmployeeService { get; set; }
    }
}
#pragma warning restore 1591