#pragma checksum "C:\Users\alinizam\source\repos\Lesson3\Lesson2App\Views\Personel\PageForViewBag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2840c992c715d4905867bbf37d56be9d48f62f24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_PageForViewBag), @"mvc.1.0.view", @"/Views/Personel/PageForViewBag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personel/PageForViewBag.cshtml", typeof(AspNetCore.Views_Personel_PageForViewBag))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2840c992c715d4905867bbf37d56be9d48f62f24", @"/Views/Personel/PageForViewBag.cshtml")]
    public class Views_Personel_PageForViewBag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\alinizam\source\repos\Lesson3\Lesson2App\Views\Personel\PageForViewBag.cshtml"
  
    var person = ViewBag.Person;

#line default
#line hidden
            BeginContext(164, 7, true);
            WriteLiteral("\r\n<h1> ");
            EndContext();
            BeginContext(172, 18, false);
#line 8 "C:\Users\alinizam\source\repos\Lesson3\Lesson2App\Views\Personel\PageForViewBag.cshtml"
Write(ViewBag.MyPageName);

#line default
#line hidden
            EndContext();
            BeginContext(190, 55, true);
            WriteLiteral(" </h1>\r\n\r\n<h2> using additional paramater </h2>\r\n<div> ");
            EndContext();
            BeginContext(246, 17, false);
#line 11 "C:\Users\alinizam\source\repos\Lesson3\Lesson2App\Views\Personel\PageForViewBag.cshtml"
 Write(person.PersonelId);

#line default
#line hidden
            EndContext();
            BeginContext(263, 15, true);
            WriteLiteral(" </div>\r\n<div> ");
            EndContext();
            BeginContext(279, 16, false);
#line 12 "C:\Users\alinizam\source\repos\Lesson3\Lesson2App\Views\Personel\PageForViewBag.cshtml"
 Write(person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(295, 15, true);
            WriteLiteral(" </div>\r\n<div> ");
            EndContext();
            BeginContext(311, 15, false);
#line 13 "C:\Users\alinizam\source\repos\Lesson3\Lesson2App\Views\Personel\PageForViewBag.cshtml"
 Write(person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(326, 71, true);
            WriteLiteral(" </div>\r\n\r\n<h2> Direct access to the viewbag properties </h2>\r\n\r\n<div> ");
            EndContext();
            BeginContext(398, 25, false);
#line 17 "C:\Users\alinizam\source\repos\Lesson3\Lesson2App\Views\Personel\PageForViewBag.cshtml"
 Write(ViewBag.person.PersonelId);

#line default
#line hidden
            EndContext();
            BeginContext(423, 15, true);
            WriteLiteral(" </div>\r\n<div> ");
            EndContext();
            BeginContext(439, 24, false);
#line 18 "C:\Users\alinizam\source\repos\Lesson3\Lesson2App\Views\Personel\PageForViewBag.cshtml"
 Write(ViewBag.person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(463, 15, true);
            WriteLiteral(" </div>\r\n<div> ");
            EndContext();
            BeginContext(479, 23, false);
#line 19 "C:\Users\alinizam\source\repos\Lesson3\Lesson2App\Views\Personel\PageForViewBag.cshtml"
 Write(ViewBag.person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(502, 11, true);
            WriteLiteral(" </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
