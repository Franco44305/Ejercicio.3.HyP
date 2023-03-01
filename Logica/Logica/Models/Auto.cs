using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Auto : Vehiculo
    {
        public int CantPuertas { get; set; }
        public DateTime FechaUltimaRevision { get; set; }
        public DateTime FechaUltimoCambioAceite { get; set; }
        public DateTime FechaVencMatafuegos { get; set; }


        public Auto(int codigo, string marca, decimal capacidad, int añoFabricacion, string color, int cantPuertas, DateTime fechaUltimaRevision, DateTime fechaUltimoCambioAceite, DateTime fechaVencMatafuegos):
            base ( codigo,  marca,  capacidad,  añoFabricacion,  color)
        {
            CantPuertas = cantPuertas;
            FechaUltimaRevision = fechaUltimaRevision;
            FechaUltimoCambioAceite = fechaUltimoCambioAceite;
            FechaVencMatafuegos = fechaVencMatafuegos;
        }
    }
}
