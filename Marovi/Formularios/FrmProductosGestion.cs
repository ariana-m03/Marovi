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
    public partial class FrmProductosGestion : Form
    {
        private Logica.Producto MiProductoLocal { get; set; }
        private bool FlagActivar { get; set; }

        public DataTable ListaProductosNormal { get; set; }
        public DataTable ListaProductosConFiltro { get; set; }

        public FrmProductosGestion()
        {
            InitializeComponent();

            MiProductoLocal = new Logica.Producto();

        }
        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtCodigoBarras.Enabled = true;
        }

        private void ActivarEditarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtCodigoBarras.Enabled = false;
        }

        private void LimpiarFormulario()
        {
            TxtCod.Clear();
            TxtNombre.Clear();
            TxtDescripcion.Clear();

            TxtCodigoBarras.Clear();
            TxtStockInicial.Clear();
            TxtEntradas.Clear();
            TxtSalidas.Clear();

            TxtStockFinal.Clear();
            TxtPeso.Clear();
            TxtUnitario.Clear();
            TxtXMayor.Clear();

            DtpIngreso.Value = DateTime.Now.Date;
            DtpCaducidad.Value = DateTime.Now.Date;
            CboxCategoria.SelectedIndex = -1;
            CbActivo.Checked = false;
        }

        private void CargarDatosComboTipoCategoria()
        {
            Logica.ProductoCategoria ObjCategoria = new Logica.ProductoCategoria();
            DataTable Datos = new DataTable();
            Datos = ObjCategoria.Listar();

            CboxCategoria.ValueMember = "ID";
            CboxCategoria.DisplayMember = "Descripcion";

            CboxCategoria.DataSource = Datos;
            CboxCategoria.SelectedIndex = -1;
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

        private void FrmProductosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;
            LlenarListaProductos(CbVerProductosActivos.Checked);
            CargarDatosComboTipoCategoria();
            LimpiarFormulario();
            ActivarBotonAgregar();

        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCod.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtStockFinal.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUnitario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtXMayor.Text.Trim()) &&
                DtpIngreso.Value.Date <= DateTime.Now.Date &&
                DtpCaducidad.Value.Date <= DateTime.Now.Date &&
                CboxCategoria.SelectedIndex > -1)
            {
                if (!BtnEditar.Enabled)
                {
                    R = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                    {
                        R = true;
                    }
                }

            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                DialogResult RespuestaProducto = MessageBox.Show("¿Está seguro de agregar este producto?", "Confirmación requerida", MessageBoxButtons.YesNo);

                if (RespuestaProducto == DialogResult.Yes)
                {
                    Logica.Producto MiProducto = new Logica.Producto();

                    MiProducto.Nombre = TxtNombre.Text.Trim();
                    MiProducto.Descripcion = TxtDescripcion.Text.Trim();
                    MiProducto.CodigoBarras = TxtCodigoBarras.Text.Trim();
                    MiProducto.StockInicial = Convert.ToInt32(TxtStockInicial.Text.Trim());
                    MiProducto.Entradas = Convert.ToInt32(TxtEntradas.Text.Trim());
                    MiProducto.Salidas = Convert.ToInt32(TxtSalidas.Text.Trim());
                    MiProducto.StockFinal = Convert.ToInt32(TxtStockFinal.Text.Trim());
                    MiProducto.Peso = TxtPeso.Text.Trim();
                    MiProducto.PrecioUnitario = Convert.ToDecimal(TxtUnitario.Text.Trim());
                    MiProducto.PrecioUnitario = Convert.ToDecimal(TxtXMayor.Text.Trim());
                    MiProducto.FechaIngreso = DtpIngreso.Value.Date;
                    MiProducto.FechaCaducidad = DtpCaducidad.Value.Date;
                    MiProducto.Categoria.IDCategoria = Convert.ToInt32(CboxCategoria.SelectedValue);


                    bool CodigoExiste = MiProducto.ConsultarPorCodigoDeBarras();

                    if (!CodigoExiste)
                    {
                        if (MiProducto.Agregar())
                        {
                            MessageBox.Show("Producto agregado correctamente.", "", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaProductos(true);
                            ActivarBotonAgregar();
                        }
                    }
                    else
                    {
                        if (CodigoExiste)
                        {
                            MessageBox.Show("El código ya fue usado", "", MessageBoxButtons.OK);
                            TxtCodigoBarras.Focus();
                            TxtCodigoBarras.SelectAll();
                        }

                    }

                }

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Producto MiProducto = new Logica.Producto();

                MiProducto.IDProducto = Convert.ToInt32(TxtCod.Text.Trim());
                MiProducto.Nombre = TxtNombre.Text.Trim();
                MiProducto.Descripcion = TxtDescripcion.Text.Trim();
                MiProducto.CodigoBarras = TxtCodigoBarras.Text.Trim();
                MiProducto.StockInicial = Convert.ToInt32(TxtStockInicial.Text.Trim());
                MiProducto.StockFinal = Convert.ToInt32(TxtStockFinal.Text.Trim());
                MiProducto.Peso = TxtPeso.Text.Trim();
                MiProducto.PrecioUnitario = Convert.ToDecimal(TxtUnitario.Text.Trim());
                MiProducto.PrecioPorMayor = Convert.ToDecimal(TxtXMayor.Text.Trim());
                MiProducto.FechaIngreso = DtpIngreso.Value.Date;
                MiProducto.FechaCaducidad = DtpCaducidad.Value.Date;
                MiProducto.Categoria.IDCategoria = Convert.ToInt32(CboxCategoria.SelectedValue);

                if (MiProducto.ConsultarPorID())
                {
                    if (MiProducto.Editar())
                    {
                        MessageBox.Show("Producto modificado correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaProductos(CbVerProductosActivos.Checked);
                        ActivarBotonAgregar();
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Logica.Producto MiProducto = new Logica.Producto();
            MiProducto.IDProducto = Convert.ToInt32(TxtCod.Text.Trim());

            if (MiProducto.ConsultarPorID())
            {
                if (FlagActivar)
                {
                    if (MiProducto.Activar())
                    {
                        MessageBox.Show("Producto activado correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaProductos(CbVerProductosActivos.Checked);
                        ActivarBotonAgregar();
                    }
                }
                else
                {
                    if (MiProducto.Desactivar())
                    {
                        MessageBox.Show("Producto eliminado correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaProductos(true);
                        ActivarBotonAgregar();
                    }
                }

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarBotonAgregar();
            DgvLista.ClearSelection();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            if (CbVerProductosActivos.Checked)
            {
                BtnEliminar.Text = "ELIMINAR";
                FlagActivar = false;
            }
            else
            {
                BtnEliminar.Text = "ACTIVAR";
                FlagActivar = true;
            }
        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();
                DataGridViewRow MiFila = DgvLista.SelectedRows[0];

                int IdProducto = Convert.ToInt32(MiFila.Cells["ColIDProducto"].Value);

                MiProductoLocal = new Logica.Producto();
                MiProductoLocal = MiProductoLocal.Consultar(IdProducto);


                TxtCod.Text = MiProductoLocal.IDProducto.ToString();
                TxtNombre.Text = MiProductoLocal.Nombre;
                TxtDescripcion.Text = MiProductoLocal.Descripcion;
                TxtCodigoBarras.Text = MiProductoLocal.CodigoBarras;
                TxtStockInicial.Text = MiProductoLocal.StockInicial.ToString();
                TxtEntradas.Text = MiProductoLocal.Entradas.ToString();
                TxtSalidas.Text = MiProductoLocal.Salidas.ToString();
                TxtStockFinal.Text = MiProductoLocal.StockFinal.ToString();
                TxtPeso.Text = MiProductoLocal.Peso;
                TxtUnitario.Text = MiProductoLocal.PrecioUnitario.ToString();
                TxtXMayor.Text = MiProductoLocal.PrecioPorMayor.ToString();
                DtpIngreso.Value = DateTime.Now.Date;
                DtpCaducidad.Value = DateTime.Now.Date;
                CboxCategoria.SelectedValue = MiProductoLocal.Categoria.IDCategoria;
                CbActivo.Checked = MiProductoLocal.Activo;

                ActivarEditarYEliminar();
            }
        }
    }
}
