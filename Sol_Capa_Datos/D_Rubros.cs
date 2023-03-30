using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol_Capa_Entidades;
using Sol_Capa_Datos;

namespace Sol_Capa_Datos
{
    public class D_Rubros
    {
        public DataTable Listado_ru(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_ru", sqlcon);
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
        public String Guardar_ru(int nopcion,E_Rubros oRU)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_ru", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nopcion", SqlDbType.Int).Value = nopcion;
                comando.Parameters.Add("@nCodigo_ru", SqlDbType.Int).Value = oRU.codigo_ru;
                comando.Parameters.Add("@cdescripcion_ru", SqlDbType.VarChar).Value = oRU.descripcion_ru;
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

        public String Eliminar_ru(int codigo_ru)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_ru", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_ru", SqlDbType.Int).Value = codigo_ru;
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
