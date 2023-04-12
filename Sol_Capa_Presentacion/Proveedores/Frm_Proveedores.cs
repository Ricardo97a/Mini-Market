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

namespace Sol_Capa_Presentacion.Proveedores
{
    public partial class Frm_Proveedores : Form
    {
        public Frm_Proveedores()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_pv = 0;
        int codigo_tdpc = 0;
        int codigo_sx = 0;
        int codigo_ru = 0;
        int codigo_di = 0;
    
      
        int botones = 0;

        #endregion
        #region "Mis Metodos" 
        private void Formato_pv()
        {
            Dgv_Principal.Columns[0].Width = 90;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO_PV";
            Dgv_Principal.Columns[1].Width = 160;
            Dgv_Principal.Columns[1].HeaderText = "TIPO DOCUMENTO";
            Dgv_Principal.Columns[2].Width = 160;
            Dgv_Principal.Columns[2].HeaderText = "NRO DOCUMENTO";
            Dgv_Principal.Columns[3].Width = 230;
            Dgv_Principal.Columns[3].HeaderText = "RAZON SOCIAL";
            Dgv_Principal.Columns[4].Width = 120;
            Dgv_Principal.Columns[4].HeaderText = "NOMBRE";
            Dgv_Principal.Columns[5].Width = 120;
            Dgv_Principal.Columns[5].HeaderText = "APELLIDO";
            Dgv_Principal.Columns[6].Width = 120;
            Dgv_Principal.Columns[6].HeaderText = "RUBRO";
            Dgv_Principal.Columns[7].Visible = false;
            Dgv_Principal.Columns[8].Visible = false;
            Dgv_Principal.Columns[9].Visible = false;
            Dgv_Principal.Columns[10].Visible = false;
            Dgv_Principal.Columns[11].Visible = false;
            Dgv_Principal.Columns[12].Visible = false;
            Dgv_Principal.Columns[13].Visible = false;
            Dgv_Principal.Columns[14].Visible = false;
            Dgv_Principal.Columns[15].Visible = false;
            Dgv_Principal.Columns[16].Visible = false;
            Dgv_Principal.Columns[17].Visible = false;
            Dgv_Principal.Columns[18].Visible = false;
            Dgv_Principal.Columns[19].Visible = false;
        }

        public void Listado_pv(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Proveedor.Listado_pv(ctexto);
                this.Formato_pv();
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
            this.btnsalir.Enabled = !estado;
          
            

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
           
           
        }

        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_pv"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String Distritos = "";
                this.codigo_pv = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_pv"].Value);               
                this.codigo_tdpc = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_tdpc"].Value);
                txtDescripcion_tdpc.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_tdpc"].Value);
                txtNro_Documento_pv.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["ndocumento_pv"].Value);
                txtrazon_social.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["razon_social_pv"].Value);
                txtNombre.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["nombres"].Value);
                txtApellido.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["apellidos"].Value);
                this.codigo_ru = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ru"].Value);
                txtdescripcion_rubro.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_ru"].Value);
                txtEmail.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["email_pv"].Value);
                txtTelefono.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["telefono_pv"].Value);
                txtmovil.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["movil_pv"].Value);
                this.codigo_sx = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_sx"].Value);
                txtdescripcion_sx.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion"].Value);
                txtDireccion.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["direccion_pv"].Value);
                this.codigo_di = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_di"].Value);
                Distritos = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_di"].Value).Trim() +" | "+
                           Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_co"].Value).Trim() +" | "+
                           Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_po"].Value).Trim();
                txtDistritos.Text = Distritos;
                txtObservaciones.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["observacion_pv"].Value);


            }

        }

        /* Formato Tipo Documento*/

        private void Formato_tdpc_pv()
        {
            Dgv_Tdpc.Columns[0].Width = 170;
            Dgv_Tdpc.Columns[0].HeaderText = "Tipo Documento";
            Dgv_Tdpc.Columns[1].Visible = false;
        }

        public void Listado_tdpc_pr(string ctexto)
        {
            try
            {
                Dgv_Tdpc.DataSource = N_Proveedor.Listado_tdpc_pv();
                this.Formato_tdpc_pv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_tdpc_pv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Tdpc.CurrentRow.Cells["codigo_tdpc"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_tdpc = Convert.ToInt32(Dgv_Tdpc.CurrentRow.Cells["codigo_tdpc"].Value);
                txtDescripcion_tdpc.Text = Convert.ToString(Dgv_Tdpc.CurrentRow.Cells["descripcion_tdpc"].Value);
            }

        }

        /* Formato Sexo*/
     

        private void Formato_sx_pv()
        {
            Dvg_Genero.Columns[0].Width = 180;
            Dvg_Genero.Columns[0].HeaderText = "Generos";
            Dvg_Genero.Columns[1].Visible = false;
        }

        public void Listado_sx_pv()
        {
            try
            {
                Dvg_Genero.DataSource = N_Proveedor.Listado_sx_pv();
                this.Formato_sx_pv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_sx_pv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dvg_Genero.CurrentRow.Cells["codigo_sx"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_sx = Convert.ToInt32(Dvg_Genero.CurrentRow.Cells["codigo_sx"].Value);
                txtdescripcion_sx.Text = Convert.ToString(Dvg_Genero.CurrentRow.Cells["descripcion"].Value);
            }

        }
        /* Formato Listado Rubros*/


        private void Formato_ru_pv()
        {   
            Dvg_Rubros.Columns[0].Width = 250;
            Dvg_Rubros.Columns[0].HeaderText = "Rubros";
            Dvg_Rubros.Columns[1].Visible = false;
        }

        public void Listado_ru_pv(string ctexto)
        {
            try
            {
                Dvg_Rubros.DataSource = N_Proveedor.Listado_ru_pv(ctexto);
                this.Formato_ru_pv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
                
        }
        private void Seleccionar_Item_ru_pv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dvg_Rubros.CurrentRow.Cells["codigo_ru"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_ru = Convert.ToInt32(Dvg_Rubros.CurrentRow.Cells["codigo_ru"].Value);
                txtdescripcion_rubro.Text = Convert.ToString(Dvg_Rubros.CurrentRow.Cells["descripcion_ru"].Value);
        }
            
        }
        /* Formato Listado Distritos*/


        private void Formato_di_pv()
        {
            Dvg_Distritos.Columns[0].Width = 200;
            Dvg_Distritos.Columns[0].HeaderText = "Distrito";
            Dvg_Distritos.Columns[1].Width = 200;
            Dvg_Distritos.Columns[1].HeaderText = "Canton";
            Dvg_Distritos.Columns[2].Width = 200;
            Dvg_Distritos.Columns[2].HeaderText = "Provincia";
            Dvg_Distritos.Columns[3].Visible = false;
        }

        public void Listado_di_pv(string ctexto)
        {
            try
            {
                Dvg_Distritos.DataSource = N_Proveedor.Listado_di_pv(ctexto);
                this.Formato_di_pv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_di_pv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dvg_Distritos.CurrentRow.Cells["codigo_di"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_di = Convert.ToInt32(Dvg_Distritos.CurrentRow.Cells["codigo_di"].Value);
                txtDistritos.Text = Convert.ToString(Dvg_Distritos.CurrentRow.Cells["descripcion_di"].Value) + " | " +
                                   Convert.ToString(Dvg_Distritos.CurrentRow.Cells["descripcion_co"].Value) + " | " +
                                    Convert.ToString(Dvg_Distritos.CurrentRow.Cells["descripcion_po"].Value);
                                  ;
            }

        }

        private void Estado_texto(bool lestado)
        {
            txtNro_Documento_pv.Enabled = !lestado;            
            txtrazon_social.Enabled = !lestado;
            txtNombre.Enabled = !lestado;
            txtApellido.Enabled = !lestado;
            txtEmail.Enabled = !lestado;
            txtTelefono.Enabled = !lestado;
            txtmovil.Enabled = !lestado;
            txtDireccion.Enabled = !lestado;
            txtObservaciones.Enabled = !lestado;
            txtdescripcion_sx.Enabled = !lestado;
            txtdescripcion_rubro.Enabled = !lestado;
            txtDistritos.Enabled = !lestado;
            txtDireccion.Enabled = !lestado;
            txtObservaciones.Enabled = !lestado;
            txtDescripcion_tdpc.Enabled = !lestado;
            btnLupaSexo.Enabled = !lestado;
            btnLupaRubro.Enabled = !lestado;
            btnLupaDistrito.Enabled = !lestado;
            btnLupaTipoDocumento.Enabled = !lestado;
            lblobservaciones.Enabled = !lestado;

        }
        private void Limpiar_texto()
        {
            txtNro_Documento_pv.Text = "";
            txtrazon_social.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtmovil.Text = "";
            txtDireccion.Text = "";
            txtObservaciones.Text = "";
            txtdescripcion_sx.Text = "";
            txtdescripcion_rubro.Text = "";
            txtDistritos.Text = "";
            txtDireccion.Text = "";
            txtObservaciones.Text = "";
            txtDescripcion_tdpc.Text = "";            

        }
        private void Placeholder_texto()
        {
            txtDescripcion_tdpc.Text = "Tipo doc (*)";           
            txtNro_Documento_pv.Text = "Nro.doc (*)";
            txtrazon_social.Text = "Razon Social (*)";
            txtNombre.Text = "Nombre (*)";
            txtApellido.Text = "Apellido (*)";
            txtdescripcion_sx.Text = "Genero (*)";
            txtdescripcion_rubro.Text = "Rubro (*)";
            txtEmail.Text = "Email (*)";
            txtTelefono.Text = "# Telefono (*)";
            txtmovil.Text = "# Movil (*)";
            txtDistritos.Text = "Distrito /Canton /Provincia (*)";   
            txtDireccion.Text = "Direccion (*)";
            txtObservaciones.Text = "";
          

        }

        #endregion
        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            this.Listado_pv("%");          
            this.Listado_tdpc_pr("%");
            this.Listado_sx_pv();
            this.Listado_ru_pv("%");
            this.Listado_di_pv("%");
            tabPage2.Visible = false;
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            //btnNuevo_pr
            botones = 2;
            estadoGuarda = 1;// nuevo registro
          
            this.Botones(true);
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Placeholder_texto();
            this.Estado_texto(false);
            Tb_Principal.SelectedIndex = 1;
            this.txtNro_Documento_pv.Focus();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            estadoGuarda = 2;// actualizar registro
          
            this.botones = 2;
            this.Seleccionar_Item();         
           

            Tb_Principal.SelectedIndex = 1;
            txtNro_Documento_pv.Focus();

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
                        this.Listado_pv("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.codigo_pv = 0;

                    }
                }


            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_pv(txtBuscarProductos.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {         
           

            if (txtDescripcion_tdpc.Text == "" || txtNro_Documento_pv.Text == "")
            {
                txtNro_Documento_pv.Text = "Abreviatura(*)";
                txtNro_Documento_pv.ForeColor = Color.Black;
                txtDescripcion_tdpc.Text = "Unidad Medidas(*)";
                txtDescripcion_tdpc.ForeColor = Color.Black;
                txtBuscarProductos.Text = "Buscar Unidas Medidas:";
                txtBuscarProductos.ForeColor = Color.Black;


            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void tabPage1_Click(object sender, EventArgs e)
        {

            if (txtNro_Documento_pv.Text == "" || txtDescripcion_tdpc.Text == "")
            {
                txtNro_Documento_pv.Text = "Abreviatura(*)";
                txtNro_Documento_pv.ForeColor = Color.Black;
                txtDescripcion_tdpc.Text = "Unidad Medidas(*)";
                txtDescripcion_tdpc.ForeColor = Color.Black;

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
            }
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlListadoTdpc.Location = btnLupaTipoDocumento.Location;
            this.pnlListadoTdpc.Visible = true;
        }  

       
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNro_Documento_pv.Text == string.Empty ||
                txtDescripcion_tdpc.Text == string.Empty ||
                 txtdescripcion_sx.Text == string.Empty ||
                   txtdescripcion_rubro.Text == string.Empty ||
                     txtrazon_social.Text == string.Empty ||
                       txtDistritos.Text == string.Empty ||
                         txtDireccion.Text == string.Empty ||
                txtEmail.Text == string.Empty ||
                txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso de Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                E_Proveedores oPrv = new E_Proveedores();
                string respuesta = "";
                oPrv.codigo_pv = this.codigo_pv;
                oPrv.codigo_tdpc = this.codigo_tdpc;
                oPrv.NroDocumento_pv = txtNro_Documento_pv.Text.Trim();
                oPrv.Razon_Social_pv = txtrazon_social.Text.Trim();
                oPrv.Nombre = txtNombre.Text.Trim();
                oPrv.Apellidos = txtApellido.Text.Trim();
                oPrv.codigo_sx = this.codigo_sx;
                oPrv.codigo_ru = this.codigo_ru;
                oPrv.email_pv = txtEmail.Text.Trim();
                oPrv.telefono_pv = txtTelefono.Text.Trim();
                oPrv.movil_pv = txtmovil.Text.Trim();
                oPrv.direccion_pv = txtDireccion.Text.Trim();
                oPrv.codigo_di = this.codigo_di;
                oPrv.observaciones_pv = txtObservaciones.Text.Trim();

                respuesta = N_Proveedor.Guardar_pv(estadoGuarda, oPrv);
                if (respuesta == "ok")
                {
                    this.Listado_pv("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtNro_Documento_pv.Text = "";
                   
                    this.txtNro_Documento_pv.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0;
                    this.codigo_pv = 0;
                    this.codigo_tdpc = 0;
                    this.codigo_sx = 0;
                    this.codigo_ru = 0;
                    this.codigo_di = 0;
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
            this.codigo_tdpc = 0;
            this.codigo_sx = 0;
            this.codigo_ru = 0;
            this.codigo_di = 0;
            this.botones = 0;


            this.Estado_Botones_Principales(true);
            this.Limpiar_texto();
            this.Botones(false);
            this.Placeholder_texto();

            this.Tb_Principal.SelectedIndex = 0;

            if (txtNro_Documento_pv.Text == string.Empty ||
                txtNro_Documento_pv.Text != null || 
                txtDescripcion_tdpc.Text == string.Empty || 
                txtDescripcion_tdpc.Text != null ||
                txtEmail.Text == string.Empty ||
                txtEmail.Text != null  ||
                txtTelefono.Text == string.Empty ||
                txtTelefono.Text != null )
            {
                txtNro_Documento_pv.Text = "Producto (*)";
                txtNro_Documento_pv.ForeColor = Color.Black;
                txtDescripcion_tdpc.Text = "Marca (*)";
                txtDescripcion_tdpc.ForeColor = Color.Black;
                txtEmail.Text = "Medida (*)";
                txtEmail.ForeColor = Color.Black;
                txtTelefono.Text = "Categoria (*)";
                txtTelefono.ForeColor = Color.Black;

            }
           
           
        }

        private void btnretornar_Click_1(object sender, EventArgs e)
        {
            this.Tb_Principal.SelectedIndex = 0;
             this.Placeholder_texto();
            /* this.codigo_pr = 0;*/
            this.botones = 0;
           
        }

        private void Tb_Principal_RightToLeftLayoutChanged(object sender, EventArgs e)
        {

        }
              

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_retornar_Click(object sender, EventArgs e)
        {
            this.pnlListadoTdpc.Visible = false;
        }

        private void btnLupaSexo_Click(object sender, EventArgs e)
        {
            this.pnlGenero.Location = btnLupaSexo.Location;
            this.pnlGenero.Visible = true;
        }

        private void btn_retornarG_Click(object sender, EventArgs e)
        {
            this.pnlListadoRubros.Visible = false;
        }

        private void Dvg_Genero_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_sx_pv();
            this.pnlGenero.Visible = false;
        }

        private void Dgv_Tdpc_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_tdpc_pv();
            pnlListadoTdpc.Visible = false;
        }

        private void btnLupaRubro_Click(object sender, EventArgs e)
        {
            this.pnlListadoRubros.Location = btnLupaRubro.Location;
            this.pnlListadoRubros.Visible = true; 
        }

        private void Dvg_Rubros_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_ru_pv();
            pnlListadoRubros.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Listado_ru_pv(txtBuscar_rubros.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.pnlListadoRubros.Visible = false;
        }

        private void btnLupaDistrito_Click(object sender, EventArgs e)
        {
            this.pnlListadoDistritos.Visible = true;
            this.pnlListadoDistritos.Location = btnLupaTipoDocumento.Location;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pnlListadoDistritos.Visible = false;
        }

        private void Dvg_Distritos_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_di_pv();
            this.pnlListadoDistritos.Visible = false;
        }

        private void btnLupa2di_Click(object sender, EventArgs e)
        {
            this.Listado_di_pv(txtBuscar_Distritos.Text);
        }
    }

}