using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Capa_Datos
{
    class Conexion
    {

        private string basee;
        private string servidor;
        private string usuario;
        private string clave;
        private bool seguridad;
        private static Conexion con = null;


        private Conexion()
        {
            this.basee = "BD_Sistema_POO";
            this.servidor = "RAMIREZ97";
            this.usuario = "sistemas";
            this.clave = "1";
            this.seguridad = false;


        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "server=" + this.servidor + "; Database=" + this.basee + ";";
                if (seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.usuario + "; Password=" + this.clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();

            }
            return con;
        }
    }
}
