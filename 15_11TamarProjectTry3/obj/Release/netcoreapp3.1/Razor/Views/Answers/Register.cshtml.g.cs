#pragma checksum "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff4855835314dcfa2ecd9d54ad36af23d5e992fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answers_Register), @"mvc.1.0.view", @"/Views/Answers/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4855835314dcfa2ecd9d54ad36af23d5e992fe", @"/Views/Answers/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"584fb3672178b2331121a42e5c500bc1c1f7ec76", @"/Views/_ViewImports.cshtml")]
    public class Views_Answers_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_15_11TamarProjectTry3.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"FormDiv\">\r\n\r\n    <h1>Register:</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4855835314dcfa2ecd9d54ad36af23d5e992fe3560", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml"
         if (ViewBag.isValid == false)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n                <strong>You didnt input the information please try again!!!!!</strong><br /> ");
#nullable restore
#line 13 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml"
                                                                                        Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n");
#nullable restore
#line 18 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            ");
#nullable restore
#line 20 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml"
       Write(Html.LabelFor(s => s.MyId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 23 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml"
       Write(Html.EditorFor(s => s.MyId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 26 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml"
       Write(Html.LabelFor(s => s.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 29 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml"
       Write(Html.EditorFor(s => s.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 32 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml"
       Write(Html.LabelFor(s => s.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 35 "C:\Users\sagib\Documents\wrokProject2\AmirClass\TamarProject\TamarWorkTry_5\15_11TamarProjectTry3\Views\Answers\Register.cshtml"
       Write(Html.EditorFor(s => s.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div><input type=\"submit\" /></div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_15_11TamarProjectTry3.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
