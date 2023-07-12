namespace TP_EJERCICIO_11.Formularios
{
    partial class Form_Demoras
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
            this.grillaDemoras = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarDemora = new System.Windows.Forms.Button();
            this.btnRegistrarDemora = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.NumericUpDown();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDemoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaDemoras
            // 
            this.grillaDemoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDemoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grillaDemoras.Location = new System.Drawing.Point(455, 212);
            this.grillaDemoras.Name = "grillaDemoras";
            this.grillaDemoras.Size = new System.Drawing.Size(443, 288);
            this.grillaDemoras.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Pedido";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 300F;
            this.Column2.HeaderText = "Motivo y descripción";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // btnEliminarDemora
            // 
            this.btnEliminarDemora.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarDemora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDemora.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDemora.Location = new System.Drawing.Point(289, 399);
            this.btnEliminarDemora.Name = "btnEliminarDemora";
            this.btnEliminarDemora.Size = new System.Drawing.Size(121, 26);
            this.btnEliminarDemora.TabIndex = 118;
            this.btnEliminarDemora.Text = "Eliminar Demora";
            this.btnEliminarDemora.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarDemora
            // 
            this.btnRegistrarDemora.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegistrarDemora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDemora.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarDemora.Location = new System.Drawing.Point(289, 367);
            this.btnRegistrarDemora.Name = "btnRegistrarDemora";
            this.btnRegistrarDemora.Size = new System.Drawing.Size(121, 26);
            this.btnRegistrarDemora.TabIndex = 117;
            this.btnRegistrarDemora.Text = "Registrar Demora";
            this.btnRegistrarDemora.UseVisualStyleBackColor = false;
            this.btnRegistrarDemora.Click += new System.EventHandler(this.btnRegistrarDemora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "DEMORAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 122;
            this.label3.Text = "Motivo y descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "ID del pedido";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(289, 234);
            this.txtID.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 20);
            this.txtID.TabIndex = 123;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(289, 307);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(120, 20);
            this.txtMotivo.TabIndex = 124;
            // 
            // Form_Demoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 676);
            this.ControlBox = false;
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarDemora);
            this.Controls.Add(this.btnRegistrarDemora);
            this.Controls.Add(this.grillaDemoras);
            this.Name = "Form_Demoras";
            this.Load += new System.EventHandler(this.Form_Demoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDemoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaDemoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnEliminarDemora;
        private System.Windows.Forms.Button btnRegistrarDemora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtID;
        private System.Windows.Forms.TextBox txtMotivo;
    }
}