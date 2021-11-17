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
    public partial class FrmProveedoresGestion : Form
    {
        private Logica.Proveedor MiProveedorLocal { get; set; }

        private bool FlagActivar { get; set; }

        public DataTable ListaProveedoresNormal { get; set; }
        public DataTable ListaProveedoresConFiltro { get; set; }

        public FrmProveedoresGestion()
        {
            InitializeComponent();
        }

        private void FrmProveedoresGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaProveedores(CbVerProveedoresActivos.Checked);
            LimpiarFormulario();
            ActivarBotonAgregar();
        }
        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtCedula.Enabled = true;
        }

        private void ActivarEditarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtCedula.Enabled = false;
        }
        private void LimpiarFormulario()
        {
            TxtCod.Clear();
            TxtCedula.Clear();
            TxtNombre.Clear();

            TxtTelefono.Clear();
            TxtCorreo.Clear();
            TxtDireccion.Clear();

            CbActivo.Checked = false;

        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDireccion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim())
                )
            {
                if (BtnEditar.Enabled)
                {
                    R = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtCorreo.Text.Trim()))
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
                DialogResult RespuestaProveedor = MessageBox.Show("¿Está seguro de agregar este proveedor?", "Confirmación requerida", MessageBoxButtons.YesNo);

                if (RespuestaProveedor == DialogResult.Yes)
                {
                    Logica.Proveedor MiProveedor = new Logica.Proveedor();

                    MiProveedor.Cedula = TxtCedula.Text.Trim();
                    MiProveedor.Nombre = TxtNombre.Text.Trim();
                    MiProveedor.Telefono = TxtTelefono.Text.Trim();
                    MiProveedor.Correo = TxtCorreo.Text.Trim();
                    MiProveedor.Direccion = TxtDireccion.Text.Trim();

                    bool CedulaExiste = MiProveedor.ConsultarPorCedula();
                    bool EmailExiste = MiProveedor.ConsultarPorEmail();

                    if (!CedulaExiste && !EmailExiste)
                    {
                        if (MiProveedor.Agregar())
                        {
                            MessageBox.Show("Proveedor agregado correctamente.", "", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaProveedores(true);
                            ActivarBotonAgregar();
                        }
                    }
                    else
                    {
                        if (CedulaExiste)
                        {
                            MessageBox.Show("La cédula ya fue usada", "", MessageBoxButtons.OK);
                            TxtCedula.Focus();
                            TxtCedula.SelectAll();
                        }
                        else if (EmailExiste)
                        {
                            MessageBox.Show("El Email ya está siendo usado", "", MessageBoxButtons.OK);
                            TxtCorreo.Focus();
                            TxtCorreo.SelectAll();
                        }

                    }

                }

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Proveedor MiProveedor = new Logica.Proveedor();

                MiProveedor.IDProveedor = Convert.ToInt32(TxtCod.Text.Trim());
                MiProveedor.Cedula = TxtCedula.Text.Trim();
                MiProveedor.Nombre = TxtNombre.Text.Trim();
                MiProveedor.Telefono = TxtTelefono.Text.Trim();
                MiProveedor.Direccion = TxtDireccion.Text.Trim();
                MiProveedor.Correo = TxtCorreo.Text.Trim();

                if (MiProveedor.ConsultarPorID())
                {
                    if (MiProveedor.Editar())
                    {
                        MessageBox.Show("Proveedor modificado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaProveedores(CbVerProveedoresActivos.Checked);
                        ActivarBotonAgregar();
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Logica.Proveedor MiProveedor = new Logica.Proveedor();
            MiProveedor.IDProveedor = Convert.ToInt32(TxtCod.Text.Trim());

            if (MiProveedor.ConsultarPorID())
            {
                if (FlagActivar)
                {
                    if (MiProveedor.Activar())
                    {
                        MessageBox.Show("Proveedor activado correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaProveedores(CbVerProveedoresActivos.Checked);
                        ActivarBotonAgregar();
                    }
                }
                else
                {
                    if (MiProveedor.Desactivar())
                    {
                        MessageBox.Show("Proveedor eliminado correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaProveedores(true);
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

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();
                DataGridViewRow MiFila = DgvLista.SelectedRows[0];

                int IdProveedor = Convert.ToInt32(MiFila.Cells["ColCodigo"].Value);

                MiProveedorLocal = new Logica.Proveedor();
                MiProveedorLocal = MiProveedorLocal.Consultar(IdProveedor);

                TxtCod.Text = MiProveedorLocal.IDProveedor.ToString();
                TxtCedula.Text = MiProveedorLocal.Cedula;
                TxtNombre.Text = MiProveedorLocal.Nombre;
                TxtTelefono.Text = MiProveedorLocal.Telefono;
                TxtDireccion.Text = MiProveedorLocal.Direccion;
                TxtCorreo.Text = MiProveedorLocal.Correo;
                CbActivo.Checked = MiProveedorLocal.Activo;

                ActivarEditarYEliminar();
            }
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

        private void CbVerProveedoresActivos_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaProveedores(CbVerProveedoresActivos.Checked);


            if (CbVerProveedoresActivos.Checked)
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
    }
}
