namespace TP_EJERCICIO_11.Formularios
{
    partial class Form_Moviles
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumeroMovil = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreMovil = new System.Windows.Forms.TextBox();
            this.btnEliminarMovil = new System.Windows.Forms.Button();
            this.btnEditarMovil = new System.Windows.Forms.Button();
            this.btnRegistrarMovil = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.grillaMoviles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMoviles)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(552, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 20);
            this.label10.TabIndex = 126;
            this.label10.Text = "Registrar/Editar/Eliminar Móviles";
            // 
            // txtNumeroMovil
            // 
            this.txtNumeroMovil.Location = new System.Drawing.Point(323, 288);
            this.txtNumeroMovil.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtNumeroMovil.Name = "txtNumeroMovil";
            this.txtNumeroMovil.Size = new System.Drawing.Size(120, 20);
            this.txtNumeroMovil.TabIndex = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(320, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 124;
            this.label12.Text = "Número de telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "Nombre";
            // 
            // txtNombreMovil
            // 
            this.txtNombreMovil.Location = new System.Drawing.Point(323, 235);
            this.txtNombreMovil.Name = "txtNombreMovil";
            this.txtNombreMovil.Size = new System.Drawing.Size(121, 20);
            this.txtNombreMovil.TabIndex = 122;
            // 
            // btnEliminarMovil
            // 
            this.btnEliminarMovil.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarMovil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMovil.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMovil.Location = new System.Drawing.Point(322, 404);
            this.btnEliminarMovil.Name = "btnEliminarMovil";
            this.btnEliminarMovil.Size = new System.Drawing.Size(121, 26);
            this.btnEliminarMovil.TabIndex = 121;
            this.btnEliminarMovil.Text = "Eliminar Móvil";
            this.btnEliminarMovil.UseVisualStyleBackColor = false;
            this.btnEliminarMovil.Click += new System.EventHandler(this.btnEliminarMovil_Click);
            // 
            // btnEditarMovil
            // 
            this.btnEditarMovil.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditarMovil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMovil.ForeColor = System.Drawing.Color.White;
            this.btnEditarMovil.Location = new System.Drawing.Point(322, 367);
            this.btnEditarMovil.Name = "btnEditarMovil";
            this.btnEditarMovil.Size = new System.Drawing.Size(121, 26);
            this.btnEditarMovil.TabIndex = 120;
            this.btnEditarMovil.Text = "Editar Móvil";
            this.btnEditarMovil.UseVisualStyleBackColor = false;
            this.btnEditarMovil.Click += new System.EventHandler(this.btnEditarMovil_Click);
            // 
            // btnRegistrarMovil
            // 
            this.btnRegistrarMovil.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegistrarMovil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMovil.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarMovil.Location = new System.Drawing.Point(322, 331);
            this.btnRegistrarMovil.Name = "btnRegistrarMovil";
            this.btnRegistrarMovil.Size = new System.Drawing.Size(121, 26);
            this.btnRegistrarMovil.TabIndex = 119;
            this.btnRegistrarMovil.Text = "Registrar Móvil";
            this.btnRegistrarMovil.UseVisualStyleBackColor = false;
            this.btnRegistrarMovil.Click += new System.EventHandler(this.btnRegistrarMovil_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(472, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 118;
            this.label13.Text = "Grilla Móviles";
            // 
            // grillaMoviles
            // 
            this.grillaMoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMoviles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grillaMoviles.Location = new System.Drawing.Point(475, 210);
            this.grillaMoviles.Name = "grillaMoviles";
            this.grillaMoviles.Size = new System.Drawing.Size(446, 278);
            this.grillaMoviles.TabIndex = 117;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 250F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Número de telefono";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Form_Moviles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 625);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumeroMovil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreMovil);
            this.Controls.Add(this.btnEliminarMovil);
            this.Controls.Add(this.btnEditarMovil);
            this.Controls.Add(this.btnRegistrarMovil);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grillaMoviles);
            this.Name = "Form_Moviles";
            this.Load += new System.EventHandler(this.Form_Moviles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMoviles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtNumeroMovil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreMovil;
        private System.Windows.Forms.Button btnEliminarMovil;
        private System.Windows.Forms.Button btnEditarMovil;
        private System.Windows.Forms.Button btnRegistrarMovil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView grillaMoviles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}