using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Cliente (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
