#pragma checksum "C:\Users\alperen\source\repos\MovieTutorial3\MovieTutorial3\MovieTutorial3.Web\Modules\Administration\Translation\TranslationIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd2e46cead2d4229b93a36edaae7fe037181e6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Administration_Translation_TranslationIndex), @"mvc.1.0.view", @"/Modules/Administration/Translation/TranslationIndex.cshtml")]
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
#line 1 "C:\Users\alperen\source\repos\MovieTutorial3\MovieTutorial3\MovieTutorial3.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alperen\source\repos\MovieTutorial3\MovieTutorial3\MovieTutorial3.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alperen\source\repos\MovieTutorial3\MovieTutorial3\MovieTutorial3.Web\Modules\_ViewImports.cshtml"
using MovieTutorial3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alperen\source\repos\MovieTutorial3\MovieTutorial3\MovieTutorial3.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alperen\source\repos\MovieTutorial3\MovieTutorial3\MovieTutorial3.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd2e46cead2d4229b93a36edaae7fe037181e6c", @"/Modules/Administration/Translation/TranslationIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26befd0cd6507a422989ed9b5d44d74d8b05195e", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Administration_Translation_TranslationIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alperen\source\repos\MovieTutorial3\MovieTutorial3\MovieTutorial3.Web\Modules\Administration\Translation\TranslationIndex.cshtml"
  
    ViewData["Title"] = Localizer.Get("Db.Administration.Translation.EntityPlural");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new MovieTutorial3.Administration.TranslationGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
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
