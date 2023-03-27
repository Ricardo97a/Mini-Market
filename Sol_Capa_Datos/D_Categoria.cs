using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol_Capa_Entidades;

namespace Sol_Capa_Datos
{ 
   public class D_Categoria
    {
        public DataTable Listado_ca(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_ca_1", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ctexto", SqlDbType.VarChar).Value = ctexto;
                sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

        }
        public String Guardar_ca(int nopcion, E_Categoria oCA)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_ca",sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nopcion",SqlDbType.Int).Value= nopcion;
                comando.Parameters.Add("@nCodigo_ca", SqlDbType.Int).Value = oCA.codigo_ca;
                comando.Parameters.Add("@cdescripcion", SqlDbType.VarChar).Value = oCA.descripcion_ca;
                sqlcon.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "ok" : "No se pudo regitrar los datos";
            }
            catch (Exception ex)
            {

                respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return respuesta;
        }

        public String Eliminar_ca(int codigo_ca)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_ca", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;                
                comando.Parameters.Add("@nCodigo_ca", SqlDbType.Int).Value = codigo_ca;
                sqlcon.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "ok" : "No se pudo eliminar los datos";
            }
            catch (Exception ex)
            {

                respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return respuesta;
        }
    }
}

