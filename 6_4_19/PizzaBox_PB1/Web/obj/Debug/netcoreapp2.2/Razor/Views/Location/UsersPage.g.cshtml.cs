#pragma checksum "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cd2793a4f0b25d107004d2fac893e20fec99670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_UsersPage), @"mvc.1.0.view", @"/Views/Location/UsersPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Location/UsersPage.cshtml", typeof(AspNetCore.Views_Location_UsersPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd2793a4f0b25d107004d2fac893e20fec99670", @"/Views/Location/UsersPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_UsersPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateSignIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
  
    ViewData["Title"] = "UsersPage";
    int numu = 1;
    ViewBag.Title = "Index";
    var LID = ViewBag.LID;
    var LIDName = ViewBag.LIDName;

#line default
#line hidden
            BeginContext(197, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(204, 7, false);
#line 11 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
Write(LIDName);

#line default
#line hidden
            EndContext();
            BeginContext(211, 13, true);
            WriteLiteral(" Users</h1>\r\n");
            EndContext();
            BeginContext(243, 9, true);
            WriteLiteral("<p>\r\n    ");
            EndContext();
            BeginContext(252, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd2793a4f0b25d107004d2fac893e20fec996704888", async() => {
                BeginContext(295, 8, true);
                WriteLiteral("Register");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-luid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
                              WriteLiteral(LID);

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
            BeginContext(307, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(400, 40, false);
#line 20 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Numu));

#line default
#line hidden
            EndContext();
            BeginContext(440, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(571, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(606, 44, false);
#line 26 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(650, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(783, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(818, 45, false);
#line 32 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(863, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(919, 44, false);
#line 35 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(963, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(1166, 65, true);
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
         foreach (var item in Model)
        {
            if (item.Ulocationid == LID)
            {

#line default
#line hidden
            BeginContext(1337, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1410, 4, false);
#line 53 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
                   Write(numu);

#line default
#line hidden
            EndContext();
            BeginContext(1414, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
                          numu++;

#line default
#line hidden
            BeginContext(1452, 27, true);
            WriteLiteral("                    </td>\r\n");
            EndContext();
            BeginContext(1612, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1663, 43, false);
#line 60 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(1870, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1921, 44, false);
#line 66 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2045, 43, false);
#line 69 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(2088, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(2359, 26, true);
            WriteLiteral("                    <td>\r\n");
            EndContext();
            BeginContext(2652, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2676, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd2793a4f0b25d107004d2fac893e20fec9967012052", async() => {
                BeginContext(2737, 7, true);
                WriteLiteral("Sign In");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-signinid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
                                                            WriteLiteral(item.Userid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["signinid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-signinid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["signinid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2748, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3052, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 87 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\UsersPage.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(3128, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(3154, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd2793a4f0b25d107004d2fac893e20fec9967014848", async() => {
                BeginContext(3176, 9, true);
                WriteLiteral("Locations");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3189, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
