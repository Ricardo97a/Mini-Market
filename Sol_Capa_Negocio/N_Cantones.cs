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
    public class N_Cantones
    {

        public static DataTable Listado_co(string ctexto)
        {
            D_Cantones Datos = new D_Cantones();
            return Datos.Listado_co(ctexto);
        }

        public static string Guardar_co(int nopcion, E_Cantones oCO)
        {
            D_Cantones Datos = new D_Cantones();
            return Datos.Guardar_co(nopcion, oCO);
        }
        public static string Eliminar_co(int codigo_co)
        {
            D_Cantones Datos = new D_Cantones();
            return Datos.Eliminar_co(codigo_co);
        }
        public static DataTable Listado_PO_CO(string ctexto)
        {
            D_Cantones Datos = new D_Cantones();
            return Datos.Listado_PO_CO(ctexto);
        }
    }
}
