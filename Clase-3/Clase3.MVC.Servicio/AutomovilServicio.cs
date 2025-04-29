using System;
using Clase3.MVC.Entidades;

namespace Clase3.MVC.Servicio
{
    public interface IAutomovilServicio
    {
        List<Automovil> ObtenerAutomoviles();
        void AgregarAutomovil(Automovil automovil);
        void EliminarAutomovil(int id);
    }

    public class AutomovilServicio : IAutomovilServicio
    {
        private static List<Automovil> _automoviles;
        public AutomovilServicio()
        {
            if(_automoviles == null)
            {
                _automoviles = new List<Automovil>();
                _automoviles.Add(new Automovil {Id = 1, Marca = "Toyota", Modelo = "Corolla", Foto = "https://placehold.co/300" });
                _automoviles.Add(new Automovil {Id = 2,Marca = "Ford", Modelo = "Focus", Foto = "https://placehold.co/300" });
                _automoviles.Add(new Automovil {Id = 3, Marca = "Chevrolet", Modelo = "Cruze", Foto = "https://placehold.co/300" });
            }
        }
        public List<Automovil> ObtenerAutomoviles()
        {
            return _automoviles;
        }
        public void AgregarAutomovil(Automovil automovil)
        {
            _automoviles.Add(automovil);
        }

        public void EliminarAutomovil(int id)
        {
            var automovil = _automoviles.Find(a => a.Id == id);
            if (automovil != null)
            {
                _automoviles.Remove(automovil);
            }
        }
    }
}
