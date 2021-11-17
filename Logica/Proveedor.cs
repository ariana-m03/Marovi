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
    public class Proveedor
    {
        public int IDProveedor { get; set; }
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



                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProveedorAgregar");

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

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDProveedor));
                MiCnn.ParamList.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ParamList.Add(new SqlParameter("@Email", this.Correo));
                MiCnn.ParamList.Add(new SqlParameter("@Direccion", this.Direccion));
                MiCnn.ParamList.Add(new SqlParameter("@Telefono", this.Telefono));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProveedorEditar");


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
                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDProveedor));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProveedorDesactivar");

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

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDProveedor));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProveedorActivar");

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
        public Proveedor Consultar(int pIDProveedor)
        {
            Proveedor R = new Proveedor();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@IdProveedor", pIDProveedor));

            DataTable DatosProveedor = new DataTable();
            DatosProveedor = MyCnn.DMLSelect("SPProveedorConsultar");

            if (DatosProveedor.Rows.Count > 0)
            {
                DataRow MiFila = DatosProveedor.Rows[0];

                R.IDProveedor = Convert.ToInt32(MiFila["IDProveedor"]);
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
                MyCnn.ParamList.Add(new SqlParameter("@Id", this.IDProveedor));

                DataTable retorno = MyCnn.DMLSelect("SPProveedorConsultarPorID");

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
                DataTable retorno = MyCnn.DMLSelect("SPProveedorConsultarPorCedula");

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

                DataTable result = ObjConexion.DMLSelect("SPProveedorConsultarPorEmail");

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
            R = MiConexion.DMLSelect("SPProveedorListarTodos");
            return R;

        }

        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@VerActivos", VerActivos));
            MyCnn.ParamList.Add(new SqlParameter("@Filtro", Filtro));

            R = MyCnn.DMLSelect("SPProveedoresListar");

            return R;
        }
    }
}
