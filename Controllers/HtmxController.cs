using Microsoft.AspNetCore.Mvc;

namespace GranDanesWebApp.Controllers
{
    public class HtmxController : Controller
    {
        public IActionResult ClienteCabezera()
        {
            return PartialView("_CabezeraCliente");
        }

        public IActionResult ClienteListaPrestamos() 
        {
            return PartialView("_ClienteListaPrestamos");
        }
    }
}
