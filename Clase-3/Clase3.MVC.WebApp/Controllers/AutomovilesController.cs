using Clase3.MVC.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.WebApp.Controllers
{
    public class AutomovilesController : Controller
    {
        private IAutomovilServicio _automovilServicio;

        public AutomovilesController(IAutomovilServicio automovilServicio)
        {
            _automovilServicio = automovilServicio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_automovilServicio.ObtenerAutomoviles());
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(string marca, string modelo, string foto)
        {  
            int id = _automovilServicio.ObtenerAutomoviles().Count + 1;
            _automovilServicio.AgregarAutomovil(new Entidades.Automovil {Id = id, Marca = marca, Modelo = modelo, Foto = foto });
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            _automovilServicio.EliminarAutomovil(id);
            return RedirectToAction("Index");
        }
    }
}
