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
        public string CodigoDeBarras { get; set; }
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
        }
    }
}
