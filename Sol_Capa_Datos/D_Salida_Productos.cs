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
    public class D_Salida_Productos
    {
        public DataTable Listado_sp(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_sp", sqlcon);
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
        public DataTable Listado_detalle_sp(int nCodigo_sp)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_Detalle_sp", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_sp", SqlDbType.VarChar).Value = nCodigo_sp;
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
        public String Guardar_sp(E_Salida_Productos oSp, DataTable dTabla)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_sp", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;               
                comando.Parameters.Add("@nCodigo_tde", SqlDbType.Int).Value = oSp.codigo_tde;               
                comando.Parameters.Add("@cNrodocumento_sp", SqlDbType.VarChar).Value = oSp.nrodocumento_sp;
                comando.Parameters.Add("@nCodigo_cl", SqlDbType.Int).Value = oSp.codigo_cl;
                comando.Parameters.Add("@cNrodocumento_cl", SqlDbType.VarChar).Value = oSp.nrodocumento_cl;
                comando.Parameters.Add("@cRazon_Social_cl", SqlDbType.VarChar).Value = oSp.razon_social_cl;
                comando.Parameters.Add("@fFecha_sp", SqlDbType.DateTime).Value = oSp.Fecha_sp;
                comando.Parameters.Add("@cObservacion_sp", SqlDbType.VarChar).Value = oSp.observacion;
                comando.Parameters.Add("@nSubtotal", SqlDbType.Decimal).Value = oSp.subtotal;
                comando.Parameters.Add("@nIva", SqlDbType.Decimal).Value = oSp.iva;
                comando.Parameters.Add("@nTotal_importe", SqlDbType.Decimal).Value = oSp.importe_total;
                comando.Parameters.Add("@tDetalle", SqlDbType.Structured).Value = dTabla;

                SqlParameter Parametro_codigo = new SqlParameter();
                Parametro_codigo.ParameterName = "@nCodigo_sp";
                Parametro_codigo.SqlDbType = SqlDbType.Int;
                Parametro_codigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(Parametro_codigo);

                sqlcon.Open();
                 comando.ExecuteNonQuery();
                respuesta = Convert.ToString(Parametro_codigo.Value);

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

        public String Eliminar_sp(int codigo_sp)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_sp", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_sp", SqlDbType.Int).Value = codigo_sp;
                sqlcon.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "ok" : "No se pudo eliminar los datos";
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
        public DataTable Listado_tde()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_tde", sqlcon);
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

       
        /*Listar Clientes */
        public DataTable Listado_cl_sp(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_cl_sp", sqlcon);
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
        /*Listar Productos */
        public DataTable Listado_pr_sp(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_pr_sp", sqlcon);
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
