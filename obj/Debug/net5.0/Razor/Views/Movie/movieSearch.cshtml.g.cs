#pragma checksum "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4697b2e23c79556d9d7e9762ade66922e79f26f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_movieSearch), @"mvc.1.0.view", @"/Views/Movie/movieSearch.cshtml")]
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
#line 1 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\_ViewImports.cshtml"
using CinemaBlazor.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\_ViewImports.cshtml"
using CinemaBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
using CinemaBlazor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4697b2e23c79556d9d7e9762ade66922e79f26f", @"/Views/Movie/movieSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a38012f3cf6f53287e34dd2205d96f97d9956074", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_movieSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
  
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""slider movie-items"">
	<div class=""container"">
	<div class=""container"">
		<div class=""row ipad-width"">
<div class=""col-md-12"">
				
				<div class=""title-hd"">
					<h2>Movies</h2>
				</div>
				<div class=""tabs"">
					<ul class=""tab-links-2"">
						<li><a href=""#tab21"">#Popular</a></li>
						<li class=""active""><a href=""#tab22""> #Coming soon</a></li>
						<li><a href=""#tab23"">  #Top rated  </a></li>
						<li><a href=""#tab24""> #Most reviewed</a></li>                        
					</ul>
				    <div class=""tab-content"">
				        
				        <div id=""tab22"" class=""tab active"">
				           <div class=""row"">
				            	<div class=""slick-multiItem h-100"">
");
#nullable restore
#line 29 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
                                     foreach(var i in Model)
										{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t            \t\t<div class=\"slide-it\">\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"movie-item\">\r\n");
#nullable restore
#line 34 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
                                                 if(@i.Image != null){
											

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t            \t\t\t<div class=\"mv-img\">\r\n");
#nullable restore
#line 37 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
                                                  
													   var base64 = Convert.ToBase64String(@i.Image);
														var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
												

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t            \t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1223, "\"", 1236, 1);
#nullable restore
#line 41 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
WriteAttributeValue("", 1229, imgSrc, 1229, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1237, "\"", 1243, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:inherit; height:50vh\">\r\n\t\t\t\t\t            \t\t\t</div>\r\n");
#nullable restore
#line 43 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
												}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t            \t\t\t<div class=\"hvr-inner\">\r\n\t\t\t\t\t            \t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4697b2e23c79556d9d7e9762ade66922e79f26f7006", async() => {
                WriteLiteral(" Read more <i class=\"ion-android-arrow-dropright\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
                                                                          WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t            \t\t\t</div>\r\n\t\t\t\t\t            \t\t\t<div class=\"title-in\">\r\n\t\t\t\t\t            \t\t\t\t<h6>");
#nullable restore
#line 48 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
                                               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\t\t\t\t\t            \t\t\t\t<p><i class=\"ion-android-star\"></i><span>7.4</span> /10</p>\r\n\t\t\t\t\t            \t\t\t</div>\r\n\t\t\t\t\t            \t\t</div>\r\n\t\t\t\t            \t\t\t\r\n\t\t\t\t            \t\t</div>\r\n");
#nullable restore
#line 54 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
										}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t            \t</div>\r\n");
#nullable restore
#line 57 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
                                 if(Model.Count == 0 ){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<img src=\"/images/error/notfound.png\" style=\"height:75vh;\" />\r\n");
#nullable restore
#line 59 "D:\subjects\Công Nghệ Web\New folder\MovieTickets\MovieTickets\Views\Movie\movieSearch.cshtml"
										}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t            </div>\r\n\t\t\t       \t \t</div>\r\n\t\t\t\t    </div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t</div>\r\n\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
