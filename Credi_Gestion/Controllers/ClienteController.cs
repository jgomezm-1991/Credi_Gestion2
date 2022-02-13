using Microsoft.AspNetCore.Mvc;

namespace Credi_Gestion.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult GetPrestamosByCliente(int id)
        {
            return View();
        }
    }
}
