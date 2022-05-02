// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CNC.Pages.ManageEmployee
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\Downloads\cnc-master\CNC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Downloads\cnc-master\CNC\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Downloads\cnc-master\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Downloads\cnc-master\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Downloads\cnc-master\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Downloads\cnc-master\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\Downloads\cnc-master\CNC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\Downloads\cnc-master\CNC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\Downloads\cnc-master\CNC\_Imports.razor"
using CNC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\Downloads\cnc-master\CNC\_Imports.razor"
using CNC.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Downloads\cnc-master\CNC\Pages\ManageEmployee\IndexEmployee.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\ASUS\Downloads\cnc-master\CNC\Pages\ManageEmployee\IndexEmployee.razor"
       
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