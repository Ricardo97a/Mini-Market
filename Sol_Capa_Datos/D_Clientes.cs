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
    public class D_Clientes
    {
        public DataTable Listado_cl(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_cl", sqlcon);
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
        public String Guardar_cl(int nopcion, E_Clientes oCL)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_cl", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nopcion", SqlDbType.Int).Value = nopcion;
                comando.Parameters.Add("@nCodigo_cl", SqlDbType.Int).Value = oCL.codigo_cl;
                comando.Parameters.Add("@nCodigo_tdpc", SqlDbType.Int).Value = oCL.codigo_tdpc;
                comando.Parameters.Add("@cNrodocumento", SqlDbType.VarChar).Value = oCL.NroDocumento_cl;
                comando.Parameters.Add("@cRazon_social_cl", SqlDbType.VarChar).Value = oCL.Razon_Social_cl;
                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = oCL.Nombre;
                comando.Parameters.Add("@cApellido", SqlDbType.VarChar).Value = oCL.Apellidos;
                comando.Parameters.Add("@nCodigo_sx", SqlDbType.Int).Value = oCL.codigo_sx;
                comando.Parameters.Add("@nCodigo_ru", SqlDbType.Int).Value = oCL.codigo_ru; 
                comando.Parameters.Add("@cEmail", SqlDbType.VarChar).Value = oCL.email_cl; 
                comando.Parameters.Add("@cTelefono", SqlDbType.VarChar).Value = oCL.telefono_cl; 
                comando.Parameters.Add("@cMovil", SqlDbType.VarChar).Value = oCL.movil_cl; 
                comando.Parameters.Add("@cDireccion", SqlDbType.Text).Value = oCL.direccion_cl; 
                comando.Parameters.Add("@nCodigo_di", SqlDbType.Int).Value = oCL.codigo_di; 
                comando.Parameters.Add("@cObservacion", SqlDbType.Text).Value = oCL.observaciones_cl; 
               
                sqlcon.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "ok" : "No se pudo regitrar los datos";
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

        public String Eliminar_cl(int codigo_cl)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_cl", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_cl", SqlDbType.Int).Value = codigo_cl;
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

        /*Listar Tipos de documentos*/
        public DataTable Listado_tdpc_cl()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_tdpc_pv", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;               
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

        /*Listar Sexo*/
        public DataTable Listado_sx_cl()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_sx_pv", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;               
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
        /*Listar Rubros */
        public DataTable Listado_ru_cl(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_ru_pv", sqlcon);
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
       

        public DataTable Listado_di_cl(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_di_pv", sqlcon);
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
    } /*fin de clase*/
}
