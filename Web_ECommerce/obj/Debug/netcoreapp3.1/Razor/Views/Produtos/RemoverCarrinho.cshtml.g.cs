#pragma checksum "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3150124fd5f1712af8cacad3a0a80601ddf30a63dddddede56a4860760438ea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_RemoverCarrinho), @"mvc.1.0.view", @"/Views/Produtos/RemoverCarrinho.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\_ViewImports.cshtml"
using Web_ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\_ViewImports.cshtml"
using Web_ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3150124fd5f1712af8cacad3a0a80601ddf30a63dddddede56a4860760438ea4", @"/Views/Produtos/RemoverCarrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a5be9ec684ed773fec2011c780a019e2285d0c44a3afd32637f8c103022ac8e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Produtos_RemoverCarrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Entities.Produto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListarProdutosCarrinhoUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverCarrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
  
    ViewData["Title"] = "RemoverCarrinho";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Remover produto do Carrinho</h1>\r\n\r\n<h3>Desejá realmente remover o produto : ");
#nullable restore
#line 9 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
                                    Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ? </h3>\r\n<div>\r\n   \r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
       Write(Html.DisplayNameFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
       Write(Html.DisplayFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
       Write(Html.DisplayNameFor(model => model.QtdCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\55149\OneDrive\Área de Trabalho\Unimar\EcommerceDDD\EcommerceDDD\Web_ECommerce\Views\Produtos\RemoverCarrinho.cshtml"
       Write(Html.DisplayFor(model => model.QtdCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3150124fd5f1712af8cacad3a0a80601ddf30a63dddddede56a4860760438ea48790", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Remover\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3150124fd5f1712af8cacad3a0a80601ddf30a63dddddede56a4860760438ea49162", async() => {
                    WriteLiteral("Voltar para itens do carrinho");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Entities.Produto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
