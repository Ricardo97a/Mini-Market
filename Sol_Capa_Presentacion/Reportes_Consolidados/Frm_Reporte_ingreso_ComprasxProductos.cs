using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Capa_Presentacion.Reportes_Consolidados
{
    public partial class Frm_Reporte_ingreso_ComprasxProductos : Form
    {
        public Frm_Reporte_ingreso_ComprasxProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Ingreso_ComprasxProductos reporte = new Reportes_Consolidados.Frm_Ingreso_ComprasxProductos();               
            reporte.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
