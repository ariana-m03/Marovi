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
    public class Ruta
    {
        public int IDRuta { get; set; }
        public string TipoTransporte { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public int CantidadParadas { get; set; }
        public string Paradas { get; set; }
        public bool Activo { get; set; }

        public Usuario NombreUsuario;

        public Ruta()
        {
            NombreUsuario = new Usuario();
            Activo = true;
        }

        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ParamList.Add(new SqlParameter("@Transporte", this.TipoTransporte));
                MiCnn.ParamList.Add(new SqlParameter("@Provincia", this.Provincia));
                MiCnn.ParamList.Add(new SqlParameter("@Canton", this.Canton));
                MiCnn.ParamList.Add(new SqlParameter("@Distrito", this.Distrito));
                MiCnn.ParamList.Add(new SqlParameter("@CantidadParadas", this.CantidadParadas));
                MiCnn.ParamList.Add(new SqlParameter("@Paradas", this.Paradas));
              

                MiCnn.ParamList.Add(new SqlParameter("@IdUsuario", this.NombreUsuario.IDUsuario));


                int retorno = MiCnn.DMLUpdateDeleteInsert("SPRutaAgregar");

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

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDRuta));
                MiCnn.ParamList.Add(new SqlParameter("@Transporte", this.TipoTransporte));
                MiCnn.ParamList.Add(new SqlParameter("@Provincia", this.Provincia));
                MiCnn.ParamList.Add(new SqlParameter("@Canton", this.Canton));
                MiCnn.ParamList.Add(new SqlParameter("@Distrito", this.Distrito));
                MiCnn.ParamList.Add(new SqlParameter("@CantidadParadas", this.CantidadParadas));
                MiCnn.ParamList.Add(new SqlParameter("@Paradas", this.Paradas));

                MiCnn.ParamList.Add(new SqlParameter("@IdUsuario", this.NombreUsuario.IDUsuario));


                int retorno = MiCnn.DMLUpdateDeleteInsert("SPRutaEditar");


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
                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDRuta));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPRutaDesactivar");

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

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDRuta));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPRutaActivar");

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

        public Ruta Consultar(int pIDRuta)
        {
            Ruta R = new Ruta();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@IdRuta", pIDRuta));

            DataTable DatosRuta = new DataTable();
            DatosRuta = MyCnn.DMLSelect("SPRutaConsultar");

            if (DatosRuta.Rows.Count > 0)
            {
                DataRow MiFila = DatosRuta.Rows[0];

                R.IDRuta = Convert.ToInt32(MiFila["IDRuta"]);
                R.TipoTransporte = Convert.ToString(MiFila["TipoTransporte"]);
                R.NombreUsuario.IDUsuario = Convert.ToInt32(MiFila["IDUsuario"]);
                R.Provincia = Convert.ToString(MiFila["Provincia"]);
                R.Canton = Convert.ToString(MiFila["Canton"]);
                R.Distrito = Convert.ToString(MiFila["Distrito"]);
                R.CantidadParadas = Convert.ToInt32(MiFila["CantidadParadas"]);
                R.Paradas = Convert.ToString(MiFila["Paradas"]);
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
                MyCnn.ParamList.Add(new SqlParameter("@Id", this.IDRuta));

                DataTable retorno = MyCnn.DMLSelect("SPRutaConsultarPorID");

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


        public bool ConsultarPorTipoTransporte()
        {
            bool R = false;

            try
            {
                Conexion ObjConexion = new Conexion();
                ObjConexion.ParamList.Add(new SqlParameter("@Transporte", this.TipoTransporte));

                DataTable result = ObjConexion.DMLSelect("SPRutaConsultarPorTipoTransporte");

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
            R = MiConexion.DMLSelect("SPRutaListarTodos");
            return R;

        }

        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@VerActivos", VerActivos));
            MyCnn.ParamList.Add(new SqlParameter("@Filtro", Filtro));

            R = MyCnn.DMLSelect("SPRutaListar");

            return R;
        }
    }
}
