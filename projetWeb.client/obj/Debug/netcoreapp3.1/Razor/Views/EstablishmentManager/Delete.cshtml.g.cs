#pragma checksum "E:\ephec\devops\projets\projetWeb.client\Views\EstablishmentManager\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba28922c39d32bf7cb756d9ded454fac57910dcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EstablishmentManager_Delete), @"mvc.1.0.view", @"/Views/EstablishmentManager/Delete.cshtml")]
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
#line 1 "E:\ephec\devops\projets\projetWeb.client\Views\_ViewImports.cshtml"
using projetWeb.client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ephec\devops\projets\projetWeb.client\Views\_ViewImports.cshtml"
using projetWeb.client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ephec\devops\projets\projetWeb.client\Views\_ViewImports.cshtml"
using projetWeb.client.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ephec\devops\projets\projetWeb.client\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ephec\devops\projets\projetWeb.client\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba28922c39d32bf7cb756d9ded454fac57910dcc", @"/Views/EstablishmentManager/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd2eb4df8e3ca87a0e4a87694ef2e1902d21400b", @"/Views/_ViewImports.cshtml")]
    public class Views_EstablishmentManager_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Establishment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Delete Existing Establishment</h2>\r\n\r\n<h3 class=\"message\">\r\n    Warning : You are about to delete an employee record.\r\n</h3>\r\n\r\n");
#nullable restore
#line 9 "E:\ephec\devops\projets\projetWeb.client\Views\EstablishmentManager\Delete.cshtml"
 using (Html.BeginForm("Delete", "EstablishmentManager", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\ephec\devops\projets\projetWeb.client\Views\EstablishmentManager\Delete.cshtml"
Write(Html.HiddenFor(m => m.EstablishmentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table border=\"0\">\r\n        <tr>\r\n            <td class=\"right\">\r\n                ");
#nullable restore
#line 16 "E:\ephec\devops\projets\projetWeb.client\Views\EstablishmentManager\Delete.cshtml"
           Write(Html.LabelFor(m => m.EstablishmentID));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 19 "E:\ephec\devops\projets\projetWeb.client\Views\EstablishmentManager\Delete.cshtml"
           Write(Model.EstablishmentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td class=\"right\">\r\n                ");
#nullable restore
#line 24 "E:\ephec\devops\projets\projetWeb.client\Views\EstablishmentManager\Delete.cshtml"
           Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "E:\ephec\devops\projets\projetWeb.client\Views\EstablishmentManager\Delete.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <button type=\"submit\">Delete</button>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 36 "E:\ephec\devops\projets\projetWeb.client\Views\EstablishmentManager\Delete.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 43 "E:\ephec\devops\projets\projetWeb.client\Views\EstablishmentManager\Delete.cshtml"
Write(Html.ActionLink("Back to Establishment Listing", "List", "EstablishmentManager"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Establishment> Html { get; private set; }
    }
}
#pragma warning restore 1591
