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

namespace Sol_Capa_Presentacion.Usuarios
{
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }
        #region "Variables"
        int estadoGuarda = 0; //sin nunguna accion 
        int codigo_us = 0;
        int botones = 0;

        #endregion
        #region "Mis Metodos"
        private void Formato_us()
        {
            Dgv_Principal.Columns[0].Width = 150;
            Dgv_Principal.Columns[0].HeaderText = "CODIGO";
            Dgv_Principal.Columns[1].Width = 200;
            Dgv_Principal.Columns[1].HeaderText = "LOGIN";
            Dgv_Principal.Columns[2].Width = 200;
            Dgv_Principal.Columns[2].HeaderText = "NOMBRES";
            Dgv_Principal.Columns[3].Width = 200;
            Dgv_Principal.Columns[3].HeaderText = "CARGOS";
            Dgv_Principal.Columns[4].Visible = false;
         
        }

        public void Listado_us(string ctexto)
        {
            try
            {
                Dgv_Principal.DataSource = N_Usuario.Listado_us(ctexto);
                Formato_us();
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
            this.txt_login_us.Enabled = estado;
            this.txt_password.Enabled = estado;
        }
        public void limpiartxt()
        {
            this.txt_login_us.Text = "";
            this.txt_password.Text = "";
        }
        private void Seleccionar_Item()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_us"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_us = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_us"].Value);
                txt_login_us.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["login_us"].Value);
                txt_password.Text = "";
                txt_nombre.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["nombre_us"].Value);
                txt_cargo.Text = Convert.ToString(Dgv_Principal.CurrentRow.Cells["cargo_us"].Value);
                ckb_adm.Checked = Convert.ToBoolean( Dgv_Principal.CurrentRow.Cells["admin"].Value);

               
            }

        }

        #endregion
        private void Frm_Unidades_Medidas_Load(object sender, EventArgs e)
        {
            this.Listado_us("%");        
        }

       
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txt_password.Text == String.Empty && this.estadoGuarda == 1)
            {
                MessageBox.Show("Falta ingresa datos requeridos (*)",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt_login_us.Text == string.Empty ||               
                     txt_nombre.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso de Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    E_Usuarios oUS = new E_Usuarios();
                    string respuesta = "";
                    oUS.codigo_us = this.codigo_us;
                    oUS.login_us = txt_login_us.Text.Trim();
                    oUS.password = txt_password.Text.Trim();
                    oUS.nombre_us = txt_nombre.Text.Trim();
                    oUS.cargo_us = txt_cargo.Text.Trim();
                    oUS.admin = ckb_adm.Checked;
                    respuesta = N_Usuario.Guardar_us(estadoGuarda, oUS);
                    if (respuesta == "ok")
                    {
                        this.Listado_us("%");
                        MessageBox.Show("Los datos han sido guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        estadoGuarda = 0;
                        this.Estado_Botones_Principales(true);
                        this.Estado_Botones_Procesos(false);
                        this.limpiartxt();
                        txt_login_us.Text = "";
                        txt_password.Text = "";
                        txt_nombre.Text = "";
                        txt_cargo.Text = "";
                        ckb_adm.Checked = false;
                        this.txt_login_us.ReadOnly = true;
                        this.txt_password.ReadOnly = true;
                        this.txt_cargo.ReadOnly = true;
                        this.txt_nombre.ReadOnly = true;
                        ckb_adm.Enabled = false;
                        this.Tb_Principal.SelectedIndex = 0;
                        this.codigo_us = 0;
                        this.botones = 0;
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            txt_login_us.Text = "";
            txt_password.Text = "";
            txt_nombre.Text = "";
            txt_cargo.Text = "";
            ckb_adm.Checked = false;
            this.txt_login_us.ReadOnly = false;
            this.txt_password.ReadOnly = false;
            this.txt_cargo.ReadOnly = false;
            this.txt_nombre.ReadOnly = false;
            ckb_adm.Enabled = true;
            Tb_Principal.SelectedIndex = 1;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            estadoGuarda = 2;// actualizar registro

            this.botones = 3;
            this.Estado_Botones_Principales(false);
            this.Estado_Botones_Procesos(true);
            this.Seleccionar_Item();
            this.txt_login_us.ReadOnly = true;
            this.txt_password.ReadOnly = false;
            this.txt_cargo.ReadOnly = false;
            this.txt_nombre.ReadOnly = false;
            ckb_adm.Enabled = true;
            Tb_Principal.SelectedIndex = 1;
            txt_login_us.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.estadoGuarda = 0; // sin ninguna accion
            this.botones = 0;
            this.codigo_us = 0;
            txt_login_us.Text = "";
            txt_password.Text = "";
            txt_nombre.Text = "";
            txt_cargo.Text = "";
            ckb_adm.Checked = false;
            this.txt_login_us.ReadOnly = true;
            this.txt_password.ReadOnly = true;
            this.txt_cargo.ReadOnly = true;
            this.txt_nombre.ReadOnly = true;
            ckb_adm.Enabled = false;
            this.Estado_Botones_Principales(true);

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
            this.codigo_us = 0;
            this.botones = 0;
        }


        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Seleccionar_Item();
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Principal.CurrentRow.Cells["codigo_us"].Value)))
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
                    this.codigo_us = Convert.ToInt32(Dgv_Principal.CurrentRow.Cells["codigo_us"].Value);
                    respuesta = N_Usuario.Eliminar_us(this.codigo_us);
                    if (respuesta.Equals("ok"))
                    {
                        this.Listado_us("%");
                        MessageBox.Show("Registro eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.codigo_us = 0;

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
            Frm_Rpt_Unidad_Medida reporte = new Frm_Rpt_Unidad_Medida();
            reporte.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Listado_um(txt_buscar_um.Text.Trim());
        }

        private void btn_buscar_um_Click(object sender, EventArgs e)
        {
            this.Listado_us(txt_buscar_um.Text);
        }
    }
}