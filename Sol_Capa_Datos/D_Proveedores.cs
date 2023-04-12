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
    public class D_Proveedores
    {
        public DataTable Listado_pv(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_pv", sqlcon);
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
        public String Guardar_pv(int nopcion, E_Proveedores oPv)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_pv", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nopcion", SqlDbType.Int).Value = nopcion;
                comando.Parameters.Add("@nCodigo_pv", SqlDbType.Int).Value = oPv.codigo_pv;
                comando.Parameters.Add("@nCodigo_tdpc", SqlDbType.Int).Value = oPv.codigo_pv;
                comando.Parameters.Add("@cNrodocumento", SqlDbType.VarChar).Value = oPv.NroDocumento_pv;
                comando.Parameters.Add("@cRazon_social_pv", SqlDbType.VarChar).Value = oPv.Razon_Social_pv;
                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = oPv.Nombre;
                comando.Parameters.Add("@cApellido", SqlDbType.VarChar).Value = oPv.Apellidos;
                comando.Parameters.Add("@nCodigo_sx", SqlDbType.Int).Value = oPv.codigo_sx;
                comando.Parameters.Add("@nCodigo_ru", SqlDbType.Int).Value = oPv.codigo_ru; 
                comando.Parameters.Add("@cEmail", SqlDbType.VarChar).Value = oPv.email_pv; 
                comando.Parameters.Add("@cTelefono", SqlDbType.VarChar).Value = oPv.telefono_pv; 
                comando.Parameters.Add("@cMovil", SqlDbType.VarChar).Value = oPv.movil_pv; 
                comando.Parameters.Add("@cDireccion", SqlDbType.Text).Value = oPv.direccion_pv; 
                comando.Parameters.Add("@nCodigo_di", SqlDbType.Int).Value = oPv.codigo_di; 
                comando.Parameters.Add("@cObservacion", SqlDbType.Text).Value = oPv.observaciones_pv; 
               
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

        public String Eliminar_pv(int codigo_pv)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_pv", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_pv", SqlDbType.Int).Value = codigo_pv;
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
        public DataTable Listado_tdpc_pv()
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
        public DataTable Listado_sx_pv()
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
        public DataTable Listado_ru_pv(string ctexto)
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
       

        public DataTable Listado_di_pv(string ctexto)
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
