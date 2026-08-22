using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ProductList(int id)
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Mouse", Price = 10.99m, Description = "Description for Product 1" },
            new Product { Id = 2, Name = "Keyboard", Price = 20.99m, Description = "Description for Product 2" },
            new Product { Id = 3, Name = "USB Drive", Price = 30.99m, Description = "Description for Product 3" }
        };
        return View(products);
    }

    public IActionResult Contact()
    {
        ViewBag.Message = "If you encounter any issues, please contact us at";
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Product product)
    {
        if (!ModelState.IsValid)
        {
            return View(product);
        }

        return RedirectToAction("ProductList");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
