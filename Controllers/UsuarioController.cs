using System.Collections.Generic;
using System.Collections;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin (this, HttpContext.Session.GetString("user"));
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario u)
        {
            UsuarioService usuarioService = new UsuarioService();

            if (u.Id == 0)
            {
                usuarioService.Inserir(u);
            }
            else
            {
                Usuario user = usuarioService.ObterPorId(u.Id);

                if (string.IsNullOrEmpty(u.Nome.Trim()))
                {
                    u.Nome = user.Nome;
                }
                if (string.IsNullOrEmpty(u.Username.Trim()))
                {
                    u.Username = user.Username;
                }
                if (string.IsNullOrEmpty(u.Senha.Trim()))
                {
                    u.Senha = user.Senha;
                }
                else
                {
                    u.Senha = Criptografia.CriptografarTexto(u.Senha);
                }
                usuarioService.Atualizar(u);
            }

            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem()
        {
            Autenticacao.CheckLogin (this, HttpContext.Session.GetString("user"));
            UsuarioService usuarioService = new UsuarioService();

            return View(usuarioService.ListarTodos());
        }

        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin (this, HttpContext.Session.GetString("user"));
            UsuarioService usuarioService = new UsuarioService();
            Usuario u = usuarioService.ObterPorId(id);

            return View(u);
        }

        public IActionResult Remover (int id)
        {
            UsuarioService us = new UsuarioService();
            Usuario user = us.ObterPorId(id);

            return View(user);
        }

        [HttpPost]
        public IActionResult Excluir (Usuario user)
        {
            if (user.Username == "admin")

            {
                ViewBag.Erro = "Usuário não pode ser removido!!!";
                return View (user);
            }

            else
            {
                UsuarioService us = new UsuarioService();
                us.Deletar(user);

                return RedirectToAction ("Listagem");
            }
        }
    }
} 