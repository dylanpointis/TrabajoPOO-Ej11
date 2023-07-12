namespace TP_EJERCICIO_11.Formularios
{
    partial class Form_Proveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPeso = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelEnvios = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grillaClientes = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaEnvios = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnRegistrarPedido = new System.Windows.Forms.Button();
            this.txtIDPedido = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugarDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugarSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(60, 262);
            this.txtPeso.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(120, 20);
            this.txtPeso.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "Peso (KG)";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(59, 215);
            this.txtCosto.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(120, 20);
            this.txtCosto.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Descripción pedido";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(59, 168);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "Costo";
            // 
            // labelEnvios
            // 
            this.labelEnvios.AutoSize = true;
            this.labelEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvios.Location = new System.Drawing.Point(207, 12);
            this.labelEnvios.Name = "labelEnvios";
            this.labelEnvios.Size = new System.Drawing.Size(109, 20);
            this.labelEnvios.TabIndex = 84;
            this.labelEnvios.Text = "Grilla Envíos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "Grilla Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Nombre de usuario del cliente";
            // 
            // grillaClientes
            // 
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Nombre,
            this.Column1,
            this.Mail});
            this.grillaClientes.Location = new System.Drawing.Point(211, 493);
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.Size = new System.Drawing.Size(490, 278);
            this.grillaClientes.TabIndex = 74;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre de usuario";
            this.Column2.Name = "Column2";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Apellido";
            this.Column1.Name = "Column1";
            // 
            // Mail
            // 
            this.Mail.FillWeight = 150F;
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.Width = 150;
            // 
            // grillaEnvios
            // 
            this.grillaEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEnvios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.NombreCliente,
            this.Descripcion,
            this.Costo,
            this.Peso,
            this.LugarSalida,
            this.LugarDestino,
            this.Movil,
            this.FechaEntrega,
            this.Estado});
            this.grillaEnvios.Location = new System.Drawing.Point(211, 42);
            this.grillaEnvios.Name = "grillaEnvios";
            this.grillaEnvios.Size = new System.Drawing.Size(1068, 400);
            this.grillaEnvios.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Lugar de salida";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(58, 309);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(121, 20);
            this.txtSalida.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Lugar de destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(58, 356);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(121, 20);
            this.txtDestino.TabIndex = 69;
            // 
            // btnRegistrarPedido
            // 
            this.btnRegistrarPedido.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegistrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPedido.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPedido.Location = new System.Drawing.Point(58, 392);
            this.btnRegistrarPedido.Name = "btnRegistrarPedido";
            this.btnRegistrarPedido.Size = new System.Drawing.Size(120, 26);
            this.btnRegistrarPedido.TabIndex = 68;
            this.btnRegistrarPedido.Text = "Registrar pedido";
            this.btnRegistrarPedido.UseVisualStyleBackColor = false;
            this.btnRegistrarPedido.Click += new System.EventHandler(this.btnRegistrarPedido_Click);
            // 
            // txtIDPedido
            // 
            this.txtIDPedido.Location = new System.Drawing.Point(60, 73);
            this.txtIDPedido.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtIDPedido.Name = "txtIDPedido";
            this.txtIDPedido.Size = new System.Drawing.Size(120, 20);
            this.txtIDPedido.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "ID del pedido";
            // 
            // txtCliente
            // 
            this.txtCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCliente.FormattingEnabled = true;
            this.txtCliente.Location = new System.Drawing.Point(59, 120);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(121, 21);
            this.txtCliente.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(976, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 65);
            this.label6.TabIndex = 125;
            this.label6.Text = "Nota: \r\nPor defecto el estado del envío es \"Esperando  aceptación del \r\noperador\"" +
    " hasta que el operador lo acepte.\r\nAdemas, el operador debe asignarle un móvil p" +
    "ara realizar la \r\nentrega.\r\n";
            // 
            // Estado
            // 
            this.Estado.FillWeight = 150F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "Fecha Entrega";
            this.FechaEntrega.Name = "FechaEntrega";
            // 
            // Movil
            // 
            this.Movil.HeaderText = "Movil";
            this.Movil.Name = "Movil";
            // 
            // LugarDestino
            // 
            this.LugarDestino.HeaderText = "Lugar Destino";
            this.LugarDestino.Name = "LugarDestino";
            // 
            // LugarSalida
            // 
            this.LugarSalida.HeaderText = "Lugar Salida";
            this.LugarSalida.Name = "LugarSalida";
            // 
            // Peso
            // 
            this.Peso.FillWeight = 50F;
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.Width = 50;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 150F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre de usuario Cliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 75F;
            this.Column3.HeaderText = "ID_Pedido";
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // Form_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 772);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDPedido);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelEnvios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grillaClientes);
            this.Controls.Add(this.grillaEnvios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnRegistrarPedido);
            this.Name = "Form_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown txtPeso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtCosto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelEnvios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.DataGridView grillaEnvios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnRegistrarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.NumericUpDown txtIDPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugarSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugarDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}