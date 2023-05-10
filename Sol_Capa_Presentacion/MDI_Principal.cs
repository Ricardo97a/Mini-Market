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
    public partial class MDI_Principal : Form
    {
        public MDI_Principal()
        {
            InitializeComponent();
        }

        private void salirDelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Productos oFrm_pr = new Frm_Productos();
            oFrm_pr.MdiParent = this;
            oFrm_pr.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pr.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Marcas oFrm_ma = new Frm_Marcas();
            oFrm_ma.MdiParent = this;
            oFrm_ma.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ma.Show();
        }

        private void unidadDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Unidades_Medidas oFrm_um = new Frm_Unidades_Medidas();
            oFrm_um.MdiParent = this;
            oFrm_um.StartPosition = FormStartPosition.CenterScreen;
            oFrm_um.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Categoria oFrm_ca = new Frm_Categoria();
            oFrm_ca.MdiParent = this;
            oFrm_ca.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ca.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Almacenes oFrm_al = new Frm_Almacenes();
            oFrm_al.MdiParent = this;
            oFrm_al.StartPosition = FormStartPosition.CenterScreen;
            oFrm_al.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLupaRubro oFrm_cl = new btnLupaRubro();
            oFrm_cl.MdiParent = this;
            oFrm_cl.StartPosition = FormStartPosition.CenterScreen;
            oFrm_cl.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Proveedores oFrm_pv = new Frm_Proveedores();
            oFrm_pv.MdiParent = this;
            oFrm_pv.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pv.Show();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Provincias oFrm_pr = new Frm_Provincias();
            oFrm_pr.MdiParent = this;
            oFrm_pr.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pr.Show();
        }

        private void cantonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cantones oFrm_ca = new Frm_Cantones();
            oFrm_ca.MdiParent = this;
            oFrm_ca.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ca.Show();
        }

        private void distritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Distritos oFrm_di = new Frm_Distritos();
            oFrm_di.MdiParent = this;
            oFrm_di.StartPosition = FormStartPosition.CenterScreen;
            oFrm_di.Show();
        }

        private void entradasDeProductosComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Entrada_Productos oFrm_ep = new Frm_Entrada_Productos();
            oFrm_ep.MdiParent = this;
            oFrm_ep.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ep.Show();
        }

        private void salidaDeProductosVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salida_Productos oFrm_sp = new Frm_Salida_Productos();
            oFrm_sp.MdiParent = this;
            oFrm_sp.StartPosition = FormStartPosition.CenterScreen;
            oFrm_sp.Show();
        }

        private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Rubros oFrm_ru = new Frm_Rubros();
            oFrm_ru.MdiParent = this;
            oFrm_ru.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ru.Show();
        }

        private void Tbar_Productos_Click(object sender, EventArgs e)
        {
            Frm_Productos oFrm_pr = new Frm_Productos();
            oFrm_pr.MdiParent = this;
            oFrm_pr.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pr.Show();
        }

        private void Tbar_Clientes_Click(object sender, EventArgs e)
        {
            btnLupaRubro oFrm_cl = new btnLupaRubro();
            oFrm_cl.MdiParent = this;
            oFrm_cl.StartPosition = FormStartPosition.CenterScreen;
            oFrm_cl.Show();
        }

        private void Tbar_Proveedores_Click(object sender, EventArgs e)
        {
            Frm_Proveedores oFrm_pv = new Frm_Proveedores();
            oFrm_pv.MdiParent = this;
            oFrm_pv.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pv.Show();
        }

        private void Tbar_Entrada_Productos_Click(object sender, EventArgs e)
        {
            Frm_Entrada_Productos oFrm_ep = new Frm_Entrada_Productos();
            oFrm_ep.MdiParent = this;
            oFrm_ep.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ep.Show();
        }        

        private void Tbar_Salida_Productos_Click(object sender, EventArgs e)
        {
            Frm_Salida_Productos oFrm_sp = new Frm_Salida_Productos();
            oFrm_sp.MdiParent = this;
            oFrm_sp.StartPosition = FormStartPosition.CenterScreen;
            oFrm_sp.Show();
        }
    }
    
}
