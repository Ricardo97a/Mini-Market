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
    public partial class Frm_Marcas : Form
    {
        public Frm_Marcas()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_ma = 0;
        int botones = 0;

        #endregion
        #region "Mis Metodos"
        private void Formato_ma()
        {
            Dgv_Principal.Columns[0].Width = 100;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO_ma";
            Dgv_Principal.Columns[1].Width = 200;
            Dgv_Principal.Columns[1].HeaderText = "Marca";
        }

        public void Listado_ma(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Marca.Listado_ma(ctexto);
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
            this.txtDescripcion_ma.Enabled = estado;
        }
        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_ma"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_ma = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ma"].Value);
                txtDescripcion_ma.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_ma"].Value);
            }

        }

        #endregion
        private void Frm_Marcas_Load(object sender, EventArgs e)
        {
            this.Listado_ma("%");
            this.Formato_ma();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtMarcas.Text== "Buscar Marcas:")
            {
                txtMarcas.Text = "";
                txtMarcas.ForeColor = Color.Black;

            }
        }

        private void txtMarcas_Leave(object sender, EventArgs e)
        {

            if (txtMarcas.Text == "")
            {
                txtMarcas.Text = "Buscar Marcas:";
                txtMarcas.ForeColor = Color.Black;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtMarcas.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)","Aviso de Sistemas",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                E_Marcas oMA= new E_Marcas();
                string respuesta = "";
                oMA.codigo_ma = this.codigo_ma;
                oMA.descripcion_ma = txtDescripcion_ma.Text.Trim();
                respuesta = N_Marca.Guardar_ma(estadoGuarda, oMA);
                if (respuesta=="ok")
                {
                    this.Listado_ma("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtDescripcion_ma.Text = "";
                    this.txtDescripcion_ma.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0; 
                    this.codigo_ma = 0;
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
            botones = 2;
            estadoGuarda = 1;// nuevo registro
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            //txtDescripcion_ma.Text = "";
            this.txtDescripcion_ma.ReadOnly = false;            
            Tb_Principal.SelectedIndex = 1;
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            estadoGuarda = 2;// actualizar registro

            this.botones = 3;
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Seleccionar_Item();
            this.txtDescripcion_ma.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
            //txtDescripcion_ma.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoGuarda = 0; // sin ninguna accion
            this.botones = 0;
            this.codigo_ma = 0;
            txtDescripcion_ma.Text = "";
            this.txtDescripcion_ma.ReadOnly = true;
            this.Estado_Botones_Principales(true);
            this.Estado_Botones_Procesos(false);
            this.Botones(false);
            this.Tb_Principal.SelectedIndex = 0;

            if (txtDescripcion_ma.Text == "" || txtDescripcion_ma.Text != null )
            {
                txtDescripcion_ma.Text = "Marcas(*)";
                txtDescripcion_ma.ForeColor = Color.Black;
          
            }
        }

        private void txtDescripcion_ma_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion_ma.Text == "Marcas(*)")
            {
                txtDescripcion_ma.Text = "";
                txtDescripcion_ma.ForeColor = Color.Black;

            }
        }

        private void txtDescripcion_ma_Leave(object sender, EventArgs e)
        {

            if (txtDescripcion_ma.Text == "")
            {
                txtDescripcion_ma.Text = "Marcas(*)";
                txtDescripcion_ma.ForeColor = Color.Black;

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
            this.codigo_ma = 0;
            this.botones = 0;
        }

        private void Tb_Principal_Click(object sender, EventArgs e)
        {
            //revisar
            if (txtMarcas.Text == "")
            {
                txtMarcas.Text = "Buscar Marcas:";
                txtMarcas.ForeColor = Color.Black;

            }else if (txtDescripcion_ma.Text !=null)
            {
                txtMarcas.Text = "Buscar Marcas:";
                txtMarcas.ForeColor = Color.Black;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_ma"].Value)))
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
                    this.codigo_ma = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ma"].Value);
                    respuesta = N_Marca.Eliminar_ma(this.codigo_ma);
                    if (respuesta.Equals("ok"))
                    {
                        this.Listado_ma("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        this.codigo_ma = 0;
                        
                    }
                }
               
              
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_ma(txtMarcas.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_ma.Text == "")
            {
                txtDescripcion_ma.Text = "Marcas(*)";
                txtDescripcion_ma.ForeColor = Color.Black;

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_ma.Text == "")
            {
                txtDescripcion_ma.Text = "Marcas(*)";
                txtDescripcion_ma.ForeColor = Color.Black;

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
    }
}