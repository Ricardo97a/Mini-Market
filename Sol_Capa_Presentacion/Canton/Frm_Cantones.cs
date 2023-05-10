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

namespace Sol_Capa_Presentacion.Canto
{
    public partial class Frm_Cantones : Form
    {
        public Frm_Cantones()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_co = 0;
        int codigo_po = 0;
        int botones = 0;

        #endregion
        #region "Mis Metodos"
        private void Formato_co()
        {
            Dgv_Principal.Columns[0].Width = 200;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO CANTON";
            Dgv_Principal.Columns[1].Width = 300;
            Dgv_Principal.Columns[1].HeaderText = "Canton";
            Dgv_Principal.Columns[2].Width = 200;
            Dgv_Principal.Columns[2].HeaderText = "Provincias";
            Dgv_Principal.Columns[3].Visible = false;
        }

        public void Listado_co(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Cantones.Listado_co(ctexto);
                this.Formato_co();
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
          //  this.btnsalir.Enabled = !estado;
            
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
            this.btnLupa_provincia.Enabled = estado;           
            this.txtDescripcion_pr.Enabled = estado;
            this.txtDescripcion_co.Enabled = estado;
        }
        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_co"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_po = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_po"].Value);
                txtDescripcion_pr.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_po"].Value);

                this.codigo_co = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_co"].Value);
                txtDescripcion_co.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_co"].Value);

            }

        }

        private void Formato_po()
        {           
            Dgv_Provincias.Columns[0].Width = 300;
            Dgv_Provincias.Columns[0].HeaderText = "PROVINCIAS";
            Dgv_Provincias.Columns[1].Visible = false;
        }

        public void Listado_PO_CO(string ctexto)
        {
            try
            {
                Dgv_Provincias.DataSource = N_Cantones.Listado_PO_CO(ctexto);
                this.Formato_po();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_po()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Provincias.CurrentRow.Cells["codigo_po"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_po = Convert.ToInt32(Dgv_Provincias.CurrentRow.Cells["codigo_po"].Value);
                txtDescripcion_pr.Text = Convert.ToString(Dgv_Provincias.CurrentRow.Cells["descripcion_po"].Value);            

            }

        }
        #endregion       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_pr.Text == string.Empty || txtDescripcion_co.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)","Aviso de Sistemas",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                E_Cantones oCO = new E_Cantones();
                string respuesta = "";
                oCO.codigo_co = this.codigo_co;
                oCO.descripcion_co = txtDescripcion_co.Text.Trim();
                oCO.codigo_po = this.codigo_po;
                respuesta = N_Cantones.Guardar_co(estadoGuarda, oCO);
                if (respuesta=="ok")
                {
                    this.Listado_co("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtDescripcion_pr.Text = "";
                    this.txtDescripcion_pr.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0; 
                    this.codigo_co = 0;
                    this.botones = 0;
                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            estadoGuarda = 2;// actualizar registro

            this.botones = 3;
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Seleccionar_Item();
            this.txtDescripcion_pr.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
            //txtDescripcion_ma.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoGuarda = 0; // sin ninguna accion
            this.botones = 0;
            this.codigo_po = 0;
            txtDescripcion_pr.Text = "";
            txtDescripcion_co.Text = "";
            this.txtDescripcion_pr.ReadOnly = true;
            this.Estado_Botones_Principales(true);
            this.Estado_Botones_Procesos(false);
            this.Botones(false);
            this.Tb_Principal.SelectedIndex = 0;

         
        }

     
        private void Dgv_Principal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Seleccionar_Item();
            this.Estado_Botones_Procesos(false);
            Tb_Principal.SelectedIndex = 1;


        }

        private void btnretornar_Click(object sender, EventArgs e)
        {           
           this.Tb_Principal.SelectedIndex = 0;
            this.txtDescripcion_co.Text = "";
            this.txtDescripcion_pr.Text = "";
            this.codigo_po = 0;
            this.botones = 0;
        }

       

        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_co"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Estas seguro de eliminar el registro selecionado?","Avisos del Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (opcion==DialogResult.Yes)
                {
                    string respuesta = "";
                    this.codigo_co= Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_co"].Value);
                    respuesta = N_Cantones.Eliminar_co(this.codigo_co);
                    if (respuesta.Equals("ok"))
                    {
                        this.Listado_co("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        this.codigo_co = 0;                        
                    }
                }               
              
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
                this.btnretornar.Visible = true;
                this.btnCancelar.Visible =false;
                this.btnGuardar.Visible =false;
                
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {           
            botones = 2;
            estadoGuarda = 1;// nuevo registro
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            //txtDescripcion_ma.Text = "";
            this.txtDescripcion_pr.ReadOnly = false;            
            Tb_Principal.SelectedIndex = 1; 
        }


        private void Dgv_Provincias_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_po();
            pnlListadoProvincias.Visible = false;          
            txtBuscar2P.Text = "Buscar Provincias:";
            this.txtDescripcion_co.Focus();
        }

        private void btnLupa2PO_Click(object sender, EventArgs e)
        {
            this.Listado_PO_CO(txtBuscar2P.Text);
        }

        private void Frm_Cantones_Load_1(object sender, EventArgs e)
        {
            this.Listado_PO_CO("%");
            this.Listado_co("%");
        }            

        private void btnLupa_provincia_Click(object sender, EventArgs e)
        {
            this.pnlListadoProvincias.Visible = true;
            this.pnlListadoProvincias.Location = btnLupa_provincia.Location;
        }

        private void btnRetornar2PO_Click(object sender, EventArgs e)
        {
            this.pnlListadoProvincias.Visible = false;
            txtBuscar2P.Text = "Buscar Provincias:";
        }

        private void txtBuscar2P_Click(object sender, EventArgs e)
        {
            txtBuscar2P.Text = "";          

        }

        private void btnLupa2PO_Click_1(object sender, EventArgs e)
        {
            this.Listado_PO_CO(txtBuscar2P.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_co(txtBuscar_Canton.Text);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Listado_co(txtBuscar_Canton.Text);
        }

        private void txtBuscar_Canton_Enter(object sender, EventArgs e)
        {
            this.Listado_co(txtBuscar_Canton.Text);
        }
    }
}