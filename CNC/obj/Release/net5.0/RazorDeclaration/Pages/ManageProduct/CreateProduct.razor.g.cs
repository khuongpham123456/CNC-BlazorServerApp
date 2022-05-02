// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CNC.Pages.ManageProduct
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
#line 2 "C:\Users\ASUS\Downloads\cnc-master\CNC\Pages\ManageProduct\CreateProduct.razor"
using CNC.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/Create")]
    public partial class CreateProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 226 "C:\Users\ASUS\Downloads\cnc-master\CNC\Pages\ManageProduct\CreateProduct.razor"
       

    private readonly CNC.Entities.Product _product = new CNC.Entities.Product();
    private IEnumerable<CNC.Entities.Category> _category;
    private IEnumerable<CNC.Entities.Size> _size;
    private IEnumerable<CNC.Entities.Color> _color;



    protected override void OnInitialized()
    {
        _category = CategoryService.getAllCategories();
        



        _size = SizeService.getAllSize();
        _color = ColorService.getAllColor();
    }
    private IEnumerable<CNC.Entities.Product> _prd;
    private async void Create_Click()
    {

        _prd = ProductService.getAllProducts();
        foreach(Product product in _prd)
        {
            if (_product.Name == product.Name)
            {
                await JSRuntime.InvokeAsync<string>("alert", "This name is exist");
                return;

            }
            else
            {
                int id = int.Parse( ProductService.getNewIdProduct() );
                string NameNewProduct = _product.Name;
                string CatagoryIdNewProduct = _product.CategoryId;
                int PriceNewProduct = _product.Price;
                string DescriptionNewProduct = _product.Description;
                CNC.Entities.Product newproduct = new CNC.Entities.Product();
                newproduct.Id = (id+1).ToString();
                newproduct.Name = NameNewProduct;
                newproduct.CategoryId = CatagoryIdNewProduct;
                newproduct.Price = PriceNewProduct;
                newproduct.Description = DescriptionNewProduct;
                ProductService.addProduct(newproduct);
                await JSRuntime.InvokeAsync<string>("alert", "Add new product");
                return;
            }
        }

        

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.IColorService ColorService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.ISizeService SizeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CNC.Service.IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591