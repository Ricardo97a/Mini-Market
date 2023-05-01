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
    public class N_Entrada_Productos
    {

        public static DataTable Listado_ep(string ctexto)
        {
            D_Entrada_Productos Datos = new D_Entrada_Productos();
            return Datos.Listado_ep(ctexto);
        }
        public static DataTable Listado_detalle_ep(int nCodigo_ep)
        {
            D_Entrada_Productos Datos = new D_Entrada_Productos();
            return Datos.Listado_detalle_ep(nCodigo_ep);
        }

        public static string Guardar_ep( E_Entrada_Productos oEP,DataTable dTable)
        {
            D_Entrada_Productos Datos = new D_Entrada_Productos();
            return Datos.Guardar_ep(oEP, dTable);
        }
        public static string Eliminar_ep(int codigo_ep)
        {
            D_Entrada_Productos Datos = new D_Entrada_Productos();
            return Datos.Eliminar_ep(codigo_ep);
        }

        public static DataTable Listado_tde()
        {
            D_Entrada_Productos Datos = new D_Entrada_Productos();
            return Datos.Listado_tde();
        }
        public static DataTable Listado_al_ep()
        {
            D_Entrada_Productos Datos = new D_Entrada_Productos();
            return Datos.Listado_al_ep();
        }
        public static DataTable Listado_pv_ep(string ctexto)
        {
            D_Entrada_Productos Datos = new D_Entrada_Productos();
            return Datos.Listado_pv_ep(ctexto);
        }
        public static DataTable Listado_pr_ep(string ctexto)
        {
            D_Entrada_Productos Datos = new D_Entrada_Productos();
            return Datos.Listado_pr_ep(ctexto);
        }

    }
}
