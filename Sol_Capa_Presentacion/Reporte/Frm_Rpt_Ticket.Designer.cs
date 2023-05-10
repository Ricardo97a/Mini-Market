
namespace Sol_Capa_Presentacion.Reporte
{
    partial class Frm_Rpt_Ticket
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
            this.crv_etiqueta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rpt_Imprimir_Ticket1 = new Sol_Capa_Presentacion.Rpt_Imprime_Ticket();
            this.SuspendLayout();
            // 
            // crv_etiqueta
            // 
            this.crv_etiqueta.ActiveViewIndex = -1;
            this.crv_etiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_etiqueta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_etiqueta.DisplayStatusBar = false;
            this.crv_etiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_etiqueta.Location = new System.Drawing.Point(0, 0);
            this.crv_etiqueta.Name = "crv_etiqueta";
            this.crv_etiqueta.ReportSource = this.Rpt_Imprimir_Ticket1;
            this.crv_etiqueta.Size = new System.Drawing.Size(635, 818);
            this.crv_etiqueta.TabIndex = 0;
            this.crv_etiqueta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Rpt_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 818);
            this.Controls.Add(this.crv_etiqueta);
            this.Name = "Frm_Rpt_Ticket";
            this.Text = "Frm_Rpt_Ticket";
            this.Load += new System.EventHandler(this.Frm_Rpt_Ticket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_etiqueta;
        private Rpt_Imprime_Ticket Rpt_Imprimir_Ticket1;
    }
}