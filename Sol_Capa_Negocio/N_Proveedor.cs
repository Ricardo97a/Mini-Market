using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol_Capa_Datos;
using Sol_Capa_Entidades;

namespace Sol_Capa_Negocio
{
    public class N_Proveedor
    {

        public static DataTable Listado_pv(string ctexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_pv(ctexto);
        }

        public static string Guardar_pv(int nopcion, E_Proveedores oPV)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Guardar_pv(nopcion, oPV);
        }
        public static string Eliminar_pv(int codigo_pr)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Eliminar_pv(codigo_pr);
        }

        public static DataTable Listado_tdpc_pv()
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_tdpc_pv();
        }
        public static DataTable Listado_sx_pv()
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_sx_pv();
        }
        public static DataTable Listado_ru_pv(string ctexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_ru_pv(ctexto);
        }
        public static DataTable Listado_di_pv(string ctexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_di_pv(ctexto);
        }

    }
}
