using System;

public enum TipoPago
{
    Transferencia,
    Cheque
}

namespace Parcial_2
{
    public class Pago
    {
        public int CodigoPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Importe { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaPago { get; set; }
        public decimal Recargo { get; set; }
        public decimal TotalAbonado => Importe + Recargo;
        public TipoPago Tipo { get; set; }

        public Instituto Instituto { get; set; }
        public Prestador Prestador { get; set; }
    }
}
