#pragma checksum "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Home\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76b967ef8f5643d10701c6edb393b924696c9b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b76b967ef8f5643d10701c6edb393b924696c9b8", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"584fb3672178b2331121a42e5c500bc1c1f7ec76", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_15_11TamarProjectTry3.Models.QuizResult>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("ClearText()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Home\Test.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            document.getElementById(\"AnswerOne\").value = \"\";\r\n            document.getElementById(\"AnswerTwo\").value = \"\";\r\n        });\r\n    </script>\r\n        <div class=\"FormDiv\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b76b967ef8f5643d10701c6edb393b924696c9b83778", async() => {
                WriteLiteral("\r\n                <div>\r\n                    <strong>");
#nullable restore
#line 14 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Home\Test.cshtml"
                       Write(ViewBag.QuestionNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(". </strong>");
#nullable restore
#line 14 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Home\Test.cshtml"
                                                         Write(Html.DisplayNameFor(Qinfo => Qinfo.QuestionOnTest.Question));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    \r\n                    ");
#nullable restore
#line 16 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Home\Test.cshtml"
               Write(Html.DisplayFor(Qinfo => Qinfo.QuestionOnTest.Question));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <strong>\r\n                        ");
#nullable restore
#line 20 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Home\Test.cshtml"
                   Write(Html.DisplayFor(Qinfo => Qinfo.QuestionOnTest.VerbToChange));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <input class=\"text-box single-line\" id=\"AnswerOne\" name=\"AnswerOne\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 881, "\"", 889, 0);
                EndWriteAttribute();
                WriteLiteral("  autocomplete = \"off\"/>\r\n");
                WriteLiteral("                    </strong>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Home\Test.cshtml"
                 if (Model.QuestionOnTest.SecondVerbToChange != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div>\r\n                        <strong>\r\n                            ");
#nullable restore
#line 29 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Home\Test.cshtml"
                       Write(Html.DisplayFor(Qinfo => Qinfo.QuestionOnTest.SecondVerbToChange));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                            <input class=\"text-box single-line\" id=\"AnswerTwo\" name=\"AnswerTwo\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1531, "\"", 1539, 0);
                EndWriteAttribute();
                WriteLiteral(" autocomplete = \"off\"/>\r\n                        </strong>\r\n                    </div>\r\n");
#nullable restore
#line 34 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Home\Test.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"submit\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        \r\n    \r\n    \r\n\r\n        \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_15_11TamarProjectTry3.Models.QuizResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
