#pragma checksum "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62175744d7827d5588fa59408dca6b2a8f14a722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetoNadd3.Pages.Avaliacoes.Pages_Avaliacoes_Delete), @"mvc.1.0.razor-page", @"/Pages/Avaliacoes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Avaliacoes/Delete.cshtml", typeof(ProjetoNadd3.Pages.Avaliacoes.Pages_Avaliacoes_Delete), null)]
namespace ProjetoNadd3.Pages.Avaliacoes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\_ViewImports.cshtml"
using ProjetoNadd3;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62175744d7827d5588fa59408dca6b2a8f14a722", @"/Pages/Avaliacoes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e97675c181d9fd99d43d75e4af988a12bc515f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Avaliacoes_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
  
    ViewData["Title"] = "Avaliação";

#line default
#line hidden
            BeginContext(104, 179, true);
            WriteLiteral("\r\n<h2>Exclusão</h2>\r\n\r\n<h3>Tem certeza que deseja excluir este registo?</h3>\r\n<div>\r\n    <h4>Avaliacao</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(284, 57, false);
#line 16 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Avaliacao.Ava_Questao));

#line default
#line hidden
            EndContext();
            BeginContext(341, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(385, 53, false);
#line 19 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Avaliacao.Ava_Questao));

#line default
#line hidden
            EndContext();
            BeginContext(438, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(482, 57, false);
#line 22 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Avaliacao.Ava_Clareza));

#line default
#line hidden
            EndContext();
            BeginContext(539, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(583, 53, false);
#line 25 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Avaliacao.Ava_Clareza));

#line default
#line hidden
            EndContext();
            BeginContext(636, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(680, 66, false);
#line 28 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Avaliacao.Ava_Complexibilidade));

#line default
#line hidden
            EndContext();
            BeginContext(746, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(790, 62, false);
#line 31 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Avaliacao.Ava_Complexibilidade));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(896, 66, false);
#line 34 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Avaliacao.Ava_Contextualizacao));

#line default
#line hidden
            EndContext();
            BeginContext(962, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1006, 62, false);
#line 37 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Avaliacao.Ava_Contextualizacao));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1112, 60, false);
#line 40 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Avaliacao.Ava_Observacao));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1216, 56, false);
#line 43 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Avaliacao.Ava_Observacao));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1316, 67, false);
#line 46 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Avaliacao.Ava_Questao_Explicito));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1427, 63, false);
#line 49 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Avaliacao.Ava_Questao_Explicito));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1534, 63, false);
#line 52 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Avaliacao.Ava_Valor_Questao));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1641, 59, false);
#line 55 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Avaliacao.Ava_Valor_Questao));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1744, 62, false);
#line 58 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Avaliacao.Ava_Mult_Escolha));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1850, 58, false);
#line 61 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Avaliacao.Ava_Mult_Escolha));

#line default
#line hidden
            EndContext();
            BeginContext(1908, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1952, 52, false);
#line 64 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Avaliacao.Provas));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2048, 51, false);
#line 67 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Avaliacao.Provas.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2137, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a0568e6382a48999bc1514e253186ec", async() => {
                BeginContext(2157, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2167, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc8f1691fa364adfa12f74db9a0c7fd9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 72 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Avaliacoes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Avaliacao.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2213, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2297, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59c0c60fa36c4a528694054ede76bcc0", async() => {
                    BeginContext(2319, 14, true);
                    WriteLiteral("Voltar a Lista");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2337, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2350, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoNadd3.Pages.Avaliacoes.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjetoNadd3.Pages.Avaliacoes.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjetoNadd3.Pages.Avaliacoes.DeleteModel>)PageContext?.ViewData;
        public ProjetoNadd3.Pages.Avaliacoes.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
