#pragma checksum "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\GetPizzaInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb673e9e9492e1f0f8b60e1af9b1484dbafb0e4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_GetPizzaInfo), @"mvc.1.0.view", @"/Views/Pizza/GetPizzaInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/GetPizzaInfo.cshtml", typeof(AspNetCore.Views_Pizza_GetPizzaInfo))]
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
#line 1 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\_ViewImports.cshtml"
using PizzaOrderingUI;

#line default
#line hidden
#line 2 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\_ViewImports.cshtml"
using PizzaOrderingUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb673e9e9492e1f0f8b60e1af9b1484dbafb0e4b", @"/Views/Pizza/GetPizzaInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f1b0c13287050f31df2b1eb1b9674d70f33aae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_GetPizzaInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\GetPizzaInfo.cshtml"
  
    ViewData["Title"] = "GetPizzaInfo";

#line default
#line hidden
            BeginContext(75, 3299, true);
            WriteLiteral(@"
<h2>Create Pizza</h2>



<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-6"">
 
            <div class=""form-group"">
              
                <div id=""toppingList"">
                 </div>
                

            </div>
            <div>
                <button class=""btn btn-default"" id=""getPizzaInfo"">GetTopping</button>
            </div>
            
        </div>

    </div>
</div>

<script>

    $(document).ready(function (e) {
        var url = ""http://localhost:54241/api/Pizzas/""
        //change to your url, same for other view.
        $.ajax({
            contentType: 'application/json',
            type: ""GET"",
            url: url,
            success: function (data, textStatus, jqXHR) {
                //Size
                  $(""#toppingList"").append(""<h2>Size:</h2>"");
                  for (var item of Object.values(data.sizes)) {
                    $(""#toppingList"").append(""<input type='radio' name='size' />"");
    ");
            WriteLiteral(@"                $(""#toppingList"").append(`<label>${item.sizeName}($${item.price})</label>`);
                    }
                //Crust
                    $(""#toppingList"").append(""<h2>Crust:</h2>"");
                  for (var item of Object.values(data.crusts)) {
                    $(""#toppingList"").append(""<input type='radio' name='crust' />"");
                    $(""#toppingList"").append(`<label>${item.crustName}($${item.price})</label>`);
                }
                //Sauce
                    $(""#toppingList"").append(""<h2>Sauce:</h2>"");
                  for (var item of Object.values(data.sauces)) {
                    $(""#toppingList"").append(""<input type='radio' name='sauce' />"");
                    $(""#toppingList"").append(`<label>${item.sauceName}($${item.price})</label>`);
                }
                  console.log(data);
                 //Sauce Amount
                    $(""#toppingList"").append(""<h2>Sauce Amount:</h2>"");
                  for (var item of Object");
            WriteLiteral(@".values(data.sauceAmounts)) {
                    $(""#toppingList"").append(""<input type='radio' name='sauceAmount' />"");
                    $(""#toppingList"").append(`<label>${item.amount}($${item.price})</label>`);
                }

                   //Cheese Amount
                    $(""#toppingList"").append(""<h2>Cheese Amount:</h2>"");
                  for (var item of Object.values(data.cheeseAmounts)) {
                    $(""#toppingList"").append(""<input type='radio' name='cheeseAmount' />"");
                    $(""#toppingList"").append(`<label>${item.amount}($${item.price})</label>`);
                   }

                 //Toppings

                    $(""#toppingList"").append(""<h2>Toppings:</h2>"");
                  for (var item of Object.values(data.toppings)) {
                    $(""#toppingList"").append(""<input type='checkbox' />"");
                    $(""#toppingList"").append(`<label>${item.toppingName}($${item.toppingPrice})</label>`);
                   }
              ");
            WriteLiteral("\r\n\r\n              \r\n              \r\n            },\r\n            error: function (jqXHR, textStatus, errorThrown) {\r\n                $(\"#getToppingResult\").val(jqXHR.statusText);\r\n            }\r\n        });\r\n    });\r\n\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
