#pragma checksum "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2cd2fa6e9af5fb385154c38e22d9da13f1a924a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#nullable restore
#line 1 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cd2fa6e9af5fb385154c38e22d9da13f1a924a", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/unRSVP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/RSVP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"d-flex space-evenly\">\r\n    <h1>Welcome ");
#nullable restore
#line 4 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<table class=\"table table-hover\">\r\n    <tr>\r\n        <th>Wedding</th>\r\n        <th>Date</th>\r\n        <th>Guest</th>\r\n        <th>Action</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
      
    foreach(Wedding g in ViewBag.Weddings)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 360, "\"", 391, 2);
            WriteAttributeValue("", 367, "/OneWedding/", 367, 12, true);
#nullable restore
#line 18 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 379, g.WeddingId, 379, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                              Write(g.NameOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 18 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                           Write(g.NameTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
           Write(g.Date.ToString("dd MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                        Write(g.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
           Write(g.Guests.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
             if(g.UserId == Model.UserId)    
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 649, "\"", 676, 2);
            WriteAttributeValue("", 656, "/delete/", 656, 8, true);
#nullable restore
#line 25 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 664, g.WeddingId, 664, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                </td>\r\n");
#nullable restore
#line 27 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
            } 

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
             if(g.Guests.Any(p => p.UserId == Model.UserId))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2cd2fa6e9af5fb385154c38e22d9da13f1a924a8177", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 972, "\"", 993, 1);
#nullable restore
#line 32 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 980, Model.UserId, 980, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"WeddingId\"");
                BeginWriteAttribute("value", " value=\"", 1062, "\"", 1082, 1);
#nullable restore
#line 33 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1070, g.WeddingId, 1070, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"submit\" value=\"unRSVP\" class=\"text-dark nav-link\">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td> \r\n");
#nullable restore
#line 37 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
             if(!g.Guests.Any(p => p.UserId == Model.UserId) && g.UserId != Model.UserId)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2cd2fa6e9af5fb385154c38e22d9da13f1a924a11288", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 1490, "\"", 1511, 1);
#nullable restore
#line 42 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1498, Model.UserId, 1498, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"WeddingId\"");
                BeginWriteAttribute("value", " value=\"", 1576, "\"", 1596, 1);
#nullable restore
#line 43 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1584, g.WeddingId, 1584, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"submit\" value=\"RSVP\" class=\"text-dark nav-link\">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td> \r\n");
#nullable restore
#line 47 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\wordy\Desktop\CodingDojo\c#\examprep\WeddingPlanner\Views\Home\Dashboard.cshtml"
    }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div class=\"form-group\">\r\n    <a href=\"/newWedding\" class=\"btn btn-info\">New Wedding</a>\r\n</div>");
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
