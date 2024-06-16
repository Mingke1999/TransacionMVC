using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MyMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //specify view name
            return View("Index");
        }
      
    }
}
