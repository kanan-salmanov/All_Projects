#pragma checksum "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12e87609487b7d0a8d171cbdfcdd78344cf77ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BlogAdmin_Views_Slider_Index), @"mvc.1.0.view", @"/Areas/BlogAdmin/Views/Slider/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BlogAdmin/Views/Slider/Index.cshtml", typeof(AspNetCore.Areas_BlogAdmin_Views_Slider_Index))]
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
#line 1 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\_ViewImports.cshtml"
using BlogTempCrud.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12e87609487b7d0a8d171cbdfcdd78344cf77ac", @"/Areas/BlogAdmin/Views/Slider/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a19138018ac9c5d5452aa2f6fe8e5ad52d9f78e", @"/Areas/BlogAdmin/Views/_ViewImports.cshtml")]
    public class Areas_BlogAdmin_Views_Slider_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Slider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateSlider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
  
    ViewData["Title"] = "Slider";

#line default
#line hidden
            BeginContext(70, 309, true);
            WriteLiteral(@"<div class=""row"" style=""margin-left:0px"">

    <div class=""col-12"">

        <div class=""widget-box"">

            <div class=""widget-title"">
                <span class=""icon""> <i class=""icon-th""></i> </span>
                <h5>Slider</h5>
                <span style=""float:right;padding:5px;""> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 379, "\"", 419, 1);
#line 14 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
WriteAttributeValue("", 386, Url.Action("AddSlider","Slider"), 386, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(420, 585, true);
            WriteLiteral(@" style=""border-radius:5px "" class=""btn btn-primary"">Add Slider</a></span>
            </div>
            <div class=""widget-content nopadding"">
                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Title</th>
                            <th>Description</th>
                            <th>Image</th>
                            <th>Edit</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 28 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                          int count = 1;

#line default
#line hidden
            BeginContext(1048, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 29 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                         foreach (var slider in Model)
                        {

#line default
#line hidden
            BeginContext(1131, 104, true);
            WriteLiteral("                            <tr class=\"odd gradeX\">\r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(1236, 5, false);
#line 32 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                                              Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1241, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1285, 12, false);
#line 33 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                               Write(slider.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1297, 45, true);
            WriteLiteral("</td>\r\n                                <td>\r\n");
            EndContext();
#line 35 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                                     if (slider.Description.Length > 40)
                                    {
                                        

#line default
#line hidden
            BeginContext(1497, 41, false);
#line 37 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                                    Write(slider.Description.Substring(0, 40)+"...");

#line default
#line hidden
            EndContext();
#line 37 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                                                                                    ;
                                    }
                                    else {
                                        

#line default
#line hidden
            BeginContext(1666, 18, false);
#line 40 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                                   Write(slider.Description);

#line default
#line hidden
            EndContext();
#line 40 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                                                           
                                    }

#line default
#line hidden
            BeginContext(1725, 83, true);
            WriteLiteral("\r\n\r\n                                </td>\r\n                                <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1808, "\"", 1841, 2);
            WriteAttributeValue("", 1814, "/", 1814, 1, true);
#line 45 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
WriteAttributeValue("", 1815, slider.Image.Remove(0, 8), 1815, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1842, 145, true);
            WriteLiteral(" style=\"max-height:200px\" alt=\"Alternate Text\" /></td>\r\n                                <td class=\"center\">\r\n                                    ");
            EndContext();
            BeginContext(1987, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6e5969595754242889f2d1513baa107", async() => {
                BeginContext(2061, 109, true);
                WriteLiteral("\r\n                                        <i class=\"icon-eye-open\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                                                              WriteLiteral(slider.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2174, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2212, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b33105bbcb84def912e976dd2a8e995", async() => {
                BeginContext(2291, 105, true);
                WriteLiteral("\r\n                                        <i class=\"icon-edit\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                                                                   WriteLiteral(slider.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2400, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2438, 182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf8a2afbc7ee4fc686abe29ccf7738f2", async() => {
                BeginContext(2510, 106, true);
                WriteLiteral("\r\n                                        <i class=\"icon-trash\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                                                             WriteLiteral(slider.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2620, 78, true);
            WriteLiteral("\r\n\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 59 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Index.cshtml"
                            count++;
                        }

#line default
#line hidden
            BeginContext(2763, 112, true);
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
