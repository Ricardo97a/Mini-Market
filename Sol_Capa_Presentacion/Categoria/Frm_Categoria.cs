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
using Sol_Capa_Presentacion.Reporte;

namespace Sol_Capa_Presentacion.Categoria
{
    public partial class Frm_Categoria : Form
    {
        public Frm_Categoria()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_ca = 0;
        int botones = 0;

        #endregion
        #region "Mis Metodos"
        private void Formato_ca()
        {
            Dgv_Principal.Columns[0].Width = 150;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO";
            Dgv_Principal.Columns[1].Width = 340;
            Dgv_Principal.Columns[1].HeaderText = "CATEGORIA";
        }

        public void Listado_ca(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Categoria.Listado_ca(ctexto);
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
           // this.btnsalir.Enabled = !estado;
            
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
            this.txtDescripcion_ca.Enabled = estado;
        }
        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_ca = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ca"].Value);
                txtDescripcion_ca.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_ca"].Value);
            }

        }

        #endregion
        private void Frm_Categoria_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
            this.Formato_ca();
        }      
           
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_ca.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)","Aviso de Sistemas",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                E_Categoria oCA = new E_Categoria();
                string respuesta = "";
                oCA.codigo_ca = this.codigo_ca;
                oCA.descripcion_ca = txtDescripcion_ca.Text.Trim();
                respuesta = N_Categoria.Guarcar_ca(estadoGuarda, oCA);
                if (respuesta=="ok")
                {
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtDescripcion_ca.Text = "";
                    this.txtDescripcion_ca.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0; 
                    this.Listado_ca("%");
                    this.codigo_ca = 0;
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
            //txtDescripcion_ca.Text = "";
            this.txtDescripcion_ca.ReadOnly = false;            
            Tb_Principal.SelectedIndex = 1;         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            estadoGuarda = 2;// actualizar registro

            this.botones = 3;
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Seleccionar_Item();
            this.txtDescripcion_ca.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
            //txtDescripcion_ca.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoGuarda = 0; // sin ninguna accion
            this.botones = 0;
            this.codigo_ca = 0;
            txtDescripcion_ca.Text = "";
            this.txtDescripcion_ca.ReadOnly = true;
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
            this.codigo_ca = 0;
            this.botones = 0;
        }
          

        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_ca"].Value)))
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
                    this.codigo_ca = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_ca"].Value);
                    respuesta = N_Categoria.Eliminar_ca(this.codigo_ca);
                    if (respuesta.Equals("ok"))
                    {
                        this.Listado_ca("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        this.codigo_ca = 0;
                        
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
                this.btnGuardar.Visible = false;
                this.btnCancelar.Visible = false;
            }
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {

            Frm_Rpt_Categoria reporte = new Frm_Rpt_Categoria();
            reporte.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Listado_ca(txt_buscar_ca.Text.Trim());
        }

        private void btn_buscar_ca_Click(object sender, EventArgs e)
        {
            this.Listado_ca(txt_buscar_ca.Text);
        }
    }
}