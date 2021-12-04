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
    public partial class FrmRutasGestion : Form
    {
        private Logica.Ruta MiRutaLocal { get; set; }

        private bool FlagActivar { get; set; }

        public DataTable ListaRutasNormal { get; set; }

        public DataTable ListaRutasConFiltro { get; set; }

        public FrmRutasGestion()
        {
            InitializeComponent();

            MiRutaLocal = new Logica.Ruta();

        }

        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtCod.Enabled = true;
        }

        private void ActivarEditarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtCod.Enabled = false;
        }
        private void LimpiarFormulario()
        {
            TxtCod.Clear();
            TxtTransporte.Clear();
            CboxUsuario.SelectedIndex = -1;

            TxtProvincia.Clear();
            TxtCanton.Clear();
            TxtDistrito.Clear();

            TxtCantidad.Clear();
            TxtParadas.Clear();
            CbActivo.Checked = false;

        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtTransporte.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtParadas.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCantidad.Text.Trim()) &&
                CboxUsuario.SelectedIndex > -1
                )
            {
                if (BtnEditar.Enabled)
                {
                    R = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtProvincia.Text.Trim()))
                    {
                        R = true;
                    }
                }

            }
            return R;
        }

        private void CargarDatosComboUsuario()
        {
            DataTable Datos = new DataTable();

            Datos = MiRutaLocal.NombreUsuario.Listar();

            CboxUsuario.ValueMember = "IDUsuario";
            CboxUsuario.DisplayMember = "Nombre";

            CboxUsuario.DataSource = Datos;
            CboxUsuario.SelectedIndex = -1;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                DialogResult RespuestaRuta = MessageBox.Show("¿Está seguro de agregar esta ruta?", "Confirmación requerida", MessageBoxButtons.YesNo);

                if (RespuestaRuta == DialogResult.Yes)
                {
                    Logica.Ruta MiRuta = new Logica.Ruta();

                    MiRuta.TipoTransporte = TxtTransporte.Text.Trim();
                    MiRuta.NombreUsuario.IDUsuario = Convert.ToInt32(CboxUsuario.SelectedValue);
                    MiRuta.Provincia = TxtProvincia.Text.Trim();
                    MiRuta.Canton = TxtCanton.Text.Trim();
                    MiRuta.Distrito = TxtDistrito.Text.Trim();
                    MiRuta.CantidadParadas = Convert.ToInt32(TxtCantidad.Text.Trim());
                    MiRuta.Paradas = TxtParadas.Text.Trim();

                    if (MiRuta.Agregar())
                    {
                       MessageBox.Show("Ruta agregado correctamente.", "", MessageBoxButtons.OK);

                       LimpiarFormulario();
                       LlenarListaRutas(true);
                       ActivarBotonAgregar();
                    }
                    
                }

            }
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Ruta MiRuta = new Logica.Ruta();

                MiRuta.IDRuta = Convert.ToInt32(TxtCod.Text.Trim());
                MiRuta.TipoTransporte = TxtTransporte.Text.Trim();
                MiRuta.NombreUsuario.IDUsuario = Convert.ToInt32(CboxUsuario.SelectedValue);
                MiRuta.Provincia = TxtProvincia.Text.Trim();
                MiRuta.Canton = TxtCanton.Text.Trim();
                MiRuta.Distrito = TxtDistrito.Text.Trim();
                MiRuta.CantidadParadas = Convert.ToInt32(TxtCantidad.Text.Trim());
                MiRuta.Paradas = TxtParadas.Text.Trim();


                if (MiRuta.ConsultarPorID())
                {
                    if (MiRuta.Editar())
                    {
                        MessageBox.Show("Ruta modificada correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaRutas(CbVerRutasActivas.Checked);
                        ActivarBotonAgregar();
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Logica.Ruta MiRuta = new Logica.Ruta();
            MiRuta.IDRuta = Convert.ToInt32(TxtCod.Text.Trim());

            if (MiRuta.ConsultarPorID())
            {
                if (FlagActivar)
                {
                    if (MiRuta.Activar())
                    {
                        MessageBox.Show("Ruta activada correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaRutas(CbVerRutasActivas.Checked);
                        ActivarBotonAgregar();
                    }
                }
                else
                {
                    if (MiRuta.Desactivar())
                    {
                        MessageBox.Show("Ruta eliminada correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaRutas(true);
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

        private void FrmRutasGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaRutas(CbVerRutasActivas.Checked);
            CargarDatosComboUsuario();
            LimpiarFormulario();
            ActivarBotonAgregar();
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

        private void CbRutasActivas_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaRutas(CbVerRutasActivas.Checked);


            if (CbVerRutasActivas.Checked)
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

                int IdRuta = Convert.ToInt32(MiFila.Cells["CIDRuta"].Value);

                MiRutaLocal = new Logica.Ruta();
                MiRutaLocal = MiRutaLocal.Consultar(IdRuta);


                TxtCod.Text = MiRutaLocal.IDRuta.ToString();
                TxtTransporte.Text = MiRutaLocal.TipoTransporte;
                TxtProvincia.Text = MiRutaLocal.Provincia;
                TxtCanton.Text = MiRutaLocal.Canton;
                TxtDistrito.Text = MiRutaLocal.Distrito;
                TxtCantidad.Text = MiRutaLocal.CantidadParadas.ToString();
                TxtParadas.Text = MiRutaLocal.Paradas;
                CboxUsuario.SelectedValue = MiRutaLocal.NombreUsuario.IDUsuario;
                CbActivo.Checked = MiRutaLocal.Activo;

                ActivarEditarYEliminar();
            }
        }
    }
}
