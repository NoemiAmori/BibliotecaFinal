#pragma checksum "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06608525cdca76bd985b01256f7b3919f02c01fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listagem), @"mvc.1.0.view", @"/Views/Usuario/Listagem.cshtml")]
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
#line 1 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06608525cdca76bd985b01256f7b3919f02c01fe", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Livros";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Nome</th>
                    <th>Username</th>
                    <th>Senha</th>
                    <th></th>
                </tr>
            </thead>

");
#nullable restore
#line 19 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
             if (Model.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
                     foreach (Usuario u in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
                           Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 835, "\"", 863, 2);
            WriteAttributeValue("", 842, "/Usuario/Edicao/", 842, 16, true);
#nullable restore
#line 29 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 858, u.Id, 858, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n");
#nullable restore
#line 33 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
            }

            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-danger\">Nenhum usuário encontrado!</p>\r\n");
#nullable restore
#line 38 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 07\Biblioteca\Views\Usuario\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
