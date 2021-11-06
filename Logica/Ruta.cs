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
        public bool Activo { get; set; }

        public Usuario Nombre { get; set; }

        public Ruta()
        {
            Nombre = new Usuario();
            Activo = true;
        }
    }
}
