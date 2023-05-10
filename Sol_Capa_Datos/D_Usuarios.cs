using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol_Capa_Datos;
using Sol_Capa_Entidades;

namespace Sol_Capa_Datos
{
    public class D_Usuario
    {
        public DataTable Listado_us(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_us", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = ctexto;
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
        public String Guardar_us(int nopcion, E_Usuarios oUS)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_us", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nopcion", SqlDbType.Int).Value = nopcion;
                comando.Parameters.Add("@nCodigo_us", SqlDbType.Int).Value = oUS.codigo_us;
                comando.Parameters.Add("@cLogin_us", SqlDbType.VarChar).Value = oUS.login_us;
                comando.Parameters.Add("@cPassword", SqlDbType.VarChar).Value = oUS.password;
                comando.Parameters.Add("@cNombre_us", SqlDbType.VarChar).Value = oUS.nombre_us;
                comando.Parameters.Add("@cCargo_us", SqlDbType.VarChar).Value = oUS.cargo_us;
                comando.Parameters.Add("@bAdmin", SqlDbType.Bit).Value = oUS.admin;
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

        public String Eliminar_us(int codigo_us)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_us", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_s", SqlDbType.Int).Value = codigo_us;
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
        public DataTable Login_us(string cLogin, string cPassword)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Login_us", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cLogin_us", SqlDbType.VarChar).Value = cLogin;
                Comando.Parameters.Add("@cPassword_us", SqlDbType.VarChar).Value = cPassword;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }
    }
}
