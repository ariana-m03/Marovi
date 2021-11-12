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
    }
}
