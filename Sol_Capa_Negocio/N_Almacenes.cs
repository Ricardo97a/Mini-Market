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
   public  class N_Almacenes
    {

        public static DataTable Listado_al(string ctexto)
        {
            D_Almacenes Datos = new D_Almacenes();
            return Datos.Listado_al(ctexto);
        }

        public static string Guardar_al(int nopcion, E_Almacenes oAL)
        {
            D_Almacenes Datos = new D_Almacenes();
            return Datos.Guardar_al(nopcion, oAL);
        }
        public static string Eliminar_al(int codigo_al)
        {
            D_Almacenes Datos = new D_Almacenes();
            return Datos.Eliminar_al(codigo_al);
        }
    }
}
