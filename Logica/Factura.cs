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
        //public List<FacturaDetalle> ListaDetalle;
        public Cliente MiCliente;

        public Factura()
        {
            UsuarioRealiza = new Usuario();
            //ListaDetalle = new List<FacturaDetalle>();
            MiCliente = new Cliente();
        }

    }
}
