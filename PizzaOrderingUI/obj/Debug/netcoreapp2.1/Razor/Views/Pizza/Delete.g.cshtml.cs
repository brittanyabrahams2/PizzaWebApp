#pragma checksum "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86a57205b17eac22443db430867a63d8fcd7c120"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Delete), @"mvc.1.0.view", @"/Views/Pizza/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/Delete.cshtml", typeof(AspNetCore.Views_Pizza_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a57205b17eac22443db430867a63d8fcd7c120", @"/Views/Pizza/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f1b0c13287050f31df2b1eb1b9674d70f33aae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Pizza>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePizzaIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(65, 173, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Pizza</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(239, 41, false);
#line 14 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(280, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(342, 37, false);
#line 17 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(379, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(440, 42, false);
#line 20 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SizeId));

#line default
#line hidden
            EndContext();
            BeginContext(482, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(544, 38, false);
#line 23 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SizeId));

#line default
#line hidden
            EndContext();
            BeginContext(582, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(643, 44, false);
#line 26 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(687, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(749, 40, false);
#line 29 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(789, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(850, 44, false);
#line 32 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Topping2));

#line default
#line hidden
            EndContext();
            BeginContext(894, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(956, 40, false);
#line 35 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Topping2));

#line default
#line hidden
            EndContext();
            BeginContext(996, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1057, 44, false);
#line 38 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Topping3));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1163, 40, false);
#line 41 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Topping3));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1264, 44, false);
#line 44 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Topping4));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1370, 40, false);
#line 47 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Topping4));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1471, 44, false);
#line 50 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Topping5));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1577, 40, false);
#line 53 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Topping5));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1651, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a984d56d837466a9c0c0a1d50319310", async() => {
                BeginContext(1677, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1687, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7236cd02b97b485fbf0b2103803bbb58", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 58 "C:\Users\z8410\Desktop\copyPizzaOrderingAPI\PizzaOrderingAPI\PizzaOrderingUI\Views\Pizza\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PizzaId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1728, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1811, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65485de95f8b4bf0a3bf5011907f750a", async() => {
                    BeginContext(1844, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1860, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1873, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Pizza> Html { get; private set; }
    }
}
#pragma warning restore 1591
