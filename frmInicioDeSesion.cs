﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryControlesComunesVariables
{
    public partial class frmInicioDeSesion : Form
    {
        //zona de declaracion de variables cuando se utilizan en todo el formulario 

        string vUsuario;
        string vContraseña;

        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // pasar los datos de la interfaz gráfica a las variables
            vUsuario = txtUsuario.Text;
            vContraseña = txtContraseña.Text;

            //validar que el usuario sea admin - admin
            if (vUsuario == "admin" && vContraseña == "admin")
            {

                //muestra la ventana principal
                frmPrincipal ventanaPrincipal = new frmPrincipal();
                ventanaPrincipal.ShowDialog();

                //oculta la ventana actual
                this.Hide();
            }
            else
            {

                MessageBox.Show("Dato Incorrecto", "Login.Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }            
        }
    }
}