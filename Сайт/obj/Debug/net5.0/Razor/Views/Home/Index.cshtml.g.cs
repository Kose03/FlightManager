#pragma checksum "D:\FlightManager\ASP.NET Framework Сайт\FlightManager + Reservations\Сайт за училище + резервации\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a67815681c1716d7c28637e9192bc146e52f0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\FlightManager\ASP.NET Framework Сайт\FlightManager + Reservations\Сайт за училище + резервации\Views\_ViewImports.cshtml"
using FlightManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FlightManager\ASP.NET Framework Сайт\FlightManager + Reservations\Сайт за училище + резервации\Views\_ViewImports.cshtml"
using FlightManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a67815681c1716d7c28637e9192bc146e52f0f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f786fd48d4832d47c30e803e7f87b4fe4964de31", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\FlightManager\ASP.NET Framework Сайт\FlightManager + Reservations\Сайт за училище + резервации\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Добре дошли!";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
	<h1 class=""display-4"">Добре дошли в сайта за онлайн резервации на полети!</h1>
	<p>За да резервирате полет трябва да отидете в страницата резервации.</p>
</div>
<script>
	window.gdprAppliesGlobally = true; if (!(""cmp_id"" in window))
	{ window.cmp_id = 38594 } if (!(""cmp_params"" in window)) { window.cmp_params = """" }
	if (!(""cmp_host"" in window)) { window.cmp_host = ""c.delivery.consentmanager.net"" }
	if (!(""cmp_cdn"" in window)) { window.cmp_cdn = ""cdn.consentmanager.net"" }
	if (!(""cmp_proto"" in window)) { window.cmp_proto = ""https:"" }
	window.cmp_getsupportedLangs = function () {
		var b = [""DE"", ""EN"", ""FR"", ""IT"", ""NO"", ""DA"", ""FI"", ""ES"", ""PT"", ""RO"", ""BG"", ""ET"", ""EL"", ""GA"", ""HR"", ""LV"", ""LT"", ""MT"", ""NL"", ""PL"", ""SV"", ""SK"", ""SL"", ""CS"", ""HU"", ""RU"", ""SR"", ""ZH"", ""TR"", ""UK"", ""AR"", ""BS""];
		if (""cmp_customlanguages"" in window) {
			for (var a = 0; a < window.cmp_customlanguages.length; a++)
			{ b.push(window.cmp_customlanguages[a].l.toUpperCase()) }
		} return b
	}; window.");
            WriteLiteral(@"cmp_getRTLLangs = function () { return [""AR""] };
	window.cmp_getlang = function (j) {
		if (typeof (j) != ""boolean"") { j = true }
		if (j && typeof (cmp_getlang.usedlang) == ""string"" && cmp_getlang.usedlang !== """")
		{ return cmp_getlang.usedlang } var g = window.cmp_getsupportedLangs();
		var c = []; var f = location.hash; var e = location.search; var a = ""languages"" in navigator ? navigator.languages : [];
		if (f.indexOf(""cmplang="") != -1) { c.push(f.substr(f.indexOf(""cmplang="") + 8, 2).toUpperCase()) }
		else {
			if (e.indexOf(""cmplang="") != -1) { c.push(e.substr(e.indexOf(""cmplang="") + 8, 2).toUpperCase()) }
			else {
				if (""cmp_setlang"" in window && window.cmp_setlang != """") { c.push(window.cmp_setlang.toUpperCase()) }
				else { if (a.length > 0) { for (var d = 0; d < a.length; d++) { c.push(a[d]) } } }
			}
		} if (""language"" in navigator) { c.push(navigator.language) } if (""userLanguage"" in navigator) { c.push(navigator.userLanguage) } var h = """"; for (var d = 0; d < c.length; d++) {");
            WriteLiteral(@"
			var b = c[d].toUpperCase();
			if (g.indexOf(b) != -1) { h = b; break } if (b.indexOf(""-"") != -1) { b = b.substr(0, 2) } if (g.indexOf(b) != -1) { h = b; break }
		} if (h == """" && typeof (cmp_getlang.defaultlang) == ""string"" && cmp_getlang.defaultlang !== """") { return cmp_getlang.defaultlang } else { if (h == """") { h = ""EN"" } } h = h.toUpperCase(); return h
	}; (function () {
		var n = document; var p = window; var f = """";
		var b = ""_en""; if (""cmp_getlang"" in p) { f = p.cmp_getlang().toLowerCase(); if (""cmp_customlanguages"" in p) { for (var h = 0; h < p.cmp_customlanguages.length; h++) {
			 if (p.cmp_customlanguages[h].l.toUpperCase() == f.toUpperCase()) { f = ""en""; break }
		} } b = ""_"" + f } function g(e, d) { var l = """"; e += ""=""; var i = e.length; if (location.hash.indexOf(e) != -1) {
			l = location.hash.substr(location.hash.indexOf(e) + i, 9999)
		} else {
			 if (location.search.indexOf(e) != -1) { l = location.search.substr(location.search.indexOf(e) + i, 9999) } else { return d }
		");
            WriteLiteral(@"} if (l.indexOf(""&"") != -1) { l = l.substr(0, l.indexOf(""&"")) } return l } var j = (""cmp_proto"" in p) ? p.cmp_proto : ""https:""; var o = [""cmp_id"", ""cmp_params"", ""cmp_host"", ""cmp_cdn"", ""cmp_proto""]; for (var h = 0; h < o.length; h++) { if (g(o[h], ""%%%"") != ""%%%"") { window[o[h]] = g(o[h], """") } } var k = (""cmp_ref"" in p) ? p.cmp_ref : location.href; var q = n.createElement(""script""); q.setAttribute(""data-cmp-ab"", ""1""); var c = g(""cmpdesign"", """"); var a = g(""cmpregulationkey"", """"); q.src = j + ""//"" + p.cmp_host + ""/delivery/cmp.php?id="" + p.cmp_id + ""&h="" + encodeURIComponent(k) + (c != """" ? ""&cmpdesign="" + encodeURIComponent(c) : """") + (a != """" ? ""&cmpregulationkey="" + encodeURIComponent(a) : """") + (""cmp_params"" in p ? ""&"" + p.cmp_params : """") + (n.cookie.length > 0 ? ""&__cmpfcc=1"" : """") + ""&l="" + f.toLowerCase() + ""&o="" + (new Date()).getTime(); q.type = ""text/javascript""; q.async = true; if (n.currentScript) { n.currentScript.parentElement.appendChild(q) } else { if (n.body) { n.body.appendChild(q) } else { ");
            WriteLiteral(@"var m = n.getElementsByTagName(""body""); if (m.length == 0) { m = n.getElementsByTagName(""div"") } if (m.length == 0) { m = n.getElementsByTagName(""span"") } if (m.length == 0) { m = n.getElementsByTagName(""ins"") } if (m.length == 0) { m = n.getElementsByTagName(""script"") } if (m.length == 0) { m = n.getElementsByTagName(""head"") } if (m.length > 0) { m[0].appendChild(q) } } } var q = n.createElement(""script""); q.src = j + ""//"" + p.cmp_cdn + ""/delivery/js/cmp"" + b + "".min.js""; q.type = ""text/javascript""; q.setAttribute(""data-cmp-ab"", ""1""); q.async = true; if (n.currentScript) { n.currentScript.parentElement.appendChild(q) } else { if (n.body) { n.body.appendChild(q) } else { var m = n.getElementsByTagName(""body""); if (m.length == 0) { m = n.getElementsByTagName(""div"") } if (m.length == 0) { m = n.getElementsByTagName(""span"") } if (m.length == 0) { m = n.getElementsByTagName(""ins"") } if (m.length == 0) { m = n.getElementsByTagName(""script"") } if (m.length == 0) { m = n.getElementsByTagName(""head"") } if (m.length >");
            WriteLiteral(@" 0) { m[0].appendChild(q) } } }
	})(); window.cmp_addFrame = function (b) { if (!window.frames[b]) {
		 if (document.body) { var a = document.createElement(""iframe""); a.style.cssText = ""display:none""; a.name = b; document.body.appendChild(a) } else { window.setTimeout(window.cmp_addFrame, 10, b) }
	}
	}; window.cmp_rc = function (h) {
		var b = document.cookie; var f = """"; var d = 0;
		while (b != """" && d < 100) { d++; while (b.substr(0, 1) == "" "") { b = b.substr(1, b.length) } var g = b.substring(0, b.indexOf(""="")); if (b.indexOf("";"") != -1) { var c = b.substring(b.indexOf(""="") + 1, b.indexOf("";"")) } else { var c = b.substr(b.indexOf(""="") + 1, b.length) } if (h == g) { f = c } var e = b.indexOf("";"") + 1; if (e == 0) { e = b.length } b = b.substring(e, b.length) } return (f)
	}; window.cmp_stub = function () {
		var a = arguments; __cmapi.a = __cmapi.a || [];
		if (!a.length) { return __cmapi.a } else { if (a[0] === ""ping"") { if (a[1] === 2) { a[2]({ gdprApplies: gdprAppliesGlobally, cmpLoaded: false");
            WriteLiteral(@", cmpStatus: ""stub"", displayStatus: ""hidden"", apiVersion: ""2.0"", cmpId: 31 }, true) } else { a[2]({ gdprAppliesGlobally: gdprAppliesGlobally, cmpLoaded: false }, true) } } else { if (a[0] === ""getUSPData"") { a[2]({ version: 1, uspString: window.cmp_rc("""") }, true) } else { if (a[0] === ""getTCData"") { __cmapi.a.push([].slice.apply(a)) } else { if (a[0] === ""addEventListener"" || a[0] === ""removeEventListener"") { __cmapi.a.push([].slice.apply(a)) } else { if (a.length == 4 && a[3] === false) { a[2]({}, false) } else { __cmapi.a.push([].slice.apply(a)) } } } } } }
	}; window.cmp_msghandler = function (d) {
		var a = typeof d.data === ""string"";
		try { var c = a ? JSON.parse(d.data) : d.data } catch (f) { var c = null } if (typeof (c) === ""object"" && c !== null && ""__cmpCall"" in c) { var b = c.__cmpCall; window.__cmp(b.command, b.parameter, function (h, g) { var e = { __cmpReturn: { returnValue: h, success: g, callId: b.callId } }; d.source.postMessage(a ? JSON.stringify(e) : e, ""*"") }) } if (typeof (c) === ""ob");
            WriteLiteral(@"ject"" && c !== null && ""__cmapiCall"" in c) { var b = c.__cmapiCall; window.__cmapi(b.command, b.parameter, function (h, g) { var e = { __cmapiReturn: { returnValue: h, success: g, callId: b.callId } }; d.source.postMessage(a ? JSON.stringify(e) : e, ""*"") }) } if (typeof (c) === ""object"" && c !== null && ""__uspapiCall"" in c) { var b = c.__uspapiCall; window.__uspapi(b.command, b.version, function (h, g) { var e = { __uspapiReturn: { returnValue: h, success: g, callId: b.callId } }; d.source.postMessage(a ? JSON.stringify(e) : e, ""*"") }) } if (typeof (c) === ""object"" && c !== null && ""__tcfapiCall"" in c) { var b = c.__tcfapiCall; window.__tcfapi(b.command, b.version, function (h, g) { var e = { __tcfapiReturn: { returnValue: h, success: g, callId: b.callId } }; d.source.postMessage(a ? JSON.stringify(e) : e, ""*"") }, b.parameter) }
	}; window.cmp_setStub = function (a) {
		if (!(a in window) ||
			(typeof (window[a]) !== ""function"" && typeof (window[a]) !== ""object""
				&& (typeof (window[a]) === ""undefined""");
            WriteLiteral(@" || window[a] !== null))) {
					window[a] = window.cmp_stub; window[a].msgHandler = window.cmp_msghandler;
					window.addEventListener(""message"", window.cmp_msghandler, false)
		}
	}; window.cmp_addFrame(""__cmapiLocator""); window.cmp_addFrame(""__cmpLocator"");
	window.cmp_addFrame(""__uspapiLocator""); window.cmp_addFrame(""__tcfapiLocator"");
	window.cmp_setStub(""__cmapi""); window.cmp_setStub(""__cmp"");
	window.cmp_setStub(""__tcfapi""); window.cmp_setStub(""__uspapi"");
</script>
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
