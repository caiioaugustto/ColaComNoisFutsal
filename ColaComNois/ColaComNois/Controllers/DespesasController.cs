using AutoMapper;
using ColaComNois.Context.DB;
using ColaComNois.Entidades;
using ColaComNois.Filters;
using ColaComNois.Repository;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ColaComNois.Controllers
{
    [AutorizacaoFilter]
    public class DespesasController : Controller
    {
        private DespesasRepository _despesasRepo;

        public DespesasController(DespesasRepository _despesasRepo)
        {
            this._despesasRepo = _despesasRepo;
        }

        public ActionResult Index()
        {
            var despesasViewModel = Mapper.Map<IList<CCN_Despesas>, IList<Despesas>>(_despesasRepo.ObterTodos());
            return View(despesasViewModel);
        }

        public ActionResult Details(int id)
        {
            var despesaPorId = _despesasRepo.ObterPorId(id);
            var despesasVieModel = Mapper.Map<CCN_Despesas, Despesas>(despesaPorId);

            return View(despesasVieModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Despesas despesa)
        {
            if (ModelState.IsValid)
            {
                var despesaDomain = Mapper.Map<CCN_Despesas>(despesa);
                _despesasRepo.Adicionar(despesaDomain);

                return RedirectToAction("Index");
            }
            else
            {
                return View(despesa);
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
