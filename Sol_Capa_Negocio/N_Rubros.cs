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
    public class N_Rubros
    {

        public static DataTable Listado_ru(string ctexto)
        {
            D_Rubros Datos = new D_Rubros();
            return Datos.Listado_ru(ctexto);
        }

        public static string Guardar_ru(int nopcion, E_Rubros oRU)
        {
            D_Rubros Datos = new D_Rubros();
            return Datos.Guardar_ru(nopcion, oRU);
        }
        public static string Eliminar_ru(int codigo_ru)
        {
            D_Rubros Datos = new D_Rubros();
            return Datos.Eliminar_ru(codigo_ru);
        }
    }
}
