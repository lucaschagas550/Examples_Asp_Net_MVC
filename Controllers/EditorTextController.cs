using Examples_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examples_MVC.Controllers
{
    public class EditorTextController : Controller
    {
        public static EditorTexto textoPublic = new EditorTexto();

        public EditorTextController()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(textoPublic);
        }

        [HttpPost]
        public IActionResult Create(EditorTexto editorTexto)
        {
            textoPublic.Content = editorTexto.Content;

            return RedirectToAction("Index");
        }
    }
}
