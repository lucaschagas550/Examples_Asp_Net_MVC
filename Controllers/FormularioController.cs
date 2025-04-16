using Examples_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examples_MVC.Controllers;

public class FormularioController : Controller
{
    // GET
    public IActionResult Index(Formulario request)
    {
        var form = new Formulario(new TestRadio(true, false), "test");
        form.ExercicioDe = request.ExercicioDe;
        form.ExercicioAte = request.ExercicioAte;

        CreateViewBag();

        return View(form);
    }

    [HttpPost]
    public IActionResult PostForm(Formulario form)
    {
        Console.WriteLine("teste");
        return View("Index", form);
    }

    [HttpPost]
    public IActionResult PostSelectListExercicio(Formulario form)
    {
        Console.WriteLine("teste");
        return RedirectToAction("Index", form);
    }

    private void CreateViewBag()
    {
        var startYear = 1995;
        var currentYear = DateTime.Now.Year;

        ViewBag.ExercicioIniciadoEm1995 = Enumerable.Range(startYear, currentYear - startYear + 1)
                  .OrderByDescending(x => x)
                  .Select(x => new SelectListItem { Value = x.ToString(), Text = x.ToString() })
                  .ToList();

    }
}