#pragma checksum "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc6ec31dc28ab4524fc85d73fe6f2dc1cef1d220"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_All), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Admin/All.cshtml", typeof(AspNetCore.Areas_Admin_Views_Admin_All))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc6ec31dc28ab4524fc85d73fe6f2dc1cef1d220", @"/Areas/Admin/Views/Admin/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0f6eb31d1c8637546d58ee5a6164dbc58c0c748", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Admin_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Antonia_Elena_Blog.Areas.Admin.ViewModels.BlogPostBindingModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Publish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
  
    ViewData["Title"] = "Published";
    int counter = 1;

#line default
#line hidden
            BeginContext(146, 47, true);
            WriteLiteral("\n\n<h1 class=\"text-center pb-3\">ALL POSTS</h1>\n\n");
            EndContext();
#line 10 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
 foreach (var blogPost in Model)
{

#line default
#line hidden
            BeginContext(228, 86, true);
            WriteLiteral("    <div class=\"container p-4 mb-5 blog-container\">\n        <span class=\"p-2 counter\">");
            EndContext();
            BeginContext(315, 7, false);
#line 13 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
                             Write(counter);

#line default
#line hidden
            EndContext();
            BeginContext(322, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 14 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
         if (blogPost.IsDraft)
        {

#line default
#line hidden
            BeginContext(371, 155, true);
            WriteLiteral("            <span class=\"p-2 draft\">Draft</span>\n            <div>\n                <button type=\"button\" class=\"btn btn-success mt-3\">\n                    ");
            EndContext();
            BeginContext(526, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb16a108ab34288bb569e3f5931f0c2", async() => {
                BeginContext(601, 43, true);
                WriteLiteral("<i class=\"far fa-check-circle\"></i> Publish");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
                                                                     WriteLiteral(blogPost.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(648, 46, true);
            WriteLiteral("\n                </button>\n            </div>\n");
            EndContext();
#line 22 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(727, 57, true);
            WriteLiteral("            <span class=\"p-2 published\">Published</span>\n");
            EndContext();
#line 26 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
        }

#line default
#line hidden
            BeginContext(794, 32, true);
            WriteLiteral("        <h6 class=\"text-center\">");
            EndContext();
            BeginContext(827, 17, false);
#line 27 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
                           Write(blogPost.Category);

#line default
#line hidden
            EndContext();
            BeginContext(844, 38, true);
            WriteLiteral("</h6>\n        <h3 class=\"text-center\">");
            EndContext();
            BeginContext(883, 24, false);
#line 28 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
                           Write(blogPost.Title.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(907, 38, true);
            WriteLiteral("</h3>\n        <h6 class=\"text-center\">");
            EndContext();
            BeginContext(946, 41, false);
#line 29 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
                           Write(blogPost.CreatedOn.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(987, 95, true);
            WriteLiteral("</h6>\n        <hr class=\"blog-title-divider\"/>\n        <p class=\"text-center\">\n            <em>");
            EndContext();
            BeginContext(1083, 15, false);
#line 32 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
           Write(blogPost.Writer);

#line default
#line hidden
            EndContext();
            BeginContext(1098, 46, true);
            WriteLiteral("</em>\n        </p>\n        <div class=\"row\">\n\n");
            EndContext();
#line 36 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
             if (blogPost.ImageUrl != null)
            {

#line default
#line hidden
            BeginContext(1202, 98, true);
            WriteLiteral("                <div class=\"col-lg-6 text-center\">\n                    <img class=\"img-fluid blog\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1300, "\"", 1324, 1);
#line 39 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
WriteAttributeValue("", 1306, blogPost.ImageUrl, 1306, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1325, 67, true);
            WriteLiteral(" alt=\"Card image\" width=\"80%\" height=\"80%\">\n                </div>\n");
            EndContext();
#line 41 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1437, 115, true);
            WriteLiteral("                <div class=\"col-lg-6 text-center p-5\" style=\"background-color: whitesmoke\">No Image Availabe</div>\n");
            EndContext();
#line 45 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
            }

#line default
#line hidden
            BeginContext(1566, 74, true);
            WriteLiteral("            <div class=\"col-lg-6 text-left blog-content\">\n                ");
            EndContext();
            BeginContext(1641, 26, false);
#line 47 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
           Write(Html.Raw(blogPost.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 289, true);
            WriteLiteral(@"
                <div class=""text-right"">
                    <h6 class=""btn forwards-backwards-btn"">
                        <a><i class=""fas fa-chevron-left""></i> Back</a>
                    </h6>
                    <h6 class=""btn forwards-backwards-btn edit"">
                        ");
            EndContext();
            BeginContext(1956, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04296a002f3b44339da31dd3df10d651", async() => {
                BeginContext(2028, 32, true);
                WriteLiteral("<i class=\"far fa-edit\"></i> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
                                                                      WriteLiteral(blogPost.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2064, 118, true);
            WriteLiteral("\n                    </h6>\n                    <h6 class=\"btn forwards-backwards-btn delete\">\n                        ");
            EndContext();
            BeginContext(2182, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6feb553443cb43a498e38ed595ee4953", async() => {
                BeginContext(2256, 35, true);
                WriteLiteral("<i class=\"fas fa-trash\"></i> Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
                                                                        WriteLiteral(blogPost.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2295, 96, true);
            WriteLiteral("\n                    </h6>\n                </div>\n            </div>\n\n        </div>\n    </div>\n");
            EndContext();
#line 63 "/Users/jolitaarnaudova/Desktop/Antonia_Elena_Blog/Antonia_Elena_Blog/Areas/Admin/Views/Admin/All.cshtml"
    counter++;
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Antonia_Elena_Blog.Areas.Admin.ViewModels.BlogPostBindingModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
