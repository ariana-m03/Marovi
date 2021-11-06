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
    class FacturaDetalle
    {
        public int Cantidad { get; set; }

        public decimal PrecioFactura { get; set; }

        public Producto MiProducto { get; set; }

        public FacturaDetalle()
        {
            MiProducto = new Producto();
        }
    }
}
