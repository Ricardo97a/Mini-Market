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
    public  class N_Usuario
    {

        public static DataTable Listado_us(string ctexto)
        {
            D_Usuario Datos = new D_Usuario();
            return Datos.Listado_us(ctexto);
        }

        public static string Guardar_us(int nopcion, E_Usuarios oUS)
        {
            D_Usuario Datos = new D_Usuario();
            return Datos.Guardar_us(nopcion, oUS);
        }
        public static string Eliminar_us(int codigo_US)
        {
            D_Usuario Datos = new D_Usuario();
            return Datos.Eliminar_us(codigo_US);
        }
        public static DataTable Login_us(string cLogin, string cPassword)
        {
            D_Usuario Datos = new D_Usuario();
            return Datos.Login_us(cLogin, cPassword);
        }
    }
}
