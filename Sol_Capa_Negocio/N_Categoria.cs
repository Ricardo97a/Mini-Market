using Sol_Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_Capa_Entidades;
using Sol_Capa_Negocio;


namespace Sol_Capa_Negocio
{
    public class N_Categoria
    {
        public static DataTable Listado_ca(string ctexto)
        {
            D_Categoria Datos = new D_Categoria();
            return Datos.Listado_ca(ctexto);
        }

        public static string Guarcar_ca(int nopcion, E_Categoria oCA)
        {
            D_Categoria Datos = new D_Categoria();
            return  Datos.Guardar_ca(nopcion,oCA);
        }
        public static string Eliminar_ca(int codigo_ca)
        {
            D_Categoria Datos = new D_Categoria();
            return Datos.Eliminar_ca(codigo_ca);
        }
    }
}
