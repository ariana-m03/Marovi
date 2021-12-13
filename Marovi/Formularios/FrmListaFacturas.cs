using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FrmListaFacturas : Form
    {
        private Logica.Factura MiFacturaLocal { get; set; }

        public DataTable ListaFacturasNormal { get; set; }
        public DataTable ListaFacturasConFiltro { get; set; }

        public FrmListaFacturas()
        {
            InitializeComponent();

            MiFacturaLocal = new Logica.Factura();
         

        }

        private void LlenarListaFacturas(bool VerActivos, string FiltroBusqueda = "")
        {

            Logica.Factura MiFactura = new Logica.Factura();

            if (!string.IsNullOrEmpty(FiltroBusqueda.Trim()))
            {
                ListaFacturasConFiltro = MiFactura.Listar(VerActivos, FiltroBusqueda);
                DgvLista.DataSource = ListaFacturasConFiltro;
            }
            else
            {
                ListaFacturasNormal = MiFactura.Listar(VerActivos);
                DgvLista.DataSource = ListaFacturasNormal;
            }
            DgvLista.ClearSelection();
        }

        private void FrmListaFacturas_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;
            LlenarListaFacturas(CbVerFacturasActivas.Checked);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 2)
            {
                LlenarListaFacturas(CbVerFacturasActivas.Checked, TxtBuscar.Text.Trim());

            }
            else
            {
                LlenarListaFacturas(CbVerFacturasActivas.Checked);
            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            Logica.Factura MiFactura = new Logica.Factura();
            
            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow MiFila = DgvLista.SelectedRows[0];
                MiFactura.IDFactura = Convert.ToInt32(MiFila.Cells["CIDFactura"].Value);

                
                    if (MiFactura.Anular())
                    {
                        MessageBox.Show("Factura anulada correctamente", "", MessageBoxButtons.OK);
                        LlenarListaFacturas(CbVerFacturasActivas.Checked);
                       
                    }
                
            

            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Logica.Factura MiFactura = new Logica.Factura();

            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow MiFila = DgvLista.SelectedRows[0];
                MiFactura.IDFactura = Convert.ToInt32(MiFila.Cells["CIDFactura"].Value);
           
                ReportDocument MiReporteFactura = new ReportDocument();

                MiReporteFactura = new Reportes.RptFactura();

                MiReporteFactura = MiFactura.Imprimir(MiReporteFactura);

                FrmVisualizadorReportes MiFormCRV = new FrmVisualizadorReportes();

                MiFormCRV.CrvVisualizadorReportes.ReportSource = MiReporteFactura;

                MiFormCRV.Show();


                MiFormCRV.CrvVisualizadorReportes.Zoom(1);
            }
        }

        private void CbVerFacturasActivas_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaFacturas(CbVerFacturasActivas.Checked);

        }
    }
}
