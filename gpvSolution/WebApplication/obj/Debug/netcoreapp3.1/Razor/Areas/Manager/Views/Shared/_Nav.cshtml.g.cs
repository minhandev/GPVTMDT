#pragma checksum "C:\Users\minhandev\Desktop\GPVTMDT\gpvSolution\WebApplication\Areas\Manager\Views\Shared\_Nav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002cfe79047f532d3e93c38e26841d6c1433c3e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Shared__Nav), @"mvc.1.0.view", @"/Areas/Manager/Views/Shared/_Nav.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002cfe79047f532d3e93c38e26841d6c1433c3e5", @"/Areas/Manager/Views/Shared/_Nav.cshtml")]
    public class Areas_Manager_Views_Shared__Nav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"sb-sidenav-menu\">\n    <div class=\"nav\">\n        <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 79, "\"", 114, 1);
#nullable restore
#line 3 "C:\Users\minhandev\Desktop\GPVTMDT\gpvSolution\WebApplication\Areas\Manager\Views\Shared\_Nav.cshtml"
WriteAttributeValue("", 86, Url.Action("Index", "Home"), 86, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
            TRANG CHỦ
        </a>
        <div class=""sb-sidenav-menu-heading"">Interface</div>
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseLayouts"" aria-expanded=""false"" aria-controls=""collapseLayouts"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-columns""></i></div>
            HỆ THỐNG
            <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
        </a>
        <div class=""collapse"" id=""collapseLayouts"" aria-labelledby=""headingOne"" data-parent=""#sidenavAccordion"">
            <nav class=""sb-sidenav-menu-nested nav""><a class=""nav-link""");
            BeginWriteAttribute("href", " href=\"", 846, "\"", 881, 1);
#nullable restore
#line 14 "C:\Users\minhandev\Desktop\GPVTMDT\gpvSolution\WebApplication\Areas\Manager\Views\Shared\_Nav.cshtml"
WriteAttributeValue("", 853, Url.Action("Index", "User"), 853, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">NGƯỜI DÙNG</a><a class=""nav-link"" href=""layout-sidenav-light.html"">Light Sidenav</a></nav>
        </div>
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""false"" aria-controls=""collapsePages"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-book-open""></i></div>
            Pages
            <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
        </a>
        <div class=""collapse"" id=""collapsePages"" aria-labelledby=""headingTwo"" data-parent=""#sidenavAccordion"">
            <nav class=""sb-sidenav-menu-nested nav accordion"" id=""sidenavAccordionPages"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#pagesCollapseAuth"" aria-expanded=""false"" aria-controls=""pagesCollapseAuth"">
                    Authentication
                    <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                </a>
                <div class=""collapse");
            WriteLiteral(@""" id=""pagesCollapseAuth"" aria-labelledby=""headingOne"" data-parent=""#sidenavAccordionPages"">
                    <nav class=""sb-sidenav-menu-nested nav""><a class=""nav-link"" href=""login.html"">Login</a><a class=""nav-link"" href=""register.html"">Register</a><a class=""nav-link"" href=""password.html"">Forgot Password</a></nav>
                </div>
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#pagesCollapseError"" aria-expanded=""false"" aria-controls=""pagesCollapseError"">
                    Error
                    <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                </a>
                <div class=""collapse"" id=""pagesCollapseError"" aria-labelledby=""headingOne"" data-parent=""#sidenavAccordionPages"">
                    <nav class=""sb-sidenav-menu-nested nav""><a class=""nav-link"" href=""401.html"">401 Page</a><a class=""nav-link"" href=""404.html"">404 Page</a><a class=""nav-link"" href=""500.html"">500 Page</a></nav>
                </div>
   ");
            WriteLiteral(@"         </nav>
        </div>
        <div class=""sb-sidenav-menu-heading"">Addons</div>
        <a class=""nav-link"" href=""charts.html"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-chart-area""></i></div>
            Charts
        </a><a class=""nav-link"" href=""tables.html"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-table""></i></div>
            Tables
        </a>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
