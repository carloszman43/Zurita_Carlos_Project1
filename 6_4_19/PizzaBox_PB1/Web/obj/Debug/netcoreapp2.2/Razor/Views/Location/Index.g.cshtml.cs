#pragma checksum "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cba4234b40807451c8b40ba226b73fc159572a42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_Index), @"mvc.1.0.view", @"/Views/Location/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Location/Index.cshtml", typeof(AspNetCore.Views_Location_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba4234b40807451c8b40ba226b73fc159572a42", @"/Views/Location/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.Models.Location>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UsersPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int num = 1;
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
            BeginContext(150, 24, true);
            WriteLiteral("\r\n<h1>Locations</h1>\r\n\r\n");
            EndContext();
            BeginContext(232, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(317, 39, false);
#line 18 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Num));

#line default
#line hidden
            EndContext();
            BeginContext(356, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(483, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(518, 43, false);
#line 24 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Street1));

#line default
#line hidden
            EndContext();
            BeginContext(561, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(617, 43, false);
#line 27 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Street2));

#line default
#line hidden
            EndContext();
            BeginContext(660, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(716, 40, false);
#line 30 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(756, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(812, 41, false);
#line 33 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(853, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(909, 43, false);
#line 36 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(952, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1008, 43, false);
#line 39 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Zipcode));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 45 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1169, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1218, 3, false);
#line 48 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(1221, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
                  num++;

#line default
#line hidden
            BeginContext(1250, 19, true);
            WriteLiteral("            </td>\r\n");
            EndContext();
            BeginContext(1374, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(1409, 42, false);
#line 55 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Street1));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1507, 42, false);
#line 58 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Street2));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1605, 39, false);
#line 61 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1700, 40, false);
#line 64 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1796, 42, false);
#line 67 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1838, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1894, 42, false);
#line 70 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Zipcode));

#line default
#line hidden
            EndContext();
            BeginContext(1936, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1991, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cba4234b40807451c8b40ba226b73fc159572a4210678", async() => {
                BeginContext(2048, 5, true);
                WriteLiteral("Users");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-lid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
                                            WriteLiteral(item.Locationid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-lid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2057, 21, true);
            WriteLiteral(" | \r\n                ");
            EndContext();
            BeginContext(2078, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cba4234b40807451c8b40ba226b73fc159572a4213029", async() => {
                BeginContext(2133, 8, true);
                WriteLiteral("New User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-luid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
                                          WriteLiteral(item.Locationid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["luid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-luid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["luid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2648, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 84 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2685, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.Models.Location>> Html { get; private set; }
    }
}
#pragma warning restore 1591
