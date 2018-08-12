using ProjetoMVC_Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoMVC_Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Eduardo Oliveira",
                Tipo = "Administrador"
            };

            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            //ViewBag.Id = pessoa.PessoaId;
            //ViewBag.Nome = pessoa.Nome;
            //ViewBag.Tipo = pessoa.Tipo;

            return View(pessoa);
        }
        public ActionResult Contatos()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Lista(FormCollection form)
        //{
        //    ViewData["PessoaId"] = form["PessoaId"];
        //    ViewData["Nome"] = form["Nome"];
        //    ViewData["Tipo"] = form["Tipo"];

        //    return View();
        //}

        //public ActionResult Lista(Pessoa pessoa)
        //{
        //    ViewData["PessoaId"] = pessoa.PessoaId;
        //    ViewData["Nome"] = pessoa.Nome;
        //    ViewData["Tipo"] = pessoa.Tipo;

        //    return View();
        //}
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}