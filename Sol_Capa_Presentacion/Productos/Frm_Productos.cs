using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_Capa_Entidades;
using Sol_Capa_Negocio;

namespace Sol_Capa_Presentacion.Productos
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_pr = 0;
        int codigo_um = 0;
        int codigo_ca = 0;
        int codigo_ma = 0;
        int botones = 0;

        #endregion
        #region "Mis Metodos" 
        private void Formato_pr()
        {
            Dgv_Principal.Columns[0].Width = 130;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO";
            Dgv_Principal.Columns[1].Width = 350;
            Dgv_Principal.Columns[1].HeaderText = "PRODUCTO";
            Dgv_Principal.Columns[2].Width = 220;
            Dgv_Principal.Columns[2].HeaderText = "MARCA";
            Dgv_Principal.Columns[3].Width = 180;
            Dgv_Principal.Columns[3].HeaderText = "U.MEDIDA";
            Dgv_Principal.Columns[4].Width = 180;
            Dgv_Principal.Columns[4].HeaderText = "CATEGORIA";
            Dgv_Principal.Columns[5].Width = 180;
            Dgv_Principal.Columns[5].HeaderText = "STOCK MIN";
            Dgv_Principal.Columns[6].Width = 200;
            Dgv_Principal.Columns[6].HeaderText = "STOCK MAX";
            Dgv_Principal.Columns[7].Visible = false;
            Dgv_Principal.Columns[8].Visible = false;
            Dgv_Principal.Columns[9].Visible = false;
            Dgv_Principal.Columns[10].Visible = false;
        }

        public void Listado_pr(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Productos.Listado_pr(ctexto);
                this.Formato_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Estado_Botones_Principales(bool estado)
        {
            this.btnnuevo.Enabled = estado;
            this.btnactualizar.Enabled = estado;
            this.btneliminar.Enabled = estado;
            this.btnreporte.Enabled = estado;
           

        }
        private void Estado_Botones_Procesos(bool estado)
        {
            this.btnCancelar.Visible = estado;
            this.btnGuardar.Visible = estado;
            this.btnretornar.Visible = !estado;

        }
        public void Botones(bool estado)
        {
            this.btnGuardar.Enabled = estado;
            this.btnCancelar.Enabled = estado;
            this.btnLupaMarca.Visible = estado;
            this.btnLupaCategoria.Visible = estado;
            this.btnLupaMedida.Visible = estado;
            this.txtDescripcion_pr.Enabled = estado;
            this.txtDescripcion_ma.Enabled = estado;
            this.txtDescripcion_ca.Enabled = estado;
            this.txtDescripcion_um.Enabled = estado;
            this.txtStock_max.Enabled = estado;
            this.txtStock_min.Enabled = estado;
            this.txt_precio_pr.Enabled = estado;
            
        }
        public void LimpiarText()
        {
            this.txtDescripcion_pr.Text = "";
            this.txtDescripcion_ma.Text = "";
            this.txtDescripcion_ca.Text = "";
            this.txtDescripcion_um.Text = "";
            this.txtStock_max.Text = "";
            this.txtStock_min.Text = "";
            this.txt_precio_pr.Text = "";
        }
        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_pr = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_pr"].Value);               
                txtDescripcion_pr.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_pr"].Value);
                this.codigo_ma = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ma"].Value);
                txtDescripcion_ma.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_ma"].Value);
                this.codigo_um = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_um"].Value);
                txtDescripcion_ca.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_um"].Value);
                this.codigo_ca = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ca"].Value);
                txtDescripcion_um.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_ca"].Value);
                txtStock_min.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["stock_min"].Value);
                txtStock_max.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["stock_max"].Value);
                txt_precio_pr.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["pu_venta"].Value);

            }

        }

        /* Formato marcas*/

        private void Formato_ma_pr()
        {
            Dgv_Marca.Columns[0].Width = 300;
            Dgv_Marca.Columns[0].HeaderText = "MARCA";
            Dgv_Marca.Columns[1].Visible = false;
        }

        public void Listado_ma_pr(string ctexto)
        {
            try
            {
                Dgv_Marca.DataSource = N_Productos.Listado_ma_pr(ctexto);
                this.Formato_ma_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_ma_pr()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Marca.CurrentRow.Cells["codigo_ma"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_ma = Convert.ToInt32(Dgv_Marca.CurrentRow.Cells["codigo_ma"].Value);
                txtDescripcion_ma.Text = Convert.ToString(Dgv_Marca.CurrentRow.Cells["descripcion_ma"].Value);
            }

        }

        /* Formato Unidad de medida*/
     

        private void Formato_um_pr()
        {
            Dgv_Unidades.Columns[0].Width = 300;
            Dgv_Unidades.Columns[0].HeaderText = "Unidad de Medidas";
            Dgv_Unidades.Columns[1].Visible = false;
        }

        public void Listado_um_pr(string ctexto)
        {
            try
            {
                Dgv_Unidades.DataSource = N_Productos.Listado_um_pr(ctexto);
                this.Formato_um_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_um_pr()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Marca.CurrentRow.Cells["codigo_ma"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_um = Convert.ToInt32(Dgv_Unidades.CurrentRow.Cells["codigo_um"].Value);
                txtDescripcion_um.Text = Convert.ToString(Dgv_Unidades.CurrentRow.Cells["descripcion_um"].Value);
            }

        }
        /* Formato Unidad de Categorias*/


        private void Formato_ca_pr()
        {
            Dvg_Categorias.Columns[0].Width = 300;
            Dvg_Categorias.Columns[0].HeaderText = "CATEGORIA";
            Dvg_Categorias.Columns[1].Visible = false;
        }

        public void Listado_ca_pr(string ctexto)
        {
            try
            {
                Dvg_Categorias.DataSource = N_Productos.Listado_ca_pr(ctexto);
                this.Formato_ca_pr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_ca_pr()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dvg_Categorias.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_ca = Convert.ToInt32(Dvg_Categorias.CurrentRow.Cells["codigo_ca"].Value);
                txtDescripcion_ca.Text = Convert.ToString(Dvg_Categorias.CurrentRow.Cells["descripcion_ca"].Value);
            }

        }
        private void Formato_Stock_Actual()
        {
            Dvg_StockActual.Columns[0].Width = 250;
            Dvg_StockActual.Columns[0].HeaderText = "Almacen";
            Dvg_StockActual.Columns[1].Width = 200;
            Dvg_StockActual.Columns[1].HeaderText = "STOCK ACTUAL";
            Dvg_StockActual.Columns[2].Width = 200;
            Dvg_StockActual.Columns[2].HeaderText = "P.U COMPRA";

        }

        public void Listado_Stock_Actual(int nCodigo_pr)
        {
            try
            {
                Dvg_StockActual.DataSource = N_Productos.Ver_Stock_Actual(nCodigo_pr);
                this.Formato_Stock_Actual();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        #endregion
        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_pr("%");          
            this.Listado_ma_pr("%");
            this.Listado_um_pr("%");
            this.Listado_ca_pr("%");
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            //btnNuevo_pr
            botones = 2;
            estadoGuarda = 1;// nuevo registro
            this.gbxStockActual.Visible = false;
            this.Botones(false);
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);         
            this.txtStock_min.Text = "0";
            this.txtStock_max.Text = "0";
            this.txt_precio_pr.Text = "0";
            this.txtDescripcion_pr.ReadOnly = false;
            this.txtStock_min.ReadOnly = false;
            this.txtStock_max.ReadOnly = false;
           // this.txtDescripcion_ma.ReadOnly = false;
            this.txt_precio_pr.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            estadoGuarda = 2;// actualizar registro
            this.gbxStockActual.Visible = false;
            this.botones = 3;
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Seleccionar_Item();
            this.txtDescripcion_pr.ReadOnly = false;
            this.txtDescripcion_ma.ReadOnly = true;
            this.txtDescripcion_um.ReadOnly = true;
            this.txtDescripcion_ca.ReadOnly = true;
            txt_precio_pr.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
            txtDescripcion_pr.Focus();

        }            


        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_pr"].Value)))
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
                    this.codigo_pr = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_pr"].Value);
                    respuesta = N_Productos.Eliminar_pr(this.codigo_pr);
                    if (respuesta.Equals("ok"))
                    {
                        this.Listado_pr("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.codigo_pr = 0;

                    }
                }


            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         //   this.Listado_pr(txtBuscarProductos.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            this.Estado_Botones_Principales(false);
            if (txtDescripcion_ma.Text == "" || txtDescripcion_pr.Text == "")
            {
                txtDescripcion_pr.Text = "Abreviatura(*)";
                txtDescripcion_pr.ForeColor = Color.Black;
                txtDescripcion_ma.Text = "Unidad Medidas(*)";
                txtDescripcion_ma.ForeColor = Color.Black;
               // txtBuscarProductos.Text = "Buscar Unidas Medidas:";
//                txtBuscarProductos.ForeColor = Color.Black;


            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }      



        private void Tb_Principal_Selected(object sender, TabControlEventArgs e)
        {
            if (Tb_Principal.SelectedTab == Tb_Principal.TabPages[1])
            {
                this.Estado_Botones_Principales(false);
                this.btnsalir.Enabled = true;
            }
            else
            {
                this.Estado_Botones_Principales(true);
            }
            if (botones == 2)
            {
                this.Botones(true);
                this.btnretornar.Visible = false;
            }
            else if (botones == 3)
            {
                this.Botones(true);
            }
            else
            {

                this.Botones(false);
                this.btnGuardar.Visible = false;
                this.btnCancelar.Visible = false;
                this.btnretornar.Visible = true;
            }
        }

       

        private void Dgv_Marca_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_ma_pr();
            pnlListadoMarcas.Visible = false;
        }

        private void Dgv_Unidades_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar_Item_um_pr();
            pnlListadoMedida.Visible = false;
        }


        private void btnLupa2M_Click(object sender, EventArgs e)
        {
        //    this.Listado_ma_pr(txtBuscar2M.Text);
        }

        private void btnLupa2U_Click(object sender, EventArgs e)
        {
            this.Listado_um_pr(txtBuscar_medida.Text);
        }

        private void btnRetornar2M_Click(object sender, EventArgs e)
        {
            this.pnlListadoMarcas.Visible = false;
        }

        private void btnRetornar2U_Click(object sender, EventArgs e)
        {
            this.pnlListadoMedida.Visible = false;
        }

        private void btnRetornar2C_Click(object sender, EventArgs e)
        {
            this.pnlListadoCategoria.Visible = false;
        }              

        private void Dvg_Categorias_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar_Item_ca_pr();
            pnlListadoCategoria.Visible = false;
        }

        private void btnLupa2C_Click(object sender, EventArgs e)
        {
          //  this.Listado_ca_pr(txtBuscar2C.Text);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtDescripcion_pr.Text == string.Empty ||
                txtDescripcion_ma.Text == string.Empty ||
                txtDescripcion_ca.Text == string.Empty ||
                txtDescripcion_um.Text == string.Empty ||
                txt_precio_pr.Text ==string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso de Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                E_Productos oPR = new E_Productos();
                string respuesta = "";
                oPR.codigo_pr = this.codigo_pr;
                oPR.descripcion_pr = txtDescripcion_pr.Text.Trim();
                oPR.codigo_ma = this.codigo_ma;
                oPR.codigo_um = this.codigo_um;
                oPR.codigo_ca = this.codigo_ca;
                oPR.stock_min = Convert.ToDecimal(txtStock_min.Text);
                oPR.stock_max = Convert.ToDecimal(txtStock_max.Text);
                oPR.pu_venta = Convert.ToDecimal(txt_precio_pr.Text);
                respuesta = N_Productos.Guardar_pr(estadoGuarda, oPR);
                if (respuesta == "ok")
                {
                    this.Listado_pr("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtDescripcion_pr.Text = "";
                    this.txtStock_min.Text = "0";
                    this.txtStock_max.Text = "0";
                    this.txt_precio_pr.Text = "0";
                    this.txtDescripcion_ma.ReadOnly = true;
                    this.txtStock_min.ReadOnly = false;
                    this.txtStock_max.ReadOnly = false;
                    this.txt_precio_pr.ReadOnly = false;
                    this.txtDescripcion_pr.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0;
                    this.codigo_pr = 0;
                    this.botones = 0;
                    this.gbxStockActual.Visible = false;
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
            this.Listado_Stock_Actual(this.codigo_pr);
            this.gbxStockActual.Visible = true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.estadoGuarda = 0; // sin ninguna accion
            this.gbxStockActual.Visible = false;
            this.botones = 0;
            this.codigo_pr = 0;
            this.txtStock_min.Text = "0";
            this.txtStock_max.Text = "0";
            this.txtDescripcion_pr.ReadOnly = true;
            this.txtStock_min.ReadOnly = false;
            this.txtStock_max.ReadOnly = false;
            this.Estado_Botones_Principales(true);
            this.Botones(false);
            this.LimpiarText();
            this.Tb_Principal.SelectedIndex = 0;    
           
        }

        private void btnretornar_Click_1(object sender, EventArgs e)
        {
            this.Tb_Principal.SelectedIndex = 0;
            this.codigo_pr = 0;
            this.botones = 0;
            this.gbxStockActual.Visible = false;
            this.LimpiarText();
            this.Estado_Botones_Principales(true);
        }

        private void Tb_Principal_RightToLeftLayoutChanged(object sender, EventArgs e)
        {

        }
        /* Formato Stock Actual*/

    

        private void btnLupaMarca_Click(object sender, EventArgs e)
        {
            this.pnlListadoMarcas.Location = btnLupaMarca.Location;
            this.pnlListadoMarcas.Visible = true;
        }

        private void btnLupaMedida_Click(object sender, EventArgs e)
        {
            this.pnlListadoMedida.Location = btnLupaMarca.Location;
            this.pnlListadoMedida.Visible = true;
        }

        private void btnLupaCategoria_Click(object sender, EventArgs e)
        {
            this.pnlListadoCategoria.Location = btnLupaMarca.Location;
            this.pnlListadoCategoria.Visible = true;
        }

        private void btnLupa_Producto_Click(object sender, EventArgs e)
        {
            this.Listado_pr(txtBuscar_Producto.Text);
        }

        private void btnRetornar2PO_Click(object sender, EventArgs e)
        {
            this.pnlListadoMedida.Visible = false;
            this.txtBuscar_medida.Text = "Buscar";
        }

        private void btnLupa2PO_Click(object sender, EventArgs e)
        {
            this.Listado_um_pr(txtBuscar_medida.Text);
        }

        private void txtBuscar_medida_Click(object sender, EventArgs e)
        {
            this.txtBuscar_medida.Text = "";
        }

        private void btn_Buscar_Marcas_Click(object sender, EventArgs e)
        {
            this.Listado_ma_pr(txt_buscar_marca.Text);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.pnlListadoMarcas.Visible = false;
        }

        private void btn_buscar_Categoria_Click(object sender, EventArgs e)
        {
            this.Listado_ca_pr(txt_Buscar_Categoria.Text);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.pnlListadoCategoria.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}