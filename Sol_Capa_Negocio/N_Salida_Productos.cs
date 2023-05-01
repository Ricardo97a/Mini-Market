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
    public class N_Salida_Productos
    {

        public static DataTable Listado_sp(string ctexto)
        {
            D_Salida_Productos Datos = new D_Salida_Productos();
            return Datos.Listado_sp(ctexto);
        }
        public static DataTable Listado_detalle_sp(int nCodigo_sp)
        {
            D_Salida_Productos Datos = new D_Salida_Productos();
            return Datos.Listado_detalle_sp(nCodigo_sp);
        }

        public static string Guardar_sp( E_Salida_Productos osp,DataTable dTable)
        {
            D_Salida_Productos Datos = new D_Salida_Productos();
            return Datos.Guardar_sp(osp, dTable);
        }
        public static string Eliminar_sp(int codigo_sp)
        {
            D_Salida_Productos Datos = new D_Salida_Productos();
            return Datos.Eliminar_sp(codigo_sp);
        }

        public static DataTable Listado_tde()
        {
            D_Salida_Productos Datos = new D_Salida_Productos();
            return Datos.Listado_tde();
        }
       
        public static DataTable Listado_cl_sp(string ctexto)
        {
            D_Salida_Productos Datos = new D_Salida_Productos();
            return Datos.Listado_cl_sp(ctexto);
        }
        public static DataTable Listado_pr_sp(string ctexto)
        {
            D_Salida_Productos Datos = new D_Salida_Productos();
            return Datos.Listado_pr_sp(ctexto);
        }

    }
}
