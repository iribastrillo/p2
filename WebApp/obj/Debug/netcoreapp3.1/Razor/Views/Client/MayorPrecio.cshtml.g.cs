#pragma checksum "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16843af9d932b08ee6681b4aa6f21f4d68f7a484"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_MayorPrecio), @"mvc.1.0.view", @"/Views/Client/MayorPrecio.cshtml")]
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
#line 1 "C:\Users\agust\Source\Repos\p2\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\agust\Source\Repos\p2\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16843af9d932b08ee6681b4aa6f21f4d68f7a484", @"/Views/Client/MayorPrecio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_MayorPrecio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Pedido>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
  
    ViewData["Title"] = "MayorPrecio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Pedidos de mayor precio</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
           Write(Html.DisplayNameFor(model => model.FinalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
           Write(Html.DisplayNameFor(model => model.Open));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
           Write(Html.DisplayFor(modelItem => item.FinalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
           Write(Html.DisplayFor(modelItem => item.Open));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 44 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Client\MayorPrecio.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591