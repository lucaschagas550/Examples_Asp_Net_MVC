using Examples_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examples_MVC.Controllers
{
    public class SelectListController : Controller
    {
        public SelectListController()
        {
            
        }

        [HttpGet]
        public IActionResult Index(List<int> paisesSelecionadosId)
        {

            var paises = new List<Paises>()
            {
                new Paises { Id = 1, Nome = "Brasil"},
                new Paises { Id = 2, Nome = "Argentina"},
                new Paises { Id = 3, Nome = "Chile"},
                new Paises { Id = 4, Nome = "Uruguai"},
                new Paises { Id = 5, Nome = "Paraguai"}
            };

            CriarViewBag(paises);
            return View(paisesSelecionadosId);
        }

        private void CriarViewBag(List<Paises> paises)
        {
            ViewBag.Paises = new SelectList(paises, "Id", "Nome");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PaisesCreate request)
        {
            Console.WriteLine(request);
            return RedirectToAction("Index", new { paisesSelecionadosId = request.PaisesId });
        }

    }
}
