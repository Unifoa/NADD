#pragma checksum "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9414ba6826a4f8eaae9de8fc5bccdc1b91ada236"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetoNadd3.Pages.Provas.Pages_Provas_Details), @"mvc.1.0.razor-page", @"/Pages/Provas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Provas/Details.cshtml", typeof(ProjetoNadd3.Pages.Provas.Pages_Provas_Details), null)]
namespace ProjetoNadd3.Pages.Provas
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9414ba6826a4f8eaae9de8fc5bccdc1b91ada236", @"/Pages/Provas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e97675c181d9fd99d43d75e4af988a12bc515f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Provas_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(99, 160, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Prova</h4>\r\n    <hr />\r\n    <dl>\r\n        <dt>\r\n            Número da Avaliação:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(260, 47, false);
#line 18 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prova.Prova_Avd));

#line default
#line hidden
            EndContext();
            BeginContext(307, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Qtd. Questões:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(408, 55, false);
#line 24 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prova.Prova_Qnt_Questao));

#line default
#line hidden
            EndContext();
            BeginContext(463, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Valor da Prova Explicito?\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 30 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
             if (Html.DisplayTextFor(model => model.Prova.Prova_Valor_Explicito) == "0")
            {
                

#line default
#line hidden
            BeginContext(689, 3, true);
            WriteLiteral("NÃO");
            EndContext();
#line 32 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
                                
            }
            else
            {
                

#line default
#line hidden
            BeginContext(771, 3, true);
            WriteLiteral("SIM");
            EndContext();
#line 36 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
                                
            }

#line default
#line hidden
            BeginContext(798, 99, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            Valor da Prova:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(898, 55, false);
#line 43 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prova.Prova_Valor_Prova));

#line default
#line hidden
            EndContext();
            BeginContext(953, 114, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Teve Equilibrio dos Valores da Questões?\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 49 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
             if (Html.DisplayTextFor(model => model.Prova.Prova_Equilibrio_Questao) == "0")
            {
                

#line default
#line hidden
            BeginContext(1197, 3, true);
            WriteLiteral("NÃO");
            EndContext();
#line 51 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
                                
            }
            else
            {
                

#line default
#line hidden
            BeginContext(1279, 3, true);
            WriteLiteral("SIM");
            EndContext();
#line 55 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
                                
            }

#line default
#line hidden
            BeginContext(1306, 97, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            Referência Bibliografica?\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 62 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
             if (Html.DisplayTextFor(model => model.Prova.Prova_Ref_Bibliografica) == "0")
            {
                

#line default
#line hidden
            BeginContext(1532, 3, true);
            WriteLiteral("NÃO");
            EndContext();
#line 64 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
                                
            }
            else
            {
                

#line default
#line hidden
            BeginContext(1614, 3, true);
            WriteLiteral("SIM");
            EndContext();
#line 68 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
                                
            }

#line default
#line hidden
            BeginContext(1641, 95, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            Disciplina:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1737, 58, false);
#line 75 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prova.Disciplinas.Dis_Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Ano Letivo:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1893, 57, false);
#line 81 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prova.Disciplinas.Dis_Ano));

#line default
#line hidden
            EndContext();
            BeginContext(1950, 108, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Periodo da Disciplina:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2059, 61, false);
#line 87 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prova.Disciplinas.Dis_Periodo));

#line default
#line hidden
            EndContext();
            BeginContext(2120, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2167, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20bcd999339e489e96b2324db40c2ecd", async() => {
                BeginContext(2219, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Provas\Details.cshtml"
                           WriteLiteral(Model.Prova.Id);

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
            BeginContext(2229, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2237, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aaa434cc334279968c24897238a3e9", async() => {
                BeginContext(2259, 14, true);
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
            BeginContext(2277, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoNadd3.Pages.Provas.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjetoNadd3.Pages.Provas.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjetoNadd3.Pages.Provas.DetailsModel>)PageContext?.ViewData;
        public ProjetoNadd3.Pages.Provas.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
