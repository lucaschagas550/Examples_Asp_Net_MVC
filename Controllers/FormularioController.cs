using Microsoft.AspNetCore.Mvc;

namespace Examples_MVC.Controllers;

public class FormularioController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View("Index","Teste Nome");
    }
}