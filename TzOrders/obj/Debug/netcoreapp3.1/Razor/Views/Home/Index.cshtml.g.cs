#pragma checksum "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c32b3cbb18745857a53a7563157c95aafec8cd4"
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
#line 1 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\_ViewImports.cshtml"
using TzOrders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\_ViewImports.cshtml"
using TzOrders.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c32b3cbb18745857a53a7563157c95aafec8cd4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34845d066381cb1d257a2cddec31cdc0a0f8ae1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TzOrders.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Продажи";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<p>\r\n\r\n    <div class=\"btn btn-sm btn-dark\">");
#nullable restore
#line 10 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml"
                                Write(Html.ActionLink("Добавить продажу", "Create", null, null, new { style = "color: white; font-weight: bold; text-decoration: none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
</p>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th>Название продажи</th>
            <th>Клиент</th>
            <th>Контактное лицо</th>
            <th>Ответственный за продажу</th>
            <th>Операции</th>
        </tr>
    </thead>

");
#nullable restore
#line 23 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contragent.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contact.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ResContact.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Редактировать", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 40 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Удалить", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Юрий\source\repos\TzOrders\TzOrders\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TzOrders.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
