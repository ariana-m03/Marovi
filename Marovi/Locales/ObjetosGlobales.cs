using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marovi.Locales
{
    public static class ObjetosGlobales
    {
        public static Form MiFormPrincipal = new Formularios.FrmPrincipal();

        public static Logica.Usuario MiUsuarioGlobal = new Logica.Usuario();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        public static Formularios.FrmListaUsuarios MiFormListaUsuarios = new Formularios.FrmListaUsuarios();

        public static Formularios.FrmProductosGestion MiFormGestionProductos = new Formularios.FrmProductosGestion();

        public static Formularios.FrmListaProductos MiFormListaProductos = new Formularios.FrmListaProductos();

        public static Formularios.FrmProveedoresGestion MiFormGestionProveedores = new Formularios.FrmProveedoresGestion();

        public static Formularios.FrmListaProveedores MiFormListaProveedores = new Formularios.FrmListaProveedores();

        public static Formularios.FrmClientesGestion MiFormGestionClientes = new Formularios.FrmClientesGestion();

        public static Formularios.FrmListaClientes MiFormListaClientes = new Formularios.FrmListaClientes();

        public static Formularios.FrmRutasGestion MiFormGestionRutas = new Formularios.FrmRutasGestion();

        public static Formularios.FrmListaRutas MiFormListaRutas = new Formularios.FrmListaRutas();

        public static Formularios.FrmFacturasGestion MiFormGestionFacturas = new Formularios.FrmFacturasGestion();

        public static Formularios.FrmListaFacturas MiFormListaFacturas = new Formularios.FrmListaFacturas();

        public static Reportes.RptFactura MiReporteFactura = new Reportes.RptFactura();

        public static Formularios.FrmCategoriasGestion MiFormGestionCategorias = new Formularios.FrmCategoriasGestion();

        //public static Formularios.FrmVisualizadorReportes MiVisualizador = new Formularios.FrmVisualizadorReportes();


    }
}
