#pragma checksum "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df819c1088db58014720e799de35a1db6baccee2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Talks_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Talks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Talks/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Talks_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df819c1088db58014720e799de35a1db6baccee2", @"/Areas/Admin/Views/Talks/Index.cshtml")]
    public class Areas_Admin_Views_Talks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference1.Domain.Entities.Talks>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 158, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(304, 38, false);
#line 17 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(342, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(398, 45, false);
#line 20 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(443, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(499, 40, false);
#line 23 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(539, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(595, 47, false);
#line 26 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(642, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(698, 43, false);
#line 29 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(741, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(859, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(908, 37, false);
#line 38 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(945, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1001, 44, false);
#line 41 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1101, 39, false);
#line 44 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1196, 46, false);
#line 47 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1298, 42, false);
#line 50 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1340, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1396, 51, false);
#line 53 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1468, 57, false);
#line 54 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1546, 55, false);
#line 55 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\Talks\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1640, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference1.Domain.Entities.Talks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
