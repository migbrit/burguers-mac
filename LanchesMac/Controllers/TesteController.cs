using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class TesteController : Controller
    {
        public string Index()
        {
            return $"Testando o metodo Index to TesteController : {DateTime.Now} ";
        }
    }
}
