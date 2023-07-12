
namespace TP_EJERCICIO_11.Formularios
{
    partial class Form_ReclamosClientes
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
            this.grillaReclamos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPedido = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRealizarReclamo = new System.Windows.Forms.Button();
            this.btnEliminarMovil = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaReclamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECLAMOS";
            // 
            // grillaReclamos
            // 
            this.grillaReclamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaReclamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.grillaReclamos.Location = new System.Drawing.Point(291, 84);
            this.grillaReclamos.Name = "grillaReclamos";
            this.grillaReclamos.Size = new System.Drawing.Size(743, 308);
            this.grillaReclamos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "ID del pedido";
            // 
            // txtIDPedido
            // 
            this.txtIDPedido.Location = new System.Drawing.Point(137, 108);
            this.txtIDPedido.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtIDPedido.Name = "txtIDPedido";
            this.txtIDPedido.Size = new System.Drawing.Size(120, 20);
            this.txtIDPedido.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 111;
            this.label3.Text = "Nombre de proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(137, 174);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(120, 20);
            this.txtProveedor.TabIndex = 112;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(137, 232);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(120, 20);
            this.txtDescripcion.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "Descripción";
            // 
            // btnRealizarReclamo
            // 
            this.btnRealizarReclamo.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRealizarReclamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarReclamo.ForeColor = System.Drawing.Color.White;
            this.btnRealizarReclamo.Location = new System.Drawing.Point(137, 267);
            this.btnRealizarReclamo.Name = "btnRealizarReclamo";
            this.btnRealizarReclamo.Size = new System.Drawing.Size(121, 26);
            this.btnRealizarReclamo.TabIndex = 115;
            this.btnRealizarReclamo.Text = "Realizar reclamo";
            this.btnRealizarReclamo.UseVisualStyleBackColor = false;
            this.btnRealizarReclamo.Click += new System.EventHandler(this.btnRealizarReclamo_Click);
            // 
            // btnEliminarMovil
            // 
            this.btnEliminarMovil.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarMovil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMovil.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMovil.Location = new System.Drawing.Point(137, 308);
            this.btnEliminarMovil.Name = "btnEliminarMovil";
            this.btnEliminarMovil.Size = new System.Drawing.Size(121, 26);
            this.btnEliminarMovil.TabIndex = 116;
            this.btnEliminarMovil.Text = "Eliminar Reclamo";
            this.btnEliminarMovil.UseVisualStyleBackColor = false;
            this.btnEliminarMovil.Click += new System.EventHandler(this.btnEliminarMovil_Click);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID_Pedido";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de usuario Cliente";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Proveedor";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 300F;
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha Reclamo";
            this.Column5.Name = "Column5";
            // 
            // Form_ReclamosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 749);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminarMovil);
            this.Controls.Add(this.btnRealizarReclamo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDPedido);
            this.Controls.Add(this.grillaReclamos);
            this.Controls.Add(this.label1);
            this.Name = "Form_ReclamosClientes";
            this.Load += new System.EventHandler(this.ReclamosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaReclamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaReclamos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtIDPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRealizarReclamo;
        private System.Windows.Forms.Button btnEliminarMovil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}