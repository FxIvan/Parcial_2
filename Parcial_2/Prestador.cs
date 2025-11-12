using System;
using System.Collections.Generic;

namespace Parcial_2
{
    public class Prestador
    {
        public int Codigo { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }

        public List<Instituto> Institutos { get; set; } = new List<Instituto>();
    }
}
