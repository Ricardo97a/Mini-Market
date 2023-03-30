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

namespace Sol_Capa_Presentacion.Rubros
{
    public partial class Frm_Rubros : Form
    {
        public Frm_Rubros()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_ru = 0;
        int botones = 0;

        #endregion
        #region "Mis Metodos"
        private void Formato_ru()
        {
            Dgv_Principal.Columns[0].Width = 100;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO_RU";
            Dgv_Principal.Columns[1].Width = 200;
            Dgv_Principal.Columns[1].HeaderText = "RUBRO";
        }

        public void Listado_ru(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Rubros.Listado_ru(ctexto);
                this.Formato_ru();
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
            this.txtDescripcion_ru.Enabled = estado;
        }
        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_ru"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_ru = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ru"].Value);
                txtDescripcion_ru.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_ru"].Value);
            }

        }

        #endregion
        private void Frm_Rubros_Load(object sender, EventArgs e)
        {
            this.Listado_ru("%");          
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
            if (txtDescripcion_ru.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)","Aviso de Sistemas",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                E_Rubros oRU= new E_Rubros();
                string respuesta = "";
                oRU.codigo_ru = this.codigo_ru;
                oRU.descripcion_ru = txtDescripcion_ru.Text.Trim();
                respuesta = N_Rubros.Guardar_ru(estadoGuarda, oRU);
                if (respuesta=="ok")
                {
                    this.Listado_ru("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtDescripcion_ru.Text = "";
                    this.txtDescripcion_ru.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0; 
                    this.codigo_ru = 0;
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
            this.txtDescripcion_ru.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
            //txtDescripcion_ma.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoGuarda = 0; // sin ninguna accion
            this.botones = 0;
            this.codigo_ru = 0;
            txtDescripcion_ru.Text = "";
            this.txtDescripcion_ru.ReadOnly = true;
            this.Estado_Botones_Principales(true);
            this.Estado_Botones_Procesos(false);
            this.Botones(false);
            this.Tb_Principal.SelectedIndex = 0;

            if (txtDescripcion_ru.Text == "" || txtDescripcion_ru.Text != null )
            {
                txtDescripcion_ru.Text = "Marcas(*)";
                txtDescripcion_ru.ForeColor = Color.Black;
          
            }
        }

        private void txtDescripcion_ma_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion_ru.Text == "Marcas(*)")
            {
                txtDescripcion_ru.Text = "";
                txtDescripcion_ru.ForeColor = Color.Black;

            }
        }

        private void txtDescripcion_ma_Leave(object sender, EventArgs e)
        {

            if (txtDescripcion_ru.Text == "")
            {
                txtDescripcion_ru.Text = "Marcas(*)";
                txtDescripcion_ru.ForeColor = Color.Black;

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
            this.codigo_ru = 0;
            this.botones = 0;
        }

        private void Tb_Principal_Click(object sender, EventArgs e)
        {
            //revisar
            if (txtMarcas.Text == "")
            {
                txtMarcas.Text = "Buscar Marcas:";
                txtMarcas.ForeColor = Color.Black;

            }else if (txtDescripcion_ru.Text !=null)
            {
                txtMarcas.Text = "Buscar Marcas:";
                txtMarcas.ForeColor = Color.Black;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_ru"].Value)))
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
                    this.codigo_ru = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ru"].Value);
                    respuesta = N_Rubros.Eliminar_ru(this.codigo_ru);
                    if (respuesta.Equals("ok"))
                    {
                        this.Listado_ru("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        this.codigo_ru = 0;                        
                    }
                }               
              
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_ru(txtDescripcion_ru.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_ru.Text == "")
            {
                txtDescripcion_ru.Text = "Marcas(*)";
                txtDescripcion_ru.ForeColor = Color.Black;

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_ru.Text == "")
            {
                txtDescripcion_ru.Text = "Marcas(*)";
                txtDescripcion_ru.ForeColor = Color.Black;

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