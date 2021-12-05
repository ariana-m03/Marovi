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
    public class FacturaDetalle
    {
        public int IdDetalleFact { get; set; }
        public int Cantidad { get; set; }
        public decimal TotalMayor { get; set; }
        public decimal TotalUnitario { get; set; }


        public Producto MiProducto { get; set; }

        public FacturaDetalle()
        {
            MiProducto = new Producto();
        }
    }
}
