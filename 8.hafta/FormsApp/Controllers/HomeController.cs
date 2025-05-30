using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography;

namespace FormsApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(string searchString, string category)
    {
        var products= Repository.Products;
        if(!String.IsNullOrEmpty(searchString)){
            ViewBag.SearchString = searchString;
            products = products.Where(p=>p.Name!.ToLower().Contains(searchString)).ToList();
        }
        if(!String.IsNullOrEmpty(category)&& category !="0"){
            products = products.Where(p=>p.CategoryId == int.Parse(category)).ToList();
        }
        //ViewBag.Categories= new SelectList(Repository.Categories, "CategoryId", "Name", category); (Geçici bir kullnım. Verileri açıkta tutar. Saldırıyla karşılaşılabilir.)

        var model = new ProductViewModel{
            Products = products,
            Categories = Repository.Categories,
            SelectedCategory = category
        };
        return View(model);
    }
    [HttpGet]
    public IActionResult Create(){
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product model){
        if(ModelState.IsValid){
            model.ProductId = Repository.Products.Count +1;
            Repository.CreateProduct(model);
            return RedirectToAction("Index");
        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View(model);
    }

}
