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
    public partial class FrmFacturaDetalleGestion : Form
    {

        private DataTable ListaProductos { get; set; }
        private DataTable ListaProductosConFiltro { get; set; }
        private Logica.Producto MiProducto { get; set; }

        public FrmFacturaDetalleGestion()
        {
            InitializeComponent();

            ListaProductos = new DataTable();
            ListaProductosConFiltro = new DataTable();
            MiProducto = new Logica.Producto();

        }

        private void FrmFacturaDetalleGestion_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista()
        {
            ListaProductos = MiProducto.ListarEnDetalle();

            DgvListaProductos.DataSource = ListaProductos;

            DgvListaProductos.ClearSelection();

        }
        private bool ValidarDatos()
        {
            bool R = false;

            if (DgvListaProductos.SelectedRows.Count == 1 &&
                NudCantidad.Value > 0)
            {
                R = true;
            }
            else
            {
                if (NudCantidad.Value <= 0)
                {
                    MessageBox.Show("La Cantidad no puede ser cero o negativa", "Error de validación", MessageBoxButtons.OK);
                }
            }

            return R;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {


                DataRow NuevaFila = Locales.ObjetosGlobales.MiFormGestionFacturas.DtListaProductos.NewRow();

                NuevaFila["IDProducto"] = Convert.ToInt32(DgvListaProductos.SelectedRows[0].Cells["CIDProducto"].Value);

                NuevaFila["Nombre"] = DgvListaProductos.SelectedRows[0].Cells["CNombre"].Value.ToString();

                NuevaFila["TotalUnitario"] = DgvListaProductos.SelectedRows[0].Cells["CPrecioUnitario"].Value.ToString();

                NuevaFila["TotalMayor"] = DgvListaProductos.SelectedRows[0].Cells["CPrecioMayor"].Value.ToString();

                NuevaFila["Cantidad"] = NudCantidad.Value;

                Locales.ObjetosGlobales.MiFormGestionFacturas.DtListaProductos.Rows.Add(NuevaFila);

                this.DialogResult = DialogResult.OK;

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
