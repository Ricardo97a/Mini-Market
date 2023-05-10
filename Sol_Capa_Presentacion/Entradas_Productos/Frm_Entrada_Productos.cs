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
        int codigo_pv = 0;
        int codigo_tde = 0;
        int codigo_ep = 0;
        int codigo_al = 0;
        int codigo_pr = 0;
        int estadoGuarda = 0;
        DataTable TablaDetalle = new DataTable();

        int botones = 0;

        #endregion
        #region "Mis Metodos" 
        private void Formato_ep()
        {
            Dgv_Principal.Columns[0].Width = 130;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO_EP";
            Dgv_Principal.Columns[1].Width = 230;
            Dgv_Principal.Columns[1].HeaderText = "TIPO DOCUMENTO";
            Dgv_Principal.Columns[2].Width = 190;
            Dgv_Principal.Columns[2].HeaderText = "NRO DOCUMENTO";
            Dgv_Principal.Columns[3].Width = 180;
            Dgv_Principal.Columns[3].HeaderText = "FECHA DOC";
            Dgv_Principal.Columns[4].Width = 250;
            Dgv_Principal.Columns[4].HeaderText = "PROVEEDOR";
            Dgv_Principal.Columns[5].Width = 250;
            Dgv_Principal.Columns[5].HeaderText = "ALMACEN";
            Dgv_Principal.Columns[6].Width = 250;
            Dgv_Principal.Columns[6].HeaderText = "TOTAL IMPORTE";
            Dgv_Principal.Columns[7].Visible = false;
            Dgv_Principal.Columns[8].Visible = false;
            Dgv_Principal.Columns[9].Visible = false;
            Dgv_Principal.Columns[10].Visible = false;
            Dgv_Principal.Columns[11].Visible = false;
            Dgv_Principal.Columns[12].Visible = false;
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
        //    this.btnsalir.Enabled = !estado;
         //   this.Crear_Tabla_Detalle();



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

               // this.TablaDetalle.AcceptChanges();
                Dvg_Detalle.DataSource = N_Entrada_Productos.Listado_detalle_ep(this.codigo_ep);
                this.Formato_Detalle();
            }

        }

        private void Formato_Detalle()
        {
            Dvg_Detalle.Columns[0].Width = 300;
            Dvg_Detalle.Columns[0].HeaderText = "PRODUCTO";
            Dvg_Detalle.Columns[1].Width = 250;
            Dvg_Detalle.Columns[1].HeaderText = "MARCA";
            Dvg_Detalle.Columns[2].Width = 130;
            Dvg_Detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dvg_Detalle.Columns[3].Width = 120;
            Dvg_Detalle.Columns[3].HeaderText = "CANTIDAD";
            Dvg_Detalle.Columns[4].Width = 140;
            Dvg_Detalle.Columns[4].HeaderText = "PU COMPRA";
            Dvg_Detalle.Columns[5].Width = 170;
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
            this.TablaDetalle.Columns.Add("Pu_compra", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Total", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Codigo_pr", System.Type.GetType("System.Int32"));

            Dvg_Detalle.DataSource = this.TablaDetalle;
            this.Formato_Detalle();
        }
            

        private void Agregar_Item(string cDescripcion_pr, string cDescripcion_ma, string cDescripcion_um,decimal nCantidad, decimal nPu_compra, decimal nTotal, int nCodigo_pr)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["Descripcion_pr"] = cDescripcion_pr;
            xFila["Descripcion_ma"] = cDescripcion_ma;
            xFila["Descripcion_um"] = cDescripcion_um;
            xFila["Cantidad"] = nCantidad;
            xFila["Pu_compra"] = nPu_compra;
            xFila["Total"] = nTotal;
            xFila["Codigo_pr"] = nCodigo_pr;
            this.TablaDetalle.Rows.Add(xFila);
            TablaDetalle.AcceptChanges();
        }
        /* Formato Tipo Documento*/

        private void Formato_tdpc_ep()
        {
            Dgv_Tdpc_ep.Columns[0].Width = 320;
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
            Dvg_Proveedor.Columns[0].Width = 320;
            Dvg_Proveedor.Columns[0].HeaderText = "PROVEEDOR";
            Dvg_Proveedor.Columns[1].Width = 300;
            Dvg_Proveedor.Columns[1].HeaderText = "TIPO DOC.";
            Dvg_Proveedor.Columns[2].Width = 300;
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

        /* Formato Listado Productos*/


        private void Formato_pr_ep()
        {
            Dvg_Productos.Columns[0].Width = 300;
            Dvg_Productos.Columns[0].HeaderText = "PRODUCTO";
            Dvg_Productos.Columns[1].Width = 300;
            Dvg_Productos.Columns[1].HeaderText = "MARCA";
            Dvg_Productos.Columns[2].Width = 130;
            Dvg_Productos.Columns[2].HeaderText = "U. MEDIDA";
            Dvg_Productos.Columns[3].Width = 300;
            Dvg_Productos.Columns[3].HeaderText = "CATEGORIA";
            Dvg_Productos.Columns[4].Visible = false;
        }

        public void Listado_pr_ep(string ctexto)
        {
            try
            {
                Dvg_Productos.DataSource = N_Entrada_Productos.Listado_pr_ep(ctexto);
                this.Formato_pr_ep();
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
                decimal xPu_Compra;
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
                    decimal prueba = Convert.ToDecimal(0.00);
                    xDescripcion_pr = Convert.ToString(Dvg_Productos.CurrentRow.Cells["descripcion_pr"].Value);
                    xDescripcion_ma = Convert.ToString(Dvg_Productos.CurrentRow.Cells["descripcion_ma"].Value);
                    xDescripcion_um = Convert.ToString(Dvg_Productos.CurrentRow.Cells["descripcion_um"].Value);
                    xCantidad = prueba;
                    xPu_Compra = prueba;
                    xTotal = prueba;


                    this.Agregar_Item(xDescripcion_pr, xDescripcion_ma, xDescripcion_um, xCantidad, xPu_Compra, xTotal, xCodigo_pr);
                }
                
            }

        }
        /* Formato Listado Almacen*/


        private void Formato_al_ep()
        {
            //  Dvg_Almacen.Columns[0].Width = 200;
            //Dvg_Almacen.Columns[0].HeaderText = "CODIGO_AL";
            Dvg_Almacen.Columns[0].Visible = false;
            Dvg_Almacen.Columns[1].Width = 360;
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
                this.codigo_al = Convert.ToInt32(Dvg_Almacen.CurrentRow.Cells["codigo_al"].Value);
                this.txtdescripcion_almacen.Text = Convert.ToString(Dvg_Almacen.CurrentRow.Cells["descripcion_al"].Value);

            }

        }

        private void Estado_texto(bool lestado)
        {
            txtNro_Documento_ep.Enabled = !lestado;
            txtrazon_social_pv.Enabled = !lestado;
            btnLupaTipoDocumento_ep.Enabled = !lestado;                    
            txtDescripcion_tde.Enabled = !lestado;
            txtdescripcion_almacen.Enabled = !lestado;
            txtObservaciones.Enabled = !lestado;
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
            txtdescripcion_almacen.Text = "";
            txtSubtotal.Text = "";
            txtIva.Text = "";
            txtTotal_importe.Text = "";         
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

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            //btnNuevo_pr
            botones = 2;
            this.estadoGuarda = 1;  
            this.Botones(true);
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
                     
            this.Estado_texto(false);
            this.Crear_Tabla_Detalle();

            this.txtNro_Documento_ep.Focus();          
            Tb_Principal.SelectedIndex = 1;
            Dvg_Detalle.Columns[3].ReadOnly = false;
            Dvg_Detalle.Columns[4].ReadOnly = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_ep"].Value)))
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
                    this.codigo_ep = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ep"].Value);
                    respuesta = N_Entrada_Productos.Eliminar_ep(this.codigo_ep);
                    if (respuesta.Equals("ok"))
                    {
                        //    this.Listado_pv("%");
                        MessageBox.Show("Registro anulado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.codigo_ep = 0;

                    }
                }


            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // this.Listado_pv(txtBuscarProductos.Text.Trim());
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
            if (txtDescripcion_tde.Text == string.Empty  ||
                txtNro_Documento_ep.Text == string.Empty ||
                txtrazon_social_pv.Text == string.Empty  ||
                Dvg_Detalle.Rows.Count == 0              ||
                txtdescripcion_almacen.Text == string.Empty) 

            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso de Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                E_Entrada_Productos oEP = new E_Entrada_Productos();
                string respuesta = "";
                oEP.codigo_ep = this.codigo_ep;
                oEP.codigo_tde = this.codigo_tde;
                oEP.nrodocumento_ep = txtNro_Documento_ep.Text.Trim();
                oEP.codigo_pv = this.codigo_pv;
                oEP.Fecha_ep = dtp_fecha_ep.Value;
                oEP.codigo_al = this.codigo_al;
                oEP.observacion = txtObservaciones.Text.Trim();
                oEP.subtotal = Convert.ToDecimal(txtSubtotal.Text.Trim());
                oEP.iva = Convert.ToDecimal(txtIva.Text.Trim());
                oEP.importe_total = Convert.ToDecimal(txtTotal_importe.Text.Trim());

                respuesta = N_Entrada_Productos.Guardar_ep( oEP, TablaDetalle);
                if (respuesta == "ok")
                {
                    this.Listado_ep("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtNro_Documento_ep.Text = "";

                    this.txtNro_Documento_ep.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0;                  
                     codigo_pv = 0;
                     codigo_tde = 0;
                     codigo_ep = 0;
                     codigo_al = 0;
                    this.estadoGuarda = 0;
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
            //this.Seleccionar_Item();
            //this.Agregar_Item();
            //this.Seleccionar_Item_pr_ep();
            this.Estado_Botones_Procesos(false);
            Tb_Principal.SelectedIndex = 1;


        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.estadoGuarda = 0;
            this.botones = 0;
            this.codigo_pr = 0;   
            this.Estado_Botones_Principales(true);
            this.Limpiar_texto();
            Dvg_Detalle.Columns[3].ReadOnly = true;
            Dvg_Detalle.Columns[4].ReadOnly = true;
            this.Botones(false);
           
            this.pnlListado_proveedor.Visible = false;
            this.pnlListadoTdpc_ep.Visible = false;
            this.pnlListado_almacen.Visible = false;
            this.pnlListado_Productos.Visible = false;
            this.Tb_Principal.SelectedIndex = 0;
          
        }

        private void btnretornar_Click_1(object sender, EventArgs e)
        {
            this.Tb_Principal.SelectedIndex = 0;
            this.Limpiar_texto();
            
            Dvg_Detalle.Columns.Clear();

            this.codigo_pr = 0;
            this.botones = 0;
        }       

        private void Dgv_Tdpc_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_tdpc_pv();
            pnlListadoTdpc_ep.Visible = false;
            lbl_tpde.Visible = true;
        }


        private void Frm_Entrada_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_ep("%");
            this.Listado_tdpc_ep("%");
            this.Listado_pr_ep("%");
            this.Listado_al_ep("%");
            this.Listado_pv_ep("%");
            tabPage2.Visible = false;
        }
        private void Dvg_Proveedor_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_pv_ep();
            txtBuscar_proveedor.Text = "Buscar Proveedor";
            this.pnlListado_proveedor.Visible = false;
        }

        private void Dvg_Almacen_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_al_ep();
            pnlListado_almacen.Visible = false;
        }

       
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.pnlListado_Productos.Visible = true;
            this.pnlListado_Productos.Location = txtDescripcion_tde.Location;
         
        }

      
        private void Dvg_Productos_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_pr_ep();
            txt_buscar_producto.Text = "Buscar Producto";
            this.pnlListado_Productos.Visible = false;

        }

        private void Dvg_Detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.estadoGuarda==1)
            {
                DataRow yFilas = (DataRow)TablaDetalle.Rows[e.RowIndex];
                decimal yCantidad = Convert.ToDecimal(yFilas["Cantidad"]);
                decimal yPu_compra = Convert.ToDecimal(yFilas["Pu_compra"]);
                yFilas["Total"] = decimal.Round(yCantidad * yPu_compra, 2).ToString("#0.00");

                this.Calcular_totales();
            }
          
        }

        private void Dvg_Detalle_DoubleClick(object sender, EventArgs e)
        {
           
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

        private void btnRetornar_list_pv_Click(object sender, EventArgs e)
        {
            this.pnlListado_proveedor.Visible = false;
            txtBuscar_proveedor.Text = "Buscar Proveedor";
        }

        private void txtBuscar_proveedor_Click(object sender, EventArgs e)
        {
            txtBuscar_proveedor.Text = "";
        }

        private void btn_retornar_list_tde_Click(object sender, EventArgs e)
        {
            this.pnlListadoTdpc_ep.Visible = false;
        }

        private void btnLupa2PO_Click(object sender, EventArgs e)
        {
            this.Listado_pr_ep(txt_buscar_producto.Text);
        }

        private void btn_Retornar_lista_pr_Click(object sender, EventArgs e)
        {
            this.pnlListado_Productos.Visible = false;
            txt_buscar_producto.Text = "Buscar Producto";
        }

        private void txt_buscar_producto_Click(object sender, EventArgs e)
        {
            txt_buscar_producto.Text = "";
        }

        private void btnLupaTipoDocumento_ep_Click_1(object sender, EventArgs e)
        {
            this.pnlListadoTdpc_ep.Visible = true;
            this.pnlListadoTdpc_ep.Location = btnLupaTipoDocumento_ep.Location;

        }

        private void btnLupa_Proveedor_Click_1(object sender, EventArgs e)
        {
            this.pnlListado_proveedor.Visible = true;
            this.pnlListado_proveedor.Location = txtDescripcion_tde.Location;
        }

        private void btnLupa_Almacen_Click_1(object sender, EventArgs e)
        {
            this.pnlListado_almacen.Visible = true;
            this.pnlListado_almacen.Location = btnLupaTipoDocumento_ep.Location;
        }

        private void btnRetornar2PO_Click(object sender, EventArgs e)
        {
            this.pnlListado_almacen.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}