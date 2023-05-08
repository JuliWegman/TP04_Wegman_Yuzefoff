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
        return View();
    }
}
