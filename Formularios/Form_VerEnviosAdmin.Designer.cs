namespace TP_EJERCICIO_11.Formularios
{
    partial class Form_VerEnviosAdmin
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
            this.grillaEnvios = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugarSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugarDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaEnvios
            // 
            this.grillaEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEnvios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.NombreProv,
            this.NombreCliente,
            this.Descripcion,
            this.Costo,
            this.Peso,
            this.LugarSalida,
            this.LugarDestino,
            this.Movil,
            this.FechaEntrega,
            this.Estado});
            this.grillaEnvios.Location = new System.Drawing.Point(144, 175);
            this.grillaEnvios.Name = "grillaEnvios";
            this.grillaEnvios.Size = new System.Drawing.Size(1001, 400);
            this.grillaEnvios.TabIndex = 75;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 75F;
            this.Column3.HeaderText = "ID_Pedido";
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // NombreProv
            // 
            this.NombreProv.HeaderText = "Nombre del Proveedor";
            this.NombreProv.Name = "NombreProv";
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre de usuario Cliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 150F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // Peso
            // 
            this.Peso.FillWeight = 50F;
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.Width = 50;
            // 
            // LugarSalida
            // 
            this.LugarSalida.HeaderText = "Lugar Salida";
            this.LugarSalida.Name = "LugarSalida";
            // 
            // LugarDestino
            // 
            this.LugarDestino.HeaderText = "Lugar Destino";
            this.LugarDestino.Name = "LugarDestino";
            // 
            // Movil
            // 
            this.Movil.HeaderText = "Movil";
            this.Movil.Name = "Movil";
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "Fecha Entrega";
            this.FechaEntrega.Name = "FechaEntrega";
            // 
            // Estado
            // 
            this.Estado.FillWeight = 150F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // Form_VerEnviosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 810);
            this.ControlBox = false;
            this.Controls.Add(this.grillaEnvios);
            this.Name = "Form_VerEnviosAdmin";
            this.Load += new System.EventHandler(this.Form_VerEnviosAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaEnvios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProv;
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