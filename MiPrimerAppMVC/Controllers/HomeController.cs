using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiPrimerAppMVC.Models;

namespace MiPrimerAppMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Message"] = "Hello World";
        string Mensaje = "Hola variables de vista";
        ViewBag.MensajeIN = Mensaje;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult  VistaDemo()
    {
        return View();
    }
}
