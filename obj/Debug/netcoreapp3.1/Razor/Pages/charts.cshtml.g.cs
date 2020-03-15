#pragma checksum "/Users/garryclawson/Documents/GitHub/mice-exploration-tool/Pages/charts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4214f2b6341b99884ea43d10b7647168d05ebb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(miceExplorationTool.Pages.Pages_charts), @"mvc.1.0.razor-page", @"/Pages/charts.cshtml")]
namespace miceExplorationTool.Pages
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
#line 1 "/Users/garryclawson/Documents/GitHub/mice-exploration-tool/Pages/_ViewImports.cshtml"
using miceExplorationTool;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4214f2b6341b99884ea43d10b7647168d05ebb2", @"/Pages/charts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"526602671fd78adbbe7ad730f5147fc7f0bf2430", @"/Pages/_ViewImports.cshtml")]
    public class Pages_charts : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/dicomImageToGrid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/base64ToImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/charts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/garryclawson/Documents/GitHub/mice-exploration-tool/Pages/charts.cshtml"
  
    //ViewData["Title"] = "Chart page";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4214f2b6341b99884ea43d10b7647168d05ebb24569", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""css/charts.css"">
    <link rel=""stylesheet"" href=""css/navbar.css"">
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.min.js""></script>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"">
    <link href=""https://fonts.googleapis.com/css2?family=Work+Sans&display=swap"" rel=""stylesheet"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4214f2b6341b99884ea43d10b7647168d05ebb26061", async() => {
                WriteLiteral("\r\n\r\n    <!-- // Intro and header -->\r\n\r\n    <Section class=\"navBar\">\r\n        <header>\r\n            <div class=\"container\">\r\n                <h1 class=\"logo\"></h1>\r\n\r\n                <nav>\r\n                    <ul>\r\n                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4214f2b6341b99884ea43d10b7647168d05ebb26585", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4214f2b6341b99884ea43d10b7647168d05ebb27817", async() => {
                    WriteLiteral("Search");
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
                WriteLiteral("</li>\r\n                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4214f2b6341b99884ea43d10b7647168d05ebb29051", async() => {
                    WriteLiteral("Body Part");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4214f2b6341b99884ea43d10b7647168d05ebb210288", async() => {
                    WriteLiteral("Charts");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4214f2b6341b99884ea43d10b7647168d05ebb211523", async() => {
                    WriteLiteral("About");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                    </ul>
                </nav>
            </div>
        </header>
    </Section>

    <div class=""charts"">
        <canvas id=""AgeOfMice""></canvas>
    </div>

    <div class=""charts"">
        <canvas id=""Centers""></canvas>
    </div>

    <div class=""charts"">
        <canvas id=""DistMiceByAge""></canvas>
    </div>

    <div class=""charts"">
        <canvas id=""MFDist""></canvas>
    </div>

    <div class=""charts"">
        <canvas id=""genes""></canvas>
    </div>


    <!-- // Helper points  -->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</html>

<script>

    //Script for each chart on CHARTS page of the webapp

    //Global options for all charts

    Chart.defaults.global.defaultFontFamily = 'Work Sans';
    Chart.defaults.global.defaultFontSize = 15;
    Chart.defaults.global.defaultFontColor = '#777';

    //Age of Mice Chart

    let AgeOfMice = document.getElementById('AgeOfMice').getContext('2d');

    let AgeOfMiceChart = new Chart(AgeOfMice, {
        type: 'bar',//bar, horizontalBar,pie,line,doughnut,radar,polarArea
        data: {
            labels: ['Mouse 1', 'Mouse 2', 'Mouse 3', 'Mouse 4', 'Mouse 5', 'mouse 6'],
            datasets: [{
                label: 'Group 1',
                data: [
                    14,
                    23,
                    3,
                    21,
                    11,
                    5
                ],
                //backgroundColor:'green'

                backgroundColor: [
                    'rgba(220,105,20,1)',
                    'rgba(70,77,87,1)',
          ");
            WriteLiteral(@"          'rgba(212,232,211,1)',
                    'rgba(228,220,203,1)',
                    'rgba(237,137,23,1)',
                    'rgba(166,196,188,1)',
                    'rgba(234,122,88,1)',
                ],
                borderWidth: 1,
                borderColor: '#777',
                hoverBorderWidth: 3,
                hoverBorderColor: '#000'
            }]
        },
        options: {
            title: {
                display: true,
                text: 'Age of Mice',
                fontSize: 20
            },
            legend: {
                display: false,
                position: 'right', // top, bottom, left, right
                labels: {
                    fontColor: '#000'
                }
            },
            layout: {
                padding: {
                    left: 0,
                    right: 0,
                    top: 0,
                    bottom: 0
                }
            },
            tooltips: {
                enabled: true
          ");
            WriteLiteral(@"  },
            scales: {
                yAxes: [{
                    scaleLabel: {
                        display: true,
                        labelString: 'Age (Weeks)'
                    }
                }],
                xAxes: [{
                    scaleLabel: {
                        display: true,
                        labelString: 'Mouse ID'
                    }
                }]
            }
        }
    });

    // Centers Chart

    let Centers = document.getElementById('Centers').getContext('2d');

    let CentersChart = new Chart(Centers, {
        type: 'pie',//bar, horizontalBar,pie,line,doughnut,radar,polarArea
        data: {
            labels: ['Centre 1', 'Center 2', 'Centre 3', 'Centre 4', 'Center 5', 'Centre 6'],
            datasets: [{
                label: 'Group 1',
                data: [
                    142,
                    232,
                    30,
                    215,
                    111,
                    50
                ],
            ");
            WriteLiteral(@"    //backgroundColor:'green'

                backgroundColor: [
                    'rgba(220,105,20,1)',
                    'rgba(70,77,87,1)',
                    'rgba(212,232,211,1)',
                    'rgba(228,220,203,1)',
                    'rgba(237,137,23,1)',
                    'rgba(166,196,188,1)',
                    'rgba(234,122,88,1)',
                ],
                borderWidth: 1,
                borderColor: '#777',
                hoverBorderWidth: 3,
                hoverBorderColor: '#000'
            }]
        },
        options: {
            title: {
                display: true,
                text: 'Phenotyping Centers',
                fontSize: 20
            },
            legend: {
                display: true,
                position: 'right', // top, bottom, left, right
                labels: {
                    fontColor: '#000'
                }
            },
            layout: {
                padding: {
                    left: 0,
                    ");
            WriteLiteral(@"right: 0,
                    top: 0,
                    bottom: 0
                }
            },
            tooltips: {
                enabled: true
            },

        }
    });

    // Distribution of mice by age charts

    let DistMiceByAge = document.getElementById('DistMiceByAge').getContext('2d');

    let DistMiceByAgeChart = new Chart(DistMiceByAge, {
        type: 'bar',//bar, horizontalBar,pie,line,doughnut,radar,polarArea
        data: {
            labels: ['1-20', '21-40', '41-60', '61 -80', '81-100', '100-121'],
            datasets: [{
                label: 'Male',
                data: [
                    14,
                    56,
                    70,
                    65,
                    50,
                    32
                ],
                backgroundColor: [
                    'rgba(220,105,20,1)',
                    'rgba(70,77,87,1)',
                    'rgba(212,232,211,1)',
                    'rgba(228,220,203,1)',
                    'rgba(237,137,23");
            WriteLiteral(@",1)',
                    'rgba(166,196,188,1)',
                    'rgba(234,122,88,1)',
                ],
                borderWidth: 1,
                borderColor: '#777',
                hoverBorderWidth: 3,
                hoverBorderColor: '#000'
            }
            ]
        },
        options: {
            title: {
                display: true,
                text: 'Distribution of Mice by Age ',
                fontSize: 20
            },
            legend: {
                display: false,
                position: 'right', // top, bottom, left, right
                labels: {
                    fontColor: '#000'
                }
            },
            layout: {
                padding: {
                    left: 0,
                    right: 0,
                    top: 0,
                    bottom: 0
                }
            },
            tooltips: {
                enabled: true
            },
            scales: {
                yAxes: [{
                    scaleLabe");
            WriteLiteral(@"l: {
                        display: true,
                        labelString: 'Number of Mice'
                    }
                }],
                xAxes: [{
                    scaleLabel: {
                        display: true,
                        labelString: 'Age (Weeks)'
                    }
                }]
            }
        }
    });

    // Distribution of male to female mice

    let MFDist = document.getElementById('MFDist').getContext('2d');

    let MFDistChart = new Chart(MFDist, {
        type: 'radar',//bar, horizontalBar,pie,line,doughnut,radar,polarArea
        data: {
            labels: ['Centre 1', 'Center 2', 'Centre 3', 'Centre 4', 'Center 5', 'Centre 6'],
            datasets: [{
                label: 'Male',
                data: [
                    142,
                    232,
                    70,
                    215,
                    111,
                    50
                ],
                backgroundColor: 'rgba(228,220,203,1)',
               ");
            WriteLiteral(@" borderWidth: 1,
                borderColor: '#777',
                hoverBorderWidth: 3,
                hoverBorderColor: '#000'
            },
            {
                label: 'Female',
                data: [
                    101,
                    245,
                    41,
                    99,
                    214,
                    301
                ],
                backgroundColor: 'rgba(237,137,23,1)',
                borderWidth: 1,
                borderColor: '#777',
                hoverBorderWidth: 3,
                hoverBorderColor: '#000'
            }
            ]
        },
        options: {
            title: {
                display: true,
                text: 'Distribution of Male to Female Mice ',
                fontSize: 20
            },
            legend: {
                display: true,
                position: 'right', // top, bottom, left, right
                labels: {
                    fontColor: '#000'
                }
            },
         ");
            WriteLiteral(@"   layout: {
                padding: {
                    left: 0,
                    right: 0,
                    top: 0,
                    bottom: 0
                }
            },
            tooltips: {
                enabled: true
            },

        }
    });

    // Distribution of genes knockouts

    let genes = document.getElementById('genes').getContext('2d');

    let genesChart = new Chart(genes, {
        type: 'bar',//bar, horizontalBar,pie,line,doughnut,radar,polarArea
        data: {
            labels: ['1-20', '21-40', '41-60', '61 -80', '81-100', '100-121'],
            datasets: [{
                type: 'line',
                label: 'weight (g)',
                borderColor: 'blue',
                borderWidth: 2,
                fill: false,
                //  yAxisID: 'y-axis-1',
                data: [
                    20,
                    30,
                    40,
                    43,
                    37,
                    29,
                ],
         ");
            WriteLiteral(@"       // yAxisID: ""y-axis-1"",
            },
            {
                label: 'Gene Symbol : Rab15',

                data: [
                    14,
                    56,
                    70,
                    65,
                    50,
                    32
                ],
                //  yAxisID: ""y-axis-2"",
                backgroundColor: [
                    'rgba(220,105,20,1)',
                    'rgba(70,77,87,1)',
                    'rgba(212,232,211,1)',
                    'rgba(228,220,203,1)',
                    'rgba(237,137,23,1)',
                    'rgba(166,196,188,1)',
                    'rgba(234,122,88,1)',
                ],
                borderWidth: 1,
                borderColor: '#777',
                hoverBorderWidth: 3,
                hoverBorderColor: '#000'
            }
            ]
        },
        options: {
            title: {
                display: true,
                text: 'Weight of mice across age ranges ',
                fontSize:");
            WriteLiteral(@" 20
            },
            legend: {
                display: true,
                position: 'right', // top, bottom, left, right
                labels: {
                    fontColor: '#000',
                    filter: function (item, chart) {
                        return !item.text.includes('Gene Symbol : Rab15');
                    }
                }
            },
            layout: {
                padding: {
                    left: 0,
                    right: 0,
                    top: 0,
                    bottom: 0
                }
            },
            tooltips: {
                enabled: true
            },
            scales: {
                yAxes: [{
                    scaleLabel: {
                        display: true,
                        labelString: 'Number of Mice'
                    }
                }],
                xAxes: [{
                    scaleLabel: {
                        display: true,
                        labelString: 'Age (Weeks)'
      ");
            WriteLiteral("              }\n                }]\n            }\n        }\n    });\r\n\r\n\r\n    console.log(\"Charts Page Loaded :)\");\r\n\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<chartsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<chartsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<chartsModel>)PageContext?.ViewData;
        public chartsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
