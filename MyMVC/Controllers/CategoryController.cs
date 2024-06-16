using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit(int? id)
        {
            var category = new Category { Id = id.HasValue ? id.Value : 0 };
             

            return View(category);
            
        }
    }
}
