#pragma checksum "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Customer\DeleteCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b108457c5e77c20c67ca2f1ad88cd5d02a512343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_DeleteCustomer), @"mvc.1.0.view", @"/Views/Customer/DeleteCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/DeleteCustomer.cshtml", typeof(AspNetCore.Views_Customer_DeleteCustomer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b108457c5e77c20c67ca2f1ad88cd5d02a512343", @"/Views/Customer/DeleteCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f1b0c13287050f31df2b1eb1b9674d70f33aae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_DeleteCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Customer\DeleteCustomer.cshtml"
  
    ViewData["Title"] = "DeleteCustomer";

#line default
#line hidden
            BeginContext(52, 1232, true);
            WriteLiteral(@"
<h2>DeleteCustomer</h2>


<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-6"">
            <h2>Delete a Person</h2>
            <div class=""form-group"">
                <label for=""id"">Id</label>
                <input type=""text"" class=""form-control"" id=""id"" />
            </div>
            <div>
                <button class=""btn btn-default"" id=""deleteperson"">Delete</button>
            </div>
            <div>
                <input type=""text"" class=""form-control"" id=""deleteResult"" />
            </div>
        </div>

    </div>
</div>

<script>

    $('#deleteperson').click(function (e) {
        $(""#deleteResult"").val("""");
        var url = ""http://localhost:54241/api/Customers/"" + $(""#id"").val();

        $.ajax({
            contentType: 'application/json',
            type: ""Delete"",
            url: url,
            success: function (data, textStatus, jqXHR) {
                $(""#deleteResult"").val(""Succeed"");
                $(""#delete");
            WriteLiteral("person\").val(\"\");\r\n            },\r\n            error: function (jqXHR, textStatus, errorThrown) {\r\n                $(\"#deleteResult\").val(jqXHR.statusText);\r\n            }\r\n        });\r\n    });\r\n\r\n</script>\r\n");
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
