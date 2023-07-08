﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_EJERCICIO_11.Clases;
using TP_EJERCICIO_11.Formularios;

namespace TP_EJERCICIO_11
{
    public partial class Form_General : Form
    {
        private string nombreUsuario;
        private string Rol;
        private string Nombre;
        private string Apellido;
        private string Mail;


        private Form FormActual = null;

        public Form_General()
        {
            InitializeComponent();
        }
        public Form_General(Usuario unUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = unUsuario.nombreDeUsuario;
            this.Nombre = unUsuario.Nombre;
            this.Apellido = unUsuario.Apellido;
            this.Mail = unUsuario.Mail;
            this.Rol = unUsuario.Rol;
        }

        private void Form_General_Load(object sender, EventArgs e)
        {
            if (Rol == "Operador")
            {
                Form_Operadores formulario = new Form_Operadores();
                formulario.MdiParent = this;
                formulario.Show();
            }
            if (Rol == "Admin")
            {
                btnCuentas.Visible = true;
            }
        }

        public void MostrarFormulario(Form unFormulario)
        {
            if(FormActual != null) //Si ya hay un formActual que lo cierre
            {
                FormActual.Close();
            }
            FormActual = unFormulario;
            FormActual.MdiParent = this;
            FormActual.Dock = DockStyle.Fill;
            FormActual.Show();
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            if (Rol == "Proveedor")
            {
                Proveedor unProveedor = new Proveedor(nombreUsuario, Nombre, Apellido, Mail);
                Form_Proveedor formulario = new Form_Proveedor(unProveedor);
                MostrarFormulario(formulario);
            }
            if (Rol == "Cliente")
            {
                Cliente unCliente = new Cliente(nombreUsuario, Nombre, Apellido, Mail);
                Form_Clientes formulario = new Form_Clientes(unCliente);
                MostrarFormulario(formulario);
            }

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            Form_Admin formulario = new Form_Admin();
            formulario.MdiParent = this;
            MostrarFormulario(formulario);
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            if (Rol == "Cliente")
            {
                Cliente unCliente = new Cliente(nombreUsuario, Nombre, Apellido, Mail);
                Form_ReclamosClientes formulario = new Form_ReclamosClientes(unCliente);
                MostrarFormulario(formulario);
            }
        }
    }
}
