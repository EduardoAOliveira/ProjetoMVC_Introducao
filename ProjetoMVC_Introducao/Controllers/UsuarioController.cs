using ProjetoMVC_Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoMVC_Introducao.Controllers
{
    public class UsuarioController : Controller
    {        
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View();
        }
        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {       

            //if (usuario.Senha != usuario.ConfirmaçãoSenha)
            //{
            //    ModelState.AddModelError("", "Senhas são diferentes");// exibir no summary a mensagem de erro.
            //}
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);// Vai para resultado.
            }
            return View(usuario);// vai para Index.
        }
        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
    }
}