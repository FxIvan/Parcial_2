using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        Gestor gestor = new Gestor();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCamposInstituto()
        {
            txtInstitutoCodigo.Clear();
            txtInstitutoNombre.Clear();
            txtInstitutoTelefono.Clear();
            txtInstitutoDireccion.Clear();
        }

        private void LimpiarCamposPrestador()
        {
            txtPrestadorCodigo.Clear();
            txtPrestadorRazonSocial.Clear();
            txtPrestadorTelefono.Clear();
        }


        private void RefrescarGrillas()
        {
            dgvInstitutos.DataSource = null;
            dgvInstitutos.DataSource = gestor.Institutos.ToList();

            dgvPrestadores.DataSource = null;
            dgvPrestadores.DataSource = gestor.Prestadores.ToList();

            dgvTodosPagos.DataSource = null;
            dgvTodosPagos.DataSource = gestor.Pagos
                .OrderBy(p => p.Instituto?.Codigo)
                .Select(p => new
                {
                    Instituto = p.Instituto?.Nombre,
                    Prestador = p.Prestador?.RazonSocial,
                    p.CodigoPago,
                    p.FechaVencimiento,
                    p.Importe,
                    p.Recargo,
                    p.TotalAbonado,
                    p.Cancelado,
                    p.Tipo
                })
                .ToList();
        }

        private void btnAgregarInstituto_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtInstitutoCodigo.Text);
                if (gestor.Institutos.Any(i => i.Codigo == codigo))
                    throw new Exception("Ya existe un instituto con ese código.");

                var inst = new Instituto
                {
                    Codigo = codigo,
                    Nombre = txtInstitutoNombre.Text,
                    Telefono = txtInstitutoTelefono.Text,
                    Direccion = txtInstitutoDireccion.Text
                };

                gestor.Institutos.Add(inst);
                RefrescarGrillas();
                LimpiarCamposInstituto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarPrestador_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtPrestadorCodigo.Text);
                if (gestor.Prestadores.Any(p => p.Codigo == codigo))
                    throw new Exception("Ya existe un prestador con ese código.");

                var prest = new Prestador
                {
                    Codigo = codigo,
                    RazonSocial = txtPrestadorRazonSocial.Text,
                    Telefono = txtPrestadorTelefono.Text
                };

                gestor.Prestadores.Add(prest);
                RefrescarGrillas();
                LimpiarCamposPrestador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerarPago_Click(object sender, EventArgs e)
        {
            if (dgvInstitutos.CurrentRow == null || dgvPrestadoresInstituto.CurrentRow == null)
                return;

            var inst = (Instituto)dgvInstitutos.CurrentRow.DataBoundItem;
            var prest = (Prestador)dgvPrestadoresInstituto.CurrentRow.DataBoundItem;

            decimal importe = decimal.Parse(txtPagoImporte.Text);
            DateTime venc = dtpPagoVencimiento.Value;
            TipoPago tipo = cmbTipoPago.SelectedItem.ToString() == "Cheque" ? TipoPago.Cheque : TipoPago.Transferencia;

            gestor.GenerarPago(inst, prest, importe, venc, tipo);
            RefrescarGrillas();
        }

        private void dgvInstitutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInstitutos.CurrentRow == null) return;

            var inst = (Instituto)dgvInstitutos.CurrentRow.DataBoundItem;

            dgvPrestadoresInstituto.DataSource = (from p in gestor.Prestadores
                                                  where p.Institutos.Contains(inst)
                                                  select p).ToList();

            dgvPagosSeleccion.DataSource = gestor.Pagos
                .Where(p => p.Instituto == inst)
                .OrderBy(p => p.FechaVencimiento)
                .ToList();
        }

        private void dgvPrestadores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrestadores.CurrentRow == null) return;

            var prest = (Prestador)dgvPrestadores.CurrentRow.DataBoundItem;

            dgvInstitutosPrestador.DataSource = (from i in gestor.Institutos
                                                 where i.Prestadores.Contains(prest)
                                                 select i).ToList();
        }

        private void btnAsignarPrestador_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya un instituto y un prestador seleccionados
                if (dgvInstitutos.CurrentRow == null)
                    throw new Exception("Debe seleccionar un instituto.");
                if (dgvPrestadores.CurrentRow == null)
                    throw new Exception("Debe seleccionar un prestador.");

                // Obtener las instancias seleccionadas desde las grillas
                var inst = (Instituto)dgvInstitutos.CurrentRow.DataBoundItem;
                var prest = (Prestador)dgvPrestadores.CurrentRow.DataBoundItem;

                // Verificar si ya está asignado
                if (inst.Prestadores.Contains(prest))
                    throw new Exception("El prestador ya está asignado a este instituto.");

                // Asignar usando el método del Gestor
                gestor.AsignarPrestador(inst, prest);

                // Actualizar las grillas que muestran las relaciones
                dgvPrestadoresInstituto.DataSource = null;
                dgvPrestadoresInstituto.DataSource = inst.Prestadores.ToList();

                dgvInstitutosPrestador.DataSource = null;
                dgvInstitutosPrestador.DataSource = prest.Institutos.ToList();

                MessageBox.Show($"✅ Prestador '{prest.RazonSocial}' asignado al Instituto '{inst.Nombre}' correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarInstituto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInstitutos.CurrentRow == null)
                    throw new Exception("Debe seleccionar un instituto para modificar.");

                var inst = (Instituto)dgvInstitutos.CurrentRow.DataBoundItem;

                // Actualizar propiedades desde los TextBox
                inst.Nombre = txtInstitutoNombre.Text;
                inst.Telefono = txtInstitutoTelefono.Text;
                inst.Direccion = txtInstitutoDireccion.Text;

                RefrescarGrillas();
                LimpiarCamposInstituto();

                MessageBox.Show("✅ Instituto modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarInstituto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInstitutos.CurrentRow == null)
                    throw new Exception("Debe seleccionar un instituto para eliminar.");

                var inst = (Instituto)dgvInstitutos.CurrentRow.DataBoundItem;

                // Verificar si tiene pagos pendientes
                bool tienePagosPendientes = gestor.Pagos.Any(p => p.Instituto == inst && !p.Cancelado);
                if (tienePagosPendientes)
                    throw new Exception("No se puede eliminar el instituto porque tiene pagos pendientes.");

                // Confirmación
                var confirm = MessageBox.Show(
                    $"¿Seguro que desea eliminar el instituto '{inst.Nombre}'?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    gestor.Institutos.Remove(inst);

                    // Quitar relaciones en prestadores
                    foreach (var prest in gestor.Prestadores)
                        prest.Institutos.Remove(inst);

                    RefrescarGrillas();
                    MessageBox.Show("✅ Instituto eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarPrestador_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrestadores.CurrentRow == null)
                    throw new Exception("Debe seleccionar un prestador para modificar.");

                var prest = (Prestador)dgvPrestadores.CurrentRow.DataBoundItem;

                prest.RazonSocial = txtPrestadorRazonSocial.Text;
                prest.Telefono = txtPrestadorTelefono.Text;

                RefrescarGrillas();
                LimpiarCamposPrestador();

                MessageBox.Show("✅ Prestador modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarPrestador_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrestadores.CurrentRow == null)
                    throw new Exception("Debe seleccionar un prestador para eliminar.");

                var prest = (Prestador)dgvPrestadores.CurrentRow.DataBoundItem;

                // No eliminar si tiene institutos asignados
                if (prest.Institutos.Any())
                    throw new Exception("No se puede eliminar el prestador porque tiene institutos asignados.");

                var confirm = MessageBox.Show(
                    $"¿Seguro que desea eliminar el prestador '{prest.RazonSocial}'?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    gestor.Prestadores.Remove(prest);

                    // Eliminar posibles pagos asociados
                    gestor.Pagos.RemoveAll(p => p.Prestador == prest);

                    RefrescarGrillas();
                    MessageBox.Show("✅ Prestador eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya un pago seleccionado
                if (dgvPagosSeleccion.CurrentRow == null)
                    throw new Exception("Debe seleccionar un pago para cancelar.");

                // Obtener el pago desde la lista del gestor
                var pago = (Pago)dgvPagosSeleccion.CurrentRow.DataBoundItem;

                // Verificar si ya fue pagado
                if (pago.Cancelado)
                    throw new Exception("El pago ya fue cancelado previamente.");

                // Llamar al método del gestor para cancelar el pago
                gestor.CancelarPago(pago, DateTime.Today);

                // Actualizar grillas (pagos, todos los pagos, etc.)
                RefrescarGrillas();

                // Volver a mostrar los pagos del instituto seleccionado
                if (dgvInstitutos.CurrentRow != null)
                {
                    var inst = (Instituto)dgvInstitutos.CurrentRow.DataBoundItem;
                    dgvPagosSeleccion.DataSource = gestor.Pagos
                        .Where(p => p.Instituto == inst)
                        .OrderBy(p => p.FechaVencimiento)
                        .ToList();
                }

                MessageBox.Show($"✅ Pago {pago.CodigoPago} cancelado correctamente.\nTotal abonado: ${pago.TotalAbonado:F2}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
