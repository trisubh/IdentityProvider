#pragma checksum "D:\IdentityServer\IdentityServer\Views\User\Authenticate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c169fa5e7c69128535ee533368ae1361706e0756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Authenticate), @"mvc.1.0.view", @"/Views/User/Authenticate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Authenticate.cshtml", typeof(AspNetCore.Views_User_Authenticate))]
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
#line 1 "D:\IdentityServer\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServer;

#line default
#line hidden
#line 2 "D:\IdentityServer\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c169fa5e7c69128535ee533368ae1361706e0756", @"/Views/User/Authenticate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f39343255d883200aea98a2d0118731e125e0e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Authenticate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.cookie.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\IdentityServer\IdentityServer\Views\User\Authenticate.cshtml"
  
    ViewData["Title"] = "Authenticate";


#line default
#line hidden
            BeginContext(49, 57, true);
            WriteLiteral("    <input type=\"button\" value=\"Validate\" id=\"Login\" />\r\n");
            EndContext();
            BeginContext(108, 135, true);
            WriteLiteral("    <input type=\"text\" id=\"uid\" />\r\n    <input type=\"password\" id=\"pwd\" />\r\n    <div id=\"error\" style=\"display:none;color:red\"></div>\r\n");
            EndContext();
            BeginContext(246, 27, true);
            WriteLiteral("\r\n<h1>Authenticate</h1>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(290, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(296, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c169fa5e7c69128535ee533368ae1361706e07564805", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(347, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(353, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c169fa5e7c69128535ee533368ae1361706e07566058", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(411, 4028, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            function getParams(name) {
                var paramValue = undefined;
                var paramstring = window.location.search.split(""?"")[1];
                if (paramstring != null) {
                    var params = paramstring.split("","")

                    $.each(params, function (i, e) {
                        var obj = e.split(""="")
                        if (name == obj[0])
                            paramValue = obj[1];
                    })
                }
                return paramValue;

            }


            $(""#Login"").on(""click"", function () {
                Authenticate();
            });

            if ($.cookie(""username"") != null) {
                Authenticate();
            }


            function Authenticate() {
                if (getParams(""ClientSecret"") != null) {
                    $.ajax({
                        url: ""http://localhost:51659/authenticate"",
  ");
                WriteLiteral(@"                      type: ""POST"",
                        data: JSON.stringify({
                            ""Id"": ""1"",
                            ""FirstName"": ""a"",
                            ""LastName"": ""a"",
                            ""Username"": $(""#uid"").val(),
                            ""Password"": $(""#pwd"").val(),
                            ""Role"": ""a"",
                            ""Token"": ""a"",
                            ""ClientSecret"": getParams(""ClientSecret"")
                        }),
                        beforeSend: function (jqXHR) {
                            jqXHR.setRequestHeader(""Content-Type"", ""application/json"");
                            jqXHR.setRequestHeader(""Accept"", ""application/json"");
                            jqXHR.setRequestHeader(""IsValidatedFromProvider"", ""Yes"");
                        },
                        crossDomain: true,
                        cache: false,
                        success: function (cobj, status) {
                   ");
                WriteLiteral(@"         if (status != null) {
                                window.location.replace(cobj);
                            }
                        },
                        error: function (jqXHR, error, errorThrown) {
                            $(""#error"").html(jqXHR.responseJSON.message).show();
                        },
                    });
                }
                else {
                    $.ajax({
                        url: ""http://localhost:51659/appcentre"",
                        type: ""POST"",
                        data: JSON.stringify({
                            ""Id"": ""1"",
                            ""FirstName"": ""a"",
                            ""LastName"": ""a"",
                            ""Username"": $.cookie(""username"")!=null?$.cookie(""username""): $(""#uid"").val(),
                            ""Password"": $(""#pwd"").val(),
                            ""Role"": ""a"",
                            ""Token"": ""a"",
                            ""ClientSecret"": """"
      ");
                WriteLiteral(@"                  }),
                        beforeSend: function (jqXHR) {
                            jqXHR.setRequestHeader(""Content-Type"", ""application/json"");
                            jqXHR.setRequestHeader(""Accept"", ""application/json"");
                            jqXHR.setRequestHeader(""IsValidatedFromProvider"", ""Yes"");
                        },
                        crossDomain: true,
                        cache: false,
                        success: function (cobj, status) {
                            if (status != null) {

                                window.location.replace(cobj);
                            }
                        },
                        error: function (jqXHR, error, errorThrown) {
                            $(""#error"").html(jqXHR.responseJSON.message).show();
                        },
                    });
                }
            };
        });
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591