#pragma checksum "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0edbc414baeab078fa8aa296dbfd65d0ca3db39d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_RedirectPage), @"mvc.1.0.view", @"/Views/Location/RedirectPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Location/RedirectPage.cshtml", typeof(AspNetCore.Views_Location_RedirectPage))]
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
#line 1 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0edbc414baeab078fa8aa296dbfd65d0ca3db39d", @"/Views/Location/RedirectPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_RedirectPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.Models.Pizza>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
  
    ViewData["Title"] = "RedirectPage";

#line default
#line hidden
            BeginContext(88, 36, true);
            WriteLiteral("\r\n<h1>RedirectPage</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(124, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0edbc414baeab078fa8aa296dbfd65d0ca3db39d3808", async() => {
                BeginContext(147, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(161, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(254, 40, false);
#line 16 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Nump));

#line default
#line hidden
            EndContext();
            BeginContext(294, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(350, 43, false);
#line 19 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Pizzaid));

#line default
#line hidden
            EndContext();
            BeginContext(393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(449, 40, false);
#line 22 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(489, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(545, 41, false);
#line 25 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(586, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(642, 40, false);
#line 28 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(682, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(738, 44, false);
#line 31 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Porderid));

#line default
#line hidden
            EndContext();
            BeginContext(782, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(838, 45, false);
#line 34 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingN1));

#line default
#line hidden
            EndContext();
            BeginContext(883, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(939, 45, false);
#line 37 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingN2));

#line default
#line hidden
            EndContext();
            BeginContext(984, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1040, 45, false);
#line 40 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingN3));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1141, 45, false);
#line 43 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingN4));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1242, 45, false);
#line 46 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingN5));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1405, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1454, 39, false);
#line 55 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nump));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1549, 42, false);
#line 58 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pizzaid));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1647, 39, false);
#line 61 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1742, 40, false);
#line 64 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(1782, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1838, 39, false);
#line 67 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1877, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1933, 43, false);
#line 70 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.Porderid));

#line default
#line hidden
            EndContext();
            BeginContext(1976, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2032, 44, false);
#line 73 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingN1));

#line default
#line hidden
            EndContext();
            BeginContext(2076, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2132, 44, false);
#line 76 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingN2));

#line default
#line hidden
            EndContext();
            BeginContext(2176, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2232, 44, false);
#line 79 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingN3));

#line default
#line hidden
            EndContext();
            BeginContext(2276, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2332, 44, false);
#line 82 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingN4));

#line default
#line hidden
            EndContext();
            BeginContext(2376, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2432, 44, false);
#line 85 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingN5));

#line default
#line hidden
            EndContext();
            BeginContext(2476, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2532, 65, false);
#line 88 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2597, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2618, 71, false);
#line 89 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2689, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2710, 69, false);
#line 90 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2779, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 93 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\RedirectPage.cshtml"
}

#line default
#line hidden
            BeginContext(2818, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.Models.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591
