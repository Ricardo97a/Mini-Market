using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Sol_Capa_Entidades;
using Sol_Capa_Negocio;
using Sol_Capa_Presentacion.Reporte;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.Web;
using System.Diagnostics;
using PdfSharp.Pdf;
using System.Drawing.Printing;

namespace Sol_Capa_Presentacion.Salidad_Productos
{
    public partial class Frm_Salida_Productos : Form
    {

        public Frm_Salida_Productos()
        {
           
            InitializeComponent();
        }
        #region "Variables"       
        int codigo_pv = 0;
        int codigo_tdpc = 0;
        int codigo_sp = 0;       
        int codigo_pr = 0;
        int codigo_cl = 0;
        int estadoGuarda = 0;
        DataTable TablaDetalle = new DataTable();
        string boleta = "Boleta-";
      
        int botones = 0;
        

        #endregion
        #region "Mis Metodos" 
        private void Formato_sp()
        {
            Dgv_Principal.Columns[0].Width = 150;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO SP";
            Dgv_Principal.Columns[1].Width = 250;
            Dgv_Principal.Columns[1].HeaderText = "TIPO DOCUMENTO";
            Dgv_Principal.Columns[2].Width = 200;
            Dgv_Principal.Columns[2].HeaderText = "NRO DOCUMENTO";
            Dgv_Principal.Columns[3].Width = 150;
            Dgv_Principal.Columns[3].HeaderText = "FECHA DOC";
            Dgv_Principal.Columns[4].Width = 230;
            Dgv_Principal.Columns[4].HeaderText = "NRO.DOC.CLI";
            Dgv_Principal.Columns[5].Width = 300;
            Dgv_Principal.Columns[5].HeaderText = "CLIENTE";
            Dgv_Principal.Columns[6].Width = 200;
            Dgv_Principal.Columns[6].HeaderText = "TOTAL IMPORTE";
            Dgv_Principal.Columns[7].Visible = false;
            Dgv_Principal.Columns[8].Visible = false;
            Dgv_Principal.Columns[9].Visible = false;
            Dgv_Principal.Columns[10].Visible = false;
            Dgv_Principal.Columns[11].Visible = false;
           
        }

        public void Listado_sp(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Salida_Productos.Listado_sp(ctexto);
                this.Formato_sp();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Estado_Botones_Principales(bool estado)
        {
            this.btnnuevo.Enabled = estado;
            this.btneliminar.Enabled = estado;
            this.btnreporte.Enabled = estado;
            this.btnsalir.Enabled = !estado;
         //   this.Crear_Tabla_Detalle();



        }
        private void Estado_Botones_Procesos(bool estado)
        {
            this.btnCancelar.Visible = estado;
            this.btnGuardar.Visible = estado;  
        }
        public void Botones(bool estado)
        {
            this.btnGuardar.Visible = !estado;
            this.btnCancelar.Visible = !estado;
            this.btn_agregar.Visible = !estado;
            this.btn_quitar.Visible = !estado;



        }

        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_sp"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_sp = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_sp"].Value);
                this.codigo_tdpc = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_tde"].Value);
                this.codigo_pv = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_cl"].Value);
                //this.codigo_al = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_al"].Value);
                txt_nrodocumento_sp.Text = Dgv_Principal.CurrentRow.Cells["nrodocumento_cl"].Value.ToString();
                txtDescripcion_tde.Text = Dgv_Principal.CurrentRow.Cells["descripcion"].Value.ToString();
                txtNro_Documento_sp.Text = Dgv_Principal.CurrentRow.Cells["nrodocumento_sp"].Value.ToString();
                dtp_fecha_sp.Value = Convert.ToDateTime(Dgv_Principal.CurrentRow.Cells["fecha_sp"].Value);             
                txt_razon_social_cl.Text = Dgv_Principal.CurrentRow.Cells["razon_social_cl"].Value.ToString();
                txtObservaciones.Text = Dgv_Principal.CurrentRow.Cells["observacion_sp"].Value.ToString();
                txtSubtotal.Text = Dgv_Principal.CurrentRow.Cells["subtotal"].Value.ToString();
                txtIva.Text = Dgv_Principal.CurrentRow.Cells["iva"].Value.ToString();
                txtTotal_importe.Text = Dgv_Principal.CurrentRow.Cells["total_importe"].Value.ToString();

                this.TablaDetalle.AcceptChanges();
                Dvg_Detalle.DataSource = N_Salida_Productos.Listado_detalle_sp(this.codigo_sp);
                this.Formato_Detalle();
            }

        }

        private void Formato_Detalle()
        {
            Dvg_Detalle.Columns[0].Width = 300;
            Dvg_Detalle.Columns[0].HeaderText = "PRODUCTO";
            Dvg_Detalle.Columns[1].Width = 200;
            Dvg_Detalle.Columns[1].HeaderText = "MARCA";
            Dvg_Detalle.Columns[2].Width = 150;
            Dvg_Detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dvg_Detalle.Columns[3].Width = 120;
            Dvg_Detalle.Columns[3].HeaderText = "CANTIDAD";
            Dvg_Detalle.Columns[4].Width = 150;
            Dvg_Detalle.Columns[4].HeaderText = "PU VENTA";
            Dvg_Detalle.Columns[5].Width = 300;
            Dvg_Detalle.Columns[5].HeaderText = "TOTAL";
            Dvg_Detalle.Columns[6].Visible = false;
            Dvg_Detalle.Columns[0].ReadOnly = true;
            Dvg_Detalle.Columns[1].ReadOnly = true;
            Dvg_Detalle.Columns[2].ReadOnly = true;
            Dvg_Detalle.Columns[3].ReadOnly = true;
            Dvg_Detalle.Columns[4].ReadOnly = true;
            Dvg_Detalle.Columns[5].ReadOnly = true;

        }       
        private void Crear_Tabla_Detalle()
        {
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("Descripcion_pr", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Descripcion_ma", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Descripcion_um", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Pu_venta", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Total", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Codigo_pr", System.Type.GetType("System.Int32"));

            Dvg_Detalle.DataSource = this.TablaDetalle;
            this.Formato_Detalle();
        }

        private void Agregar_Item(string cDescripcion_pr, string cDescripcion_ma, string cDescripcion_um,decimal nCantidad, decimal nPu_venta, decimal nTotal, int nCodigo_pr)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["Descripcion_pr"] = cDescripcion_pr;
            xFila["Descripcion_ma"] = cDescripcion_ma;
            xFila["Descripcion_um"] = cDescripcion_um;
            xFila["Cantidad"] = nCantidad;
            xFila["Pu_venta"] = nPu_venta;
            xFila["Total"] = nTotal;
            xFila["Codigo_pr"] = nCodigo_pr;
            this.TablaDetalle.Rows.Add(xFila);
            TablaDetalle.AcceptChanges();
        }
        /* Formato Tipo Documento*/

        private void Formato_tdpc_sp()
        {
            Dgv_Tdpc_ep.Columns[0].Width = 320;
            Dgv_Tdpc_ep.Columns[0].HeaderText = "Tipo Documento";
            Dgv_Tdpc_ep.Columns[1].Visible = false;
        }

        public void Listado_tdpc_sp(string ctexto)
        {
            try
            {
                Dgv_Tdpc_ep.DataSource = N_Salida_Productos.Listado_tde();
                this.Formato_tdpc_sp();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_tdpc_pv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Tdpc_ep.CurrentRow.Cells["codigo_tde"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                 this.codigo_tdpc = Convert.ToInt32(Dgv_Tdpc_ep.CurrentRow.Cells["codigo_tde"].Value);
                  txtDescripcion_tde.Text = Convert.ToString(Dgv_Tdpc_ep.CurrentRow.Cells["descripcion"].Value);
            }

        }


        /* Formato Listado Clientes*/


        private void Formato_cl_sp()
        {
            Dvg_Clientes_sp.Columns[0].Width = 320;
            Dvg_Clientes_sp.Columns[0].HeaderText = "CLIENTE";
            Dvg_Clientes_sp.Columns[1].Width = 300;
            Dvg_Clientes_sp.Columns[1].HeaderText = "TIPO DOC.";
            Dvg_Clientes_sp.Columns[2].Width = 300;
            Dvg_Clientes_sp.Columns[2].HeaderText = "NRO. DOC.";
            Dvg_Clientes_sp.Columns[3].Visible = false;
        }

        public void Listado_cl_sp(string ctexto)
        {
            try
            {
                Dvg_Clientes_sp.DataSource = N_Salida_Productos.Listado_cl_sp(ctexto);
                this.Formato_cl_sp();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_cl_sp()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dvg_Clientes_sp.CurrentRow.Cells["codigo_cl"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_cl = Convert.ToInt32(Dvg_Clientes_sp.CurrentRow.Cells["codigo_cl"].Value);
                txt_nrodocumento_sp.Text = Convert.ToString(Dvg_Clientes_sp.CurrentRow.Cells["nrodocumento_cl"].Value);
                txt_razon_social_cl.Text = Convert.ToString(Dvg_Clientes_sp.CurrentRow.Cells["razon_social_cl"].Value);
                if(this.codigo_cl==1) // Si el cliente es generico
                {
                    txt_razon_social_cl.ReadOnly = false;
                    txt_nrodocumento_sp.ReadOnly = false;
                }
                else
                { // Para los demas clientes
                    txt_razon_social_cl.ReadOnly = false;
                    txt_nrodocumento_sp.ReadOnly = false;
                }
            }

        }

        /* Formato Listado Productos*/


        private void Formato_pr_sp()
        {
            Dvg_Productos.Columns[0].Width = 300;
            Dvg_Productos.Columns[0].HeaderText = "PRODUCTO";
            Dvg_Productos.Columns[1].Width = 200;
            Dvg_Productos.Columns[1].HeaderText = "MARCA";
            Dvg_Productos.Columns[2].Width = 150;
            Dvg_Productos.Columns[2].HeaderText = "U. MEDIDA";
            Dvg_Productos.Columns[3].Width = 200;
            Dvg_Productos.Columns[3].HeaderText = "CATEGORIA";
            Dvg_Productos.Columns[4].Width = 100;
            Dvg_Productos.Columns[4].HeaderText = "STOCK ACTUAL";
            Dvg_Productos.Columns[5].Width = 200;
            Dvg_Productos.Columns[5].HeaderText = "PU_VENTA";
            Dvg_Productos.Columns[6].Visible = false;
        }

        public void Listado_pr_sp(string ctexto)
        {
            try
            {
                Dvg_Productos.DataSource = N_Salida_Productos.Listado_pr_sp(ctexto);
                this.Formato_pr_sp();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_pr_ep()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dvg_Productos.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string xDescripcion_pr;
                string xDescripcion_ma;
                string xDescripcion_um;
                decimal xCantidad;
                decimal xPu_venta;
                decimal xTotal;
                int xCodigo_pr;

                bool Agregar = true;

                xCodigo_pr = Convert.ToInt32(Dvg_Productos.CurrentRow.Cells["codigo_pr"].Value);
                foreach (DataRow FilaTemp in TablaDetalle.Rows)
                {
                    if( Convert.ToInt32(FilaTemp["codigo_pr"])== xCodigo_pr)
                    {
                        Agregar = false;
                        MessageBox.Show("El producto ya se encuentra agregado", "Aviso del Sistema");

                    }
                }
                if (Agregar==true)
                {   

                    xDescripcion_pr = Convert.ToString(Dvg_Productos.CurrentRow.Cells["descripcion_pr"].Value);
                    xDescripcion_ma = Convert.ToString(Dvg_Productos.CurrentRow.Cells["descripcion_ma"].Value);
                    xDescripcion_um = Convert.ToString(Dvg_Productos.CurrentRow.Cells["descripcion_um"].Value);
                    xCantidad = Convert.ToDecimal(0.00);
                    xPu_venta = Convert.ToDecimal(Dvg_Productos.CurrentRow.Cells["pu_venta"].Value);
                    xTotal = Convert.ToDecimal(0.00);


                    this.Agregar_Item(xDescripcion_pr, xDescripcion_ma, xDescripcion_um, xCantidad, xPu_venta, xTotal, xCodigo_pr);
                }
                
            }

        }
       
        private void Estado_texto(bool lestado)
        {
            btnLupaTipoDocumento_sp.Enabled = !lestado;           
            btnLupa_Cliente.Enabled = !lestado;          
            txtNro_Documento_sp.Enabled = !lestado;
            txtDescripcion_tde.Enabled = !lestado;
            txt_nrodocumento_sp.Enabled = !lestado;
            dtp_fecha_sp.Enabled = !lestado;     
            txtObservaciones.Enabled = !lestado;     
            txt_razon_social_cl.Enabled = !lestado;     
            
        }
        private void Limpiar_texto()
        {
            txtNro_Documento_sp.Text = "";
          
            txtObservaciones.Text = "";
            txtDescripcion_tde.Text = "";
        }
     
        private void Calcular_totales()
        {
            decimal nSubtotal = 0;
            decimal nIva = 0;
            decimal nTotal_importe = 0;

            if (Dvg_Detalle.Rows.Count == 0)
            {
                 nSubtotal = 0;
                 nIva = 0;
                 nTotal_importe = 0;
            }
            else
            {
                TablaDetalle.AcceptChanges();
                foreach(DataRow FilaTemporal in TablaDetalle.Rows)
                {
                    nTotal_importe = nTotal_importe + Convert.ToDecimal(FilaTemporal["total"]);
                   

                }
                nTotal_importe = decimal.Round(nTotal_importe, 2);

                nSubtotal = nTotal_importe / (1 + Convert.ToDecimal("0,13"));
                nIva = (nTotal_importe - nSubtotal);

                txtSubtotal.Text = decimal.Round(nSubtotal, 2).ToString("#0.00");
                txtIva.Text = decimal.Round(nIva,2).ToString("#0.00");
                txtTotal_importe.Text =decimal.Round(nTotal_importe,2).ToString("#0.00");
            }
        }

       
        public void AbrirPDFEnNavegador(string rutaArchivoPDF)
        {
            try
            {
                // Inicia el proceso del navegador predeterminado del usuario
                Process proceso = new Process();
                proceso.StartInfo.FileName = rutaArchivoPDF;
                proceso.StartInfo.UseShellExecute = true;

                // Abre el archivo PDF en una pestaña nueva del navegador
                proceso.StartInfo.Verb = "open";

                // Inicia el proceso y espera a que termine
                proceso.Start();
                proceso.WaitForExit();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir
                Console.WriteLine("Error al abrir el archivo PDF en el navegador: " + ex.Message);
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            //btnNuevo_pr
            botones = 2;
            this.estadoGuarda = 1;  
            this.Botones(false);
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);          
            this.Estado_texto(false);
            this.Crear_Tabla_Detalle();
            this.txtNro_Documento_sp.Focus();          
            Tb_Principal.SelectedIndex = 0;
            Dvg_Detalle.Columns[3].ReadOnly = false;
            Dvg_Detalle.Columns[4].ReadOnly = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_sp"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Estas seguro de anular el registro selecionado?", "Avisos del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    string respuesta = "";
                   this.codigo_sp = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_sp"].Value);
                   respuesta = N_Salida_Productos.Eliminar_sp(this.codigo_sp);
                    if (respuesta.Equals("ok"))
                    {
                         // this.Listado_sp("%");
                        MessageBox.Show("Registro anulado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.codigo_sp = 0;

                    }
                }


            }

        }             

        private void Tb_Principal_Selected(object sender, TabControlEventArgs e)
        {
            if (Tb_Principal.SelectedTab == Tb_Principal.TabPages[1])
            {
                this.Estado_Botones_Principales(false);
                //  this.Estado_texto(false);
            }

            else
            {
                this.Estado_Botones_Principales(true);
            }


            if (botones == 2)
            {
                this.Botones(false);
                this.Estado_texto(false);
               
            }
            else if (botones == 3)
            {
                this.Botones(true);
            }
            else
            {

                this.Botones(true);
                this.Estado_texto(true);
              
                this.btn_agregar.Visible = false;
                this.btn_quitar.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlListadoTdpc_sp.Location = btnLupaTipoDocumento_sp.Location;
            this.pnlListadoTdpc_sp.Visible = true;
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtDescripcion_tde.Text == string.Empty  ||
                txtNro_Documento_sp.Text == string.Empty ||              
                Dvg_Detalle.Rows.Count == 0              ||
                txt_razon_social_cl.Text == string.Empty) 

            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso de Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                string Rpta = "";
                E_Salida_Productos oSp = new E_Salida_Productos();
                oSp.codigo_sp = this.codigo_sp;
                oSp.codigo_tde = this.codigo_tdpc;
                oSp.nrodocumento_sp = txtNro_Documento_sp.Text.Trim();
                oSp.codigo_cl = this.codigo_cl;
                oSp.nrodocumento_cl = txt_nrodocumento_sp.Text.Trim();
                oSp.razon_social_cl = txt_razon_social_cl.Text.Trim();
                oSp.Fecha_sp = dtp_fecha_sp.Value;
                oSp.observacion = txtObservaciones.Text.Trim();
                oSp.subtotal = Convert.ToDecimal(txtSubtotal.Text.Trim());
                oSp.iva = Convert.ToDecimal(txtIva.Text.Trim());
                oSp.importe_total = Convert.ToDecimal(txtTotal_importe.Text.Trim());

                this.TablaDetalle.AcceptChanges();

                Rpta = N_Salida_Productos.Guardar_sp(oSp, TablaDetalle);
                if (Rpta != String.Empty)
                {
                    this.codigo_sp = Convert.ToInt32(Rpta);
                    //this.Listado_sp("%");
                    MessageBox.Show("Los datos han sido guardados correctamente # "+this.codigo_sp, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //REPORTE
                   Rpt_Imprime_Ticket rp_reporte = new Rpt_Imprime_Ticket();
 
                    //rp_reporte.SetParameterValue("@nCodigo_sp", this.codigo_sp);
                    


                    rp_reporte.DataSourceConnections[0].SetConnection("RAMIREZ97", "BD_Sistema_POO", "sistemas", "1");
                  
                    // rp_reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:\Users\ricar\Documents\Tuti\"+ boleta +txtNro_Documento_sp.Text+".pdf");

                    // string rutaArchivoPDF = @"C:\Users\ricar\Documents\Tuti\" + boleta + txtNro_Documento_sp.Text + ".pdf";
                    // ImprimirPDF(rutaArchivoPDF);

                     //string rutaArchivoPDF = @"C:\Users\ricar\Documents\Tuti\" + boleta + txtNro_Documento_sp.Text + ".pdf";
                     //AbrirPDFEnNavegador(rutaArchivoPDF);
                     
                    Frm_Rpt_Ticket reporte = new Frm_Rpt_Ticket();
                    reporte.Imprimir_report(codigo_sp);
                    // reporte.IdCodigo = codigo_sp;
                   
                     reporte.ShowDialog();
                    

                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.Estado_texto(false);
                    Dvg_Detalle.Columns[3].ReadOnly = true;
                    Tb_Principal.SelectedIndex = 0;
                    this.codigo_sp = 0;
                    this.estadoGuarda = 0;

                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Dgv_Principal_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            //this.Seleccionar_Item();
            //this.Agregar_Item();
            //this.Seleccionar_Item_pr_ep();
            this.Estado_Botones_Procesos(false);
            Tb_Principal.SelectedIndex = 0;


        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {


            this.estadoGuarda = 0;
            this.botones = 0;
            this.codigo_pv = 0;
            //  this.codigo_tdpc = 0;
            //   this.codigo_sx = 0;
            ///   this.codigo_ru = 0;
            //   this.codigo_di = 0;
            //   this.botones = 0;


            this.Estado_Botones_Principales(true);
            this.Limpiar_texto();
            Dvg_Detalle.Columns[3].ReadOnly = true;
            Dvg_Detalle.Columns[4].ReadOnly = true;
            this.Botones(false);
            

            this.Tb_Principal.SelectedIndex = 0;

        }

        private void btnretornar_Click_1(object sender, EventArgs e)
        {
            this.Tb_Principal.SelectedIndex = 0;
           
            /* this.codigo_pr = 0;*/
            this.botones = 0;

        }

        private void btn_retornar_Click(object sender, EventArgs e)
        {
            this.pnlListadoTdpc_sp.Visible = false;
        }


        private void Dgv_Tdpc_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_tdpc_pv();
            pnlListadoTdpc_sp.Visible = false;
          
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }



        

       
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.pnlListado_Productos_sp.Visible = true;
           this.pnlListado_Productos_sp.Location = txtDescripcion_tde.Location;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pnlListado_Productos_sp.Visible = false;
        }

        private void Dvg_Productos_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_pr_ep();
            this.pnlListado_Productos_sp.Visible = false;           

        }

        private void Dvg_Detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.estadoGuarda==1)
            {
                DataRow yFilas = (DataRow)TablaDetalle.Rows[e.RowIndex];
                decimal yCantidad = Convert.ToDecimal(yFilas["Cantidad"]);
                decimal yPu_venta = Convert.ToDecimal(yFilas["Pu_venta"]);
                yFilas["Total"] = decimal.Round(yCantidad * yPu_venta, 2).ToString("#0.00");

                this.Calcular_totales();
            }
          
        }

       

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (Dvg_Detalle.Rows.Count>0)
            {
                Dvg_Detalle.Rows.Remove(Dvg_Detalle.CurrentRow);
                Dvg_Detalle.Refresh();
                TablaDetalle.AcceptChanges();
                this.Calcular_totales();
            }
        }

        private void btnLupaTipoDocumento_sp_Click(object sender, EventArgs e)
        {
            this.pnlListadoTdpc_sp.Location = btnLupaTipoDocumento_sp.Location;
            this.pnlListadoTdpc_sp.Visible = true;
        }             

        private void btnLupa_clientes_sp_Click(object sender, EventArgs e)
        {
            this.pnlListado_clientes_sp.Location = btnLupaTipoDocumento_sp.Location;
            this.pnlListado_clientes_sp.Visible = true;
        }

        private void Dvg_Clientes_sp_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_cl_sp();
            this.pnlListado_clientes_sp.Visible = false;
        }

        private void Frm_Salida_Productos_Load(object sender, EventArgs e)
        {
            //this.Listado_sp("%");
            this.Listado_tdpc_sp("%");
            this.Listado_pr_sp("%");

            this.Listado_cl_sp("%");
            this.btnGuardar.Visible = false;
            this.btnCancelar.Visible = false;
         


            //tabPage2.Visible = false;
        }

        private void Dgv_Principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            Frm_Rpt_Salida_Productos reporte = new Frm_Rpt_Salida_Productos();
            reporte.ShowDialog();
        }

        private void btnRetornar2PO_Click(object sender, EventArgs e)
        {
            this.pnlListado_Productos_sp.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Listado_pr_sp(txtBuscar_Productos.Text);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.pnlListado_clientes_sp.Visible = false;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Listado_cl_sp(txtBuscar_Clientes.Text);
        }

        private void btnLupaTipoDocumento_sp_Click_1(object sender, EventArgs e)
        {
            this.pnlListadoTdpc_sp.Visible = true;
            this.pnlListadoTdpc_sp.Location = txtDescripcion_tde.Location;
        }

        private void btnLupa_Cliente_Click(object sender, EventArgs e)
        {
            this.pnlListado_clientes_sp.Visible = true;
            this.pnlListado_clientes_sp.Location = txtDescripcion_tde.Location;
        }

        private void btnLupa_provincia_Click(object sender, EventArgs e)
        {
            this.Listado_sp(txtBuscar_sp.Text);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.pnlListadoTdpc_sp.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}