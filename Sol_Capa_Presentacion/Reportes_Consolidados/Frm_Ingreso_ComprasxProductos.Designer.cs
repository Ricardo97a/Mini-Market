
namespace Sol_Capa_Presentacion.Reportes_Consolidados
{
    partial class Frm_Ingreso_ComprasxProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txt_fecha_inicio = new System.Windows.Forms.TextBox();
            this.txt_fecha_fin = new System.Windows.Forms.TextBox();
            this.Rpt_Ingreso_CompraxProducto1 = new Sol_Capa_Presentacion.Rpt_Ingreso_CompraxProducto();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Rpt_Ingreso_CompraxProducto1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1365, 705);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio.Location = new System.Drawing.Point(57, 80);
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.Size = new System.Drawing.Size(161, 26);
            this.txt_fecha_inicio.TabIndex = 1;
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin.Location = new System.Drawing.Point(57, 112);
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.Size = new System.Drawing.Size(161, 26);
            this.txt_fecha_fin.TabIndex = 2;
            // 
            // Frm_Ingreso_ComprasxProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 705);
            this.Controls.Add(this.txt_fecha_fin);
            this.Controls.Add(this.txt_fecha_inicio);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Frm_Ingreso_ComprasxProductos";
            this.Text = "Frm_Ingreso_ComprasxProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox txt_fecha_inicio;
        private System.Windows.Forms.TextBox txt_fecha_fin;
        private Rpt_Ingreso_CompraxProducto Rpt_Ingreso_CompraxProducto1;
    }
}