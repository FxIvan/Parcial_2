using System;
using System.Collections.Generic;
using System.Linq;

namespace Parcial_2
{
    public class Gestor
    {
        public List<Instituto> Institutos { get; set; } = new List<Instituto>();
        public List<Prestador> Prestadores { get; set; } = new List<Prestador>();
        public List<Pago> Pagos { get; set; } = new List<Pago>();

        public event Action<Pago> PagoMayorA15k;

        public void AsignarPrestador(Instituto inst, Prestador prest)
        {
            if (!inst.Prestadores.Contains(prest))
            {
                inst.Prestadores.Add(prest);
                prest.Institutos.Add(inst);
            }
        }

        public void GenerarPago(Instituto inst, Prestador prest, decimal importe, DateTime venc, TipoPago tipo)
        {
            int nuevoCodigo = Pagos.Any() ? Pagos.Max(p => p.CodigoPago) + 1 : 1;
            Pagos.Add(new Pago
            {
                CodigoPago = nuevoCodigo,
                FechaVencimiento = venc,
                Importe = importe,
                Tipo = tipo,
                Instituto = inst,
                Prestador = prest
            });
        }

        public void CancelarPago(Pago pago, DateTime fechaPago)
        {
            pago.Cancelado = true;
            pago.FechaPago = fechaPago;

            if (fechaPago > pago.FechaVencimiento)
            {
                pago.Recargo = pago.Tipo == TipoPago.Transferencia
                ? pago.Importe * 0.02m  // 2%
                : pago.Importe * 0.05m; // 5%
            }

            if (pago.TotalAbonado > 15000)
                PagoMayorA15k?.Invoke(pago);
        }
    }
}
