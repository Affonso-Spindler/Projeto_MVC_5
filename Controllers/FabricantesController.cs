using Projeto_MVC_5.Contexts;
using Projeto_MVC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_MVC_5.Controllers
{
    public class FabricantesController : Controller
    {
        private EFContext context = new EFContext();

        private static IList<Fabricante> fabricantes =
            new List<Fabricante>()
            {
                new Fabricante() {
                    FabricanteId = 1,
                    Nome =   "Notebooks"},
                new Fabricante() {
                    FabricanteId = 2,
                    Nome =   "Monitores"},
                new Fabricante() {
                    FabricanteId = 3,
                    Nome =   "Impressoras"},
                new Fabricante() {
                    FabricanteId = 4,
                    Nome =   "Mouses"},
                new Fabricante() {
                    FabricanteId = 5,
                    Nome =   "Desktops"}
            };

        //	GET:	Fabricantes
        public ActionResult Index()
        {
            //return View(fabricantes);
            return View(context.Fabricantes.OrderBy(c => c.Nome));
        }
    }
}
