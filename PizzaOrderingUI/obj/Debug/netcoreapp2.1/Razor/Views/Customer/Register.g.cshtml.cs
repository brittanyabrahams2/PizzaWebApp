#pragma checksum "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Customer\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ba58bb07e56a645d5e7f89113e3c7061c5bd29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Register), @"mvc.1.0.view", @"/Views/Customer/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Register.cshtml", typeof(AspNetCore.Views_Customer_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ba58bb07e56a645d5e7f89113e3c7061c5bd29", @"/Views/Customer/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f1b0c13287050f31df2b1eb1b9674d70f33aae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Customer\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(46, 3390, true);
            WriteLiteral(@"
<h2>Register</h2>


<div class=""container"">
    <div class=""row"">
      
            <div class=""col-sm-6"">
                <h2>Create a new Person</h2>

                <div class=""form-group"">
                    <label for=""username"">Username:</label>
                    <input type=""text"" class=""form-control"" id=""username"" />
                </div>
                <div class=""form-group"">
                    <label for=""password"">Password:</label>
                    <input type=""password"" class=""form-control"" id=""password"" />
                </div>

                <div class=""form-group"">
                    <label for=""firstname"">First Name:</label>
                    <input type=""text"" class=""form-control"" id=""firstname"" />
                </div>
                <div class=""form-group"">
                    <label for=""lastname"">Last Name:</label>
                    <input type=""text"" class=""form-control"" id=""lastname"" />
                </div>


                <div cla");
            WriteLiteral(@"ss=""form-group"">
                    <label for=""address"">Address:</label>
                    <input type=""text"" class=""form-control"" id=""address"" />
                </div>
                <div class=""form-group"">
                    <label for=""state"">State:</label>
                    <input type=""text"" class=""form-control"" id=""state"" />
                </div>

                <div class=""form-group"">
                    <label for=""city"">City:</label>
                    <input type=""text"" class=""form-control"" id=""city"" />
                </div>

                <div class=""form-group"">
                    <label for=""zipcode"">Zipcode:</label>
                    <input type=""text"" class=""form-control"" id=""zipcode"" />
                </div>

                <div class=""form-group"">
                    <label for=""phoneno"">Phoneno:</label>
                    <input type=""text"" class=""form-control"" id=""phoneno"" />
                </div>




                <div>
                ");
            WriteLiteral(@"    <button class=""btn btn-default"" id=""create"">Create</button>
                </div>

                <div>
                    <input type=""text"" class=""form-control"" id=""postResult"" />
                </div>
              
            </div>
    </div>
</div>
<script>
    $('#create').click(function (e) {
        var url = ""http://localhost:54241/api/Customers/"";
        $.ajax({
            contentType: 'application/json',
            type: ""POST"",
            url: url,
            data: JSON.stringify({
                Username: $('#username').val(),
                Password: $('#password').val(),

                Firstname: $('#firstname').val(),
                Lastname: $('#lastname').val(),


                Address: $('#address').val(),
                State: $('#state').val(),
                City: $('#city').val(),
                Zip: $('#zipcode').val(),
                PhoneNo: $('#phoneno').val()

            }),

            success: function (data, textStatu");
            WriteLiteral(@"s, jqXHR) {
                $(""#postResult"").val(""Person created ok. Id="" + jqXHR.responseText);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $(""#postResult"").val(jqXHR.statusText);
                console.log(data);
            }
        });
    });
</script>");
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