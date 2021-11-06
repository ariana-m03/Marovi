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
    }
}
