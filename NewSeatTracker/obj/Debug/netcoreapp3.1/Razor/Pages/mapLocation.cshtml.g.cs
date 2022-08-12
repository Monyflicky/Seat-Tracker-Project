#pragma checksum "C:\Users\Owner\Documents\New Seat Tracker\NewSeatTracker\Pages\mapLocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "503465924eb1581a2f16dc1345539e7a90d75b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NewSeatTracker.Pages.Pages_mapLocation), @"mvc.1.0.razor-page", @"/Pages/mapLocation.cshtml")]
namespace NewSeatTracker.Pages
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
#line 1 "C:\Users\Owner\Documents\New Seat Tracker\NewSeatTracker\Pages\_ViewImports.cshtml"
using NewSeatTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\Documents\New Seat Tracker\NewSeatTracker\Pages\mapLocation.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"503465924eb1581a2f16dc1345539e7a90d75b98", @"/Pages/mapLocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b4fcf2d46f4825d8c6ad8655e4e65825738b6c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_mapLocation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Owner\Documents\New Seat Tracker\NewSeatTracker\Pages\mapLocation.cshtml"
  
    ViewData["Title"] = "Details page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Upper", async() => {
                WriteLiteral("\r\n    <div class=\"upper_section\">\r\n        <div class=\"m_canvas\">\r\n            <canvas width = \"500px\" height = \"100px\"  id = \"my_Canvas\"></canvas>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n<script async defer src=\"https://maps.googleapis.com/maps/api/js?callback=initMap\">\r\n</script>\r\n<script>\r\n    // Initialize and add the map\r\n        function initMap() {\r\n        // The location of Uluru\r\n        const uluru = { lat: ");
#nullable restore
#line 26 "C:\Users\Owner\Documents\New Seat Tracker\NewSeatTracker\Pages\mapLocation.cshtml"
                        Write(Model.rest.address.lat);

#line default
#line hidden
#nullable disable
            WriteLiteral(", lng: ");
#nullable restore
#line 26 "C:\Users\Owner\Documents\New Seat Tracker\NewSeatTracker\Pages\mapLocation.cshtml"
                                                      Write(Model.rest.address.lon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" };
        // The map, centered at Uluru
        const map = new google.maps.Map(document.getElementById(""map""), {
            zoom: 4,
            center: uluru,
        });
        // The marker, positioned at Uluru
        const marker = new google.maps.Marker({
            position: uluru,
            map: map,
        });
        }

window.initMap = initMap;
</script>
<div class=""text-center first-page"" id=""map"">
    
</div> 
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mapLocationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<mapLocationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<mapLocationModel>)PageContext?.ViewData;
        public mapLocationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
