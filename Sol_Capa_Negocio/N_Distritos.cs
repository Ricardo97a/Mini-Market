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
    public class N_Distritos
    {

        public static DataTable Listado_di(string ctexto)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Listado_di(ctexto);
        }

        public static string Guardar_di(int nopcion, E_Distritos oDI)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Guardar_di(nopcion, oDI);
        }
        public static string Eliminar_di(int codigo_di)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Eliminar_di(codigo_di);
        }
        public static DataTable Listado_PO_CO(string ctexto)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Listado_PO_CO(ctexto);
        }
        
    }
}
