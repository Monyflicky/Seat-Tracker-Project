#pragma checksum "C:\Users\Owner\Documents\New Seat Tracker\NewSeatTracker\Pages\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc613b7798243aff46c3f1cff7832210fc739a58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NewSeatTracker.Pages.Pages_Confirmation), @"mvc.1.0.razor-page", @"/Pages/Confirmation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc613b7798243aff46c3f1cff7832210fc739a58", @"/Pages/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b4fcf2d46f4825d8c6ad8655e4e65825738b6c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Confirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Owner\Documents\New Seat Tracker\NewSeatTracker\Pages\Confirmation.cshtml"
  
    ViewData["Title"] = "Third page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"third_page\">\r\n    <div class=\"acceptance-info\">\r\n        <p>");
#nullable restore
#line 11 "C:\Users\Owner\Documents\New Seat Tracker\NewSeatTracker\Pages\Confirmation.cshtml"
      Write(Model.acceptanceMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"thanks-info\">\r\n        <p>");
#nullable restore
#line 14 "C:\Users\Owner\Documents\New Seat Tracker\NewSeatTracker\Pages\Confirmation.cshtml"
      Write(Model.thankNoteMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"end_page_two\">\r\n      <p>\r\n\r\n      </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmationModel>)PageContext?.ViewData;
        public ConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
