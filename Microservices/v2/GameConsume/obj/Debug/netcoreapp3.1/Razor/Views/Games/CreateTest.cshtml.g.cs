#pragma checksum "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\CreateTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd19b10ac04a7f0a7293564a31aded66faa08246"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_CreateTest), @"mvc.1.0.view", @"/Views/Games/CreateTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd19b10ac04a7f0a7293564a31aded66faa08246", @"/Views/Games/CreateTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f36b9856f6c7e1d197745fb440f7e50d831a5ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_CreateTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<v2.shared.Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ross\Documents\UWS\Year 4\Term 1\Computing Honours Project\Development Work\GitHub Repo\Microservices\v2\GameConsume\Views\Games\CreateTest.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create Test</h1>
<hr />
<script src=""https://code.jquery.com/jquery-3.6.0.js""></script>

<!--CREATE FUNCTION-->
<script type=""text/javascript"">
function createGame() {
    var game = {gameTitle :"""", genre:"""", releaseYear:"""", description:""""};
    game.gameTitle = ""Test Title"";
    game.genre = ""Test Genre"";
    game.releaseYear = ""2022"";
    game.description = ""Test Description"";
    $.ajax({
        type: ""POST"",
        data :JSON.stringify(game),
        url: ""https://localhost:5001/api/games"",
        contentType: ""application/json""
    });
};
</script>


<!--<<body onload=""createGame()""></body>-->

<script>
    createGame();
</script>");
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
