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
    public partial class FrmUsuariosGestion : Form
    {

        private Logica.Usuario MiUsuarioLocal { get; set; }

        private bool FlagActivar { get; set; }
        private bool FlagCambioPassword { get; set; }

        public DataTable ListaUsuariosNormal { get; set; }
        public DataTable ListaUsuariosConFiltro { get; set; }


        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Usuario();

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

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaUsuarios(CbVerUsuariosActivos.Checked);
            CargarDatosCombo();
            LimpiarFormulario();
            ActivarBotonAgregar();

        }

        private void LimpiarFormulario()
        {
            TxtCod.Clear();
            TxtCedula.Clear();
            TxtNombre.Clear();

            TxtTelefono.Clear();
            TxtCorreo.Clear();
            TxtDireccion.Clear();

            CboxTipoUsuario.SelectedIndex = -1;
            TxtPass.Clear();
            CbActivo.Checked = false;

            FlagCambioPassword = false;

        }
        private void CargarDatosCombo()
        {
            Logica.UsuarioRol ObjUsuarioRol = new Logica.UsuarioRol();
            DataTable Datos = new DataTable();
            Datos = ObjUsuarioRol.Listar();

            CboxTipoUsuario.ValueMember = "ID";
            CboxTipoUsuario.DisplayMember = "Descripcion";

            CboxTipoUsuario.DataSource = Datos;

            CboxTipoUsuario.SelectedIndex = -1;
        }

        private void LlenarListaUsuarios(bool VerActivos, string FiltroBusqueda = "")
        {
            Logica.Usuario MiUsuario = new Logica.Usuario();

            if (!string.IsNullOrEmpty(FiltroBusqueda.Trim()))
            {
                ListaUsuariosConFiltro = MiUsuario.Listar(VerActivos, FiltroBusqueda);
                DgvLista.DataSource = ListaUsuariosConFiltro;
            }
            else
            {
                ListaUsuariosNormal = MiUsuario.Listar(VerActivos);
                DgvLista.DataSource = ListaUsuariosNormal;
            }
            DgvLista.ClearSelection();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarBotonAgregar();
            DgvLista.ClearSelection();

        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();
                DataGridViewRow MiFila = DgvLista.SelectedRows[0];

                int IdUsuario = Convert.ToInt32(MiFila.Cells["ColIDUsuario"].Value);

                MiUsuarioLocal = new Logica.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.Consultar(IdUsuario);

                TxtCod.Text = MiUsuarioLocal.IDUsuario.ToString();
                TxtCedula.Text = MiUsuarioLocal.Cedula;
                TxtNombre.Text = MiUsuarioLocal.Nombre;
                TxtTelefono.Text = MiUsuarioLocal.Telefono;
                TxtDireccion.Text = MiUsuarioLocal.Direccion;
                CboxTipoUsuario.SelectedValue = MiUsuarioLocal.Rol.IDUsuarioRol;
                TxtCorreo.Text = MiUsuarioLocal.Username;

                CbActivo.Checked = MiUsuarioLocal.Activo;

                ActivarEditarYEliminar();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                DialogResult RespuestaUsuario = MessageBox.Show("¿Está seguro de agregar este usuario?", "Confirmación requerida", MessageBoxButtons.YesNo);

                if (RespuestaUsuario == DialogResult.Yes)
                {
                    Logica.Usuario MiUsuario = new Logica.Usuario();

                    MiUsuario.Cedula = TxtCedula.Text.Trim();
                    MiUsuario.Nombre = TxtNombre.Text.Trim();
                    MiUsuario.Telefono = TxtTelefono.Text.Trim();
                    MiUsuario.Username = TxtCorreo.Text.Trim();
                    MiUsuario.Direccion = TxtDireccion.Text.Trim();
                    MiUsuario.Contrasena = TxtPass.Text.Trim();
                    MiUsuario.Rol.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);



                    bool CedulaExiste = MiUsuario.ConsultarPorCedula();
                    bool EmailExiste = MiUsuario.ConsultarPorEmail();

                    if (!CedulaExiste && !EmailExiste)
                    {
                        if (MiUsuario.Agregar())
                        {
                            MessageBox.Show("Usuario agregado correctamente.", "", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaUsuarios(true);
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
        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCorreo.Text.Trim()) &&
                CboxTipoUsuario.SelectedIndex > -1)
            {
                if (BtnEditar.Enabled)
                {
                    R = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtPass.Text.Trim()))
                    {
                        R = true;
                    }
                }

            }

            return R;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Usuario MiUsuario = new Logica.Usuario();

                MiUsuario.IDUsuario = Convert.ToInt32(TxtCod.Text.Trim());
                MiUsuario.Cedula = TxtCedula.Text.Trim();
                MiUsuario.Nombre = TxtNombre.Text.Trim();
                MiUsuario.Telefono = TxtTelefono.Text.Trim();
                MiUsuario.Username = TxtCorreo.Text.Trim();
                MiUsuario.Direccion = TxtDireccion.Text.Trim();
                MiUsuario.Contrasena = "";

                if (FlagCambioPassword)
                {
                    MiUsuario.Contrasena = TxtPass.Text.Trim();
                }

                MiUsuario.Rol.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);

                if (MiUsuario.ConsultarPorID())
                {
                    if (MiUsuario.Editar())
                    {
                        MessageBox.Show("Usuario modificado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaUsuarios(CbVerUsuariosActivos.Checked);
                        ActivarBotonAgregar();
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Logica.Usuario MiUsuario = new Logica.Usuario();
            MiUsuario.IDUsuario = Convert.ToInt32(TxtCod.Text.Trim());

            if (MiUsuario.ConsultarPorID())
            {
                if (FlagActivar)
                {
                    if (MiUsuario.Activar())
                    {
                        MessageBox.Show("Usuario activado correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaUsuarios(CbVerUsuariosActivos.Checked);
                        ActivarBotonAgregar();
                    }
                }
                else
                {
                    if (MiUsuario.Desactivar())
                    {
                        MessageBox.Show("Usuario eliminado correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaUsuarios(true);
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

        private void CbVerUsuariosActivos_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaUsuarios(CbVerUsuariosActivos.Checked);


            if (CbVerUsuariosActivos.Checked)
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


        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 2)
            {
                LlenarListaUsuarios(CbVerUsuariosActivos.Checked, TxtBuscar.Text.Trim());

            }
            else
            {
                LlenarListaUsuarios(CbVerUsuariosActivos.Checked);
            }
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPass.Text.Trim()) && BtnEditar.Enabled)
            {
                FlagCambioPassword = true;
            }
            else
            {
                FlagCambioPassword = false;
            }

        }

    }
}
