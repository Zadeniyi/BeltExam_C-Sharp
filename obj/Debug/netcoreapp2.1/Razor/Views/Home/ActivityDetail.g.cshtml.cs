#pragma checksum "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e21553445385ba1a3dc1708d178316ee2c17b4b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ActivityDetail), @"mvc.1.0.view", @"/Views/Home/ActivityDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ActivityDetail.cshtml", typeof(AspNetCore.Views_Home_ActivityDetail))]
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
#line 1 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 2 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e21553445385ba1a3dc1708d178316ee2c17b4b5", @"/Views/Home/ActivityDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ActivityDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewActivity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 21, true);
            WriteLiteral("\r\n<h1>Activity Name: ");
            EndContext();
            BeginContext(42, 17, false);
#line 3 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
              Write(ViewBag.act.Title);

#line default
#line hidden
            EndContext();
            BeginContext(59, 26, true);
            WriteLiteral("</h1>\r\n<h3>Date:</h3> <h4>");
            EndContext();
            BeginContext(86, 19, false);
#line 4 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
              Write(ViewBag.act.ActDate);

#line default
#line hidden
            EndContext();
            BeginContext(105, 26, true);
            WriteLiteral("</h4>\r\n<h3>Time:</h3> <h4>");
            EndContext();
            BeginContext(132, 16, false);
#line 5 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
              Write(ViewBag.act.Time);

#line default
#line hidden
            EndContext();
            BeginContext(148, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 6 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
  
    bool temp = false;
    foreach(var rando in @ViewBag.act.ActtoUser){   
            if ( @ViewBag.Userid == @rando.User.UserId){
            temp = true;
            }
        }
        if (temp ==false){

#line default
#line hidden
            BeginContext(375, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 389, "\"", 444, 4);
            WriteAttributeValue("", 396, "/joinact/", 396, 9, true);
#line 14 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
WriteAttributeValue("", 405, ViewBag.act.ActivityId, 405, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 428, "/", 428, 1, true);
#line 14 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
WriteAttributeValue("", 429, ViewBag.UserId, 429, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(445, 28, true);
            WriteLiteral("><button>Join</button></a>\r\n");
            EndContext();
#line 15 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
        }
        else{

#line default
#line hidden
            BeginContext(499, 54, true);
            WriteLiteral("            <h2>RSVP Status: <em>You\'re In</em></h2>\r\n");
            EndContext();
#line 18 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
        }

#line default
#line hidden
            BeginContext(567, 28, true);
            WriteLiteral("\r\n<h3>Coordinator:</h3> <h4>");
            EndContext();
            BeginContext(596, 25, false);
#line 21 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
                     Write(ViewBag.theuser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(621, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(623, 24, false);
#line 21 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
                                                Write(ViewBag.theuser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(647, 41, true);
            WriteLiteral("</h4>\r\n<h3>Description:</h3>\r\n<h5><p><em>");
            EndContext();
            BeginContext(689, 23, false);
#line 23 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
      Write(ViewBag.act.Description);

#line default
#line hidden
            EndContext();
            BeginContext(712, 46, true);
            WriteLiteral("</em></p></h5>\r\n<h3>Participants:</h3>\r\n<ul>\r\n");
            EndContext();
#line 26 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
     foreach(var people in ViewBag.act.ActtoUser){

#line default
#line hidden
            BeginContext(810, 12, true);
            WriteLiteral("    <h5><li>");
            EndContext();
            BeginContext(823, 21, false);
#line 27 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
       Write(people.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(844, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(846, 20, false);
#line 27 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
                              Write(people.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(866, 12, true);
            WriteLiteral("</li></h5>\r\n");
            EndContext();
#line 28 "C:\Users\Sasuke\Documents\Coding Dojo\C#\ORM\EntityFramework\BeltExam\ActivityCenter\Views\Home\ActivityDetail.cshtml"
    }

#line default
#line hidden
            BeginContext(885, 11, true);
            WriteLiteral("    \r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewActivity> Html { get; private set; }
    }
}
#pragma warning restore 1591
