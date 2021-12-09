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
    public class ProductoCategoria
    {
        public int IDCategoria { get; set; }
        public string Categoria { get; set; }
        public bool Activo { get; set; }

        public ProductoCategoria()
        {
            Activo = true;
        }



        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ParamList.Add(new SqlParameter("@Categoria", this.Categoria));
 
                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoCategoriaAgregar");

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

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDCategoria));
                MiCnn.ParamList.Add(new SqlParameter("@Categoria", this.Categoria));
                
                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoCategoriaEditar");


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
                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDCategoria));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoCategoriaDesactivar");

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

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDCategoria));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoCategoriaActivar");

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
        public ProductoCategoria Consultar(int pIDCategoria)
        {
            ProductoCategoria R = new ProductoCategoria();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@Id", pIDCategoria));

            DataTable DatosCategoria = new DataTable();
            DatosCategoria = MyCnn.DMLSelect("SPProductoCategoriaConsultar");

            if (DatosCategoria.Rows.Count > 0)
            {
                DataRow MiFila = DatosCategoria.Rows[0];

                R.IDCategoria = Convert.ToInt32(MiFila["IDCategoria"]);
                R.Categoria = Convert.ToString(MiFila["Categoria"]);
                
            }
            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();
                MyCnn.ParamList.Add(new SqlParameter("@Id", this.IDCategoria));

                DataTable retorno = MyCnn.DMLSelect("SPProductoCategoriaConsultarPorID");

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
        
            public bool ConsultarPorCategoria()
        {
            bool R = false;

            try
            {
                Conexion ObjConexion = new Conexion();
                ObjConexion.ParamList.Add(new SqlParameter("@Categoria", this.Categoria));

                DataTable result = ObjConexion.DMLSelect("SPProductoCategoriaConsultarPorCat");

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
            R = MiConexion.DMLSelect("SPProductoCategoriaListarTodas");
            return R;

        }

        public DataTable ListarCombo()
        {
            DataTable R = new DataTable();
            Conexion MiConexion = new Conexion();
            R = MiConexion.DMLSelect("SPCategoriaListarCombo");
            return R;

        }

        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@VerActivos", VerActivos));
            MyCnn.ParamList.Add(new SqlParameter("@Filtro", Filtro));

            R = MyCnn.DMLSelect("SPProductoCategoriaListar");

            return R;
        }
    }
}
