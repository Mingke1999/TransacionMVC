using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoryRepository.GetCategories();
            return View(categories);
        }
        //[FromQuery] [FromRoute] Model binding
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ViewBag.Action = "edit";
            var category = CategoryRepository.GetCategoryById(id.HasValue ? id.Value : 0);
            //new Category { Id = id.HasValue ? id.Value : 0 };
             

            return View(category);
            
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoryRepository.UpdateCategory(category.Id, category);

                return RedirectToAction(nameof(Index));
            }
           return View(category);
        }
        public IActionResult Add()
        {
            ViewBag.Action = "add";
            return View();
        }
        [HttpPost]
        public IActionResult Add([FromForm]Category category)
        {
            if (ModelState.IsValid)
            {
                CategoryRepository.AddCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        public IActionResult Delete(int categoryId)
        {
            CategoryRepository.DeleteCategory(categoryId);
            return RedirectToAction(nameof(Index));
        }
    }
}
