#pragma checksum "/home/garry/mice-exploration-tool/Pages/base64ToImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a207dfe1087a42325a42dcd85a16ec144ee21ca1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(helloWorld.Pages.Pages_base64ToImage), @"mvc.1.0.razor-page", @"/Pages/base64ToImage.cshtml")]
namespace helloWorld.Pages
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
#line 1 "/home/garry/mice-exploration-tool/Pages/_ViewImports.cshtml"
using helloWorld;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a207dfe1087a42325a42dcd85a16ec144ee21ca1", @"/Pages/base64ToImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ebca3e28741f80632ff1a12075a139804f43cf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_base64ToImage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/dicomImageToGrid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Males", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/garry/mice-exploration-tool/Pages/base64ToImage.cshtml"
  
    //ViewData["Title"] = "base64ToImage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a207dfe1087a42325a42dcd85a16ec144ee21ca15880", async() => {
                WriteLiteral("\r\n    <title>Base64 Image</title>\r\n    <link rel=\"stylesheet\" href=\"css/base64ToImage.css\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a207dfe1087a42325a42dcd85a16ec144ee21ca16935", async() => {
                WriteLiteral("\r\n\r\n    <div id=\"header\">Image taken from a URL, converted to Base64 and then converted back to an Image.</div>\r\n\r\n\r\n    <!--Button samples to trigger call to another page from code behind -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a207dfe1087a42325a42dcd85a16ec144ee21ca17399", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a207dfe1087a42325a42dcd85a16ec144ee21ca17671", async() => {
                        WriteLiteral("Home");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a207dfe1087a42325a42dcd85a16ec144ee21ca19053", async() => {
                        WriteLiteral("What I want to happen");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        <!--<input asp-for=\"Message\" /> <input type=\"submit\" class=\"btn btn-warning\" />-->\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n    <!--Test IMageMap property -->\r\n    <img src=\"https://raw.githubusercontent.com/18685030/DicomTestImages/master/SampleTestImages/mouse.jpeg\" alt=\"mouse\" usemap=\"#mouseMap\" width=\"400\" height=\"400\">\r\n    \r\n    ");
#nullable restore
#line 36 "/home/garry/mice-exploration-tool/Pages/base64ToImage.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a207dfe1087a42325a42dcd85a16ec144ee21ca112441", async() => {
                    WriteLiteral("\r\n        <map name=\"mouseMap\">\r\n            <area shape=\"rect\" id=\"btnGet\" coords=\"50,50,150,150\" href=\"#\" onclick=\"myform.submit() \"alt=\"paw\" />\r\n            <area shape=\"rect\" coords=\"250,250,350,350\" href=\"#\" alt=\"body\" />\r\n        </map>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"




    <!--Div that DICOM images are dynamically appended to to show as a grid -->
    <div class=""images"">
        <div id=""dicomImage""></div>
    </div>

        
        
        
        
<!-- javascript tags -->
<script src=""https://unpkg.com/cornerstone-wado-image-loader@3.0.6/dist/cornerstoneWADOImageLoader.min.js""></script>
<script src=""js/cornerstone.min.js""></script>
<script src=""js/cornerstoneMath.min.js""></script>
<script src=""js/cornerstoneTools.min.js""></script>
<script src=""js/dicomParser.min.js""></script>
<script src=""js/cornerstoneWADOImageLoader.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>        

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




<!-- javascript to convert base64 to jpg and jpeg to base64 -->

<script>

//Look for image 'img' tag and and note click of its co-ordinates

    $(document).ready(function () {
        $(""img"").on(""click"", function (event) {
        event.preventDefault();
    
        var x = event.pageX - this.offsetLeft;
        var y = event.pageY - this.offsetTop;
    
        
        //ajax to fire a POST request to trigger the handler method 'Button' in the code behind file
        $.ajax
            ({
                type: ""POST"",
                url: ""/base64ToImage?handler=Button"",
                
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""XSRF-TOKEN"",
                        $('input:hidden[name=""__RequestVerificationToken""]').val());
                },

                //dataType: ""text"",
                //success: function (result) {
                //    alert(result);
                //},
                error: fun");
            WriteLiteral(@"ction (status, ex) {
                    console.log(""Error Code: Status: "" + status + "" Ex: "" + ex);
                }
            });
            
        console.log(""X Coordinate: "" + x + "" Y Coordinate: "" + y);

    });
    });








// >>>>>>> Part A: Convert image to Base64

    //var imageURL = 'https://raw.githubusercontent.com/18685030/DicomTestImages/master/SampleTestImages/mouse.jpeg'

    //The funtion with image link to translate to Base64
    toDataURL(imageURL, function (dataUrl) {
        //document.write('Result in string:', dataUrl)

        var image = new Image();
        //Getting the source from the span.
        //image.src = document.getElementById('source').innerHTML;

        //console.log(dataUrl);
        image.src = dataUrl;
        image.style = ""width:400px;height:400px;display:inline-block"";
        image.usemap = ""#mouseMap"";
        document.body.appendChild(image);
        console.log('base64 image loaded');
    })

    // >>>>>>> Part");
            WriteLiteral(@" B: Converts Base64 to image

    //GETs image from location and converts to base64 using 'readAsDataURL' function
    function toDataURL(url, callback) {
        var httpRequest = new XMLHttpRequest();
        httpRequest.onload = function () {
            var fileReader = new FileReader();
            fileReader.onloadend = function () {
                callback(fileReader.result);
            }
            fileReader.readAsDataURL(httpRequest.response);
        };
        httpRequest.open('GET', url);
        httpRequest.responseType = 'blob';
        httpRequest.send();
    }


    //Cornserstone Library to present DICOM images in grid
    cornerstoneWADOImageLoader.external.cornerstone = cornerstone;

    //Array of image addresses. This array could be populated by URLs (to a storage device of DICOMs) from a MySQL query depending on user selection?

    var ImageArray = ");
#nullable restore
#line 161 "/home/garry/mice-exploration-tool/Pages/base64ToImage.cshtml"
                Write(Html.Raw(Json.Serialize(ViewData["DICOMArrayList"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    //console.log(ImageArray[1]);
    //console.log(ImageArray.length);

    //Forloop through image set and appends image to end of previous image

    for (var i = 0; i < ImageArray.length; i++) {
        console.log(""Images"", i+1, ""of"", ImageArray.length, ""loaded"");
        var imageNum = ImageArray[i];
        let imageId = ""wadouri:"" + imageNum;

        //Create new div element for each DICOM image and insert it befor the dicomImage div in body
        const imageDiv = document.createElement(""div"");
        imageDiv.style = ""width:20vw; height:20vw; border: thin solid white; display:inline-block"";
        var currentDiv = document.getElementById(""dicomImage"");
        currentDiv.parentNode.insertBefore(imageDiv, currentDiv);
        cornerstone.enable(imageDiv);

        //Load the DICOM image and allow supoprt tools for image zoom and contrast etc
        cornerstone.loadImage(imageId).then(function(image) {
        cornerstone.displayImage(imageDiv, image);
        cornerstoneTo");
            WriteLiteral(@"ols.mouseInput.enable(imageDiv);
        cornerstoneTools.mouseWheelInput.enable(imageDiv);
        cornerstoneTools.wwwc.activate(imageDiv, 1); // ww/wc is the default tool for left mouse button
        cornerstoneTools.pan.activate(imageDiv, 2); // pan is the default tool for middle mouse button
        cornerstoneTools.zoom.activate(imageDiv, 4); // zoom is the default tool for right mouse button
        cornerstoneTools.zoomWheel.activate(imageDiv); // zoom is the default tool for middle mouse wheel
        //cornerstoneTools.imageStats.enable(imageElement);
        //console.log(""Images"", i, ""of"", ImageArray.length, ""loaded"");
        });

    }






    // //Forloop through jpg image set in assets folder and appends image to end of previous image
    // for (var i = 0; i < 3; i++) {
    // var jpgImg = document.createElement(""img"");
    // jpgImg.style = ""width:300px; height:300px"";
    // jpgImg.src = ""assets/image"" + i +"".jpg""; //remove jpg if not required
    // document.body.a");
            WriteLiteral("ppendChild(jpgImg);\r\n    // }\r\n\r\n    //console.log(\"Page Loaded :)\");\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<base64ToImageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<base64ToImageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<base64ToImageModel>)PageContext?.ViewData;
        public base64ToImageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
