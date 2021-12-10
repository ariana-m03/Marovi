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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtPass.Text.Trim()))
            {
                string u = TxtUsuario.Text.Trim();
                string p = TxtPass.Text.Trim();

                Logica.Usuario MiUsuario = new Logica.Usuario();

                int IdUsuarioValidado = MiUsuario.ValidarLogIn(u, p);
                

                if (IdUsuarioValidado > 0)
                {
                    Locales.ObjetosGlobales.MiUsuarioGlobal = MiUsuario.Consultar(IdUsuarioValidado);

                    Locales.ObjetosGlobales.MiFormPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña son incorrectos", "", MessageBoxButtons.OK);
                    TxtPass.Focus();
                    TxtPass.SelectAll();
                }

            }
        }

        
 

        private void BtnVer_Click(object sender, EventArgs e)
        {

        }

        private void BtnVer_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPass.UseSystemPasswordChar = false;
        }

        private void BtnVer_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPass.UseSystemPasswordChar = true;
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnIngresar_Click(sender, e);
            }
        }
    }
}
