#pragma checksum "C:\Users\wordy\Desktop\CodingDojo\c#\ORMs\ChefsnDishes\Views\Home\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2e8f695f52a81ffe2a1f06f98322f6f0ff4cdc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
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
#line 1 "C:\Users\wordy\Desktop\CodingDojo\c#\ORMs\ChefsnDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wordy\Desktop\CodingDojo\c#\ORMs\ChefsnDishes\Views\_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e8f695f52a81ffe2a1f06f98322f6f0ff4cdc8", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 class=\"mx-4\">Yum, take a look at our tasty dishes!</h1>\r\n<a href=\"/newDish\">Add a Dish</a>\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Chef</th>\r\n        <th>Tastiness</th>\r\n        <th>Calories</th>\r\n    </tr>\r\n");
#nullable restore
#line 11 "C:\Users\wordy\Desktop\CodingDojo\c#\ORMs\ChefsnDishes\Views\Home\Dishes.cshtml"
      
        foreach(Chef c in ViewBag.allChefs)
        {
            foreach(Dish d in c.Dish)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\wordy\Desktop\CodingDojo\c#\ORMs\ChefsnDishes\Views\Home\Dishes.cshtml"
               Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\wordy\Desktop\CodingDojo\c#\ORMs\ChefsnDishes\Views\Home\Dishes.cshtml"
               Write(d.Chef.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\wordy\Desktop\CodingDojo\c#\ORMs\ChefsnDishes\Views\Home\Dishes.cshtml"
               Write(d.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\wordy\Desktop\CodingDojo\c#\ORMs\ChefsnDishes\Views\Home\Dishes.cshtml"
               Write(d.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\wordy\Desktop\CodingDojo\c#\ORMs\ChefsnDishes\Views\Home\Dishes.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
