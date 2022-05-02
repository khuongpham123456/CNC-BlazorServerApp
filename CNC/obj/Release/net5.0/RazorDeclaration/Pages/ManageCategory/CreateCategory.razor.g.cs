// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CNC.Pages.ManageCategory
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
#line 2 "C:\Users\ASUS\Downloads\cnc-master\CNC\Pages\ManageCategory\CreateCategory.razor"
using CNC.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Category/Create")]
    public partial class CreateCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\ASUS\Downloads\cnc-master\CNC\Pages\ManageCategory\CreateCategory.razor"
      
    private readonly CNC.Entities.Category category = new CNC.Entities.Category();
    protected override void OnInitialized()
    {

    }
    private async void Save_Click()
    {
        
        int count = CategoryService.CountCategoryFromName(category.Name);
        if (count != 0)
        {
            await JSRuntime.InvokeAsync<string>("alert", "This name of category already exists");
            return;
        }
        else
        {
            int id = int.Parse( CategoryService.TakeLastIDCategory() );
            Category newcategory = new Category();
            newcategory.Id =  (id+1).ToString();
            newcategory.Name = category.Name;
            newcategory.Status = 0;
            CategoryService.addCategory(newcategory);
            await JSRuntime.InvokeAsync<string>("alert", "Add new category success");
            NavigationManager.NavigateTo("/Category");
            return;
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591