#pragma checksum "D:\_workspace\aplicativos\backoffice\SalveMariaBackoffice\SalveMariaBackoffice\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc7ad9da20334c1c82d1bff787a8ad32dafd715"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\_workspace\aplicativos\backoffice\SalveMariaBackoffice\SalveMariaBackoffice\Views\_ViewImports.cshtml"
using SalveMariaBackoffice;

#line default
#line hidden
#line 2 "D:\_workspace\aplicativos\backoffice\SalveMariaBackoffice\SalveMariaBackoffice\Views\_ViewImports.cshtml"
using SalveMariaBackoffice.Models;

#line default
#line hidden
#line 3 "D:\_workspace\aplicativos\backoffice\SalveMariaBackoffice\SalveMariaBackoffice\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc7ad9da20334c1c82d1bff787a8ad32dafd715", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b720ab9da2c26143c5154df612175eba4fa91287", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alertas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;height:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\_workspace\aplicativos\backoffice\SalveMariaBackoffice\SalveMariaBackoffice\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Página Inicial";

#line default
#line hidden
            BeginContext(73, 39, true);
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n        ");
            EndContext();
            BeginContext(112, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cc7ad9da20334c1c82d1bff787a8ad32dafd7154423", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(175, 16, true);
            WriteLiteral("\r\n    \r\n\r\n\r\n    ");
            EndContext();
            BeginContext(193, 887, false);
#line 12 "D:\_workspace\aplicativos\backoffice\SalveMariaBackoffice\SalveMariaBackoffice\Views\Home\Index.cshtml"
Write(Html
                                    .Grid(Model)
                                    .Build(columns =>
                                    {
                                    columns.Add(model => model.Id).Titled("id");
                                    columns.Add(model => model.Nome).Titled("Nome");
                                    columns.Add(model => model.Endereco).Titled("Endereço");
                                    columns.Add(model => $"<button    class=\"btn btn - primary\"  onclick=\"openModal({model.Id}, '{model.Latitude}', '{model.Longitude}', '{model.Nome}')\" data-id=\"{model.Id}\">Ver Localização</button>").Encoded(false);
    })
                                    .Empty("Sem dados")
                                    .Filterable()
                                    .Sortable()
                                    .Pageable()
    );

#line default
#line hidden
            EndContext();
            BeginContext(1081, 682, true);
            WriteLiteral(@"


</div>



<div id=""id_da_div_modal"" class=""modal fade"">
    <div class=""modal-dialog"" style=""max-width:700px"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""><span aria-hidden=""true"">×</span><span class=""sr-only"">Fechar</span></button>
            </div>
            <div class=""modal-body"">
                <div id=""nomePessoa""><p> </p></div>
                <div id=""dvMap"" style=""width: 650px; height: 500px"">
                </div>

            </div>

        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1782, 1138, true);
                WriteLiteral(@"
<script type=""text/javascript"" src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyA09E_qCdshKdTJPHVuoDUB8ULwbqBKogM""></script>
<script type=""text/javascript"">


    function openModal(id, latitude, longitude, nome) {

        var mapOptions = {
            center: new google.maps.LatLng(latitude, longitude),
            zoom: 15,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var infoWindow = new google.maps.InfoWindow();
        var map = new google.maps.Map(document.getElementById(""dvMap""), mapOptions);

            var myLatlng = new google.maps.LatLng(latitude, longitude);
            var marker = new google.maps.Marker({
                position: myLatlng,
                map: map,
                title: nome
            });
            (function (marker) {
                google.maps.event.addListener(marker, ""click"", function (e) {
                    infoWindow.setContent(""Socorro"");
                    infoWindow.open(map, marker);
              ");
                WriteLiteral("  });\r\n            })(marker);\r\n   \r\n        $(\"#id_da_div_modal\").modal(\"show\");\r\n\r\n\r\n     \r\n    }\r\n\r\n</script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alertas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
