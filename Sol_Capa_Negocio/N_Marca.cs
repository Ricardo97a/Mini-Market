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
    public class N_Marca
    {

        public static DataTable Listado_ma(string ctexto)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Listado_ma(ctexto);
        }

        public static string Guardar_ma(int nopcion, E_Marcas oMA)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Guardar_ma(nopcion, oMA);
        }
        public static string Eliminar_ma(int codigo_ma)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Eliminar_ma(codigo_ma);
        }
    }
}
