using Sol_Capa_Entidades;
using Sol_Capa_Negocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Sol_Capa_Presentacion.Entradas_Productos
{
    public partial class Frm_Entrada_Productos : Form
    {
        public Frm_Entrada_Productos()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_pv = 0;
        int codigo_tde = 0;
        int codigo_ep = 0;
        int codigo_al = 0;
        DataTable tabalaDetalle = new DataTable();
        
        int botones = 0;

        #endregion
        #region "Mis Metodos" 
        private void Formato_ep()
        {
            Dgv_Principal.Columns[0].Width = 90;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO_EP";
            Dgv_Principal.Columns[1].Width = 160;
            Dgv_Principal.Columns[1].HeaderText = "TIPO DOCUMENTO";
            Dgv_Principal.Columns[2].Width = 160;
            Dgv_Principal.Columns[2].HeaderText = "NRO DOCUMENTO";
            Dgv_Principal.Columns[4].Width = 110;
            Dgv_Principal.Columns[4].HeaderText = "FECHA DOC";
            Dgv_Principal.Columns[3].Width = 230;
            Dgv_Principal.Columns[3].HeaderText = "PROVEEDOR";
            Dgv_Principal.Columns[5].Width = 110;
            Dgv_Principal.Columns[5].HeaderText = "ALMACEN";
            Dgv_Principal.Columns[6].Width = 140;
            Dgv_Principal.Columns[6].HeaderText = "TOTAL IMPORTE";
            Dgv_Principal.Columns[7].Visible = false;
            Dgv_Principal.Columns[8].Visible = false;
            Dgv_Principal.Columns[9].Visible = false;
            Dgv_Principal.Columns[10].Visible = false;
            Dgv_Principal.Columns[11].Visible = false;
        }

        public void Listado_ep(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Entrada_Productos.Listado_ep(ctexto);
                this.Formato_ep();
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
            this.Crear_Tabla_Detalle();
          
            

        }
        private void Estado_Botones_Procesos(bool estado)
        {
            this.btnCancelar.Visible = estado;
            this.btnGuardar.Visible = estado;
            this.btnretornar.Visible = !estado;



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
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_ep"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {          
                this.codigo_ep = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ep"].Value);               
                this.codigo_tde = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_tde"].Value);
                this.codigo_pv = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_pv"].Value);
                this.codigo_al = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_al"].Value);
                txtDescripcion_tde.Text = Dgv_Principal.CurrentRow.Cells["descripcion"].Value.ToString();
                txtNro_Documento_ep.Text = Dgv_Principal.CurrentRow.Cells["nrodocumento"].Value.ToString();
                dtp_fecha_ep.Value = Convert.ToDateTime(Dgv_Principal.CurrentRow.Cells["fecha_ep"].Value);
                txtrazon_social_pv.Text = Dgv_Principal.CurrentRow.Cells["razon_social_pv"].Value.ToString();
                txtdescripcion_almacen.Text = Dgv_Principal.CurrentRow.Cells["descripcion_al"].Value.ToString();
                txtObservaciones.Text = Dgv_Principal.CurrentRow.Cells["observacion_ep"].Value.ToString();
                txtSubtotal.Text = Dgv_Principal.CurrentRow.Cells["subtotal"].Value.ToString();
                txtIva.Text = Dgv_Principal.CurrentRow.Cells["iva"].Value.ToString();
                txtTotal_importe.Text = Dgv_Principal.CurrentRow.Cells["total_importe"].Value.ToString();
                this.tabalaDetalle.AcceptChanges();
                Dvg_Detalle.DataSource = N_Entrada_Productos.Listado_detalle_ep(this.codigo_ep);
                this.Formato_Detalle();
            }

        }
        private void Formato_Detalle()
        {
            Dvg_Detalle.Columns[0].Width = 220;
            Dvg_Detalle.Columns[0].HeaderText = "PRODUCTOS";
            Dvg_Detalle.Columns[1].Width = 100;
            Dvg_Detalle.Columns[1].HeaderText = "MARCA";
            Dvg_Detalle.Columns[2].Width = 90;
            Dvg_Detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dvg_Detalle.Columns[3].Width = 90;
            Dvg_Detalle.Columns[3].HeaderText = "CANTIDAD";
            Dvg_Detalle.Columns[4].Width = 110;
            Dvg_Detalle.Columns[4].HeaderText = "PU COMPRA";
            Dvg_Detalle.Columns[5].Width = 90;
            Dvg_Detalle.Columns[5].HeaderText = "TOTAL";
            Dvg_Detalle.Columns[6].Visible = false;

        }
        private void Crear_Tabla_Detalle()
        {
            this.tabalaDetalle = new DataTable("TablaDetalle");
            this.tabalaDetalle.Columns.Add("Descripcion_pr", System.Type.GetType("System.String"));
            this.tabalaDetalle.Columns.Add("Descripcion_ma", System.Type.GetType("System.String"));
            this.tabalaDetalle.Columns.Add("Descripcion_um", System.Type.GetType("System.String"));
            this.tabalaDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"));
            this.tabalaDetalle.Columns.Add("Pu_compra", System.Type.GetType("System.Decimal"));
            this.tabalaDetalle.Columns.Add("Total", System.Type.GetType("System.Decimal"));
            this.tabalaDetalle.Columns.Add("Codigo_pr", System.Type.GetType("System.Int32"));

            Dvg_Detalle.DataSource = this.tabalaDetalle;
            this.Formato_Detalle();
        }

        /* Formato Tipo Documento*/

        private void Formato_tdpc_ep()
        {
            Dgv_Tdpc_ep.Columns[0].Width = 170;
            Dgv_Tdpc_ep.Columns[0].HeaderText = "Tipo Documento";
            Dgv_Tdpc_ep.Columns[1].Visible = false;
        }

        public void Listado_tdpc_ep(string ctexto)
        {
            try
            {
                Dgv_Tdpc_ep.DataSource = N_Proveedor.Listado_tdpc_pv();
                this.Formato_tdpc_ep();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_tdpc_pv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Tdpc_ep.CurrentRow.Cells["codigo_tdpc"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               // this.codigo_tdpc = Convert.ToInt32(Dgv_Tdpc_ep.CurrentRow.Cells["codigo_tdpc"].Value);
                txtDescripcion_tde.Text = Convert.ToString(Dgv_Tdpc_ep.CurrentRow.Cells["descripcion_tdpc"].Value);
            }

        }

       
        /* Formato Listado Proveedor*/


        private void Formato_pv_ep()
        {
            Dvg_Proveedor.Columns[0].Width = 250;
            Dvg_Proveedor.Columns[0].HeaderText = "PROVEEDOR";
            Dvg_Proveedor.Columns[1].Width = 250;
            Dvg_Proveedor.Columns[1].HeaderText = "TIPO DOC.";
            Dvg_Proveedor.Columns[2].Width = 250;
            Dvg_Proveedor.Columns[2].HeaderText = "NRO. DOC.";
            Dvg_Proveedor.Columns[3].Visible = false;
        }

        public void Listado_pv_ep(string ctexto)
        {
            try
            {
                Dvg_Proveedor.DataSource = N_Entrada_Productos.Listado_pv_ep(ctexto);
                this.Formato_pv_ep();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
                
        }
        private void Seleccionar_Item_pv_ep()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dvg_Proveedor.CurrentRow.Cells["codigo_pv"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_pv = Convert.ToInt32(Dvg_Proveedor.CurrentRow.Cells["codigo_pv"].Value);
                txtrazon_social_pv.Text = Convert.ToString(Dvg_Proveedor.CurrentRow.Cells["razon_social_pv"].Value);
        }
            
        }
        /* Formato Listado Almacen*/


        private void Formato_al_ep()
        {
          //  Dvg_Almacen.Columns[0].Width = 200;
            //Dvg_Almacen.Columns[0].HeaderText = "CODIGO_AL";
            Dvg_Almacen.Columns[0].Visible = false;
            Dvg_Almacen.Columns[1].Width = 220;
            Dvg_Almacen.Columns[1].HeaderText = "ALMACEN";
            Dvg_Almacen.Columns[2].Visible = false;
           
        }

        public void Listado_al_ep(string ctexto)
        {
            try
            {
                Dvg_Almacen.DataSource = N_Entrada_Productos.Listado_al_ep();
                this.Formato_al_ep();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_al_ep()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dvg_Almacen.CurrentRow.Cells["codigo_al"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               this.codigo_pv = Convert.ToInt32(Dvg_Almacen.CurrentRow.Cells["codigo_al"].Value);
               this.txtdescripcion_almacen.Text = Convert.ToString(Dvg_Almacen.CurrentRow.Cells["descripcion_al"].Value);
           
            }

        }

        private void Estado_texto(bool lestado)
        {
            txtNro_Documento_ep.Enabled = !lestado;
            txtrazon_social_pv.Enabled = !lestado;          
            btnLupaTipoDocumento_ep.Enabled = !lestado;
            lblfecha.Enabled = !lestado;
            lblobservaciones.Enabled = !lestado;
            txtDescripcion_tde.Enabled = !lestado;
            txtdescripcion_almacen.Enabled = !lestado;
            dtp_fecha_ep.Enabled = !lestado;
            btnLupa_Proveedor.Enabled = !lestado;
            btnLupa_Almacen.Enabled = !lestado;
            


        }
        private void Limpiar_texto()
        {
            txtNro_Documento_ep.Text = "";
            txtrazon_social_pv.Text = "";
           
            txtObservaciones.Text = "";
            txtDescripcion_tde.Text = "";            

        }
        private void Placeholder_texto()        {
            txtDescripcion_tde.Text = "Tipo doc (*)";           
            txtNro_Documento_ep.Text = "Nro.doc (*)";
            txtrazon_social_pv.Text = "Proveedor  (*)"; 
            txtdescripcion_almacen.Text = "Almacen (*)";
            txtObservaciones.Text = "";
          
        }

        #endregion
       
        private void button2_Click(object sender, EventArgs e)
        {
            //btnNuevo_pr
            botones = 2;          
          
            this.Botones(true);
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Placeholder_texto();
            this.Estado_texto(false);
            Tb_Principal.SelectedIndex = 1;
            this.txtNro_Documento_ep.Focus();
          
        }      

        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_pv"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Estas seguro de eliminar el registro selecionado?", "Avisos del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    string respuesta = "";
                    this.codigo_pv = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_pv"].Value);
                    respuesta = N_Proveedor.Eliminar_pv(this.codigo_pv);
                    if (respuesta.Equals("ok"))
                    {
                    //    this.Listado_pv("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.codigo_pv = 0;

                    }
                }


            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           // this.Listado_pv(txtBuscarProductos.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {         
           

            if (txtDescripcion_tde.Text == "" || txtNro_Documento_ep.Text == "")
            {
                txtNro_Documento_ep.Text = "Abreviatura(*)";
                txtNro_Documento_ep.ForeColor = Color.Black;
                txtDescripcion_tde.Text = "Unidad Medidas(*)";
                txtDescripcion_tde.ForeColor = Color.Black;
                txtBuscarProductos.Text = "Buscar Unidas Medidas:";
                txtBuscarProductos.ForeColor = Color.Black;


            }
        }

      
        private void tabPage1_Click(object sender, EventArgs e)
        {

            if (txtNro_Documento_ep.Text == "" || txtDescripcion_tde.Text == "")
            {
                txtNro_Documento_ep.Text = "Abreviatura(*)";
                txtNro_Documento_ep.ForeColor = Color.Black;
                txtDescripcion_tde.Text = "Unidad Medidas(*)";
                txtDescripcion_tde.ForeColor = Color.Black;

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
                this.btnretornar.Visible = false;
            }
            else if (botones == 3)
            {
                this.Botones(true);
            }            
            else
            {

                this.Botones(true);              
                this.Estado_texto(true);
                this.btnretornar.Visible = true;
                this.btn_agregar.Visible = false;
                this.btn_quitar.Visible = false;

            }
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlListadoTdpc_ep.Location = btnLupaTipoDocumento_ep.Location;
            this.pnlListadoTdpc_ep.Visible = true;
        }  

       
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNro_Documento_ep.Text == string.Empty ||
                txtDescripcion_tde.Text == string.Empty ||
                 
                   txtdescripcion_almacen.Text == string.Empty ||
                     txtrazon_social_pv.Text == string.Empty )
                   
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso de Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                E_Proveedores oPrv = new E_Proveedores();
                string respuesta = "";
                oPrv.codigo_pv = this.codigo_pv;
             //   oPrv.codigo_tdpc = this.codigo_tdpc;
                oPrv.NroDocumento_pv = txtNro_Documento_ep.Text.Trim();
                oPrv.Razon_Social_pv = txtrazon_social_pv.Text.Trim();
               
                oPrv.observaciones_pv = txtObservaciones.Text.Trim();

                respuesta = N_Proveedor.Guardar_pv(estadoGuarda, oPrv);
                if (respuesta == "ok")
                {
                   // this.Listado_pv("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtNro_Documento_ep.Text = "";
                   
                    this.txtNro_Documento_ep.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0;
                    this.codigo_pv = 0;
                  //  this.codigo_tdpc = 0;
                  //  this.codigo_sx = 0;
                  //  this.codigo_ru = 0;
                  //  this.codigo_di = 0;
                    this.botones = 0;
                   
                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void Dgv_Principal_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            this.Estado_Botones_Procesos(false);
            Tb_Principal.SelectedIndex = 1;
     
        
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

            this.estadoGuarda = 0; // sin ninguna accion
          
            this.botones = 0;
            this.codigo_pv = 0;
          //  this.codigo_tdpc = 0;
         //   this.codigo_sx = 0;
         ///   this.codigo_ru = 0;
         //   this.codigo_di = 0;
         //   this.botones = 0;


            this.Estado_Botones_Principales(true);
            this.Limpiar_texto();
            this.Botones(false);
            this.Placeholder_texto();

            this.Tb_Principal.SelectedIndex = 0;

            if (txtNro_Documento_ep.Text == string.Empty ||
                txtNro_Documento_ep.Text != null || 
                txtDescripcion_tde.Text == string.Empty || 
                txtDescripcion_tde.Text != null )
              
            {
                txtNro_Documento_ep.Text = "Producto (*)";
                txtNro_Documento_ep.ForeColor = Color.Black;
                txtDescripcion_tde.Text = "Marca (*)";
                txtDescripcion_tde.ForeColor = Color.Black;
              
            }
           
           
        }

        private void btnretornar_Click_1(object sender, EventArgs e)
        {
            this.Tb_Principal.SelectedIndex = 0;
             this.Placeholder_texto();
            /* this.codigo_pr = 0;*/
            this.botones = 0;
           
        }             
              
        private void btn_retornar_Click(object sender, EventArgs e)
        {
            this.pnlListadoTdpc_ep.Visible = false;
        }


        private void Dgv_Tdpc_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_tdpc_pv();
            pnlListadoTdpc_ep.Visible = false;
        }

     
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.pnlListado_almacen.Visible = false;
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            this.pnlListado_proveedor.Visible = false;
        }       

        private void btnLupaTipoDocumento_ep_Click(object sender, EventArgs e)
        {
            this.pnlListadoTdpc_ep.Visible = true;
            this.pnlListadoTdpc_ep.Location = btnLupaTipoDocumento_ep.Location;
        }

        private void Frm_Entrada_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_ep("%");
            this.Listado_tdpc_ep("%");
           // this.("%");

           this.Listado_al_ep("%");
            this.Listado_pv_ep("%");
            tabPage2.Visible = false;
        }

        private void btnLupa_Proveedor_Click(object sender, EventArgs e)
        {
            this.pnlListado_proveedor.Visible = true;
            this.pnlListado_proveedor.Location = btnLupaTipoDocumento_ep.Location;
        }

        private void Dvg_Proveedor_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_pv_ep();
            this.pnlListado_proveedor.Visible = false;
        }

        private void Dvg_Almacen_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_al_ep();
            pnlListado_almacen.Visible = false;
        }

        private void btnLupa2Proveedor_Click(object sender, EventArgs e)
        {
            this.Listado_pv_ep(txtBuscar_proveedor.Text);
        }

        private void btnLupa_Almacen_Click(object sender, EventArgs e)
        {
            this.pnlListado_almacen.Visible = true;
            this.pnlListado_almacen.Location = btnLupa_Almacen.Location;
        }
    }

}