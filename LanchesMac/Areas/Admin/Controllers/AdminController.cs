using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace LanchesMac.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
