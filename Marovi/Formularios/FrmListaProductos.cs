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
    public partial class FrmListaProductos : Form
    {
        private Logica.Producto MiProductoLocal { get; set; }
        

        public DataTable ListaProductosNormal { get; set; }
        public DataTable ListaProductosConFiltro { get; set; }

        public FrmListaProductos()
        {
            InitializeComponent();

            MiProductoLocal = new Logica.Producto();

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 2)
            {
                LlenarListaProductos(CbVerProductosActivos.Checked, TxtBuscar.Text.Trim());

            }
            else
            {
                LlenarListaProductos(CbVerProductosActivos.Checked);
            }
        }

        private void CbVerProductosActivos_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaProductos(CbVerProductosActivos.Checked);
        }

        private void LlenarListaProductos(bool VerActivos, string FiltroBusqueda = "")
        {
            Logica.Producto MiProducto = new Logica.Producto();

            if (!string.IsNullOrEmpty(FiltroBusqueda.Trim()))
            {
                ListaProductosConFiltro = MiProducto.Listar(VerActivos, FiltroBusqueda);
                DgvLista.DataSource = ListaProductosConFiltro;
            }
            else
            {
                ListaProductosNormal = MiProducto.Listar(VerActivos);
                DgvLista.DataSource = ListaProductosNormal;
            }
            DgvLista.ClearSelection();
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {

            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;
            LlenarListaProductos(CbVerProductosActivos.Checked);

        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
