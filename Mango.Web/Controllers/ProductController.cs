using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Controllers
{
    public class ProductController : Controller
    {


        public IActionResult ProductIndex()
        {
            return View();
        }

        public IActionResult ProductCreate()
        {
            return View();
        }

        public IActionResult ProductEdit()
        {
            return View();
        }

        public IActionResult ProductDelete()
        {
            return View();
        }
    }
}
