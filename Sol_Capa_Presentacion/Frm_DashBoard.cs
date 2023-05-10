using Sol_Capa_Presentacion.Almacenes;
using Sol_Capa_Presentacion.Canto;
using Sol_Capa_Presentacion.Categoria;
using Sol_Capa_Presentacion.Clientes;
using Sol_Capa_Presentacion.Distritos;
using Sol_Capa_Presentacion.Entradas_Productos;
using Sol_Capa_Presentacion.Marcas;
using Sol_Capa_Presentacion.Productos;
using Sol_Capa_Presentacion.Proveedores;
using Sol_Capa_Presentacion.Provincias;
using Sol_Capa_Presentacion.Rubros;
using Sol_Capa_Presentacion.Salidad_Productos;
using Sol_Capa_Presentacion.Unidad_Medidas;
using Sol_Capa_Presentacion.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Capa_Presentacion
{
    public partial class Frm_DashBoard : Form
    {
        public Frm_DashBoard()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        private Form activeForm = null;

        #endregion
        #region "Mis Métodos"
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Pnl_cuerpo.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        private void Frm_DashBoard_Load(object sender, EventArgs e)
        {
            this.Pnl_procesos.Visible = false;
            this.Pnl_reportes.Visible = false;
            this.Pnl_datosmaestros.Visible = false;
            this.Pnl_sistemas.Visible = false;
        }

        private void Btn_procesos_Click(object sender, EventArgs e)
        {
            if (this.Pnl_procesos.Visible == false)
            {
                this.Pnl_procesos.Visible = true;
            }
            else
            {
                this.Pnl_procesos.Visible = false;
            }
            this.Pnl_reportes.Visible = false;
            this.Pnl_datosmaestros.Visible = false;
            this.Pnl_sistemas.Visible = false;
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            if (this.Pnl_reportes.Visible == false)
            {
                this.Pnl_reportes.Visible = true;
            }
            else
            {
                this.Pnl_reportes.Visible = false;
            }
            this.Pnl_procesos.Visible = false;
            this.Pnl_datosmaestros.Visible = false;
            this.Pnl_sistemas.Visible = false;
        }

        private void Btn_datosmaestros_Click(object sender, EventArgs e)
        {
            if (this.Pnl_datosmaestros.Visible == false)
            {
                this.Pnl_datosmaestros.Visible = true;
            }
            else
            {
                this.Pnl_datosmaestros.Visible = false;
            }
            this.Pnl_procesos.Visible = false;
            this.Pnl_reportes.Visible = false;
            this.Pnl_sistemas.Visible = false;
        }

        private void Btn_sistemas_Click(object sender, EventArgs e)
        {
            if (this.Pnl_sistemas.Visible == false)
            {
                this.Pnl_sistemas.Visible = true;
            }
            else
            {
                this.Pnl_sistemas.Visible = false;
            }
            this.Pnl_procesos.Visible = false;
            this.Pnl_reportes.Visible = false;
            this.Pnl_datosmaestros.Visible = false;
        }

        private void Btn_entradaproductos_Click(object sender, EventArgs e)
        {          
            openChildForm(new Frm_Entrada_Productos());
        }

        private void Btn_salidaproductos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Salida_Productos());
        }

        private void Btn_reporte1_Click(object sender, EventArgs e)
        {
            //openChildForm(new Reportes_Consolidado.Frm_Reporte_Ingreso_ComprasxProductos());
        }

        private void Btn_reporte2_Click(object sender, EventArgs e)
        {
           // openChildForm(new Reportes_Consolidado.Frm_Reporte_Ingreso_AcumuladoxProducto());
        }

        private void Btn_reporte3_Click(object sender, EventArgs e)
        {
            //openChildForm(new Reportes_Consolidado.Frm_Reporte_Salida_VentasxProductos());
        }

        private void Btn_reporte4_Click(object sender, EventArgs e)
        {
           // openChildForm(new Reportes_Consolidado.Frm_Reporte_Salida_AcumuladoxProducto());
        }

        private void Btn_productos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Productos());
        }

        private void Btn_marcas_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Marcas());
        }

        private void Btn_medidas_Click(object sender, EventArgs e)
        {
          openChildForm(new Frm_Unidades_Medidas());
        }

        private void Btn_categorias_Click(object sender, EventArgs e)
        {
           openChildForm(new Frm_Categoria());
        }

        private void Btn_almacenes_Click(object sender, EventArgs e)
        {
           openChildForm(new Frm_Almacenes());
        }

        private void Btn_clientes_Click(object sender, EventArgs e)
        {
            openChildForm(new btnLupaRubro());
        }

        private void Btn_proveedores_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Proveedores());
        }

        private void Btn_rubros_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Rubros());
        } 
               
        private void Btn_usuariosistema_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Usuarios());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_fecha.Text = DateTime.Now.ToLongDateString();
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void Btn_Provincia_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Provincias());
        }

        private void Btn_distritos_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Frm_Distritos());
        }

        private void Btn_canton_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Cantones());
        }
    }
}
