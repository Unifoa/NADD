#pragma checksum "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Cursos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "250e88426730bf9c4e579e24b699cd50fa3ee101"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetoNadd3.Pages.Cursos.Pages_Cursos_Details), @"mvc.1.0.razor-page", @"/Pages/Cursos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cursos/Details.cshtml", typeof(ProjetoNadd3.Pages.Cursos.Pages_Cursos_Details), null)]
namespace ProjetoNadd3.Pages.Cursos
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"250e88426730bf9c4e579e24b699cd50fa3ee101", @"/Pages/Cursos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e97675c181d9fd99d43d75e4af988a12bc515f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cursos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Cursos\Details.cshtml"
  
    ViewData["Title"] = "Curso";

#line default
#line hidden
            BeginContext(97, 185, true);
            WriteLiteral("\r\n<h2>Detalhe do Curso</h2>\r\n\r\n<div>\r\n    <h4>Curso</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Nome do Curso:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(283, 46, false);
#line 18 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Curso.Cur_Nome));

#line default
#line hidden
            EndContext();
            BeginContext(329, 103, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Qtd. de Periodos:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(433, 54, false);
#line 24 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Curso.Cur_Num_Periodos));

#line default
#line hidden
            EndContext();
            BeginContext(487, 86, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Curso Anual?\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 30 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Cursos\Details.cshtml"
             if (Html.DisplayTextFor(model => model.Curso.Cur_Ano_Sem) == "0")
            {
                

#line default
#line hidden
            BeginContext(690, 3, true);
            WriteLiteral("NÃO");
            EndContext();
#line 32 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Cursos\Details.cshtml"
                                
            }
            else
            {
                

#line default
#line hidden
            BeginContext(772, 3, true);
            WriteLiteral("SIM");
            EndContext();
#line 36 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Cursos\Details.cshtml"
                                
            }

#line default
#line hidden
            BeginContext(799, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Área do Cruso:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(900, 53, false);
#line 44 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Curso.Areas.Area_Nome));

#line default
#line hidden
            EndContext();
            BeginContext(953, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1000, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9693270964134581b3fd03d7e4617605", async() => {
                BeginContext(1052, 6, true);
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
#line 49 "E:\projeto com layout\ProjetoNadd3\ProjetoNadd3\Pages\Cursos\Details.cshtml"
                           WriteLiteral(Model.Curso.Id);

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
            BeginContext(1062, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1070, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cfd70add24542e290c6f16419b5becf", async() => {
                BeginContext(1092, 14, true);
                WriteLiteral("Voltar a lista");
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
            BeginContext(1110, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoNadd3.Pages.Cursos.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjetoNadd3.Pages.Cursos.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjetoNadd3.Pages.Cursos.DetailsModel>)PageContext?.ViewData;
        public ProjetoNadd3.Pages.Cursos.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
