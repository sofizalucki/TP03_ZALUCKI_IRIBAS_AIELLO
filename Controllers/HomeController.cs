using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_03_ZIA.Models;

namespace TP_03_ZIA.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //MusicStore.inicializarDiscografica;
        //ViewBag.Discos = MusicStore.Discos
        return View();
    }
    /*public IActionResult discoExiste(string nombre){
        bool Contiene = Discos.ContainsKey(nombre);
        
    }*/
}
