using Microsoft.AspNetCore.Mvc;

namespace TP9.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        
        return View();
    }

    public IActionResult Registro()
    {
        return View("Registro");
    }

    public IActionResult OlvidarContrasena()
    {
        return View("OlvidarContrasena");
    }

    public IActionResult Bienvenido()
    {
        return View("Bienvenido");
    }
}
