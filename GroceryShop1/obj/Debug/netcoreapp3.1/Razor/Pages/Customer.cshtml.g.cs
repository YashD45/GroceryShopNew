#pragma checksum "C:\Users\SAI\OneDrive\Desktop\api\GroceryShop\Pages\Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64993473ad87876667420ac98ac7adb07cc09f74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Customer), @"mvc.1.0.razor-page", @"/Pages/Customer.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64993473ad87876667420ac98ac7adb07cc09f74", @"/Pages/Customer.cshtml")]
    public class Pages_Customer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container mt-5"">
    <div class=""row justify-content-center align-items-center"">
        <div class=""col-sm-12 col-md-12 col-lg-4"">
            <h1 class=""mb-3"">Register</h1>

            <form method=""post"">
                <div asp-validation-summary=""All"" class=""text-danger"">
                </div>

                <div class=""mb-3"">
                    <label class=""form-label"" asp-for=""Model.Email"">Email Address</label>
                    <input type=""text"" asp-for=""Model.Email"" class=""form-control"" />
                    <span asp-validation-for=""Model.Email"" class=""text-danger""></span>
                </div>
                <div class=""mb-3"">
                    <label class=""form-label"" asp-for=""Model.Password"">Password</label>
                    <input type=""text"" asp-for=""Model.Password"" class=""form-control"" />
                    <span asp-validation-for=""Model.Password"" class=""text-danger""></span>
                </div>
                <div class=""mb-3"">
         ");
            WriteLiteral(@"           <label class=""form-label"" asp-for=""Model.ConfermPassword"">Confirm Password</label>
                    <input type=""text"" asp-for=""Model.ConfermPassword"" class=""form-control"" />
                    <span asp-validation-for=""Model.ConfermPassword"" class=""text-danger""></span>
                </div>
                    <div class=""mb-3"">
                        <button type=""submit"" class=""btn btn-primary"">Register</button>
                    
                </div>
            </form>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroceryShop.Pages.CustomerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GroceryShop.Pages.CustomerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GroceryShop.Pages.CustomerModel>)PageContext?.ViewData;
        public GroceryShop.Pages.CustomerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
