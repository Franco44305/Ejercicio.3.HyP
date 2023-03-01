using Logica.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logic
    {
        List<Moto> listaMotos = new List<Moto>();
        List<Auto> listaAutos = new List<Auto>();
        List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        List<Reparacion> listaReparaciones = new List<Reparacion>();


        //Punto 1
        public string DevolverDescripcion(Vehiculo vehiculo)
        {
            string Descripcion = string.Empty;
            if(vehiculo is Moto)
            {
                Moto moto = vehiculo as Moto;
                if (moto != null)
                {
                    return $"{moto.Codigo} + {moto.Marca} + {moto.Cilindrada} + {moto.TipoDeMoto}";
                }
                else
                {
                    return "Moto es null";
                }               
            }
            else
            {
                Auto auto = vehiculo as Auto;
                if (auto != null)
                {
                    return $"{auto.Codigo} + {auto.Marca} + {auto.AñoFabricacion} + {auto.CantPuertas}";
                }
                else
                {
                    return "Auto es null";
                }
            }
        }

        //Punto 2
        public bool ActualizarReparacion(int CodigoReparacion, int Precio)
        {
            foreach(var item in listaReparaciones)
            {
                if (CodigoReparacion == item.CodigoReparacion)
                {
                    if (item.TipoDeTrabajo == TipoTrabajo.TecnicaVehicular || item.TipoDeTrabajo == TipoTrabajo.CambioDeAceite)
                    {
                        item.CostoTrabajo = Precio;
                        item.Fecha = DateTime.Today;
                        return true;
                    }
                }
            }           
            return false;
        }


        //Punto 3
        public List<string> DevolverAutosConMataFuegosOff()
        {
            List<string> autosVencidos = new List<string>();
            foreach (var item in listaAutos)
            {
                string cadena1 = "";
                if(item.FechaVencMatafuegos > DateTime.Today) 
                {
                    cadena1 = $"{item.Codigo} | Matafuego vencido";
                }
                if (item.FechaUltimaRevision.AddYears(1) < DateTime.Today)
                {
                    string cadena2 = " | Revision Vencida";
                    if (string.IsNullOrEmpty(cadena1))
                    {
                        autosVencidos.Add(cadena2);
                    }
                    else
                    {
                        string cadenanueva = string.Concat(cadena1, cadena2);
                        autosVencidos.Add(cadenanueva);
                    }
                }
            }
            return autosVencidos;
        }
    }
}
