#pragma checksum "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29987b65e2d924f16cf0eaf712b5162b54bd57ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Order), @"mvc.1.0.view", @"/Views/Home/Order.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29987b65e2d924f16cf0eaf712b5162b54bd57ec", @"/Views/Home/Order.cshtml")]
    public class Views_Home_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_3_1.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
  
    ViewData["Title"] = "Заказы";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29987b65e2d924f16cf0eaf712b5162b54bd57ec3452", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Заказы</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29987b65e2d924f16cf0eaf712b5162b54bd57ec4512", async() => {
                WriteLiteral("\r\n    <h3>Заказы</h3>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29987b65e2d924f16cf0eaf712b5162b54bd57ec4797", async() => {
                    WriteLiteral("Перейти на главную");
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
                WriteLiteral(@"
    <table class=""table-condensed"">
        <tr>
            <td>Номер заказа</td>
            <td>Ширина</td>
            <td>Высота</td>
            <td>Управление</td>
            <td>Имя и фамилия покупателя</td>
            <td>Адрес покупателя</td>
            <td>E-mail</td>
            <td>Контактный  телефон покупателя</td>
            <td>Индекс жалюзи</td>
           

        </tr>
");
#nullable restore
#line 31 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 34 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
       Write(order.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
       Write(order.Height);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
       Write(order.Width);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
       Write(order.Control);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
       Write(order.Userr);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 39 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
       Write(order.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 40 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
       Write(order.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 41 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
       Write(order.ContactPhone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 42 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
       Write(order.JaluziId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n       \r\n        <td>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 47 "D:\Институт\6Семестр\СМПТРЗ\jaluzi\MVC_3_1\Views\Home\Order.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_3_1.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
