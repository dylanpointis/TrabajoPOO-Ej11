
namespace TP_EJERCICIO_11
{
    partial class Form_Clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEnvios = new System.Windows.Forms.Label();
            this.grillaEnvios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugarSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugarDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBajaPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULARIO CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hacer seguimiento pedido / dar de baja pedido";
            // 
            // labelEnvios
            // 
            this.labelEnvios.AutoSize = true;
            this.labelEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvios.Location = new System.Drawing.Point(77, 158);
            this.labelEnvios.Name = "labelEnvios";
            this.labelEnvios.Size = new System.Drawing.Size(109, 20);
            this.labelEnvios.TabIndex = 86;
            this.labelEnvios.Text = "Grilla Envíos";
            // 
            // grillaEnvios
            // 
            this.grillaEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEnvios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.NombreProv,
            this.Descripcion,
            this.Costo,
            this.Peso,
            this.LugarSalida,
            this.LugarDestino,
            this.Movil,
            this.FechaEntrega,
            this.Estado});
            this.grillaEnvios.Location = new System.Drawing.Point(68, 192);
            this.grillaEnvios.Name = "grillaEnvios";
            this.grillaEnvios.Size = new System.Drawing.Size(1119, 375);
            this.grillaEnvios.TabIndex = 85;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 75F;
            this.Column1.HeaderText = "ID_Pedido";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // NombreProv
            // 
            this.NombreProv.HeaderText = "Nombre Proveedor";
            this.NombreProv.Name = "NombreProv";
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
            this.Estado.FillWeight = 200F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 200;
            // 
            // btnBajaPedido
            // 
            this.btnBajaPedido.BackColor = System.Drawing.Color.Firebrick;
            this.btnBajaPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaPedido.ForeColor = System.Drawing.Color.White;
            this.btnBajaPedido.Location = new System.Drawing.Point(68, 598);
            this.btnBajaPedido.Name = "btnBajaPedido";
            this.btnBajaPedido.Size = new System.Drawing.Size(121, 26);
            this.btnBajaPedido.TabIndex = 98;
            this.btnBajaPedido.Text = "Dar de baja pedido";
            this.btnBajaPedido.UseVisualStyleBackColor = false;
            this.btnBajaPedido.Click += new System.EventHandler(this.btnBajaPedido_Click);
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 772);
            this.ControlBox = false;
            this.Controls.Add(this.btnBajaPedido);
            this.Controls.Add(this.labelEnvios);
            this.Controls.Add(this.grillaEnvios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Clientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEnvios;
        private System.Windows.Forms.DataGridView grillaEnvios;
        private System.Windows.Forms.Button btnBajaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProv;
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