#pragma checksum "D:\GitHub\FlightManager\Сайт\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f724839b4c9565b26f0b065c1c186e4d58e9fd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#nullable restore
#line 1 "D:\GitHub\FlightManager\Сайт\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\FlightManager\Сайт\Areas\Identity\Pages\_ViewImports.cshtml"
using AuthSystem.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\FlightManager\Сайт\Areas\Identity\Pages\_ViewImports.cshtml"
using AuthSystem.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub\FlightManager\Сайт\Areas\Identity\Pages\_ViewImports.cshtml"
using AuthSystem.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f724839b4c9565b26f0b065c1c186e4d58e9fd1", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6068885a67f19255aa3d80f0b676de0192ed02", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\GitHub\FlightManager\Сайт\Areas\Identity\Pages\_AuthLayout.cshtml"
  
	Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
	<div class=""col-md-6 offset-md-3"">
		<div class=""card login-logout-tab"">
			<div class=""card-header"">
				<ul class=""nav nav-tabs card-header-tabs"">
					<li class=""nav-item"">
						<a class=""nav-link"" href='/Identity/Account/Login'>Вход</a>
					</li>
					<li class=""nav-item"">
						<a class=""nav-link"" href='/Identity/Account/Register'>Регистрация</a>
					</li>
				</ul>
			</div>
			<div class=""card-content"">
				<div class=""row"">
					<div class=""col-md-12"">
						");
#nullable restore
#line 20 "D:\GitHub\FlightManager\Сайт\Areas\Identity\Pages\_AuthLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
#nullable restore
#line 28 "D:\GitHub\FlightManager\Сайт\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

	<script>
		$(function () {
			var current = location.pathname;
			$('.nav-tabs li a').each(function () {
				var $this = $(this);
				if (current.indexOf($this.attr('href')) !== -1) 
				{
					$this.addClass('active');
				}
			})
		})
	</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
