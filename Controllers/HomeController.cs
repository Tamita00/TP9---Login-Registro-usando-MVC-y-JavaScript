using Microsoft.AspNetCore.Mvc;

namespace TP9.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        return View();
    }

    
    public IActionResult VerificarUsuario(string UserName, string Contraseña)
    {
        if(BD.MostrarInfo(UserName, Contraseña) == null) return View();
        else return View("Bienvenido");
    }

    public IActionResult Bienvenido(string UserName, string Contraseña)
    {
        ViewBag.MostrarInfo = BD.MostrarInfo(UserName, Contraseña);
        return View("Bienvenido");
    }


    
    public IActionResult Registrar()
    {
        return View("Registro");
    }

[HttpPost]
    public IActionResult GuardarUsuario(string UserName, string Contraseña, int Telefono, string Nombre, string Genero)
    {
        BD.AgregarUsuario(UserName, Contraseña, Telefono, Nombre, Genero);
        return RedirectToAction();
    }

    public IActionResult OlvidarContrasena(string UserName, string ContraseñaNueva)
    {
        BD.CambiarContra( UserName, ContraseñaNueva);
        return View();
    }
}
