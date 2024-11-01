using Examples_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examples_MVC.Controllers;

public class FormularioController : Controller
{
    // GET
    public IActionResult Index()
    {
        var form = new Formulario(new TestRadio(true, false), "test");
        
        return View(form);
    }

    [HttpPost]
    public IActionResult PostForm(Formulario form)
    {
        Console.WriteLine("teste");
        return View("Index", form);
    }
}