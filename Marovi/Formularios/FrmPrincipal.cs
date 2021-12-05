using CrystalDecisions.CrystalReports.Engine;
using Marovi.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marovi.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LblUsuario.Text = Locales.ObjetosGlobales.MiUsuarioGlobal.Nombre;

            switch (Locales.ObjetosGlobales.MiUsuarioGlobal.Rol.IDUsuarioRol)
            {

                case 1:

                    break;

                case 2:

                    mantenimientosToolStripMenuItem.Visible = false;
                    reportesToolStripMenuItem.Visible = false;

                    break;
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionUsuarios.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionUsuarios = new FrmUsuariosGestion();
                Locales.ObjetosGlobales.MiFormGestionUsuarios.Show();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionProductos.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionProductos = new FrmProductosGestion();
                Locales.ObjetosGlobales.MiFormGestionProductos.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionClientes.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionClientes = new FrmClientesGestion();
                Locales.ObjetosGlobales.MiFormGestionClientes.Show();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionProveedores.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionProveedores = new FrmProveedoresGestion();
                Locales.ObjetosGlobales.MiFormGestionProveedores.Show();
            }
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionRutas.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionRutas = new FrmRutasGestion();
                Locales.ObjetosGlobales.MiFormGestionRutas.Show();
            }
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormListaFacturas.Visible)
            {
                Locales.ObjetosGlobales.MiFormListaFacturas = new FrmListaFacturas();
                Locales.ObjetosGlobales.MiFormListaFacturas.Show();
            }
        }

        private void gestiónDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionFacturas.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionFacturas = new FrmFacturasGestion();
                Locales.ObjetosGlobales.MiFormGestionFacturas.Show();
            }
        }


        private void listadoDeUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormListaUsuarios.Visible)
            {
                Locales.ObjetosGlobales.MiFormListaUsuarios = new FrmListaUsuarios();
                Locales.ObjetosGlobales.MiFormListaUsuarios.Show();
            }
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormListaProductos.Visible)
            {
                Locales.ObjetosGlobales.MiFormListaProductos = new FrmListaProductos();
                Locales.ObjetosGlobales.MiFormListaProductos.Show();
            }
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormListaClientes.Visible)
            {
                Locales.ObjetosGlobales.MiFormListaClientes = new FrmListaClientes();
                Locales.ObjetosGlobales.MiFormListaClientes.Show();
            }
        }

        private void listadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormListaProveedores.Visible)
            {
                Locales.ObjetosGlobales.MiFormListaProveedores = new FrmListaProveedores();
                Locales.ObjetosGlobales.MiFormListaProveedores.Show();
            }
        }

        private void listadoDeRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormListaRutas.Visible)
            {
                Locales.ObjetosGlobales.MiFormListaRutas = new FrmListaRutas();
                Locales.ObjetosGlobales.MiFormListaRutas.Show();
            }
        }
    }
}
