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
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }

        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ParamList.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ParamList.Add(new SqlParameter("@Cedula", this.Cedula));
                MiCnn.ParamList.Add(new SqlParameter("@Email", this.Correo));
                MiCnn.ParamList.Add(new SqlParameter("@Direccion", this.Direccion));
                MiCnn.ParamList.Add(new SqlParameter("@Telefono", this.Telefono));



                int retorno = MiCnn.DMLUpdateDeleteInsert("SPClienteAgregar");

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

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDCliente));
                MiCnn.ParamList.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ParamList.Add(new SqlParameter("@Email", this.Correo));
                MiCnn.ParamList.Add(new SqlParameter("@Direccion", this.Direccion));
                MiCnn.ParamList.Add(new SqlParameter("@Telefono", this.Telefono));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPClienteEditar");


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
                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDCliente));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPClienteDesactivar");

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

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDCliente));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPClienteActivar");

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

        public Cliente Consultar(int pIDCliente)
        {
            Cliente R = new Cliente();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@IdCliente", pIDCliente));

            DataTable DatosCliente = new DataTable();
            DatosCliente = MyCnn.DMLSelect("SPClienteConsultar");

            if (DatosCliente.Rows.Count > 0)
            {
                DataRow MiFila = DatosCliente.Rows[0];

                R.IDCliente = Convert.ToInt32(MiFila["IDCliente"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Cedula = Convert.ToString(MiFila["Cedula"]);
                R.Telefono = Convert.ToString(MiFila["Telefono"]);
                R.Direccion = Convert.ToString(MiFila["Direccion"]);
                R.Correo = Convert.ToString(MiFila["Correo"]);
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
                MyCnn.ParamList.Add(new SqlParameter("@Id", this.IDCliente));

                DataTable retorno = MyCnn.DMLSelect("SPClienteConsultarPorID");

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
                DataTable retorno = MyCnn.DMLSelect("SPClienteConsultarPorCedula");

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
                ObjConexion.ParamList.Add(new SqlParameter("@Email", this.Correo));

                DataTable result = ObjConexion.DMLSelect("SPClienteConsultarPorEmail");

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
            R = MiConexion.DMLSelect("SPClienteListarTodos");
            return R;

        }

        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@VerActivos", VerActivos));
            MyCnn.ParamList.Add(new SqlParameter("@Filtro", Filtro));

            R = MyCnn.DMLSelect("SPClienteListar");

            return R;
        }
    }
}
