#pragma checksum "/Users/panitarn/Projects/crud-mvc/Views/Content/GetContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ce8bcbed774fb23e3de645c9c14d8b1d1849059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_GetContent), @"mvc.1.0.view", @"/Views/Content/GetContent.cshtml")]
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
#line 1 "/Users/panitarn/Projects/crud-mvc/Views/_ViewImports.cshtml"
using crud_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/panitarn/Projects/crud-mvc/Views/_ViewImports.cshtml"
using crud_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ce8bcbed774fb23e3de645c9c14d8b1d1849059", @"/Views/Content/GetContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b89ce5063a2960afb786aa5bcc0b2958ad773fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_GetContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<crud_mvc.Models.Content>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<section>\n        <div class=\"row featurette\">\n            <div class=\"col-md-6\">\n                <img class=\"featurette-image img-fluid mx-auto\"");
            BeginWriteAttribute("src", " src=\"", 178, "\"", 225, 1);
#nullable restore
#line 6 "/Users/panitarn/Projects/crud-mvc/Views/Content/GetContent.cshtml"
WriteAttributeValue("", 184, Html.DisplayFor(model => model.CoverImg), 184, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"100%x150\" data-holder-rendered=\"true\">\n            </div>\n            <div class=\"col-md-6 mt-3\">\n                <h1><b>");
#nullable restore
#line 9 "/Users/panitarn/Projects/crud-mvc/Views/Content/GetContent.cshtml"
                  Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h1>\n                <h3>By ");
#nullable restore
#line 10 "/Users/panitarn/Projects/crud-mvc/Views/Content/GetContent.cshtml"
                  Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                <h3>Genre: ");
#nullable restore
#line 11 "/Users/panitarn/Projects/crud-mvc/Views/Content/GetContent.cshtml"
                      Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1><br />

                <h3 class=""featurette-heading"">First featurette heading. <span class=""text-muted"">It'll blow your mind.</span></h3>
                <p>Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
            </div>
        </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<crud_mvc.Models.Content> Html { get; private set; }
    }
}
#pragma warning restore 1591
