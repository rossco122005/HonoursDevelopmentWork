#pragma checksum "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47863c3aaa99016e1575e6b1cac2d231d3a0f3e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Edit), @"mvc.1.0.view", @"/Views/Games/Edit.cshtml")]
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
#line 1 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\_ViewImports.cshtml"
using GameConsume;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\_ViewImports.cshtml"
using GameConsume.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47863c3aaa99016e1575e6b1cac2d231d3a0f3e0", @"/Views/Games/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f36b9856f6c7e1d197745fb440f7e50d831a5ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<v2.shared.Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Game</h4>
<hr />
<script src=""https://code.jquery.com/jquery-3.6.0.js""></script>
<!--UPDATE FUNCTION-->
<script type=""text/javascript"">
function updateGame() {
    var game = {gameID:0, gameTitle :"""", genre:"""", releaseYear:"""", description:""""};
    game.gameID = ");
#nullable restore
#line 16 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\Edit.cshtml"
             Write(Model.GameID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    game.gameTitle = document.getElementById(""GameTitle"").value;
    game.genre = document.getElementById(""Genre"").value;
    game.releaseYear = document.getElementById(""ReleaseYear"").value;
    game.description = document.getElementById(""Description"").value;
    $.ajax({
        type: ""PUT"",
        data :JSON.stringify(game),
        url: ""https://localhost:5001/api/games/"" + ");
#nullable restore
#line 24 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\Edit.cshtml"
                                              Write(Model.GameID);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        contentType: \"application/json\"\r\n    });\r\n    window.location.replace(\"https://localhost:5002/Games\");\r\n};\r\n</script>\r\n\r\n\r\n<table>\r\n    <tr>\r\n        <th>Game Title</th>\r\n    </tr>\r\n    <tr>\r\n        <td><input type=\"text\" id=\"GameTitle\"");
            BeginWriteAttribute("value", " value=\"", 1022, "\"", 1046, 1);
#nullable restore
#line 37 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\Edit.cshtml"
WriteAttributeValue("", 1030, Model.GameTitle, 1030, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" size=\"50\"></td>\r\n    </tr>\r\n    <tr>\r\n        <th>Genre</th>\r\n    </tr>\r\n    <tr>\r\n        <td><input type=\"text\" id=\"Genre\"");
            BeginWriteAttribute("value", " value=\"", 1172, "\"", 1192, 1);
#nullable restore
#line 43 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\Edit.cshtml"
WriteAttributeValue("", 1180, Model.Genre, 1180, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" size=\"50\"></td>\r\n    </tr>\r\n    <tr>\r\n        <th>Release Year</th>\r\n    </tr>\r\n    <tr>\r\n        <td><input type=\"text\" id=\"ReleaseYear\"");
            BeginWriteAttribute("value", " value=\"", 1331, "\"", 1357, 1);
#nullable restore
#line 49 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\Edit.cshtml"
WriteAttributeValue("", 1339, Model.ReleaseYear, 1339, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" size=\"50\"></td>\r\n    </tr>\r\n    <tr>\r\n        <th>Description</th>\r\n    </tr>\r\n    <tr>\r\n        <td><input type=\"text\" id=\"Description\"");
            BeginWriteAttribute("value", " value=\"", 1495, "\"", 1521, 1);
#nullable restore
#line 55 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\Edit.cshtml"
WriteAttributeValue("", 1503, Model.Description, 1503, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" size=\"50\"></td>\r\n    </tr>\r\n</table>\r\n\r\n<input type=\"submit\" value=\"Create\" onclick=\"updateGame()\" class=\"btn btn-primary\" />\r\n\r\n</br>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47863c3aaa99016e1575e6b1cac2d231d3a0f3e07890", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<v2.shared.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
