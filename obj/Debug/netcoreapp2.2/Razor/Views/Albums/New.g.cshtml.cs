#pragma checksum "/Users/Guest/Desktop/MusicOrganizer.Solution/MusicOrganizer/Views/Albums/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc71efb0a7b061fe53e08099a286beef80675acf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc71efb0a7b061fe53e08099a286beef80675acf", @"/Views/Albums/New.cshtml")]
    public class Views_Albums_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<h1>Add a new album to ");
            EndContext();
            BeginContext(24, 10, false);
#line 1 "/Users/Guest/Desktop/MusicOrganizer.Solution/MusicOrganizer/Views/Albums/New.cshtml"
                  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(34, 12, true);
            WriteLiteral("</h1>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 46, "\"", 80, 3);
            WriteAttributeValue("", 55, "/artists/", 55, 9, true);
#line 3 "/Users/Guest/Desktop/MusicOrganizer.Solution/MusicOrganizer/Views/Albums/New.cshtml"
WriteAttributeValue("", 64, Model.Id, 64, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 73, "/albums", 73, 7, true);
            EndWriteAttribute();
            BeginContext(81, 68, true);
            WriteLiteral(" method=\"post\">\n  <input id=\"artistId\" name=\"artistId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 149, "\"", 166, 1);
#line 4 "/Users/Guest/Desktop/MusicOrganizer.Solution/MusicOrganizer/Views/Albums/New.cshtml"
WriteAttributeValue("", 157, Model.Id, 157, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(167, 372, true);
            WriteLiteral(@">
  <label for=""albumTitle"">Album title</label>
  <input id=""albumTitle"" name=""albumTitle"" type=""text"">
  <label for=""trackTotal"">total number of tracks</label>
  <input id=""trackTotal"" name=""trackTotal"" type=""text"">
  <label for=""runTime"">total run time of album</label>
  <input id=""runTime"" name=""runTime"" type=""text"">
  <button type='submit'>Add album</button>
</form>");
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
