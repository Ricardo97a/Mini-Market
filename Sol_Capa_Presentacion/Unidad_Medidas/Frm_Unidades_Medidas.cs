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

namespace Sol_Capa_Presentacion.Categoria
{
    public partial class Frm_Unidades_Medidas : Form
    {
        public Frm_Unidades_Medidas()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_um = 0;
        int botones = 0;

        #endregion
        #region "Mis Metodos"
        private void Formato_um()
        {
            Dgv_Principal.Columns[0].Width = 100;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO_UM";
            Dgv_Principal.Columns[1].Width = 100;
            Dgv_Principal.Columns[1].HeaderText = "ABREVIATURA_UM";
            Dgv_Principal.Columns[2].Width = 200;
            Dgv_Principal.Columns[2].HeaderText = "MEDIDAS";
        }

        public void Listado_um(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Unidad_Medidas.Listado_um(ctexto);
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
            this.txtAbreviatura_um.Enabled = estado;
            this.txtDescripcion_um.Enabled = estado;
        }

        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_um"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_um = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_um"].Value);
                txtAbreviatura_um.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["abreviatura"].Value);
                txtDescripcion_um.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_um"].Value);
            }

        }

        #endregion
        private void Frm_Unidades_Medidas_Load(object sender, EventArgs e)
        {
            this.Listado_um("%");
            this.Formato_um();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUM.Text == "Buscar Unidas Medidas:")
            {
                txtUM.Text = "";
                txtUM.ForeColor = Color.Black;

            }
        }

        private void txtUM_Leave(object sender, EventArgs e)
        {

            if (txtUM.Text == "")
            {
                txtUM.Text = "Buscar Unidas Medidas:";
                txtUM.ForeColor = Color.Black;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtAbreviatura_um.Text == string.Empty || txtUM.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso de Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                E_Unidad_Medidas oUM = new E_Unidad_Medidas();
                string respuesta = "";
                oUM.codigo_um = this.codigo_um;
                oUM.abreviatura_um = txtAbreviatura_um.Text.Trim();
                oUM.descripcion_um = txtDescripcion_um.Text.Trim();
                respuesta = N_Unidad_Medidas.Guardar_um(estadoGuarda, oUM);
                if (respuesta == "ok")
                {
                    this.Listado_um("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtAbreviatura_um.Text = "";
                    this.txtDescripcion_um.Text = "";
                    this.txtDescripcion_um.ReadOnly = true;
                    this.txtAbreviatura_um.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0;
                    this.codigo_um = 0;
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
            this.Botones(false);
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            // txtAbreviatura_um.Text = "";
            // txtDescripcion_um.Text = "";
            this.txtAbreviatura_um.ReadOnly = false;
            this.txtDescripcion_um.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            estadoGuarda = 2;// actualizar registro

            this.botones = 3;
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Seleccionar_Item();
            this.txtAbreviatura_um.ReadOnly = false;
            this.txtDescripcion_um.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
            txtAbreviatura_um.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.estadoGuarda = 0; // sin ninguna accion
            this.botones = 0;
            this.codigo_um = 0;
            txtAbreviatura_um.Text = "";
            txtDescripcion_um.Text = "";
            this.txtAbreviatura_um.ReadOnly = true;
            this.txtDescripcion_um.ReadOnly = true;
            this.Estado_Botones_Principales(true);

            this.Botones(false);

            this.Tb_Principal.SelectedIndex = 0;

            if (txtAbreviatura_um.Text == "" || txtAbreviatura_um.Text != null || txtDescripcion_um.Text == "" || txtDescripcion_um.Text != null)
            {
                txtAbreviatura_um.Text = "Abreviatura(*)";
                txtAbreviatura_um.ForeColor = Color.Black;
                txtDescripcion_um.Text = "Unidad Medidas(*)";
                txtDescripcion_um.ForeColor = Color.Black;

            }

        }

        private void txtDescripcion_um_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion_um.Text == "Unidad Medidas(*)")
            {
                txtDescripcion_um.Text = "";
                txtDescripcion_um.ForeColor = Color.Black;

            }
        }

        private void txtDescripcion_um_Leave(object sender, EventArgs e)
        {

            if (txtDescripcion_um.Text == "")
            {
                txtDescripcion_um.Text = "Unidad Medidas(*)";
                txtDescripcion_um.ForeColor = Color.Black;

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
            this.codigo_um = 0;
            this.botones = 0;
        }


        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_um"].Value)))
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
                    this.codigo_um = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_um"].Value);
                    respuesta = N_Unidad_Medidas.Eliminar_um(this.codigo_um);
                    if (respuesta.Equals("ok"))
                    {
                        this.Listado_um("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.codigo_um = 0;

                    }
                }


            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_um(txtUM.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            this.Estado_Botones_Principales(false);
            if (txtDescripcion_um.Text == "" || txtAbreviatura_um.Text == "")
            {
                txtAbreviatura_um.Text = "Abreviatura(*)";
                txtAbreviatura_um.ForeColor = Color.Black;
                txtDescripcion_um.Text = "Unidad Medidas(*)";
                txtDescripcion_um.ForeColor = Color.Black;
                txtUM.Text = "Buscar Unidas Medidas:";
                txtUM.ForeColor = Color.Black;


            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAbreviatura_um_Click(object sender, EventArgs e)
        {
            if (txtAbreviatura_um.Text == "Abreviatura(*)")
            {
                txtAbreviatura_um.Text = "";
                txtAbreviatura_um.ForeColor = Color.Black;

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

            if (txtAbreviatura_um.Text == "" || txtDescripcion_um.Text == "")
            {
                txtAbreviatura_um.Text = "Abreviatura(*)";
                txtAbreviatura_um.ForeColor = Color.Black;
                txtDescripcion_um.Text = "Unidad Medidas(*)";
                txtDescripcion_um.ForeColor = Color.Black;

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