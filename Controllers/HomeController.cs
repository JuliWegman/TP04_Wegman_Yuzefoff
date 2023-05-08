using Microsoft.AspNetCore.Mvc;

namespace TP04_Wegman_Yuzefoff.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        
        ViewBag.Paquetes=OrtWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete(){
        ViewBag.hoteles=OrtWorld.ListaHoteles;
        ViewBag.aereos=OrtWorld.ListaAereos;
        ViewBag.Excursiones=OrtWorld.ListaExcursiones;
        ViewBag.destinos=OrtWorld.ListaDestinos;
        return View();
    }
}
