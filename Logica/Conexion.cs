using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Logica
{
    public class Conexion
    {
        String CadenaConn { get; set; }


        public List<SqlParameter> ParamList = new List<SqlParameter>();

        public int DMLUpdateDeleteInsert(String SPName)
        {
            int Return = 0;

            using (SqlConnection MyCnn = new SqlConnection(CadenaConn))

            {
                SqlCommand MyComando = new SqlCommand(SPName, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;

                if (ParamList != null && ParamList.Count > 0)
                {
                    foreach (SqlParameter item in ParamList)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }

                MyCnn.Open();

                Return = MyComando.ExecuteNonQuery();
            }

            return Return;
        }

        public DataTable DMLSelect(String SPName, bool LoadTableSchema = false)
        {
            DataTable Return = new DataTable();

            using (SqlConnection MyCnn = new SqlConnection(CadenaConn))
            {
                SqlCommand MyComando = new SqlCommand(SPName, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;
                if (ParamList != null && ParamList.Count > 0)
                {
                    foreach (SqlParameter item in ParamList)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }
                SqlDataAdapter MyAdaptador = new SqlDataAdapter(MyComando);

                if (LoadTableSchema)
                {
                    MyAdaptador.FillSchema(Return, SchemaType.Source);
                }
                else
                {
                    MyAdaptador.Fill(Return);
                }
            }
            return Return;
        }

        public Object DMLConRetornoEscalar(String SPName)
        {
            Object Return = null;
            using (SqlConnection MyCnn = new SqlConnection(CadenaConn))

            {
                SqlCommand MyComando = new SqlCommand(SPName, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;

                if (ParamList != null && ParamList.Count > 0)
                {
                    foreach (SqlParameter item in ParamList)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }
                MyCnn.Open();
                Return = MyComando.ExecuteScalar();
            }

            return Return;
        }

        public Conexion()
        {
            this.CadenaConn = ConfigurationManager.ConnectionStrings["CNNSTR"].ToString();
        }

    }
}

