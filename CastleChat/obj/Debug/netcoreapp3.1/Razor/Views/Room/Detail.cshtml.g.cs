#pragma checksum "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4cf8277c3fee5bbb1df289e2ebd6ab498dedf58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Detail), @"mvc.1.0.view", @"/Views/Room/Detail.cshtml")]
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
#line 1 "D:\CastleChat\CastleChat\Views\_ViewImports.cshtml"
using CastleChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CastleChat\CastleChat\Views\_ViewImports.cshtml"
using CastleChat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4cf8277c3fee5bbb1df289e2ebd6ab498dedf58", @"/Views/Room/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b580e13bf9a297530e5b3c79e406951892c64b", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CastleChat.Models.Room>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
  
    ViewData["Title"] = Model.title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://cdn.tiny.cloud/1/uvgdoko25cnan2u4rt9n9uat33hvoah26qqhieavnv49kfxy/tinymce/5/tinymce.min.js\" referrerpolicy=\"origin\"></script>\r\n<script>tinymce.init({ selector: \'textarea\' });</script>\r\n<h1>");
#nullable restore
#line 7 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"alert alert-secondary border-0 rounded-0 text-black\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 380, "\"", 404, 1);
#nullable restore
#line 9 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 386, Model.author.icon, 386, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:50px; height:50px;border-radius:50px;\" />\r\n    <span><a");
            BeginWriteAttribute("href", " href=\"", 474, "\"", 518, 2);
            WriteAttributeValue("", 481, "/Account/?name=", 481, 15, true);
#nullable restore
#line 10 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 496, Model.author.username, 496, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: black;\">");
#nullable restore
#line 10 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
                                                                           Write(Model.author.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n    <br><span><small>Reg Date: ");
#nullable restore
#line 11 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
                          Write(Model.author.regDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></span><br>\r\n    <span><small>Post Date: ");
#nullable restore
#line 12 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
                       Write(Model.pubDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></span><br>\r\n    <hr>\r\n");
#nullable restore
#line 14 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
     if (Model.filePath != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 776, "\"", 797, 1);
#nullable restore
#line 16 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 782, Model.filePath, 782, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 300px; width: auto\"><br>\r\n");
#nullable restore
#line 17 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 18 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
  Write(Html.Raw(Model.text));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

</div>
<script>
    function togglehide(id) {
        var x = document.getElementById(""Reply_"" + id);
        if (x.style.display === ""none"") {
            x.style.display = ""block"";
        } else {
            x.style.display = ""none"";
        }
    }
</script>

");
#nullable restore
#line 32 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
 foreach (var i in ViewBag.Disc.discussions)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-secondary border-0 rounded-0 text-black\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 1284, "\"", 1304, 1);
#nullable restore
#line 35 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 1290, i.author.icon, 1290, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:50px; height:50px;border-radius:50px;\" />\r\n    <span><a");
            BeginWriteAttribute("href", " href=\"", 1374, "\"", 1414, 2);
            WriteAttributeValue("", 1381, "/Account/?name=", 1381, 15, true);
#nullable restore
#line 36 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 1396, i.author.username, 1396, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: black;\">");
#nullable restore
#line 36 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
                                                                       Write(i.author.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n    <br><span><small>Reg Date: ");
#nullable restore
#line 37 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
                          Write(i.author.regDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></span><br>\r\n    <span><small>Post Date: ");
#nullable restore
#line 38 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
                       Write(i.pubDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></span><br>\r\n    <hr>\r\n");
#nullable restore
#line 40 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
     try
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
         if (i.discussion.id != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"ml-2 mr-2 p-2\" style=\"background:#eeeeee; border:1px solid #cccccc;\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1771, "\"", 1791, 1);
#nullable restore
#line 44 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 1777, i.author.icon, 1777, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:50px; height:50px;border-radius:50px;\" />\r\n            <span><a");
            BeginWriteAttribute("href", " href=\"", 1869, "\"", 1909, 2);
            WriteAttributeValue("", 1876, "/Account/?name=", 1876, 15, true);
#nullable restore
#line 45 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 1891, i.author.username, 1891, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: black;\">");
#nullable restore
#line 45 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
                                                                               Write(i.author.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span><br><hr>\r\n");
#nullable restore
#line 46 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
             if (i.discussion.filePath != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 2056, "\"", 2084, 1);
#nullable restore
#line 48 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 2062, i.discussion.filePath, 2062, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 300px; width: auto\"><br>\r\n");
#nullable restore
#line 49 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 50 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
       Write(Html.Raw(i.discussion.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div><br>\r\n");
#nullable restore
#line 52 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
         
    }
    catch { }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
     if (i.filePath != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 2290, "\"", 2307, 1);
#nullable restore
#line 57 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 2296, i.filePath, 2296, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 300px; width: auto\"><br>\r\n");
#nullable restore
#line 58 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 59 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
  Write(Html.Raw(i.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br>\r\n    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2408, "\"", 2435, 3);
            WriteAttributeValue("", 2418, "togglehide(", 2418, 11, true);
#nullable restore
#line 61 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 2429, i.id, 2429, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2434, ")", 2434, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\"><i class=\"fa fa-reply mr-2\" aria-hidden=\"true\"></i>Reply</button>\r\n</div>\r\n    <div");
            BeginWriteAttribute("id", " id=\"", 2549, "\"", 2565, 2);
            WriteAttributeValue("", 2554, "Reply_", 2554, 6, true);
#nullable restore
#line 63 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 2560, i.id, 2560, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none;\">\r\n");
#nullable restore
#line 64 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4cf8277c3fee5bbb1df289e2ebd6ab498dedf5815346", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"replyid\"");
                BeginWriteAttribute("value", " value=\"", 2797, "\"", 2810, 1);
#nullable restore
#line 67 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue("", 2805, i.id, 2805, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                <small>*Optional</small>
                <input type=""file"" name=""file"" class=""form-control"" style=""width: 100%;"" accept=""image/*""><br>
                <textarea name=""text"" class=""form-control texta"" style=""width: 100%; height: 300px; resize: none;""");
                BeginWriteAttribute("id", " id=\"", 3082, "\"", 3099, 2);
                WriteAttributeValue("", 3087, "editor", 3087, 6, true);
#nullable restore
#line 70 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
WriteAttributeValue(" ", 3093, i.id, 3094, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></textarea><br>\r\n                <button type=\"submit\" class=\"btn btn-outline-secondary\" style=\"width: 100%;\"><i class=\"fa fa-reply mr-2\" aria-hidden=\"true\"></i>Reply</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2674, "/Room/AddReply/", 2674, 15, true);
#nullable restore
#line 66 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
AddHtmlAttributeValue("", 2689, Model.id, 2689, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 73 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <h4><a href=\"/Account/Login/\" class=\"btn btn-outline-secondary\">Login to leave comments</a></h4>\r\n            </div>\r\n");
#nullable restore
#line 79 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n    </div>\r\n");
#nullable restore
#line 82 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 84 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
 if (ViewBag.Disc.PageViewModel.HasPreviousPage)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4cf8277c3fee5bbb1df289e2ebd6ab498dedf5819634", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
                                WriteLiteral(ViewBag.Disc.PageViewModel.PageNumber - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 87 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
 if (ViewBag.Disc.PageViewModel.HasNextPage)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4cf8277c3fee5bbb1df289e2ebd6ab498dedf5822219", async() => {
                WriteLiteral("Forward");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
                                WriteLiteral(ViewBag.Disc.PageViewModel.PageNumber + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 91 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 94 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4cf8277c3fee5bbb1df289e2ebd6ab498dedf5824837", async() => {
                WriteLiteral(@"
        <small>*Optional</small>
        <input type=""file"" name=""file"" class=""form-control"" style=""width: 100%;"" accept=""image/*""><br>
        <textarea name=""text"" class=""form-control texta"" style=""width: 100%; height: 250px; resize: none;"" id=""editor#1""></textarea><br>
        <button type=""submit"" class=""btn btn-outline-secondary"" style=""width: 100%;"">Reply</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3986, "/Room/AddDiscuss/", 3986, 17, true);
#nullable restore
#line 96 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
AddHtmlAttributeValue("", 4003, Model.id, 4003, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <br>\r\n");
#nullable restore
#line 103 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-4\">\r\n        <h4><a href=\"/Account/Login/\" class=\"btn btn-outline-secondary\">Login to leave comments</a></h4>\r\n    </div>\r\n");
#nullable restore
#line 109 "D:\CastleChat\CastleChat\Views\Room\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CastleChat.Models.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591