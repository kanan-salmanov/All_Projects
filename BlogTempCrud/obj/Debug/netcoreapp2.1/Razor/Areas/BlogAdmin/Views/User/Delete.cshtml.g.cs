#pragma checksum "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\User\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e66393310f1e44673233d41c3445e762c01d5fa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BlogAdmin_Views_User_Delete), @"mvc.1.0.view", @"/Areas/BlogAdmin/Views/User/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BlogAdmin/Views/User/Delete.cshtml", typeof(AspNetCore.Areas_BlogAdmin_Views_User_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66393310f1e44673233d41c3445e762c01d5fa6", @"/Areas/BlogAdmin/Views/User/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a19138018ac9c5d5452aa2f6fe8e5ad52d9f78e", @"/Areas/BlogAdmin/Views/_ViewImports.cshtml")]
    public class Areas_BlogAdmin_Views_User_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
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
#line 2 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\User\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/BlogAdmin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(123, 199, true);
            WriteLiteral("\r\n<h2>Delete User</h2>\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"widget-box\">\r\n        <div class=\"row\" style=\"margin-left:10px\">\r\n            <div class=\"col-12\">\r\n                <p>Name : ");
            EndContext();
            BeginContext(323, 10, false);
#line 13 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\User\Delete.cshtml"
                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(333, 36, true);
            WriteLiteral(" </p>\r\n                <p>Lastname: ");
            EndContext();
            BeginContext(370, 14, false);
#line 14 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\User\Delete.cshtml"
                        Write(Model.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(384, 33, true);
            WriteLiteral("</p>\r\n                <p>Email : ");
            EndContext();
            BeginContext(418, 11, false);
#line 15 "C:\Users\Fujitsu\Desktop\BlogTempCrud\BlogTempCrud\Areas\BlogAdmin\Views\User\Delete.cshtml"
                      Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(429, 293, true);
            WriteLiteral(@"</p>
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
            BeginContext(722, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed0e199b8b554410ae544564dd07f39c", async() => {
                BeginContext(742, 101, true);
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
            BeginContext(850, 164, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" style=\"margin-left:10px\">\r\n            <div class=\"col-12\">\r\n                <hr />\r\n                ");
            EndContext();
            BeginContext(1014, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17d873cb665e4aa681f46625c5bb3eeb", async() => {
                BeginContext(1036, 39, true);
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
            BeginContext(1079, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
