#pragma checksum "/Users/Guest/Desktop/MusicOrganizer.Solution/MusicOrganizer/Views/Albums/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6adec18dc6e6e335bcdf2d6ce0ba6829838aa50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_New), @"mvc.1.0.view", @"/Views/Albums/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Albums/New.cshtml", typeof(AspNetCore.Views_Albums_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6adec18dc6e6e335bcdf2d6ce0ba6829838aa50", @"/Views/Albums/New.cshtml")]
    public class Views_Albums_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 22, true);
            WriteLiteral("<h1>Add a new item to ");
            EndContext();
            BeginContext(23, 10, false);
#line 1 "/Users/Guest/Desktop/MusicOrganizer.Solution/MusicOrganizer/Views/Albums/New.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(33, 12, true);
            WriteLiteral("</h1>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 45, "\"", 79, 3);
            WriteAttributeValue("", 54, "/artists/", 54, 9, true);
#line 3 "/Users/Guest/Desktop/MusicOrganizer.Solution/MusicOrganizer/Views/Albums/New.cshtml"
WriteAttributeValue("", 63, Model.Id, 63, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 72, "/albums", 72, 7, true);
            EndWriteAttribute();
            BeginContext(80, 68, true);
            WriteLiteral(" method=\"post\">\n  <input id=\"artistId\" name=\"artistId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 148, "\"", 165, 1);
#line 4 "/Users/Guest/Desktop/MusicOrganizer.Solution/MusicOrganizer/Views/Albums/New.cshtml"
WriteAttributeValue("", 156, Model.Id, 156, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(166, 154, true);
            WriteLiteral(">\n  <label for=\"albumTitle\">Album title</label>\n  <input id=\"albumTitle\" name=\"albumTitle\" type=\"text\">\n  <button type=\'submit\'>Add album</button>\n</form>");
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
