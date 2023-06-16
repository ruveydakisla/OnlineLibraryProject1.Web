using Microsoft.AspNetCore.Mvc;

namespace OnlineLibraryProject.Web.Controllers
{
    public class YeniController : Controller
    {
       
        public IActionResult Yeni()
        {
            return View();
        }
       

    }
}
