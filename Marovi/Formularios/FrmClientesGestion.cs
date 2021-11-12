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
    public partial class FrmClientesGestion : Form
    {
        private Logica.Cliente MiClienteLocal { get; set; }

        private bool FlagActivar { get; set; }

        public DataTable ListaClientesNormal { get; set; }
        public DataTable ListaClientesConFiltro { get; set; }

        public FrmClientesGestion()
        {
            InitializeComponent();

            MiClienteLocal = new Logica.Cliente();

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
            TxtCedula.Text = TxtCedula.Tag.ToString();
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
                TxtCedula.Text.Trim() != TxtCedula.Tag.ToString() &&
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

        private void CbVerClientesActivos_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaClientes(CbVerClientesActivos.Checked);


            if (CbVerClientesActivos.Checked)
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                DialogResult RespuestaCliente = MessageBox.Show("¿Está seguro de agregar este cliente?", "Confirmación requerida", MessageBoxButtons.YesNo);

                if (RespuestaCliente == DialogResult.Yes)
                {
                    Logica.Cliente MiCliente = new Logica.Cliente();

                    MiCliente.Cedula = TxtCedula.Text.Trim();
                    MiCliente.Nombre = TxtNombre.Text.Trim();
                    MiCliente.Telefono = TxtTelefono.Text.Trim();
                    MiCliente.Correo = TxtCorreo.Text.Trim();
                    MiCliente.Direccion = TxtDireccion.Text.Trim();

                    bool CedulaExiste = MiCliente.ConsultarPorCedula();
                    bool EmailExiste = MiCliente.ConsultarPorEmail();

                    if (!CedulaExiste && !EmailExiste)
                    {
                        if (MiCliente.Agregar())
                        {
                            MessageBox.Show("Cliente agregado correctamente.", "", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaClientes(true);
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

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            TxtCedula.ForeColor = Color.Black;
            if (TxtCedula.Text == TxtCedula.Tag.ToString())
            {
                TxtCedula.ForeColor = Color.LightGray;
            }
        }

        private void TxtCedula_Enter(object sender, EventArgs e)
        {
            if (TxtCedula.Text == TxtCedula.Tag.ToString())
            {
                TxtCedula.Clear();
            }
        }

        private void TxtCedula_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
            {
                TxtCedula.Text = TxtCedula.Tag.ToString();
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Cliente MiCliente = new Logica.Cliente();

                MiCliente.IDCliente = Convert.ToInt32(TxtCod.Text.Trim());
                MiCliente.Cedula = TxtCedula.Text.Trim();
                MiCliente.Nombre = TxtNombre.Text.Trim();
                MiCliente.Telefono = TxtTelefono.Text.Trim();
                MiCliente.Direccion = TxtDireccion.Text.Trim();
                MiCliente.Correo = TxtCorreo.Text.Trim();

                if (MiCliente.ConsultarPorID())
                {
                    if (MiCliente.Editar())
                    {
                        MessageBox.Show("Cliente modificado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaClientes(CbVerClientesActivos.Checked);
                        ActivarBotonAgregar();
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Logica.Cliente MiCliente = new Logica.Cliente();
            MiCliente.IDCliente = Convert.ToInt32(TxtCod.Text.Trim());

            if (MiCliente.ConsultarPorID())
            {
                if (FlagActivar)
                {
                    if (MiCliente.Activar())
                    {
                        MessageBox.Show("Cliente activado correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaClientes(CbVerClientesActivos.Checked);
                        ActivarBotonAgregar();
                    }
                }
                else
                {
                    if (MiCliente.Desactivar())
                    {
                        MessageBox.Show("Cliente eliminado correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaClientes(true);
                        ActivarBotonAgregar();
                    }
                }

            }
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, false, true);
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

        private void FrmClientesGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaClientes(CbVerClientesActivos.Checked);
            LimpiarFormulario();
            ActivarBotonAgregar();
        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();
                DataGridViewRow MiFila = DgvLista.SelectedRows[0];

                int IdCliente = Convert.ToInt32(MiFila.Cells["CIDCliente"].Value);

                MiClienteLocal = new Logica.Cliente();
                MiClienteLocal = MiClienteLocal.Consultar(IdCliente);

                TxtCod.Text = MiClienteLocal.IDCliente.ToString();
                TxtCedula.Text = MiClienteLocal.Cedula;
                TxtNombre.Text = MiClienteLocal.Nombre;
                TxtTelefono.Text = MiClienteLocal.Telefono;
                TxtDireccion.Text = MiClienteLocal.Direccion;
                TxtCorreo.Text = MiClienteLocal.Correo;
                CbActivo.Checked = MiClienteLocal.Activo;

                ActivarEditarYEliminar();
            }
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
       
    }
}
