using Microsoft.AspNetCore.Mvc;

namespace TP04_Wegman_Yuzefoff.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paquetes=OrtWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete()
    {
        ViewBag.hoteles=OrtWorld.ListaHoteles;
        ViewBag.aereos=OrtWorld.ListaAereos;
        ViewBag.excursiones=OrtWorld.ListaExcursiones;
        ViewBag.destinos=OrtWorld.ListaDestinos;
        return View();
    }
    public IActionResult GuardarPaquete(string destinoSeleccionado, int HotelElegido, int AereoElegido, int ExcursionElegido)
    {
         Paquete x = new Paquete(OrtWorld.ListaHoteles[HotelElegido],OrtWorld.ListaAereos[AereoElegido],OrtWorld.ListaExcursiones[ExcursionElegido]);
         bool Existe=OrtWorld.IngresarPaquete(destinoSeleccionado,x);
        if(Existe){
        OrtWorld.Paquetes.Add(destinoSeleccionado,x);
        return RedirectToAction("Index");
        }else{
            return RedirectToAction("SelectPaquete");
        }
        
        
    }
}