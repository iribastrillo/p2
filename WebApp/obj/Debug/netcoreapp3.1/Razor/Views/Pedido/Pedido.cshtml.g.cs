#pragma checksum "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20fe97b72b845ef9260ba94cb2971c44a3020edc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Pedido), @"mvc.1.0.view", @"/Views/Pedido/Pedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20fe97b72b845ef9260ba94cb2971c44a3020edc", @"/Views/Pedido/Pedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Pedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dominio.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("empty-order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/order.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Imagen de la orden en proceso"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 96px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/burger.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Imagen de hamburguesa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 48px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
  
    ViewData["Title"] = "Pedido";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Pedido</h2>\r\n\r\n<section class=\"container border mb-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12 d-flex flex-column justify-content-center text-center p-3\">\r\n            <figure>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "20fe97b72b845ef9260ba94cb2971c44a3020edc6003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </figure>\r\n");
#nullable restore
#line 15 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
             if (ViewBag.isDelivery)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2 class=\"lead\">Confirmá los detalles del servicio de delivery</h2>\r\n");
#nullable restore
#line 18 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"container\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
     foreach (var item in ViewBag.Cart)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mb-3 p-3 border d-flex align-content-center\">\r\n            <div class=\"col-1 d-flex align-content-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "20fe97b72b845ef9260ba94cb2971c44a3020edc8291", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-11\">\r\n                <p>\r\n                    ");
#nullable restore
#line 34 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    ");
#nullable restore
#line 37 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n<h2>Detalles del pago</h2>\r\n\r\n");
#nullable restore
#line 46 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
 if (ViewBag.isDelivery)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"border mb-3 p-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                <p><b>COSTO POR PLATOS:</b></p>\r\n            </div>\r\n            <div class=\"col-8\">\r\n                <p>$ ");
#nullable restore
#line 54 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
                Write(ViewBag.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                <p><b>ENVÍO:</b></p>\r\n            </div>\r\n            <div class=\"col-8\">\r\n                <p>$ ");
#nullable restore
#line 62 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
                Write(ViewBag.Extra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                <p><b>TOTAL A PAGAR:</b></p>\r\n            </div>\r\n            <div class=\"col-8\">\r\n                <p>$ ");
#nullable restore
#line 70 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
                Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 74 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"border mb-3 p-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            <p><b>FECHA:</b></p>\r\n        </div>\r\n        <div class=\"col-8\">\r\n            <p>");
#nullable restore
#line 83 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
          Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            <p><b>COSTO POR PLATOS:</b></p>\r\n        </div>\r\n        <div class=\"col-8\">\r\n            <p>$ ");
#nullable restore
#line 91 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
            Write(ViewBag.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            <p><b>CUBIERTO:</b></p>\r\n        </div>\r\n        <div class=\"col-8\">\r\n            <p>$ ");
#nullable restore
#line 99 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
            Write(ViewBag.CoverCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            <p><b>PROPINA:</b></p>\r\n        </div>\r\n        <div class=\"col-8\">\r\n            <p>$ ");
#nullable restore
#line 107 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
            Write(ViewBag.Tip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            <p><b>TOTAL A PAGAR:</b></p>\r\n        </div>\r\n        <div class=\"col-8\">\r\n            <p>$ ");
#nullable restore
#line 115 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
            Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 119 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"d-flex justify-content-center mb-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 124 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
       Write(Html.ActionLink("¡Confirmar!",
                                 "Success",
                                 new { },
                                 new { @class = "btn btn-outline-success" }
                             ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 131 "C:\Users\agust\Source\Repos\p2\WebApp\Views\Pedido\Pedido.cshtml"
       Write(Html.ActionLink("Cancelar :(",
                                 "Cancel",
                                 new { },
                                 new { @class = "btn btn-outline-danger" }
                             ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dominio.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
