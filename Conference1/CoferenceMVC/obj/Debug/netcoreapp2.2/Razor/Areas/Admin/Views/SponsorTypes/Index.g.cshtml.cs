#pragma checksum "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b9f6233932343ebcfd8a592a284f19d85816c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SponsorTypes_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SponsorTypes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SponsorTypes/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_SponsorTypes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b9f6233932343ebcfd8a592a284f19d85816c2", @"/Areas/Admin/Views/SponsorTypes/Index.cshtml")]
    public class Areas_Admin_Views_SponsorTypes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference1.Domain.Entities.SponsorTypes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 158, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(264, 38, false);
#line 16 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(358, 40, false);
#line 19 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(398, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(454, 41, false);
#line 22 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Order));

#line default
#line hidden
            EndContext();
            BeginContext(495, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(551, 43, false);
#line 25 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(594, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(712, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(761, 37, false);
#line 34 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(798, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(854, 39, false);
#line 37 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(893, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(949, 40, false);
#line 40 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Order));

#line default
#line hidden
            EndContext();
            BeginContext(989, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1045, 42, false);
#line 43 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1143, 49, false);
#line 46 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {id=item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1213, 57, false);
#line 47 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1291, 55, false);
#line 48 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\constantin\Desktop\Csharp\Conference1\CoferenceMVC\Areas\Admin\Views\SponsorTypes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1385, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference1.Domain.Entities.SponsorTypes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
