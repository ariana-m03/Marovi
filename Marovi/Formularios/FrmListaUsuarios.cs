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
    public partial class FrmListaUsuarios : Form
    {
        private Logica.Usuario MiUsuarioLocal { get; set; }


        public DataTable ListaUsuariosNormal { get; set; }
        public DataTable ListaUsuariosConFiltro { get; set; }

        public FrmListaUsuarios()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Usuario();

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

        private void CbVerUsuariosActivos_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaUsuarios(CbVerUsuariosActivos.Checked);
        }

       

        private void FrmListaUsuarios_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaUsuarios(CbVerUsuariosActivos.Checked);
        }

        
        
    }
}
