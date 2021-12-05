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
    public partial class FrmFacturasGestion : Form
    {

        private const string PrefijoLbl = "La compra será registrada por ";

        public Logica.Factura MiFacturaLocal { get; set; }

        public DataTable DtListaProductos { get; set; }

        public FrmFacturasGestion()
        {
            InitializeComponent();

            MiFacturaLocal = new Logica.Factura();

            DtListaProductos = new DataTable();

        }

        private void FrmFacturasGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LblUsuarioRegistra.Text = PrefijoLbl + Locales.ObjetosGlobales.MiUsuarioGlobal.Nombre;

            CargarComboCliente();

            Limpiar();
        }

        private void Limpiar()
        {
            DtpFecha.Value = DateTime.Now.Date;

            TxtNumFact.Clear();
            CboxCliente.SelectedIndex = -1;


            DtListaProductos = MiFacturaLocal.AsignarEsquemaDetalle();

            DgvListaF.DataSource = DtListaProductos;

            TxtUnitario.Text = "0";
            TxtMayor.Text = "0";

        }

        private void CargarComboCliente()
        {

            DataTable Datos = new DataTable();

            Datos = MiFacturaLocal.MiCliente.Listar();

            CboxCliente.ValueMember = "ID";
            CboxCliente.DisplayMember = "Nombre";

            CboxCliente.DataSource = Datos;

            CboxCliente.SelectedIndex = -1;

        }

        private void BtnCrearFactura_Click(object sender, EventArgs e)
        {
            if(ValidarFactura())
            {

                MiFacturaLocal.Fecha = DtpFecha.Value.Date;
                MiFacturaLocal.MiCliente.IDCliente = Convert.ToInt32(((DataRowView)CboxCliente.SelectedValue)["IdCliente"]);
                MiFacturaLocal.UsuarioRealiza.IDUsuario = Locales.ObjetosGlobales.MiUsuarioGlobal.IDUsuario;

                MiFacturaLocal.NumeroFactura = TxtNumFact.Text.Trim();


                LlenarDetallesDeFactura();

                if (MiFacturaLocal.Agregar())
                {

                    MessageBox.Show("La factura se realizó correctamente!", ":)", MessageBoxButtons.OK);

                    ReportDocument MiReporteFactura = new ReportDocument();

                    MiReporteFactura = new Reportes.RptFactura();

                    MiReporteFactura = MiFacturaLocal.Imprimir(MiReporteFactura);

                    FrmVisualizadorReportes MiFormCRV = new FrmVisualizadorReportes();

                    MiFormCRV.CrvVisualizadorReportes.ReportSource = MiReporteFactura;

                    MiFormCRV.Show();


                    MiFormCRV.CrvVisualizadorReportes.Zoom(1);


                    Limpiar();
                }

            }
        }

        private void LlenarDetallesDeFactura()
        {
            foreach (DataRow fila in DtListaProductos.Rows)
            {
                Logica.FacturaDetalle detalle = new Logica.FacturaDetalle();


                detalle.MiProducto.IDProducto = Convert.ToInt32(fila["IDProducto"]);
                detalle.Cantidad = Convert.ToInt32(fila["Cantidad"]);
                detalle.TotalUnitario = Convert.ToDecimal(fila["TotalUnitario"]);
                detalle.TotalMayor = Convert.ToDecimal(fila["TotalMayor"]);

                detalle.MiProducto.Nombre = fila["Nombre"].ToString();

                MiFacturaLocal.ListaDetalle.Add(detalle);
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            Form FormBuscarItem = new Formularios.FrmFacturaDetalleGestion();

            DialogResult Resp = FormBuscarItem.ShowDialog();

            if (Resp == DialogResult.OK)
            {

                DgvListaF.DataSource = DtListaProductos;


                TxtUnitario.Text = string.Format("{0:C2}", TotalizarUnitario());

                TxtMayor.Text = string.Format("{0:C2}", TotalizarMayor());

            }
        }

        private decimal TotalizarUnitario()
        {
            decimal R = 0;

            if (DtListaProductos.Rows.Count > 0)
            {

                foreach (DataRow item in DtListaProductos.Rows)
                {

                    R += Convert.ToDecimal(item["Cantidad"]) * Convert.ToDecimal(item["TotalUnitario"]);

                }

            }
            return R;

        }

        private decimal TotalizarMayor()
        {

            decimal R = 0;

            if (DtListaProductos.Rows.Count > 0)
            {

                foreach (DataRow item in DtListaProductos.Rows)
                {

                    R += Convert.ToDecimal(item["Cantidad"]) * Convert.ToDecimal(item["TotalMayor"]);

                }

            }
            return R;
        }


        private bool ValidarFactura()
        {
            bool R = false;

            if (DtpFecha.Value.Date <= DateTime.Now.Date &&
                CboxCliente.SelectedIndex > -1 &&
                !string.IsNullOrEmpty(TxtNumFact.Text.Trim()) &&
                DtListaProductos.Rows.Count > 0)
            {
                R = true;
            }
            else
            {
         
                if (DtpFecha.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show(@"La fecha de la factura no puede ser 
                     superior a la fecha actual.", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;
        }


        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            int num = Locales.ObjetosGlobales.MiFormGestionFacturas.DgvListaF.SelectedRows[0].Index;

            Locales.ObjetosGlobales.MiFormGestionFacturas.DtListaProductos.Rows.RemoveAt(num);

            MessageBox.Show("Producto eliminado correctamente", ":)", MessageBoxButtons.OK);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            DgvListaF.ClearSelection();
        }

        
    }
}

