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
    public class Producto
    {
        public int IDProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CodigoBarras { get; set; }
        public int StockInicial { get; set; }
        public int Entradas { get; set; }
        public int Salidas { get; set; }
        public int StockFinal { get; set; }
        public string Peso { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioPorMayor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public bool Activo { get; set; }




        public ProductoCategoria Categoria { get; set; }

        public Producto()
        {
            Categoria = new ProductoCategoria();
            Activo = true;
        }

        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ParamList.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ParamList.Add(new SqlParameter("@Descripcion", this.Descripcion));
                MiCnn.ParamList.Add(new SqlParameter("@CodigoDeBarras", this.CodigoBarras));
                MiCnn.ParamList.Add(new SqlParameter("@StockInicial", this.StockInicial));
                MiCnn.ParamList.Add(new SqlParameter("@Entradas", this.Entradas));
                MiCnn.ParamList.Add(new SqlParameter("@Salidas", this.Salidas));
                MiCnn.ParamList.Add(new SqlParameter("@StockFinal", this.StockFinal));
                MiCnn.ParamList.Add(new SqlParameter("@Peso", this.Peso));
                MiCnn.ParamList.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
                MiCnn.ParamList.Add(new SqlParameter("@PrecioPorMayor", this.PrecioPorMayor));
                MiCnn.ParamList.Add(new SqlParameter("@FechaIngreso", this.FechaIngreso));
                MiCnn.ParamList.Add(new SqlParameter("@FechaCaducidad", this.FechaCaducidad));
                
                MiCnn.ParamList.Add(new SqlParameter("@IdProductoCategoria", this.Categoria.IDCategoria));
                MiCnn.ParamList.Add(new SqlParameter("@Activo", this.Activo));


                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoAgregar");

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

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDProducto));
                MiCnn.ParamList.Add(new SqlParameter("@Nombre", this.Nombre));
                MiCnn.ParamList.Add(new SqlParameter("@Descripcion", this.Descripcion));
                MiCnn.ParamList.Add(new SqlParameter("@CodigoDeBarras", this.CodigoBarras));
                MiCnn.ParamList.Add(new SqlParameter("@StockInicial", this.StockInicial));
                MiCnn.ParamList.Add(new SqlParameter("@Entradas", this.Entradas));
                MiCnn.ParamList.Add(new SqlParameter("@Salidas", this.Salidas));
                MiCnn.ParamList.Add(new SqlParameter("@StockFinal", this.StockFinal));
                MiCnn.ParamList.Add(new SqlParameter("@Peso", this.Peso));
                MiCnn.ParamList.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
                MiCnn.ParamList.Add(new SqlParameter("@PrecioPorMayor", this.PrecioPorMayor));
                MiCnn.ParamList.Add(new SqlParameter("@FechaIngreso", this.FechaIngreso));
                MiCnn.ParamList.Add(new SqlParameter("@FechaCaducidad", this.FechaCaducidad));
                MiCnn.ParamList.Add(new SqlParameter("@IdCategoria", this.Categoria.IDCategoria));
                MiCnn.ParamList.Add(new SqlParameter("@Activo", this.Activo));


                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoEditar");


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



        public Producto Consultar(int pIDProducto)
        {
            Producto R = new Producto();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@IdProducto", pIDProducto));

            DataTable DatosProducto = new DataTable();
            DatosProducto = MyCnn.DMLSelect("SPProductoConsultar");

            if (DatosProducto.Rows.Count > 0)
            {
                DataRow MiFila = DatosProducto.Rows[0];

                R.IDProducto = Convert.ToInt32(MiFila["IDProducto"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Descripcion = Convert.ToString(MiFila["Descripcion"]);
                R.StockInicial = Convert.ToInt32(MiFila["StockInicial"]);
                R.Entradas = Convert.ToInt32(MiFila["Entradas"]);
                R.Salidas = Convert.ToInt32(MiFila["Salidas"]);
                R.StockFinal = Convert.ToInt32(MiFila["StockFinal"]);
                R.Peso = Convert.ToString(MiFila["Peso"]);
                R.PrecioUnitario = Convert.ToDecimal(MiFila["PrecioUnitario"]);
                R.PrecioPorMayor = Convert.ToDecimal(MiFila["PrecioPorMayor"]);
                R.FechaIngreso = Convert.ToDateTime(MiFila["FechaIngreso"]);
                R.FechaCaducidad = Convert.ToDateTime(MiFila["FechaCaducidad"]);
                R.Categoria.IDCategoria = Convert.ToInt32(MiFila["IdCategoria"]);
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
                MyCnn.ParamList.Add(new SqlParameter("@Id", this.IDProducto));

                DataTable retorno = MyCnn.DMLSelect("SPProductoConsultarPorID");

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

        public bool ConsultarPorCodigoDeBarras()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();
                MyCnn.ParamList.Add(new SqlParameter("@CodigoDeBarras", this.CodigoBarras));
                DataTable retorno = MyCnn.DMLSelect("SPProductoConsultarPorCodigoDeBarras");

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

        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();
            Conexion MiConexion = new Conexion();
            R = MiConexion.DMLSelect("SPProdutoListarTodos");
            return R;

        }

        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@VerActivos", VerActivos));
            MyCnn.ParamList.Add(new SqlParameter("@Filtro", Filtro));

            R = MyCnn.DMLSelect("SPProductoListar");
            return R;

        }

        public DataTable ListarPorCategoria(int IDCategoria)
        {
            DataTable R = new DataTable();

            return R;

        }

        public DataTable ListarEnDetalle()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.DMLSelect("SPProductoListarEnDetalle");

            return R;
        }

        public bool Desactivar()
        {
            bool R = false;
            try
            {
                Conexion MiCnn = new Conexion();
                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDProducto));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoDesactivar");

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

                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDProducto));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPProductoActivar");

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
