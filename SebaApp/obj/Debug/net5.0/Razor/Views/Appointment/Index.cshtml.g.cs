#pragma checksum "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebe5f807946e1a69fb1d1f6a069c2e27e5a4cf44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_Index), @"mvc.1.0.view", @"/Views/Appointment/Index.cshtml")]
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
#line 1 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\_ViewImports.cshtml"
using SebaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\_ViewImports.cshtml"
using SebaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebe5f807946e1a69fb1d1f6a069c2e27e5a4cf44", @"/Views/Appointment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"540e330e1e9323325285f203a50fc8c6636dd12c", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SebaApp.Models.Appointment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebe5f807946e1a69fb1d1f6a069c2e27e5a4cf443701", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.appointID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AppointmentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AppoinmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.About_Appointment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AppointmentStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Doctor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Patient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.appointID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppointmentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppoinmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TimeSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.About_Appointment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 65 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
                 if (item.AppointmentStatus == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-outline-success \">Pending</button>\r\n");
#nullable restore
#line 68 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
                }
                else if (item.AppointmentStatus == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-outline-success \">Accepted</button>\r\n");
#nullable restore
#line 72 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-outline-danger \">Appointment Not accepted </button>\r\n");
#nullable restore
#line 76 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Doctor.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 82 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.Doctor.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                 ");
#nullable restore
#line 85 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
            Write(Html.DisplayFor(modelItem => item.Patient.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 85 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.Patient.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 89 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 90 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 93 "C:\Users\lovet\source\repos\SebaApp\SebaApp\Views\Appointment\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SebaApp.Models.Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
