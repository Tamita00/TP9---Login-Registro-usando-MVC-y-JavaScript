using Microsoft.AspNetCore.Mvc;

namespace TP9.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        return View("Index");
    }

    
    public IActionResult VerificarUsuario(string UserName, string Contraseña)
    {
        if(BD.MostrarInfo(UserName, Contraseña) == null) return View("Index");
        else{
            ViewBag.MostrarInfo = BD.MostrarInfo(UserName, Contraseña);
            return View("Bienvenido");
        } 
    }

    public IActionResult Registrar()
    {
        return View("Registro");
    }

[HttpPost]

    public IActionResult GuardarUsuario(string UserName, string Contraseña, int Telefono, string Nombre, string Genero)
    {
        BD.AgregarUsuario(UserName, Contraseña, Telefono, Nombre, Genero);
        return View("Index");
    }

    public IActionResult OlvidarContrasena1()
    {
        
        return View("CambiarContrasena");
    }

    public IActionResult OlvidarContrasena2(string UserName, string ContraseñaNueva)
    {
        BD.CambiarContra( UserName, ContraseñaNueva);
        return View("Index");
    }
}
