#pragma checksum "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65a8b558a7c76eed71f531092cffe98a9103c3d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\_ViewImports.cshtml"
using CRUDApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\_ViewImports.cshtml"
using CRUDApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a8b558a7c76eed71f531092cffe98a9103c3d7", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"908dad5fdd07b80c408a1bb28a63cf5866d8c259", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeListVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<a href=\"/Employee/AddUpdateEmployee\" class=\"btn btn-info\">Add</a> <br />\r\n");
#nullable restore
#line 8 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label style=\"color:green\">");
#nullable restore
#line 10 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
                          Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 11 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Employee ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Age</th>
            <th>DBO</th>
            <th>City</th>
            <th> </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
               Write(item.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
               Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
               Write(item.DOB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
               Write(item.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 901, "\"", 955, 2);
            WriteAttributeValue("", 908, "/Employee/AddUpdateEmployee?id=", 908, 31, true);
#nullable restore
#line 34 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
WriteAttributeValue("", 939, item.EmployeeId, 939, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Edit</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1010, "\"", 1069, 2);
            WriteAttributeValue("", 1017, "/Employee/DeleteEmployee?EmployeeID=", 1017, 36, true);
#nullable restore
#line 35 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1053, item.EmployeeId, 1053, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\globe365india\source\repos\CRUDApplication\CRUDApplication\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeListVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
