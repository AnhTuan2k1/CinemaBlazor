#pragma checksum "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\Actor\ActorsDetailsAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f076420ba65477ee3f9cd6924990f5a18f278599"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actor_ActorsDetailsAdmin), @"mvc.1.0.view", @"/Views/Actor/ActorsDetailsAdmin.cshtml")]
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
#line 1 "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\_ViewImports.cshtml"
using CinemaBlazor.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\_ViewImports.cshtml"
using CinemaBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\_ViewImports.cshtml"
using CinemaBlazor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f076420ba65477ee3f9cd6924990f5a18f278599", @"/Views/Actor/ActorsDetailsAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a38012f3cf6f53287e34dd2205d96f97d9956074", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actor_ActorsDetailsAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Actor>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\Actor\ActorsDetailsAdmin.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-3\" style=\"max-width: 540px;\">\r\n  <div class=\"row no-gutters\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 11 "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\Actor\ActorsDetailsAdmin.cshtml"
            if (Model.Image != null)
                        {
                            var base64 = Convert.ToBase64String(@Model.Image);
                            var imgSrc = String.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 439, "\"", 452, 1);
#nullable restore
#line 15 "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\Actor\ActorsDetailsAdmin.cshtml"
WriteAttributeValue("", 445, imgSrc, 445, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:100%; \">\r\n");
#nullable restore
#line 16 "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\Actor\ActorsDetailsAdmin.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-md-8\">\r\n      <div class=\"card-body\">\r\n          <h3 class=\"card-title\">");
#nullable restore
#line 20 "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\Actor\ActorsDetailsAdmin.cshtml"
                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 21 "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\Actor\ActorsDetailsAdmin.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\Xuan Thai\Downloads\Github Repo\CinemaBlazor\Views\Actor\ActorsDetailsAdmin.cshtml"
                        Write(Model.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Actor> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
