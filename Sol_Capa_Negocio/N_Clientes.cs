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
    public class N_Clientes
    {

        public static DataTable Listado_cl(string ctexto)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_cl(ctexto);
        }

        public static string Guardar_cl(int nopcion, E_Clientes ocl)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Guardar_cl(nopcion, ocl);
        }
        public static string Eliminar_cl(int codigo_cl)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Eliminar_cl(codigo_cl);
        }

        public static DataTable Listado_tdpc_cl()
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_tdpc_cl();
        }
        public static DataTable Listado_sx_cl()
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_sx_cl();
        }
        public static DataTable Listado_ru_cl(string ctexto)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_ru_cl(ctexto);
        }
        public static DataTable Listado_di_cl(string ctexto)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_di_cl(ctexto);
        }

    }
}
