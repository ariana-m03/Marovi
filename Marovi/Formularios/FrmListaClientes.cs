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
    public partial class FrmListaClientes : Form
    {
        

        public DataTable ListaClientesNormal { get; set; }
        public DataTable ListaClientesConFiltro { get; set; }

        public FrmListaClientes()
        {
            InitializeComponent();

            

        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaClientes(CbVerClientesActivos.Checked);
        }

        private void LlenarListaClientes(bool VerActivos, string FiltroBusqueda = "")
        {
            Logica.Cliente MiCliente = new Logica.Cliente();

            if (!string.IsNullOrEmpty(FiltroBusqueda.Trim()))
            {
                ListaClientesConFiltro = MiCliente.Listar(VerActivos, FiltroBusqueda);
                DgvLista.DataSource = ListaClientesConFiltro;
            }
            else
            {
                ListaClientesNormal = MiCliente.Listar(VerActivos);
                DgvLista.DataSource = ListaClientesNormal;
            }
            DgvLista.ClearSelection();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 2)
            {
                LlenarListaClientes(CbVerClientesActivos.Checked, TxtBuscar.Text.Trim());

            }
            else
            {
                LlenarListaClientes(CbVerClientesActivos.Checked);
            }
        }

        private void CbVerClientesActivos_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaClientes(CbVerClientesActivos.Checked);
        }

        private void DgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
