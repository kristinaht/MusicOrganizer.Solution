#pragma checksum "C:\Users\Kristina\desktop\Music-Organizer\Views\Artists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "996d190ffd5431e39c7d0378db865e0cb7fdd8b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artists_Index), @"mvc.1.0.view", @"/Views/Artists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Artists/Index.cshtml", typeof(AspNetCore.Views_Artists_Index))]
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
#line 1 "C:\Users\Kristina\desktop\Music-Organizer\Views\Artists\Index.cshtml"
using MusicOrganizer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"996d190ffd5431e39c7d0378db865e0cb7fdd8b4", @"/Views/Artists/Index.cshtml")]
    public class Views_Artists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 22, true);
            WriteLiteral("\r\n<h1>Artists</h1>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Kristina\desktop\Music-Organizer\Views\Artists\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(81, 44, true);
            WriteLiteral("  <h3>No artists have been added yet!</h3>\r\n");
            EndContext();
#line 8 "C:\Users\Kristina\desktop\Music-Organizer\Views\Artists\Index.cshtml"
} 

#line default
#line hidden
            BeginContext(129, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\Kristina\desktop\Music-Organizer\Views\Artists\Index.cshtml"
 foreach (Artist artist in Model)
{

#line default
#line hidden
            BeginContext(169, 8, true);
            WriteLiteral("  <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 177, "\'", 203, 2);
            WriteAttributeValue("", 184, "/artists/", 184, 9, true);
#line 12 "C:\Users\Kristina\desktop\Music-Organizer\Views\Artists\Index.cshtml"
WriteAttributeValue("", 193, artist.Id, 193, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(204, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(206, 11, false);
#line 12 "C:\Users\Kristina\desktop\Music-Organizer\Views\Artists\Index.cshtml"
                               Write(artist.Name);

#line default
#line hidden
            EndContext();
            BeginContext(217, 11, true);
            WriteLiteral("</a></h3>\r\n");
            EndContext();
#line 13 "C:\Users\Kristina\desktop\Music-Organizer\Views\Artists\Index.cshtml"
}

#line default
#line hidden
            BeginContext(231, 34, true);
            WriteLiteral("\r\n<p><a href=\'/\'>Back home</a></p>");
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