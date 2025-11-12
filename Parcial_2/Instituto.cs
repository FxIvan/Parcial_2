using System;
using System.Collections.Generic;

namespace Parcial_2
{
    public class Instituto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public List<Prestador> Prestadores { get; set; } = new List<Prestador>();
    }
}
