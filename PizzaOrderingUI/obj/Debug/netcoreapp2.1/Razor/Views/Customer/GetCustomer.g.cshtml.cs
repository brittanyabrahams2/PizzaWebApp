#pragma checksum "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Customer\GetCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c627ccf9006cfc549f7afe09530f6b30ba897ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetCustomer), @"mvc.1.0.view", @"/Views/Customer/GetCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/GetCustomer.cshtml", typeof(AspNetCore.Views_Customer_GetCustomer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c627ccf9006cfc549f7afe09530f6b30ba897ca", @"/Views/Customer/GetCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f1b0c13287050f31df2b1eb1b9674d70f33aae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_GetCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Customer\GetCustomer.cshtml"
  
    ViewData["Title"] = "GetCustomer";

#line default
#line hidden
            BeginContext(49, 1349, true);
            WriteLiteral(@"
<h2>GetUsers</h2>

<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-6"">
            <h2>Get a Customer</h2>
            <div class=""form-group"">
                <label for=""id"">Id</label>
                <input type=""text"" class=""form-control"" id=""id"" />
            </div>
            <div>
                <button class=""btn btn-default"" id=""getCustomer"">GetCustomer</button>
            </div>
            <div>
                <p type=""text"" id=""getCustomerResult"" />
            </div>
        </div>

    </div>
</div>

<script>

    $('#getCustomer').click(function (e) {
        $(""#getCustomerResult"").val("""");
        var url = ""http://localhost:54241/api/Customers/"" + $(""#id"").val();
       //change to your url, same for other view.
        $.ajax({
            contentType: 'application/json',
            type: ""GET"",
            url: url,
            success: function (data, textStatus, jqXHR) {

              
                
                f");
            WriteLiteral(@"or (var item of Object.values(data)) {
                    $(""#getCustomerResult"").append(item + ""<br />"");
                }

            },
            error: function (jqXHR, textStatus, errorThrown) {
                $(""#getCustomerResult"").val(jqXHR.statusText);
            }
        });
    });

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591