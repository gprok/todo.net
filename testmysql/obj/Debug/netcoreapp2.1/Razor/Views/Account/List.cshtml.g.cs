#pragma checksum "/Users/gprok/Projects/testmysql/testmysql/Views/Account/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "989ed4a9508d68da03d9479ca5a4b98cbabd0c43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_List), @"mvc.1.0.view", @"/Views/Account/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/List.cshtml", typeof(AspNetCore.Views_Account_List))]
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
#line 1 "/Users/gprok/Projects/testmysql/testmysql/Views/_ViewImports.cshtml"
using testmysql;

#line default
#line hidden
#line 2 "/Users/gprok/Projects/testmysql/testmysql/Views/_ViewImports.cshtml"
using testmysql.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989ed4a9508d68da03d9479ca5a4b98cbabd0c43", @"/Views/Account/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eb2325a0f4851de25edcbba272c36b7d67afd0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<h2>Accounts</h2>\n\n\n<ul>\n");
            EndContext();
#line 5 "/Users/gprok/Projects/testmysql/testmysql/Views/Account/List.cshtml"
  
    List<testmysql.Models.Account> accList = ViewBag.AccountList;

    foreach (testmysql.Models.Account a in accList)
    {

#line default
#line hidden
            BeginContext(153, 25, true);
            WriteLiteral("        <li>\n            ");
            EndContext();
            BeginContext(179, 7, false);
#line 11 "/Users/gprok/Projects/testmysql/testmysql/Views/Account/List.cshtml"
       Write(a.email);

#line default
#line hidden
            EndContext();
            BeginContext(186, 15, true);
            WriteLiteral("\n        </li>\n");
            EndContext();
#line 13 "/Users/gprok/Projects/testmysql/testmysql/Views/Account/List.cshtml"
    }
    

#line default
#line hidden
            BeginContext(214, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591