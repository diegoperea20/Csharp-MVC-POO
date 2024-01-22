using Microsoft.AspNetCore.Mvc;
using MiPrimerAppMVC.Models;
using System.Collections.Generic;
namespace MiPrimerAppMVC.Controllers
{
   public class ProductoController : Controller
{
    // Static variable to store the list of products
    private static List<Producto> productos = new List<Producto>();

    public IActionResult Index()
    {
        var productos = ObtenerProductos();
        return View(productos);
    }

    // GET /PRODUCTO/CREATE
    public IActionResult Create()
    {
        return View();
    }

    // POST /PRODUCTO/CREATE
    [HttpPost]
    public IActionResult Create(Producto producto)
    {
    if (producto == null)
    {
        ViewBag.Message = "No se recibieron datos";
    }
    else
    {
        productos.Add(producto);

        ViewBag.Message = "Datos recibidos correctamente";
    }

        // Redirige a la acción Index del controlador Producto
        return RedirectToAction("Index");
    }


    public IActionResult Inicio()
    {
        return View();
    }

    public List<Producto> ObtenerProductos()
    {
        
        return productos;
    }

    [HttpPost]
    public IActionResult Eliminar(int id)
    {
        var productoAEliminar = productos.FirstOrDefault(p => p.Id == id);

        if (productoAEliminar != null)
        {
            productos.Remove(productoAEliminar);
            ViewBag.Message = "Producto eliminado correctamente";
        }
        else
        {
            ViewBag.Message = "Producto no encontrado";
        }

        // Redirige a la acción Index del controlador Producto
        return RedirectToAction("Index");
    }

    

}

}