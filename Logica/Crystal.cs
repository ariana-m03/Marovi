using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;

namespace Logica
{
    public class Crystal
    {
        public ReportDocument Reporte { get; set; }

        public DataTable Datos { get; set; }

        public Crystal(ReportDocument pReport)
        {
            Reporte = pReport;
        }

        public Crystal()
        {

        }

        public ReportDocument GenerarReporte()
        {
            if (Datos.Rows.Count > 0)
            {
                Reporte.SetDataSource(Datos);

                return Reporte;
            }
            else
            { return null; }
        }
    }
}
