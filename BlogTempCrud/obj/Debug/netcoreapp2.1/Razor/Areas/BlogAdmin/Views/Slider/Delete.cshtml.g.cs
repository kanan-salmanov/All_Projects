#pragma checksum "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e79d1a974089826908100ae139a5015f0a40b635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BlogAdmin_Views_Slider_Delete), @"mvc.1.0.view", @"/Areas/BlogAdmin/Views/Slider/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BlogAdmin/Views/Slider/Delete.cshtml", typeof(AspNetCore.Areas_BlogAdmin_Views_Slider_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e79d1a974089826908100ae139a5015f0a40b635", @"/Areas/BlogAdmin/Views/Slider/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a19138018ac9c5d5452aa2f6fe8e5ad52d9f78e", @"/Areas/BlogAdmin/Views/_ViewImports.cshtml")]
    public class Areas_BlogAdmin_Views_Slider_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Slider>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/BlogAdmin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(125, 188, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"widget-box\">\r\n        <div class=\"row\" style=\"margin-left:10px\">\r\n            <div class=\"col-12\">\r\n                <h3>");
            EndContext();
            BeginContext(314, 11, false);
#line 13 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Delete.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(325, 26, true);
            WriteLiteral("</h3>\r\n                <p>");
            EndContext();
            BeginContext(352, 17, false);
#line 14 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Delete.cshtml"
              Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(369, 26, true);
            WriteLiteral("</p>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 395, "\"", 427, 2);
            WriteAttributeValue("", 401, "/", 401, 1, true);
#line 15 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\Slider\Delete.cshtml"
WriteAttributeValue("", 402, Model.Image.Remove(0, 8), 402, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(428, 313, true);
            WriteLiteral(@" alt=""Alternate Text"" />
                <br />
                <br />
                <p class=""text-danger"">Are you sure delete this data?</p>
                <br />
            </div>
        </div>

        <div class=""row"" style=""margin-left:10px"">
            <div class=""col-12"">
                ");
            EndContext();
            BeginContext(741, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a7228942825441fb078e1c5d92e07b0", async() => {
                BeginContext(761, 101, true);
                WriteLiteral("\r\n                    <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(869, 164, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" style=\"margin-left:10px\">\r\n            <div class=\"col-12\">\r\n                <hr />\r\n                ");
            EndContext();
            BeginContext(1033, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74ff56bb0b604f2fbb546d6b12aff04a", async() => {
                BeginContext(1055, 39, true);
                WriteLiteral("<i class=\"icon-arrow-left\"></i> Go back");
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
            BeginContext(1098, 66, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Slider> Html { get; private set; }
    }
}
#pragma warning restore 1591