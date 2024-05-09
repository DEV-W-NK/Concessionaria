using Microsoft.AspNetCore.Mvc;
using Loja_Carros;
using Loja_Carros.Models;

namespace Loja_Carros.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult Carro()
        {
            Carro carro = new Carro();
            carro.NovoCarro();
            return View(carro.ListarCarro());
        }
    }
}
