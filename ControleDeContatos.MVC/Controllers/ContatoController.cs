using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ControleDeContatos.Application.Interface;
using ControleDeContatos.Domain.Entities;
using ControleDeContatos.MVC.ViewModels;

namespace ControleDeContatos.MVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoAppService _contatoApp;

        public ContatoController(IContatoAppService contatoApp)
        {
            _contatoApp = contatoApp;
        }

        // GET: Contato
        public ActionResult Index()
        {
            var contatoViewModel = Mapper.Map<IEnumerable<Contato>, IEnumerable<ContatoViewModel>>(_contatoApp.GetAll());
            return View(contatoViewModel);
        }

        public ActionResult Criar()
        {
            return View();
        }

        public ActionResult Editar(int id)
        {
            var contato = _contatoApp.GetById(id);
            var contatoDomain = Mapper.Map<Contato, ContatoViewModel>(contato);
           
            return View(contatoDomain);
        }

        public ActionResult ApagarConfirmacao(int id)
        {

            var contato = _contatoApp.GetById(id);
            var contatoDomain = Mapper.Map<Contato, ContatoViewModel>(contato);
            return View(contatoDomain);
        }

        [HttpPost]
        public ActionResult Criar(ContatoViewModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var contatoDomain = Mapper.Map<ContatoViewModel, Contato>(contato);
                    _contatoApp.Add(contatoDomain);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(contato);
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu contato, tente novamente, detalhe do erro: {e.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Alterar(ContatoViewModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var contatoDomain = Mapper.Map<ContatoViewModel, Contato>(contato);
                    _contatoApp.Update(contatoDomain);
                    TempData["MensagemSucesso"] = "Contato alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", contato);
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu contato, tente novamente, detalhe do erro: {e.Message}";
                return RedirectToAction("Index");
            }
        }

        public ActionResult Apagar(int id)
        {
            try
            {
                var contato = _contatoApp.GetById(id);
                if (contato != null)
                {
                    _contatoApp.Remove(contato);
                    TempData["MensagemSucesso"] = "Contato apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato!";
                }
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu contato, mais detalhes do erro: {e.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}