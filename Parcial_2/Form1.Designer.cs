namespace Parcial_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInstitutos = new System.Windows.Forms.DataGridView();
            this.dgvPrestadores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPrestadoresInstituto = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvInstitutosPrestador = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPagosSeleccion = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTodosPagos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtInstitutoCodigo = new System.Windows.Forms.TextBox();
            this.txtInstitutoNombre = new System.Windows.Forms.TextBox();
            this.txtInstitutoTelefono = new System.Windows.Forms.TextBox();
            this.txtInstitutoDireccion = new System.Windows.Forms.TextBox();
            this.btnAgregarInstituto = new System.Windows.Forms.Button();
            this.btnModificarInstituto = new System.Windows.Forms.Button();
            this.btnEliminarInstituto = new System.Windows.Forms.Button();
            this.txtPrestadorCodigo = new System.Windows.Forms.TextBox();
            this.txtPrestadorRazonSocial = new System.Windows.Forms.TextBox();
            this.txtPrestadorTelefono = new System.Windows.Forms.TextBox();
            this.btnEliminarPrestador = new System.Windows.Forms.Button();
            this.btnModificarPrestador = new System.Windows.Forms.Button();
            this.btnAgregarPrestador = new System.Windows.Forms.Button();
            this.txtPagoImporte = new System.Windows.Forms.TextBox();
            this.dtpPagoVencimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.btnGenerarPago = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAsignarPrestador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstitutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestadoresInstituto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstitutosPrestador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosSeleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instituto (grilla 1)";
            // 
            // dgvInstitutos
            // 
            this.dgvInstitutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstitutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstitutos.Location = new System.Drawing.Point(17, 52);
            this.dgvInstitutos.Name = "dgvInstitutos";
            this.dgvInstitutos.Size = new System.Drawing.Size(545, 150);
            this.dgvInstitutos.TabIndex = 1;
            this.dgvInstitutos.SelectionChanged += new System.EventHandler(this.dgvInstitutos_SelectionChanged);
            // 
            // dgvPrestadores
            // 
            this.dgvPrestadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestadores.Location = new System.Drawing.Point(601, 52);
            this.dgvPrestadores.Name = "dgvPrestadores";
            this.dgvPrestadores.Size = new System.Drawing.Size(521, 150);
            this.dgvPrestadores.TabIndex = 2;
            this.dgvPrestadores.SelectionChanged += new System.EventHandler(this.dgvPrestadores_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prestadoras (grilla 2)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prestador del instituto seleccionado (grilla 3)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvPrestadoresInstituto
            // 
            this.dgvPrestadoresInstituto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestadoresInstituto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestadoresInstituto.Location = new System.Drawing.Point(17, 274);
            this.dgvPrestadoresInstituto.Name = "dgvPrestadoresInstituto";
            this.dgvPrestadoresInstituto.Size = new System.Drawing.Size(545, 158);
            this.dgvPrestadoresInstituto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Institutos del Prestador seleccionado (grilla 4)";
            // 
            // dgvInstitutosPrestador
            // 
            this.dgvInstitutosPrestador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstitutosPrestador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstitutosPrestador.Location = new System.Drawing.Point(601, 274);
            this.dgvInstitutosPrestador.Name = "dgvInstitutosPrestador";
            this.dgvInstitutosPrestador.Size = new System.Drawing.Size(521, 158);
            this.dgvInstitutosPrestador.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pagos del Instituto y Prestador seleccionados (grilla 5)";
            // 
            // dgvPagosSeleccion
            // 
            this.dgvPagosSeleccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagosSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosSeleccion.Location = new System.Drawing.Point(16, 518);
            this.dgvPagosSeleccion.Name = "dgvPagosSeleccion";
            this.dgvPagosSeleccion.Size = new System.Drawing.Size(1106, 150);
            this.dgvPagosSeleccion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 720);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Todos los pagos (grilla 6)";
            // 
            // dgvTodosPagos
            // 
            this.dgvTodosPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodosPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosPagos.Location = new System.Drawing.Point(16, 759);
            this.dgvTodosPagos.Name = "dgvTodosPagos";
            this.dgvTodosPagos.Size = new System.Drawing.Size(1106, 150);
            this.dgvTodosPagos.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1180, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Codigo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1431, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1180, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1180, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1180, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Direccion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1431, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Razon social o servicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1431, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Telefono";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1180, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Importe";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1180, 388);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Fecha de vencimiento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1180, 427);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(193, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Tipo de Pago (Transferencia / Cheque)";
            // 
            // txtInstitutoCodigo
            // 
            this.txtInstitutoCodigo.Location = new System.Drawing.Point(1183, 68);
            this.txtInstitutoCodigo.Name = "txtInstitutoCodigo";
            this.txtInstitutoCodigo.Size = new System.Drawing.Size(151, 20);
            this.txtInstitutoCodigo.TabIndex = 22;
            // 
            // txtInstitutoNombre
            // 
            this.txtInstitutoNombre.Location = new System.Drawing.Point(1183, 107);
            this.txtInstitutoNombre.Name = "txtInstitutoNombre";
            this.txtInstitutoNombre.Size = new System.Drawing.Size(151, 20);
            this.txtInstitutoNombre.TabIndex = 23;
            // 
            // txtInstitutoTelefono
            // 
            this.txtInstitutoTelefono.Location = new System.Drawing.Point(1183, 146);
            this.txtInstitutoTelefono.Name = "txtInstitutoTelefono";
            this.txtInstitutoTelefono.Size = new System.Drawing.Size(151, 20);
            this.txtInstitutoTelefono.TabIndex = 24;
            // 
            // txtInstitutoDireccion
            // 
            this.txtInstitutoDireccion.Location = new System.Drawing.Point(1183, 185);
            this.txtInstitutoDireccion.Name = "txtInstitutoDireccion";
            this.txtInstitutoDireccion.Size = new System.Drawing.Size(151, 20);
            this.txtInstitutoDireccion.TabIndex = 25;
            // 
            // btnAgregarInstituto
            // 
            this.btnAgregarInstituto.Location = new System.Drawing.Point(1183, 220);
            this.btnAgregarInstituto.Name = "btnAgregarInstituto";
            this.btnAgregarInstituto.Size = new System.Drawing.Size(151, 25);
            this.btnAgregarInstituto.TabIndex = 26;
            this.btnAgregarInstituto.Text = "Agregar instituto";
            this.btnAgregarInstituto.UseVisualStyleBackColor = true;
            this.btnAgregarInstituto.Click += new System.EventHandler(this.btnAgregarInstituto_Click);
            // 
            // btnModificarInstituto
            // 
            this.btnModificarInstituto.Location = new System.Drawing.Point(1183, 250);
            this.btnModificarInstituto.Name = "btnModificarInstituto";
            this.btnModificarInstituto.Size = new System.Drawing.Size(151, 25);
            this.btnModificarInstituto.TabIndex = 27;
            this.btnModificarInstituto.Text = "Modificar instituto";
            this.btnModificarInstituto.UseVisualStyleBackColor = true;
            this.btnModificarInstituto.Click += new System.EventHandler(this.btnModificarInstituto_Click);
            // 
            // btnEliminarInstituto
            // 
            this.btnEliminarInstituto.Location = new System.Drawing.Point(1183, 281);
            this.btnEliminarInstituto.Name = "btnEliminarInstituto";
            this.btnEliminarInstituto.Size = new System.Drawing.Size(151, 25);
            this.btnEliminarInstituto.TabIndex = 28;
            this.btnEliminarInstituto.Text = "Eliminar instituto";
            this.btnEliminarInstituto.UseVisualStyleBackColor = true;
            this.btnEliminarInstituto.Click += new System.EventHandler(this.btnEliminarInstituto_Click);
            // 
            // txtPrestadorCodigo
            // 
            this.txtPrestadorCodigo.Location = new System.Drawing.Point(1434, 68);
            this.txtPrestadorCodigo.Name = "txtPrestadorCodigo";
            this.txtPrestadorCodigo.Size = new System.Drawing.Size(151, 20);
            this.txtPrestadorCodigo.TabIndex = 29;
            // 
            // txtPrestadorRazonSocial
            // 
            this.txtPrestadorRazonSocial.Location = new System.Drawing.Point(1434, 107);
            this.txtPrestadorRazonSocial.Name = "txtPrestadorRazonSocial";
            this.txtPrestadorRazonSocial.Size = new System.Drawing.Size(151, 20);
            this.txtPrestadorRazonSocial.TabIndex = 30;
            // 
            // txtPrestadorTelefono
            // 
            this.txtPrestadorTelefono.Location = new System.Drawing.Point(1434, 146);
            this.txtPrestadorTelefono.Name = "txtPrestadorTelefono";
            this.txtPrestadorTelefono.Size = new System.Drawing.Size(151, 20);
            this.txtPrestadorTelefono.TabIndex = 31;
            // 
            // btnEliminarPrestador
            // 
            this.btnEliminarPrestador.Location = new System.Drawing.Point(1434, 238);
            this.btnEliminarPrestador.Name = "btnEliminarPrestador";
            this.btnEliminarPrestador.Size = new System.Drawing.Size(151, 25);
            this.btnEliminarPrestador.TabIndex = 35;
            this.btnEliminarPrestador.Text = "Eliminar prestador";
            this.btnEliminarPrestador.UseVisualStyleBackColor = true;
            this.btnEliminarPrestador.Click += new System.EventHandler(this.btnEliminarPrestador_Click);
            // 
            // btnModificarPrestador
            // 
            this.btnModificarPrestador.Location = new System.Drawing.Point(1434, 207);
            this.btnModificarPrestador.Name = "btnModificarPrestador";
            this.btnModificarPrestador.Size = new System.Drawing.Size(151, 25);
            this.btnModificarPrestador.TabIndex = 34;
            this.btnModificarPrestador.Text = "Modificar prestador";
            this.btnModificarPrestador.UseVisualStyleBackColor = true;
            this.btnModificarPrestador.Click += new System.EventHandler(this.btnModificarPrestador_Click);
            // 
            // btnAgregarPrestador
            // 
            this.btnAgregarPrestador.Location = new System.Drawing.Point(1434, 177);
            this.btnAgregarPrestador.Name = "btnAgregarPrestador";
            this.btnAgregarPrestador.Size = new System.Drawing.Size(151, 25);
            this.btnAgregarPrestador.TabIndex = 33;
            this.btnAgregarPrestador.Text = "Agregar prestador";
            this.btnAgregarPrestador.UseVisualStyleBackColor = true;
            this.btnAgregarPrestador.Click += new System.EventHandler(this.btnAgregarPrestador_Click);
            // 
            // txtPagoImporte
            // 
            this.txtPagoImporte.Location = new System.Drawing.Point(1183, 365);
            this.txtPagoImporte.Name = "txtPagoImporte";
            this.txtPagoImporte.Size = new System.Drawing.Size(151, 20);
            this.txtPagoImporte.TabIndex = 36;
            // 
            // dtpPagoVencimiento
            // 
            this.dtpPagoVencimiento.Location = new System.Drawing.Point(1183, 404);
            this.dtpPagoVencimiento.Name = "dtpPagoVencimiento";
            this.dtpPagoVencimiento.Size = new System.Drawing.Size(149, 20);
            this.dtpPagoVencimiento.TabIndex = 37;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Transferencia bancaria",
            "Cheque"});
            this.cmbTipoPago.Location = new System.Drawing.Point(1183, 443);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(151, 21);
            this.cmbTipoPago.TabIndex = 38;
            // 
            // btnGenerarPago
            // 
            this.btnGenerarPago.Location = new System.Drawing.Point(1183, 470);
            this.btnGenerarPago.Name = "btnGenerarPago";
            this.btnGenerarPago.Size = new System.Drawing.Size(151, 25);
            this.btnGenerarPago.TabIndex = 39;
            this.btnGenerarPago.Text = "Generar pago";
            this.btnGenerarPago.UseVisualStyleBackColor = true;
            this.btnGenerarPago.Click += new System.EventHandler(this.btnGenerarPago_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(1183, 501);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(151, 25);
            this.btnPagar.TabIndex = 40;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1180, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Instituto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1431, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Prestadores";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1180, 327);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Pagos";
            // 
            // btnAsignarPrestador
            // 
            this.btnAsignarPrestador.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAsignarPrestador.Location = new System.Drawing.Point(971, 464);
            this.btnAsignarPrestador.Name = "btnAsignarPrestador";
            this.btnAsignarPrestador.Size = new System.Drawing.Size(151, 31);
            this.btnAsignarPrestador.TabIndex = 44;
            this.btnAsignarPrestador.Text = "Asignar Prestador";
            this.btnAsignarPrestador.UseVisualStyleBackColor = false;
            this.btnAsignarPrestador.Click += new System.EventHandler(this.btnAsignarPrestador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 936);
            this.Controls.Add(this.btnAsignarPrestador);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnGenerarPago);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.dtpPagoVencimiento);
            this.Controls.Add(this.txtPagoImporte);
            this.Controls.Add(this.btnEliminarPrestador);
            this.Controls.Add(this.btnModificarPrestador);
            this.Controls.Add(this.btnAgregarPrestador);
            this.Controls.Add(this.txtPrestadorTelefono);
            this.Controls.Add(this.txtPrestadorRazonSocial);
            this.Controls.Add(this.txtPrestadorCodigo);
            this.Controls.Add(this.btnEliminarInstituto);
            this.Controls.Add(this.btnModificarInstituto);
            this.Controls.Add(this.btnAgregarInstituto);
            this.Controls.Add(this.txtInstitutoDireccion);
            this.Controls.Add(this.txtInstitutoTelefono);
            this.Controls.Add(this.txtInstitutoNombre);
            this.Controls.Add(this.txtInstitutoCodigo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvTodosPagos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPagosSeleccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvInstitutosPrestador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPrestadoresInstituto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPrestadores);
            this.Controls.Add(this.dgvInstitutos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstitutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestadoresInstituto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstitutosPrestador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosSeleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInstitutos;
        private System.Windows.Forms.DataGridView dgvPrestadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPrestadoresInstituto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvInstitutosPrestador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPagosSeleccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTodosPagos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtInstitutoCodigo;
        private System.Windows.Forms.TextBox txtInstitutoNombre;
        private System.Windows.Forms.TextBox txtInstitutoTelefono;
        private System.Windows.Forms.TextBox txtInstitutoDireccion;
        private System.Windows.Forms.Button btnAgregarInstituto;
        private System.Windows.Forms.Button btnModificarInstituto;
        private System.Windows.Forms.Button btnEliminarInstituto;
        private System.Windows.Forms.TextBox txtPrestadorCodigo;
        private System.Windows.Forms.TextBox txtPrestadorRazonSocial;
        private System.Windows.Forms.TextBox txtPrestadorTelefono;
        private System.Windows.Forms.Button btnEliminarPrestador;
        private System.Windows.Forms.Button btnModificarPrestador;
        private System.Windows.Forms.Button btnAgregarPrestador;
        private System.Windows.Forms.TextBox txtPagoImporte;
        private System.Windows.Forms.DateTimePicker dtpPagoVencimiento;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Button btnGenerarPago;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAsignarPrestador;
    }
}

