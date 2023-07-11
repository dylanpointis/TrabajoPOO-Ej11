
namespace TP_EJERCICIO_11
{
    partial class Form_Operadores
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
            this.label6 = new System.Windows.Forms.Label();
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
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.btnEditarEstado = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.grillaMoviles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMovil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMoviles)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Seleccione el envío a Aceptar/Editar Estado";
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
            this.grillaEnvios.Location = new System.Drawing.Point(129, 65);
            this.grillaEnvios.Name = "grillaEnvios";
            this.grillaEnvios.Size = new System.Drawing.Size(1152, 400);
            this.grillaEnvios.TabIndex = 74;
            this.grillaEnvios.SelectionChanged += new System.EventHandler(this.grillaEnvios_SelectionChanged);
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
            // txtEstado
            // 
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "En preparación",
            "En camino",
            "Demorado",
            "Entregado",
            "Esperando aceptación del operador"});
            this.txtEstado.Location = new System.Drawing.Point(4, 164);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(120, 21);
            this.txtEstado.TabIndex = 110;
            this.txtEstado.Visible = false;
            // 
            // btnEditarEstado
            // 
            this.btnEditarEstado.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEstado.ForeColor = System.Drawing.Color.White;
            this.btnEditarEstado.Location = new System.Drawing.Point(3, 203);
            this.btnEditarEstado.Name = "btnEditarEstado";
            this.btnEditarEstado.Size = new System.Drawing.Size(121, 26);
            this.btnEditarEstado.TabIndex = 111;
            this.btnEditarEstado.Text = "Editar Estado";
            this.btnEditarEstado.UseVisualStyleBackColor = false;
            this.btnEditarEstado.Visible = false;
            this.btnEditarEstado.Click += new System.EventHandler(this.btnEditarEstado_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(3, 65);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 26);
            this.btnAceptar.TabIndex = 116;
            this.btnAceptar.Text = "Aceptar envío";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(129, 497);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 119;
            this.label13.Text = "Grilla Móviles";
            // 
            // grillaMoviles
            // 
            this.grillaMoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMoviles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grillaMoviles.Location = new System.Drawing.Point(132, 526);
            this.grillaMoviles.Name = "grillaMoviles";
            this.grillaMoviles.Size = new System.Drawing.Size(288, 278);
            this.grillaMoviles.TabIndex = 118;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Número de telefono";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // txtMovil
            // 
            this.txtMovil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMovil.FormattingEnabled = true;
            this.txtMovil.Location = new System.Drawing.Point(3, 119);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(120, 21);
            this.txtMovil.TabIndex = 121;
            this.txtMovil.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Nombre del Móvil";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Estado";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 104);
            this.label3.TabIndex = 123;
            this.label3.Text = "Nota: \r\nPor defecto el estado\r\ndel envío es \r\n\"Esperando \r\naceptación del \r\nopera" +
    "dor\" hasta \r\nque el operador\r\nlo acepte";
            // 
            // Form_Operadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 833);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMovil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grillaMoviles);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEditarEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.grillaEnvios);
            this.Controls.Add(this.label6);
            this.Name = "Form_Operadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Operadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMoviles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grillaEnvios;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.Button btnEditarEstado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView grillaMoviles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox txtMovil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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