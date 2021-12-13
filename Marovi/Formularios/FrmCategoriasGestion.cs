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
    public partial class FrmCategoriasGestion : Form
    {
        private Logica.ProductoCategoria MiCategoriaLocal { get; set; }

        private bool FlagActivar { get; set; }

        public DataTable ListaCategoriasNormal { get; set; }
        public DataTable ListaCategoriasConFiltro { get; set; }

        public FrmCategoriasGestion()
        {
            InitializeComponent();
            MiCategoriaLocal = new Logica.ProductoCategoria();
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
            TxtCat.Clear();


            CbActivo.Checked = false;

        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCat.Text.Trim())
                )
            {
                if (BtnEditar.Enabled)
                {
                    R = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtCat.Text.Trim()))
                    {
                        R = true;
                    }
                }
            }
            return R;
        }


        private void LlenarListaCategoria(bool VerActivos, string FiltroBusqueda = "")
        {
            Logica.ProductoCategoria MiCategoria = new Logica.ProductoCategoria();

            if (!string.IsNullOrEmpty(FiltroBusqueda.Trim()))
            {
                ListaCategoriasConFiltro = MiCategoria.Listar(VerActivos, FiltroBusqueda);
                DgvLista.DataSource = ListaCategoriasConFiltro;
            }
            else
            {
                ListaCategoriasNormal = MiCategoria.Listar(VerActivos);
                DgvLista.DataSource = ListaCategoriasNormal;
            }
            DgvLista.ClearSelection();
        }

        private void CbVerCategoriasActivas_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaCategoria(CbVerCategoriasActivas.Checked);


            if (CbVerCategoriasActivas.Checked)
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

        private void FrmCategoriasGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaCategoria(CbVerCategoriasActivas.Checked);
            LimpiarFormulario();
            ActivarBotonAgregar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                DialogResult RespuestaCategoria = MessageBox.Show("¿Está seguro de agregar esta Categoria?", "Confirmación requerida", MessageBoxButtons.YesNo);

                if (RespuestaCategoria == DialogResult.Yes)
                {
                    Logica.ProductoCategoria MiCategoria = new Logica.ProductoCategoria();

                    MiCategoria.Categoria = TxtCat.Text.Trim();

                    bool CategoriaExiste = MiCategoria.ConsultarPorCategoria();

                    if (!CategoriaExiste)
                    {
                        if (MiCategoria.Agregar())
                        {
                            MessageBox.Show("Categoría agregada correctamente.", "", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaCategoria(true);
                            ActivarBotonAgregar();
                        }
                    }
                    else
                    {
                        if (CategoriaExiste)
                        {
                            MessageBox.Show("La categoría ya fue usada", "", MessageBoxButtons.OK);
                            TxtCat.Focus();
                         
                        }

                    }

                }

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.ProductoCategoria MiCategoria = new Logica.ProductoCategoria();

                MiCategoria.IDCategoria = Convert.ToInt32(TxtCod.Text.Trim());
                MiCategoria.Categoria = TxtCat.Text.Trim();
                

                if (MiCategoria.ConsultarPorID())
                {
                    if (MiCategoria.Editar())
                    {
                        MessageBox.Show("Categoria modificada correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaCategoria(CbVerCategoriasActivas.Checked);
                        ActivarBotonAgregar();
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Logica.ProductoCategoria MiCategoria = new Logica.ProductoCategoria();
            MiCategoria.IDCategoria = Convert.ToInt32(TxtCod.Text.Trim());

            if (MiCategoria.ConsultarPorID())
            {
                if (FlagActivar)
                {
                    if (MiCategoria.Activar())
                    {
                        MessageBox.Show("Categoria activada correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaCategoria(CbVerCategoriasActivas.Checked);
                        ActivarBotonAgregar();
                    }
                }
                else
                {
                    if (MiCategoria.Desactivar())
                    {
                        MessageBox.Show("Categoria eliminada correctamente", "", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaCategoria(true);
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
                LlenarListaCategoria(CbVerCategoriasActivas.Checked, TxtBuscar.Text.Trim());

            }
            else
            {
                LlenarListaCategoria(CbVerCategoriasActivas.Checked);
            }
        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();
                DataGridViewRow MiFila = DgvLista.SelectedRows[0];

                int IdCategoria = Convert.ToInt32(MiFila.Cells["CIDCategoria"].Value);

                MiCategoriaLocal = new Logica.ProductoCategoria();
                MiCategoriaLocal = MiCategoriaLocal.Consultar(IdCategoria);

                TxtCod.Text = MiCategoriaLocal.IDCategoria.ToString();
                TxtCat.Text = MiCategoriaLocal.Categoria;
                CbActivo.Checked = MiCategoriaLocal.Activo;

                ActivarEditarYEliminar();
            }
        }
    }
}
