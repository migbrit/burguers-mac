using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return $"Testando o metodo Index to AdminController : {DateTime.Now} ";
        }
        public string Demo()
        {
            return $"Testando o metodo Demo to AdminController : {DateTime.Now} ";
        }
    }
}
