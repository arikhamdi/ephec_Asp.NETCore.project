#pragma checksum "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc80d986f45d0684a82c1a097d92ef85b0f124b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Security_SignIn), @"mvc.1.0.view", @"/Views/Security/SignIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc80d986f45d0684a82c1a097d92ef85b0f124b", @"/Views/Security/SignIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e07a5e713058718de9e32a39b6f4592ee76fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Security_SignIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignIn>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h2>Sign In</h2>\r\n\r\n");
#nullable restore
#line 6 "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml"
 using (Html.BeginForm("SignIn", "Security", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 10 "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml"
           Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</td>\r\n            <td>");
#nullable restore
#line 11 "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 14 "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</td>\r\n            <td>");
#nullable restore
#line 15 "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml"
           Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 18 "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml"
           Write(Html.LabelFor(m => m.RememberMe));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</td>\r\n            <td>");
#nullable restore
#line 19 "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml"
           Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <button type=\"submit\">Sign In</button>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 27 "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml"
Write(Html.ValidationSummary(null, new { @class = "message" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 29 "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml"
   Write(Html.ActionLink("Créer un compte", "Register", "Security"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 30 "E:\ephec\devops\projets\projetWeb.client\Views\Security\SignIn.cshtml"

}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignIn> Html { get; private set; }
    }
}
#pragma warning restore 1591