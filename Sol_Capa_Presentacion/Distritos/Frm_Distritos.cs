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

namespace Sol_Capa_Presentacion.Distritos
{
    public partial class Frm_Distritos : Form
    {
        public Frm_Distritos()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_co = 0;
        int codigo_di = 0;
        int codigo_po = 0;
        int botones = 0;

        #endregion
        #region "Mis Metodos"
        private void Formato_di()
        {
            Dgv_Principal.Columns[0].Width = 100;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO_DI";
            Dgv_Principal.Columns[1].Width = 200;
            Dgv_Principal.Columns[1].HeaderText = "DISTRITOS";
            Dgv_Principal.Columns[2].Width = 200;
            Dgv_Principal.Columns[2].HeaderText = "CANTON";
            Dgv_Principal.Columns[3].Width = 200;
            Dgv_Principal.Columns[3].HeaderText = "PROVINCIA";
            Dgv_Principal.Columns[4].Visible = false;
        }

        public void Listado_di(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Distritos.Listado_di(ctexto);
                this.Formato_di();
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
            this.btnGuardar.Enabled = estado;
            this.btnCancelar.Enabled = estado;           
            this.txtDescripcion_di.Enabled = estado;
        }
        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_di"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_po = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_po"].Value);
                txtDescripcion_po.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_po"].Value);
                txtDescripcion_co.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_co"].Value);

                this.codigo_di = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_di"].Value);
                txtDescripcion_di.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_di"].Value);

               

               

            }

        }

        private void Formato_po_co()
        {
            Dgv_Provincias.Columns[0].Width = 200;
            Dgv_Provincias.Columns[0].HeaderText = "CANTON";
            Dgv_Provincias.Columns[1].Visible = false;
            Dgv_Provincias.Columns[2].Width = 200;
            Dgv_Provincias.Columns[2].HeaderText = "PROVINCIAS";
            Dgv_Provincias.Columns[3].Visible = false;
        }

        public void Listado_po_co(string ctexto)
        {
            try
            {
                Dgv_Provincias.DataSource = N_Distritos.Listado_PO_CO(ctexto);
                this.Formato_po_co();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Seleccionar_Item_po_co()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Provincias.CurrentRow.Cells["codigo_po"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_co = Convert.ToInt32(Dgv_Provincias.CurrentRow.Cells["codigo_co"].Value);
                txtDescripcion_co.Text = Convert.ToString(Dgv_Provincias.CurrentRow.Cells["descripcion_co"].Value);

                this.codigo_po = Convert.ToInt32(Dgv_Provincias.CurrentRow.Cells["codigo_po"].Value);
                txtDescripcion_po.Text = Convert.ToString(Dgv_Provincias.CurrentRow.Cells["descripcion_po"].Value);

            }

        }
        #endregion
        private void Frm_Cantones_Load(object sender, EventArgs e)
        {
           
           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtDistritos.Text== "Buscar Marcas:")
            {
                txtDistritos.Text = "";
                txtDistritos.ForeColor = Color.Black;

            }
        }

        private void txtMarcas_Leave(object sender, EventArgs e)
        {

            if (txtDistritos.Text == "")
            {
                txtDistritos.Text = "Buscar Marcas:";
                txtDistritos.ForeColor = Color.Black;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_di.Text == string.Empty || txtDescripcion_po.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)","Aviso de Sistemas",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                E_Distritos oDI = new E_Distritos();
                string respuesta = "";
                oDI.codigo_di = this.codigo_di;
                oDI.descripcion_di = txtDescripcion_di.Text.Trim();
                oDI.codigo_co = this.codigo_co;
              
                respuesta = N_Distritos.Guardar_di(estadoGuarda, oDI);
                if (respuesta=="ok")
                {
                    this.Listado_di("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtDescripcion_di.Text = "";
                    this.txtDescripcion_di.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0; 
                    this.codigo_di = 0;
                    this.botones = 0;
                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            botones = 2;
            estadoGuarda = 1;// nuevo registro
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            //txtDescripcion_ma.Text = "";
            this.txtDescripcion_ru.ReadOnly = false;            
            Tb_Principal.SelectedIndex = 1; */
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            estadoGuarda = 2;// actualizar registro

            this.botones = 3;
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Seleccionar_Item();
            this.txtDescripcion_di.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
            //txtDescripcion_ma.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoGuarda = 0; // sin ninguna accion
            this.botones = 0;
            this.codigo_po = 0;
            txtDescripcion_di.Text = "";
            this.txtDescripcion_di.ReadOnly = true;
            this.Estado_Botones_Principales(true);
            this.Estado_Botones_Procesos(false);
            this.Botones(false);
            this.Tb_Principal.SelectedIndex = 0;

            if (txtDescripcion_di.Text == "" || txtDescripcion_di.Text != null )
            {
                txtDescripcion_di.Text = "Marcas(*)";
                txtDescripcion_di.ForeColor = Color.Black;
          
            }
        }

        private void txtDescripcion_ma_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion_di.Text == "Marcas(*)")
            {
                txtDescripcion_di.Text = "";
                txtDescripcion_di.ForeColor = Color.Black;

            }
        }

        private void txtDescripcion_ma_Leave(object sender, EventArgs e)
        {

            if (txtDescripcion_di.Text == "")
            {
                txtDescripcion_di.Text = "Marcas(*)";
                txtDescripcion_di.ForeColor = Color.Black;

            }
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
            this.codigo_po = 0;
            this.botones = 0;
        }

        private void Tb_Principal_Click(object sender, EventArgs e)
        {
            //revisar
            if (txtDistritos.Text == "")
            {
                txtDistritos.Text = "Buscar Marcas:";
                txtDistritos.ForeColor = Color.Black;

            }else if (txtDescripcion_di.Text !=null)
            {
                txtDistritos.Text = "Buscar Marcas:";
                txtDistritos.ForeColor = Color.Black;
            }
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
                        this.Listado_di("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        this.codigo_co = 0;                        
                    }
                }               
              
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_di(txtDescripcion_di.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_di.Text == "")
            {
                txtDescripcion_di.Text = "Marcas(*)";
                txtDescripcion_di.ForeColor = Color.Black;

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_di.Text == "")
            {
                txtDescripcion_di.Text = "Marcas(*)";
                txtDescripcion_di.ForeColor = Color.Black;

            }
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
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {           
            botones = 2;
            estadoGuarda = 1;// nuevo registro
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            //txtDescripcion_ma.Text = "";
            this.txtDescripcion_po.Focus();
            this.txtDescripcion_po.ReadOnly = false;
            txtDescripcion_po.Focus();
            this.txtDescripcion_co.ReadOnly = false;
            this.txtDescripcion_di.ReadOnly = false;
           
            Tb_Principal.SelectedIndex = 1; 
        }

        private void btnLupaPO_Click(object sender, EventArgs e)
        {
            this.pnlListadoPO_CO.Visible = true;
            this.pnlListadoPO_CO.Location = btnLupa_po_co.Location;
        }

        private void btnRetornar2PO_Click(object sender, EventArgs e)
        {
            this.pnlListadoPO_CO.Visible = false;
        }

        private void Dgv_Provincias_DoubleClick(object sender, EventArgs e)
        {
            this.Seleccionar_Item_po_co();
            pnlListadoPO_CO.Visible = false;
            this.txtDescripcion_di.Focus();
        }

        private void btnLupa2PO_Click(object sender, EventArgs e)
        {
            this.Listado_po_co(txtBuscar2PO_CO.Text);
        }

       

        private void btnRetornar2PO_Click_1(object sender, EventArgs e)
        {
            this.pnlListadoPO_CO.Visible = false;
        }

        private void Dgv_Provincias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }         

        private void Frm_Distritos_Load(object sender, EventArgs e)
        {
            this.Listado_po_co("%");
            this.Listado_di("%");
        }
    }
}