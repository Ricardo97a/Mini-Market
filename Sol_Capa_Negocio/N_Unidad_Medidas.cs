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
    public  class N_Unidad_Medidas
    {

        public static DataTable Listado_um(string ctexto)
        {
            D_Unidad_Medidas Datos = new D_Unidad_Medidas();
            return Datos.Listado_um(ctexto);
        }

        public static string Guardar_um(int nopcion, E_Unidad_Medidas oUM)
        {
            D_Unidad_Medidas Datos = new D_Unidad_Medidas();
            return Datos.Guardar_um(nopcion, oUM);
        }
        public static string Eliminar_um(int codigo_UM)
        {
            D_Unidad_Medidas Datos = new D_Unidad_Medidas();
            return Datos.Eliminar_um(codigo_UM);
        }
    }
}
