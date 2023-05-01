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
    public class D_Entrada_Productos
    {
        public DataTable Listado_ep(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_ep", sqlcon);
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
        public DataTable Listado_detalle_ep(int nCodigo_ep)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_Detalle_ep", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_ep", SqlDbType.VarChar).Value = nCodigo_ep;
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
        public String Guardar_ep(E_Entrada_Productos oEp, DataTable dTabla)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_ep", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;               
                comando.Parameters.Add("@nCodigo_tde", SqlDbType.Int).Value = oEp.codigo_tde;               
                comando.Parameters.Add("@cNrodocumento_ep", SqlDbType.VarChar).Value = oEp.nrodocumento_ep;
                comando.Parameters.Add("@nCodigo_pv", SqlDbType.Int).Value = oEp.codigo_pv;
                comando.Parameters.Add("@fFecha_ep", SqlDbType.DateTime).Value = oEp.Fecha_ep;
                comando.Parameters.Add("@nCodigo_al", SqlDbType.Int).Value = oEp.codigo_al; 
                comando.Parameters.Add("@cObservacion_ep", SqlDbType.VarChar).Value = oEp.observacion;
                comando.Parameters.Add("@nSubtotal", SqlDbType.Decimal).Value = oEp.subtotal;
                comando.Parameters.Add("@nIva", SqlDbType.Decimal).Value = oEp.iva;
                comando.Parameters.Add("@nTotal_importe", SqlDbType.Decimal).Value = oEp.importe_total;
                comando.Parameters.Add("@tDetalle", SqlDbType.Structured).Value = dTabla;                 
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

        public String Eliminar_ep(int codigo_ep)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_ep", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_ep", SqlDbType.Int).Value = codigo_ep;
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

        /*Listar almacen*/
        public DataTable Listado_al_ep()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_al_ep", sqlcon);
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
        /*Listar proveedores */
        public DataTable Listado_pv_ep(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_pv_ep", sqlcon);
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
        public DataTable Listado_pr_ep(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_pr_ep", sqlcon);
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
