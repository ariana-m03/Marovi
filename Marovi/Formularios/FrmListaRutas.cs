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
    public partial class FrmListaRutas : Form
    {

        private Logica.Ruta MiRutaLocal { get; set; }

        public DataTable ListaRutasNormal { get; set; }

        public DataTable ListaRutasConFiltro { get; set; }

        public FrmListaRutas()
        {
            InitializeComponent();

            MiRutaLocal = new Logica.Ruta();

        }

        private void LlenarListaRutas(bool VerActivos, string FiltroBusqueda = "")
        {
            Logica.Ruta MiRuta = new Logica.Ruta();

            if (!string.IsNullOrEmpty(FiltroBusqueda.Trim()))
            {
                ListaRutasConFiltro = MiRuta.Listar(VerActivos, FiltroBusqueda);
                DgvLista.DataSource = ListaRutasConFiltro;
            }
            else
            {
                ListaRutasNormal = MiRuta.Listar(VerActivos);
                DgvLista.DataSource = ListaRutasNormal;
            }
            DgvLista.ClearSelection();
        }

        private void FrmListaRutas_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaRutas(CbVerRutasActivas.Checked);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 2)
            {
                LlenarListaRutas(CbVerRutasActivas.Checked, TxtBuscar.Text.Trim());

            }
            else
            {
                LlenarListaRutas(CbVerRutasActivas.Checked);
            }
        }

        private void CbVerRutasActivas_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaRutas(CbVerRutasActivas.Checked);
        }
    }
}
