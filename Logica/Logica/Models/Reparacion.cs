using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    internal class Reparacion
    {
        public int CodigoReparacion { get; set; }
        public DateTime Fecha { get; set; }
        public TipoTrabajo TipoDeTrabajo { get; set; }
        public int IdCliente { get; set; }
        public int CodigoVehiculo { get; set; }
        public decimal CostoTrabajo { get; set; }


        public Reparacion(int codigoReparacion, DateTime fecha, TipoTrabajo tipoDeTrabajo, int idCliente, int codigoVehiculo, decimal costoTrabajo)
        {
            CodigoReparacion = codigoReparacion;
            Fecha = fecha;
            TipoDeTrabajo = tipoDeTrabajo;
            IdCliente = idCliente;
            CodigoVehiculo = codigoVehiculo;
            CostoTrabajo = costoTrabajo;
        }
    }
}
