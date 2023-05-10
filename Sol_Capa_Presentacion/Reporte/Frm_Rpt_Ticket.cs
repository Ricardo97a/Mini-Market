using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_Capa_Datos;
namespace Sol_Capa_Presentacion.Reporte
{
    public partial class Frm_Rpt_Ticket : Form
    {
        //  public int IdCodigo { get; set; }
        // Conexion cnx = new Conexion();

        public Frm_Rpt_Ticket()
        {
            InitializeComponent();


        }
        #region

        public void Imprimir_report(int Codigo_sp)
        {

            //REPORTE
            Rpt_Imprime_Ticket rp_reporte = new Rpt_Imprime_Ticket();


            rp_reporte.DataSourceConnections[0].SetConnection("RAMIREZ97", "BD_Sistema_POO", "sistemas", "1");

            string connectionString = "Data Source=RAMIREZ97;Initial Catalog=BD_Sistema_POO;User id=sistemas; pwd=1;"
             + "Integrated Security=false;";

            // SqlConnection sqlcon = new SqlConnection();
            DataSet ds = new DataSet();
            // DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec USP_Imprimir_Venta_Generada ", connectionString);



            try
            {
                // Add table mappings.
                da.SelectCommand.Parameters.AddWithValue("@nCodigo_sp", Codigo_sp);
                da.Fill(ds, "reporte_venta");

                rp_reporte.FileName = AppDomain.CurrentDomain.BaseDirectory + "\\Rpt_Imprime_Ticket.rpt";
              //  rp_reporte.Load(AppDomain.CurrentDomain.BaseDirectory + "\\Rpt_Imprime_Ticket.rpt");
                rp_reporte.SetDataSource(ds.Tables["reporte_venta"]);
                //dt = ds.Tables["reporte_venta"];

                crv_etiqueta.ReportSource = rp_reporte;
                crv_etiqueta.Refresh();


                // Fill the

                //  rp_reporte.SetParameterValue("@nCodigo_sp", this.IdCodigo);
                // rp_reporte.Refresh();
            }
            catch (Exception)
            {

                throw;
            }




            // Add table mappings.
            // da.SelectCommand.Parameters.AddWithValue("@nCodigo_sp", IdCodigo);
            //  da.TableMappings.Add("Table", "SalesOrderHeader");
            //  rp_reporte.SetDataSource(ds.Tables["0"]);
            // Fill the

            //  rp_reporte.SetParameterValue("@nCodigo_sp", this.IdCodigo);
            //  rp_reporte.Refresh();
        }

        #endregion

        private void Frm_Rpt_Ticket_Load(object sender, EventArgs e)
        {
            /*
            //REPORTE
            Rpt_Imprime_Ticket rp_reporte = new Rpt_Imprime_Ticket();
            rp_reporte.DataSourceConnections[0].SetConnection("RAMIREZ97", "BD_Sistema_POO", "sistemas", "1");


            DataSet ds = new DataSet();

            string connectionString = "Data Source=RAMIREZ97;Initial Catalog=BD_Sistema_POO;User id=sistemas; pwd=1;"
                                      + "Integrated Security=false;";

            SqlDataAdapter da = new SqlDataAdapter(
                "exec USP_Imprimir_Venta_Generada ",
            connectionString);


            // Add table mappings.
            da.SelectCommand.Parameters.AddWithValue("@nCodigo_sp", IdCodigo);
            da.TableMappings.Add("Table", "SalesOrderHeader");
            rp_reporte.SetDataSource(ds.Tables["0"]);
            // Fill the

            rp_reporte.SetParameterValue("@nCodigo_sp", this.IdCodigo);
            rp_reporte.Refresh();*/
        }
    }
}
