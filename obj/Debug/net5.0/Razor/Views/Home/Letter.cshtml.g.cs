#pragma checksum "/Users/annapittman/Desktop/FriendLetter.Solution2/FriendLetter/Views/Home/Letter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3beedaf01cadf70d11ae7893505272c0b31fc923"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Letter), @"mvc.1.0.view", @"/Views/Home/Letter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3beedaf01cadf70d11ae7893505272c0b31fc923", @"/Views/Home/Letter.cshtml")]
    public class Views_Home_Letter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Hello From Afar</h1>\n<p>Dear ");
#nullable restore
#line 2 "/Users/annapittman/Desktop/FriendLetter.Solution2/FriendLetter/Views/Home/Letter.cshtml"
   Write(Model.Recipient);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</p>\n<p>How are you? I hope that you are having a nice weekend. I\'m vacationing in Iceland while I learn programming! </p>\n<p>");
#nullable restore
#line 4 "/Users/annapittman/Desktop/FriendLetter.Solution2/FriendLetter/Views/Home/Letter.cshtml"
Write(Model.Recipient);

#line default
#line hidden
#nullable disable
            WriteLiteral(@", you would not believe how cold it is here. I should have gone to Hawaii instead.</p>
<p>But I like programming a lot, so I've got that going for me. </p>
<p>Looking forward to seeing you soon. I'll bring you back a souvenir. </p>
<p>Cheers,</p>
<p>Travel Enthusiast ");
#nullable restore
#line 8 "/Users/annapittman/Desktop/FriendLetter.Solution2/FriendLetter/Views/Home/Letter.cshtml"
                Write(Model.Sender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
