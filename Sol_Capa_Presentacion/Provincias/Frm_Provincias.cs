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

namespace Sol_Capa_Presentacion.Provincias
{
    public partial class Frm_Provincias : Form
    {
        public Frm_Provincias()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_po = 0;
        int botones = 0;

        #endregion
        #region "Mis Metodos"
        private void Formato_po()
        {
            Dgv_Principal.Columns[0].Width = 100;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO_PO";
            Dgv_Principal.Columns[1].Width = 200;
            Dgv_Principal.Columns[1].HeaderText = "PROVINCIAS";
        }

        public void Listado_po(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Provincias.Listado_po(ctexto);
                this.Formato_po();
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
            this.txtDescripcion_po.Enabled = estado;
        }
        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_po"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_po = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_po"].Value);
                txtDescripcion_po.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_po"].Value);
            }

        }

        #endregion
        private void Frm_Provincias_Load(object sender, EventArgs e)
        {
            this.Listado_po("%");          
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtProvincias.Text== "Buscar Marcas:")
            {
                txtProvincias.Text = "";
                txtProvincias.ForeColor = Color.Black;

            }
        }

        private void txtMarcas_Leave(object sender, EventArgs e)
        {

            if (txtProvincias.Text == "")
            {
                txtProvincias.Text = "Buscar Marcas:";
                txtProvincias.ForeColor = Color.Black;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_po.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)","Aviso de Sistemas",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                E_Provincias oPO = new E_Provincias();
                string respuesta = "";
                oPO.codigo_po = this.codigo_po;
                oPO.descripcion_po = txtDescripcion_po.Text.Trim();
                respuesta = N_Provincias.Guardar_po(estadoGuarda, oPO);
                if (respuesta=="ok")
                {
                    this.Listado_po("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtDescripcion_po.Text = "";
                    this.txtDescripcion_po.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0; 
                    this.codigo_po = 0;
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
            this.txtDescripcion_po.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
            //txtDescripcion_ma.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoGuarda = 0; // sin ninguna accion
            this.botones = 0;
            this.codigo_po = 0;
            txtDescripcion_po.Text = "";
            this.txtDescripcion_po.ReadOnly = true;
            this.Estado_Botones_Principales(true);
            this.Estado_Botones_Procesos(false);
            this.Botones(false);
            this.Tb_Principal.SelectedIndex = 0;

            if (txtDescripcion_po.Text == "" || txtDescripcion_po.Text != null )
            {
                txtDescripcion_po.Text = "Marcas(*)";
                txtDescripcion_po.ForeColor = Color.Black;
          
            }
        }

        private void txtDescripcion_ma_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion_po.Text == "Marcas(*)")
            {
                txtDescripcion_po.Text = "";
                txtDescripcion_po.ForeColor = Color.Black;

            }
        }

        private void txtDescripcion_ma_Leave(object sender, EventArgs e)
        {

            if (txtDescripcion_po.Text == "")
            {
                txtDescripcion_po.Text = "Marcas(*)";
                txtDescripcion_po.ForeColor = Color.Black;

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
            if (txtProvincias.Text == "")
            {
                txtProvincias.Text = "Buscar Marcas:";
                txtProvincias.ForeColor = Color.Black;

            }else if (txtDescripcion_po.Text !=null)
            {
                txtProvincias.Text = "Buscar Marcas:";
                txtProvincias.ForeColor = Color.Black;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_po"].Value)))
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
                    this.codigo_po= Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_po"].Value);
                    respuesta = N_Provincias.Eliminar_po(this.codigo_po);
                    if (respuesta.Equals("ok"))
                    {
                        this.Listado_po("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        this.codigo_po = 0;                        
                    }
                }               
              
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_po(txtDescripcion_po.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_po.Text == "")
            {
                txtDescripcion_po.Text = "Marcas(*)";
                txtDescripcion_po.ForeColor = Color.Black;

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_po.Text == "")
            {
                txtDescripcion_po.Text = "Marcas(*)";
                txtDescripcion_po.ForeColor = Color.Black;

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
            this.txtDescripcion_po.ReadOnly = false;            
            Tb_Principal.SelectedIndex = 1; 
        }
    }
}