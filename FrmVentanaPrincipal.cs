﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    public partial class FrmVentanaPrincipal : Form
    {
        public FrmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosDesarrollador v1 = new FrmDatosDesarrollador();
            v1.Show();
            this.Hide();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCola v2 = new FrmCola();
            v2.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila v3 = new frmPila();
            v3.Show();
            this.Hide();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaSimple v4 = new FrmListaSimple();
            v4.Show();
            this.Hide();
        }

        private void listaDobleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListaDoble v5 = new FrmListaDoble();
            v5.Show();
            this.Hide();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArbolBinario v6 = new FrmArbolBinario();
            v6.Show();
            this.Hide();
        }

        private void operacionesConTablasDeBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaseDatosOperaciones v7 = new FrmBaseDatosOperaciones();
            v7.Show();
            this.Hide();
        }

        private void consultasEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaseDatosConsulta v8 = new FrmBaseDatosConsulta();
            v8.Show();
            this.Hide();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaseDatosRepasoOperaciones v8 = new FrmBaseDatosRepasoOperaciones();
            v8.Show();
            this.Hide();
        }
    }
}
