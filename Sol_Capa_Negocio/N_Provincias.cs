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
    public class N_Provincias
    {

        public static DataTable Listado_po(string ctexto)
        {
            D_Provincias Datos = new D_Provincias();
            return Datos.Listado_po(ctexto);
        }

        public static string Guardar_po(int nopcion, E_Provincias oPO)
        {
            D_Provincias Datos = new D_Provincias();
            return Datos.Guardar_po(nopcion, oPO);
        }
        public static string Eliminar_po(int codigo_po)
        {
            D_Provincias Datos = new D_Provincias();
            return Datos.Eliminar_po(codigo_po);
        }
    }
}
