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
    public partial class Frm_Almacenes : Form
    {
        public Frm_Almacenes()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_al = 0;
        int botones = 0;

        #endregion
        #region "Mis Metodos"
        private void Formato_al()
        {
            Dgv_Principal.Columns[0].Width = 100;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO_AL";
            Dgv_Principal.Columns[1].Width = 200;
            Dgv_Principal.Columns[1].HeaderText = "ALMACEN";
        }

        public void Listado_al(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Almacenes.Listado_al(ctexto);
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
            this.txtDescripcion_al.Enabled = estado;
        }
        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_al"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_al = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_al"].Value);
                txtDescripcion_al.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["descripcion_al"].Value);
            }

        }

        #endregion
        private void Frm_Almacenes_Load(object sender, EventArgs e)
        {
            this.Listado_al("%");
            this.Formato_al();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtAlmacenes.Text == "Buscar Almacenes:")
            {
                txtAlmacenes.Text = "";
                txtAlmacenes.ForeColor = Color.Black;

            }
        }

        private void txtAlmacenes_Leave(object sender, EventArgs e)
        {

            if (txtAlmacenes.Text == "")
            {
                txtAlmacenes.Text = "Buscar Almacenes:";
                txtAlmacenes.ForeColor = Color.Black;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtAlmacenes.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso de Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                E_Almacenes oAL = new E_Almacenes();
                string respuesta = "";
                oAL.codigo_al = this.codigo_al;
                oAL.descripcion_al = txtDescripcion_al.Text.Trim();
                respuesta = N_Almacenes.Guardar_al(estadoGuarda, oAL);
                if (respuesta == "ok")
                {
                    this.Listado_al("%");
                    MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGuarda = 0;
                    this.Estado_Botones_Principales(true);
                    this.Estado_Botones_Procesos(false);
                    this.txtDescripcion_al.Text = "";
                    this.txtDescripcion_al.ReadOnly = true;
                    this.Tb_Principal.SelectedIndex = 0;
                    this.codigo_al = 0;
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
            // txtDescripcion_al.Text = "";
            this.txtDescripcion_al.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            estadoGuarda = 2;// actualizar registro

            this.botones = 3;
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Seleccionar_Item();
            this.txtDescripcion_al.ReadOnly = false;
            Tb_Principal.SelectedIndex = 1;
            txtDescripcion_al.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoGuarda = 0; // sin ninguna accion\
            this.botones = 0;
            this.codigo_al = 0;
            txtDescripcion_al.Text = "";
            this.txtDescripcion_al.ReadOnly = true;
            this.Estado_Botones_Principales(true);
            this.Estado_Botones_Procesos(false);
            this.Botones(false);
            this.Tb_Principal.SelectedIndex = 0;
            if (txtDescripcion_al.Text == "" || txtDescripcion_al.Text != null)
            {
                txtDescripcion_al.Text = "Almacen(*)";
                txtDescripcion_al.ForeColor = Color.Black;

            }

        }

        private void txtDescripcion_al_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion_al.Text == "Almacen(*)")
            {
                txtDescripcion_al.Text = "";
                txtDescripcion_al.ForeColor = Color.Black;

            }
        }

        private void txtDescripcion_al_Leave(object sender, EventArgs e)
        {

            if (txtDescripcion_al.Text == "")
            {
                txtDescripcion_al.Text = "Almacen(*)";
                txtDescripcion_al.ForeColor = Color.Black;

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
            this.codigo_al = 0;
            this.botones = 0;
        }


        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_al"].Value)))
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
                    this.codigo_al = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_al"].Value);
                    respuesta = N_Marca.Eliminar_ma(this.codigo_al);
                    if (respuesta.Equals("ok"))
                    {
                        this.Listado_al("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.codigo_al = 0;

                    }
                }


            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_al(txtAlmacenes.Text.Trim());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_al.Text == "")
            {
                txtDescripcion_al.Text = "Almacenes(*)";
                txtDescripcion_al.ForeColor = Color.Black;

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
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (txtDescripcion_al.Text == "" || txtDescripcion_al.Text == "")
            {
                txtDescripcion_al.Text = "Almacenes(*)";
                txtDescripcion_al.ForeColor = Color.Black;

            }
        }
    }
}