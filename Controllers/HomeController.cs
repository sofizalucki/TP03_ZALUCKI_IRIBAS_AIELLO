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
        MusicStore.InicializarDiscografica();
        ViewBag.Discos = MusicStore.Discos;
        return View();
    }
    public IActionResult mostrarDiscos(int ID){
        bool Contiene = MusicStore.Discos.ContainsKey(ID);
        if(Contiene){
        ViewBag.Disco = MusicStore.Discos[ID];
        ViewBag.Temas = MusicStore.Discos[ID].Temas;
        }
        return View();
    }
}
