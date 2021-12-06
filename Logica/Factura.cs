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
    public class Factura
    {

        public int IDFactura { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }

        public bool Activo { get; set; }

        public Usuario UsuarioRealiza;
        public List<FacturaDetalle> ListaDetalle;
        public Cliente MiCliente;
      



        public Factura()
        {
            UsuarioRealiza = new Usuario();
            ListaDetalle = new List<FacturaDetalle>();
            MiCliente = new Cliente();
            
           
        }

        public ReportDocument Imprimir(ReportDocument repo)
        {
            ReportDocument R = repo;

            Crystal ObjCrytal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ParamList.Add(new SqlParameter("@ID", this.IDFactura));

            Datos = MiCnn.DMLSelect("SPFacturaReporte");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                ObjCrytal.Datos = Datos;

                R = ObjCrytal.GenerarReporte();
            }

            return R;
        }

        public DataTable AsignarEsquemaDetalle()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.DMLSelect("SPFacturaDetalleSchema", true);

            R.PrimaryKey = null;

            return R;
        }

        public bool Agregar()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@NumeroFact", this.NumeroFactura));
            MyCnn.ParamList.Add(new SqlParameter("@Fecha", this.Fecha));
            MyCnn.ParamList.Add(new SqlParameter("@IdUsuario", this.UsuarioRealiza.IDUsuario));
            MyCnn.ParamList.Add(new SqlParameter("@IdCliente", this.MiCliente.IDCliente));

            Object Retorno = MyCnn.DMLConRetornoEscalar("SPFacturaAgregarEncabezado");

            int IdFacturaRecienCreada;

            if (Retorno != null)
            {
                try
                {
                    IdFacturaRecienCreada = Convert.ToInt32(Retorno.ToString());

                    this.IDFactura = IdFacturaRecienCreada;

                    int Acumulador = 0;

                    foreach (FacturaDetalle item in this.ListaDetalle)
                    {
                        Conexion MyCnnDet = new Conexion();

                        MyCnnDet.ParamList.Add(new SqlParameter("@IdProd", item.MiProducto.IDProducto));
                        MyCnnDet.ParamList.Add(new SqlParameter("@IdFactura", this.IDFactura));
                        MyCnnDet.ParamList.Add(new SqlParameter("@TotUnitario", item.TotalUnitario));
                        MyCnnDet.ParamList.Add(new SqlParameter("@TotMayor", item.TotalMayor));
                        MyCnnDet.ParamList.Add(new SqlParameter("@Cant", item.Cantidad));

                        MyCnnDet.DMLUpdateDeleteInsert("SPFacturaAgregarDetalle");

                        Acumulador += 1;
                    }

                    if (Acumulador == this.ListaDetalle.Count)
                    {
                        R = true;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }

            return R;
        }

        public bool Anular()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();
                MiCnn.ParamList.Add(new SqlParameter("@Id", this.IDFactura));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPFacturaAnular");

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

        public Factura Consultar(int pIDFactura)
        {
            Factura R = new Factura();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@IdFactura", pIDFactura));

            DataTable DatosFactura = new DataTable();
            DatosFactura = MyCnn.DMLSelect("SPFacturaConsultar");

            if (DatosFactura.Rows.Count > 0)
            {
                DataRow MiFila = DatosFactura.Rows[0];

                R.IDFactura = Convert.ToInt32(MiFila["IDFactura"]);
                R.NumeroFactura = Convert.ToString(MiFila["NumeroFactura"]);
                R.Fecha = Convert.ToDateTime(MiFila["Fecha"]);
                R.MiCliente.Nombre = Convert.ToString(MiFila["Nombre"]);
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
                MyCnn.ParamList.Add(new SqlParameter("@Id", this.IDFactura));

                DataTable retorno = MyCnn.DMLSelect("SPFacturaConsultarPorID");

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

        public bool ConsultarPorNumeroFacturaYFactura()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();
                MyCnn.ParamList.Add(new SqlParameter("@NumeroF", this.NumeroFactura));
                MyCnn.ParamList.Add(new SqlParameter("@Cliente", this.MiCliente));
                DataTable retorno = MyCnn.DMLSelect("SPFacturaConsultarPorNumeroFyCliente");

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
            R = MiConexion.DMLSelect("SPFacturaListarTodas");
            return R;

        }

        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ParamList.Add(new SqlParameter("@VerActivos", VerActivos));
            MyCnn.ParamList.Add(new SqlParameter("@Filtro", Filtro));

            R = MyCnn.DMLSelect("SPFacturaListar");

            return R;
        }

        public DataTable ListarPorFecha(DateTime Fecha)
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();
            R = MiConexion.DMLSelect("SPFacturaListarPorFecha");

            return R;

        }

        public DataTable ListarPorFactura(int IDFactura)
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();
            R = MiConexion.DMLSelect("SPFacturaListarPorFactura");

            return R;

        }

    }
}
