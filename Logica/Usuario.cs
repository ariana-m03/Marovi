using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Text.RegularExpressions;

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
        public string Contrasena { get; set; }
        public string CorreoRespaldo { get; set; }

        public bool Activo { get; set; }


        public UsuarioRol Rol { get; set; }

        public Usuario()
        {
            Rol = new UsuarioRol();
            Activo = true;
        }

        //public bool ValidarEmail(string s)
        //{
           
        //    var regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        //    return regex.IsMatch(s);
           
        //}

        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                Crypto MiEncriptador = new Crypto();

                MiCnn.ParamList.Add(new SqlParameter("@Cedula", this.Cedula));
                MiCnn.ParamList.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ParamList.Add(new SqlParameter("@Telefono", this.Telefono));
                MiCnn.ParamList.Add(new SqlParameter("@Username", this.Username));
                MiCnn.ParamList.Add(new SqlParameter("@Direccion", this.Direccion));
                string PassEncriptado = MiEncriptador.EncriptarOneWay(this.Contrasena);
                MiCnn.ParamList.Add(new SqlParameter("@Pass", PassEncriptado));
                MiCnn.ParamList.Add(new SqlParameter("@IdRol", this.Rol.IDUsuarioRol));
                MiCnn.ParamList.Add(new SqlParameter("@Activo", this.Activo));




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

        public bool Editar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDUsuario));
                MiCnn.ParamList.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ParamList.Add(new SqlParameter("@Telefono", this.Telefono));
                MiCnn.ParamList.Add(new SqlParameter("@Username", this.Username));
                MiCnn.ParamList.Add(new SqlParameter("@Direccion", this.Direccion));

                Crypto MiEncriptador = new Crypto();
                string PasswordEncriptado = "";

                if (!string.IsNullOrEmpty(this.Contrasena))
                {
                    PasswordEncriptado = MiEncriptador.EncriptarOneWay(this.Contrasena);
                }

                MiCnn.ParamList.Add(new SqlParameter("@Pass", PasswordEncriptado));
                MiCnn.ParamList.Add(new SqlParameter("@IdRol", this.Rol.IDUsuarioRol));

                

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioEditar");


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

        public bool Desactivar()
        {
            bool R = false;
            try
            {
                Conexion MiCnn = new Conexion();
                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDUsuario));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioDesactivar");

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

        public bool Activar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDUsuario));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioActivar");

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
                R.Cedula = Convert.ToString(MiFila["Cedula"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Telefono = Convert.ToString(MiFila["Telefono"]);
                R.Username = Convert.ToString(MiFila["Username"]);
                R.Direccion = Convert.ToString(MiFila["Direccion"]);
                R.Contrasena = Convert.ToString(MiFila["Contrasena"]);
                R.Rol.IDUsuarioRol = Convert.ToInt32(MiFila["IDUsuarioRol"]);
                R.Rol.Rol = Convert.ToString(MiFila["Rol"]);
                R.Activo = Convert.ToBoolean(MiFila["Activo"]);
            }
            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();
                MyCnn.ParamList.Add(new SqlParameter("@Id", this.IDUsuario));

                DataTable retorno = MyCnn.DMLSelect("SPUsuarioConsultarPorID");

                if (retorno.Rows.Count > 0)
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

        public bool ConsultarPorCedula()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();
                MyCnn.ParamList.Add(new SqlParameter("@Cedula", this.Cedula));
                DataTable retorno = MyCnn.DMLSelect("SPUsuarioConsultarPorCedula");

                if (retorno.Rows.Count > 0)
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

        public bool ConsultarPorEmail()
        {
            bool R = false;

            try
            {
                Conexion ObjConexion = new Conexion();
                ObjConexion.ParamList.Add(new SqlParameter("@Email", this.Username));

                DataTable result = ObjConexion.DMLSelect("SPUsuarioConsultarPorEmail");

                if (result.Rows.Count > 0)
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

        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();
            Conexion MiConexion = new Conexion();
            R = MiConexion.DMLSelect("SPUsuariosListarTodos");
            return R;

        }

        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@VerActivos", VerActivos));
            MyCnn.ParamList.Add(new SqlParameter("@Filtro", Filtro));

            R = MyCnn.DMLSelect("SPUsuariosListar");
            return R;

        }

        public int ValidarLogIn(string pUsuario, string pPass)
        {
            int R = 0;

            this.Username = pUsuario;
            this.Contrasena = pPass;

            Crypto MiEncriptador = new Crypto();

            string PasswordEncriptado = MiEncriptador.EncriptarOneWay(this.Contrasena);

            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@User", this.Username));
            MyCnn.ParamList.Add(new SqlParameter("@Pass", PasswordEncriptado));

            DataTable respuesta = MyCnn.DMLSelect("SPUsuarioValidarLogin");

            if (respuesta != null && respuesta.Rows.Count > 0)
            {
                DataRow MiFila = respuesta.Rows[0];
                R = Convert.ToInt32(MiFila["IDUsuario"]);
            }
            return R;
        }

        public bool EditarPassword()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                //Lista de parametros que llegarán al SP

                MiCnn.ParamList.Add(new SqlParameter("@Email", this.Username));

                Crypto MiEncriptador = new Crypto();
                string PasswordEncriptado = "";

                if (!string.IsNullOrEmpty(this.Contrasena))
                {
                    PasswordEncriptado = MiEncriptador.EncriptarOneWay(this.Contrasena);
                }

                MiCnn.ParamList.Add(new SqlParameter("@Pass", PasswordEncriptado));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioEditarPassword");

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
    }
}
