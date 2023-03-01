using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }
        public int CantMarchas { get; set; }
        public TipoMoto TipoDeMoto { get; set; }

    
        public Moto(int codigo, string marca, decimal capacidad, int añoFabricacion, string color, int cilindrada, int cantMarchas, TipoMoto tipoDeMoto) : 
            base ( codigo,  marca,  capacidad,  añoFabricacion,  color)
        {
            Cilindrada = cilindrada;
            CantMarchas = cantMarchas;
            TipoDeMoto = tipoDeMoto;
        }
    }
}
