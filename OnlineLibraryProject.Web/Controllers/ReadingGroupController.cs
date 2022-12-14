using BusinessLayer.Concrete;
using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OnlineLibraryProject.Web.Controllers
{
    public class ReadingGroupController : Controller
    {
       
        ReadingGroupManager rm = new ReadingGroupManager(new EfReadingGroupRepository());
       
        
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ReadingGroup group)
        {
            rm.ReadingGroupAdd(group);
            TempData["status"] = "Group Başarıyla Eklendi";
            return RedirectToAction(nameof(Add));
        }
    }
}
