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
    public partial class FrmListaProveedores : Form
    {

        private Logica.Proveedor MiProveedorLocal { get; set; }

        public DataTable ListaProveedoresNormal { get; set; }
        public DataTable ListaProveedoresConFiltro { get; set; }

        public FrmListaProveedores()
        {

            InitializeComponent();

            MiProveedorLocal = new Logica.Proveedor();

        }
        private void LlenarListaProveedores(bool VerActivos, string FiltroBusqueda = "")
        {
            Logica.Proveedor MiProveedor = new Logica.Proveedor();

            if (!string.IsNullOrEmpty(FiltroBusqueda.Trim()))
            {
                ListaProveedoresConFiltro = MiProveedor.Listar(VerActivos, FiltroBusqueda);
                DgvLista.DataSource = ListaProveedoresConFiltro;
            }
            else
            {
                ListaProveedoresNormal = MiProveedor.Listar(VerActivos);
                DgvLista.DataSource = ListaProveedoresNormal;
            }
            DgvLista.ClearSelection();
        }

        private void FrmListaProveedores_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaProveedores(CbVerProveedoresActivos.Checked);
        }

        private void CbVerProveedoresActivos_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaProveedores(CbVerProveedoresActivos.Checked);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 2)
            {
                LlenarListaProveedores(CbVerProveedoresActivos.Checked, TxtBuscar.Text.Trim());

            }
            else
            {
                LlenarListaProveedores(CbVerProveedoresActivos.Checked);
            }
        }
    }
}
