#pragma checksum "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec4cec79ad91188a94c2a2e920df30ae86522a05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetEmployeeList), @"mvc.1.0.view", @"/Views/Home/GetEmployeeList.cshtml")]
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
#line 1 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\_ViewImports.cshtml"
using EmployeeList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\_ViewImports.cshtml"
using EmployeeList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4cec79ad91188a94c2a2e920df30ae86522a05", @"/Views/Home/GetEmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4ff3577521d80a7e92fd80c9f0d6f814cca0c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetEmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeList.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml"
  
    ViewData["Title"] = "Employee List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Employee List</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\"><h3>Name</h3></div>\r\n    <div class=\"col-md-4\"><h3>Salary</h3></div>\r\n    <div class=\"col-md-4\"><h3>Permanent</h3></div>\r\n</div>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml"
 foreach (Employee emp in Model)
{
    if (emp.IsPermanent == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-4\"><b>");
#nullable restore
#line 20 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml"
                                Write(emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n            <div class=\"col-md-4\"><b>");
#nullable restore
#line 21 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml"
                                Write(emp.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n            <div class=\"col-md-4\"><b>");
#nullable restore
#line 22 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml"
                                Write(emp.IsPermanent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 28 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml"
                             Write(emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 29 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml"
                             Write(emp.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 30 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml"
                             Write(emp.IsPermanent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\889834\source\repos\EmployeeList\EmployeeList\Views\Home\GetEmployeeList.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeList.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
