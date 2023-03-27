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
        int botones = 0;

        #endregion
        #region "Mis Metodos" 
        private void Formato_pr()
        {
            Dgv_Principal.Columns[0].Width = 100;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO_PR";
            Dgv_Principal.Columns[1].Width = 100;
            Dgv_Principal.Columns[1].HeaderText = "PRODUCTO";
            Dgv_Principal.Columns[2].Width = 200;
            Dgv_Principal.Columns[2].HeaderText = "MARCA";
            Dgv_Principal.Columns[3].Width = 200;
            Dgv_Principal.Columns[3].HeaderText = "U.MEDIDA";
            Dgv_Principal.Columns[4].Width = 200;
            Dgv_Principal.Columns[4].HeaderText = "CATEGORIA";
            Dgv_Principal.Columns[5].Width = 200;
            Dgv_Principal.Columns[5].HeaderText = "STOCK MIN";
            Dgv_Principal.Columns[6].Width = 200;
            Dgv_Principal.Columns[6].HeaderText = "STOCK MAX";
            Dgv_Principal.Columns[7].Visible = false;
            Dgv_Principal.Columns[8].Visible = false;
            Dgv_Principal.Columns[9].Visible = false;
        }

        public void Listado_pr(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Productos.Listado_pr(ctexto);
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
            this.txtDescripcion_pr.Enabled = estado;
            this.txtDescripcion_ma.Enabled = estado;
            this.txtDescripcion_um.Enabled = estado;
            this.txtDescripcion_ca.Enabled = estado;
            this.txtStock_max.Enabled = estado;
            this.txtStock_min.Enabled = estado;
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
                txtDescripcion_pr.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["abreviatura"].Value);
                txtDescripcion_ma.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_um"].Value);
            }

        }

        #endregion
        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_um("%");
            this.Formato_um();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProductos.Text == "Buscar Unidas Medidas:")
            {
                txtBuscarProductos.Text = "";
                txtBuscarProductos.ForeColor = Color.Black;

            }
        }

        private void txtUM_Leave(object sender, EventArgs e)
        {

            if (txtBuscarProductos.Text == "")
            {
                txtBuscarProductos.Text = "Buscar Unidas Medidas:";
                txtBuscarProductos.ForeColor = Color.Black;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_pr.Text == string.Empty || txtBuscarProductos.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso de Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                E_Unidad_Medidas oUM = new E_Unidad_Medidas();
                string respuesta = "";
                oUM.codigo_um = this.codigo_um;
                oUM.abreviatura_um = txtDescripcion_pr.Text.Trim();
                oUM.descripcion_um = txtDescripcion_ma.Text.Trim();
                respuesta = N_Unidad_Medidas.Guardar_um(estadoGuarda, oUM);
                if (respuesta == "ok")
                {
                    this.Listado_um("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtDescripcion_pr.Text = "";
                    this.txtDescripcion_ma.Text = "";
                    this.txtDescripcion_ma.ReadOnly = true;
                    this.txtDescripcion_pr.ReadOnly = true;
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
            this.txtDescripcion_pr.ReadOnly = false;
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
            this.txtDescripcion_pr.ReadOnly = false;
            this.txtDescripcion_ma.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
            txtDescripcion_pr.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.estadoGuarda = 0; // sin ninguna accion
            this.botones = 0;
            this.codigo_um = 0;
            txtDescripcion_pr.Text = "";
            txtDescripcion_ma.Text = "";
            this.txtDescripcion_pr.ReadOnly = true;
            this.txtDescripcion_ma.ReadOnly = true;
            this.Estado_Botones_Principales(true);

            this.Botones(false);

            this.Tb_Principal.SelectedIndex = 0;

            if (txtDescripcion_pr.Text == "" || txtDescripcion_pr.Text != null || txtDescripcion_ma.Text == "" || txtDescripcion_ma.Text != null)
            {
                txtDescripcion_pr.Text = "Abreviatura(*)";
                txtDescripcion_pr.ForeColor = Color.Black;
                txtDescripcion_ma.Text = "Unidad Medidas(*)";
                txtDescripcion_ma.ForeColor = Color.Black;

            }

        }

        private void txtDescripcion_um_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion_ma.Text == "Unidad Medidas(*)")
            {
                txtDescripcion_ma.Text = "";
                txtDescripcion_ma.ForeColor = Color.Black;

            }
        }

        private void txtDescripcion_um_Leave(object sender, EventArgs e)
        {

            if (txtDescripcion_ma.Text == "")
            {
                txtDescripcion_ma.Text = "Unidad Medidas(*)";
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
            this.Listado_um(txtBuscarProductos.Text.Trim());
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
                txtBuscarProductos.Text = "Buscar Unidas Medidas:";
                txtBuscarProductos.ForeColor = Color.Black;


            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAbreviatura_um_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_pr.Text == "Abreviatura(*)")
            {
                txtDescripcion_pr.Text = "";
                txtDescripcion_pr.ForeColor = Color.Black;

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

            if (txtDescripcion_pr.Text == "" || txtDescripcion_ma.Text == "")
            {
                txtDescripcion_pr.Text = "Abreviatura(*)";
                txtDescripcion_pr.ForeColor = Color.Black;
                txtDescripcion_ma.Text = "Unidad Medidas(*)";
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