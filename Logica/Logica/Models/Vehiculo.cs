using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Vehiculo
    {
        public int Codigo { get; set; }
        public string Marca { get; set; }
        public decimal Capacidad { get; set; }
        public int AñoFabricacion { get; set; }
        public string Color { set; get; }


        public Vehiculo(int codigo, string marca, decimal capacidad, int añoFabricacion, string color)
        {
            Codigo = codigo;
            Marca = marca;
            Capacidad = capacidad;
            AñoFabricacion = añoFabricacion;
            Color = color;
        }
    }
}
