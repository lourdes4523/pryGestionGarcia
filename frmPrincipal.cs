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
    public partial class frmPrincipal : Form
    {
        public object Mostrar { get; private set; }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar frmRegistrarTarea = new frmRegistrar();
            frmRegistrarTarea.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmMostrar frmMostrar = new frmMostrar();
            frmMostrar.ShowDialog();
        }

        
    }
}
