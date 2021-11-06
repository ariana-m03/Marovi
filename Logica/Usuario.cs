using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Logica
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CorreoRespaldo { get; set; }

        public bool Activo { get; set; }


        public UsuarioRol Rol { get; set; }

        public Usuario()
        {
            Rol = new UsuarioRol();
            Activo = true;
        }

        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                Crypto MiEncriptador = new Crypto();

                MiCnn.ParamList.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ParamList.Add(new SqlParameter("@Cedula", this.Cedula));
                MiCnn.ParamList.Add(new SqlParameter("@Telefono", this.Telefono));
                MiCnn.ParamList.Add(new SqlParameter("@Direccion", this.Direccion));
                MiCnn.ParamList.Add(new SqlParameter("@Username", this.Username));
                MiCnn.ParamList.Add(new SqlParameter("@Activo", this.Activo));
                MiCnn.ParamList.Add(new SqlParameter("@IdRol", this.Rol.IDUsuarioRol));

                string MiPassEncriptado = MiEncriptador.EncriptarOneWay(this.Password);
                MiCnn.ParamList.Add(new SqlParameter("@Pass", MiPassEncriptado));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioAgregar");

                if (retorno > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return R;
        }
        public Usuario Consultar(int pIDUsuario)
        {
            Usuario R = new Usuario();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@IdUsuario", pIDUsuario));

            DataTable DatosUsuario = new DataTable();
            DatosUsuario = MyCnn.DMLSelect("SPUsuarioConsultar");

            if (DatosUsuario.Rows.Count > 0)
            {
                DataRow MiFila = DatosUsuario.Rows[0];

                R.IDUsuario = Convert.ToInt32(MiFila["IDUsuario"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Cedula = Convert.ToString(MiFila["Cedula"]);
                R.Telefono = Convert.ToString(MiFila["Telefono"]);
                R.Direccion = Convert.ToString(MiFila["Direccion"]);
                R.Username = Convert.ToString(MiFila["Username"]);
                R.Password = Convert.ToString(MiFila["Password"]);
                R.Rol.IDUsuarioRol = Convert.ToInt32(MiFila["IDUsuarioRol"]);
                R.Rol.Rol = Convert.ToString(MiFila["Rol"]);
                R.Activo = Convert.ToBoolean(MiFila["Activo"]);
            }
            return R;
        }
        public int ValidarLogIn(string pUsuario, string pPass)
        {
            int R = 0;

            this.Username = pUsuario;
            this.Password = pPass;

            Crypto MiEncriptador = new Crypto();

            //string PasswordEncriptado = MiEncriptador.EncriptarOneWay(this.Password);

            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@User", this.Username));
            MyCnn.ParamList.Add(new SqlParameter("@Pass", this.Password));

            DataTable respuesta = MyCnn.DMLSelect("SPUsuarioValidarLogin");

            if (respuesta != null && respuesta.Rows.Count > 0)
            {
                DataRow MiFila = respuesta.Rows[0];
                R = Convert.ToInt32(MiFila["IDUsuario"]);
            }
            return R;
        }
    }
}
