
namespace Sol_Capa_Presentacion.Reportes_Consolidados
{
    partial class Frm_Reporte_ingreso_ComprasxProductos
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
            this.Dp_inicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dp_Fin = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dp_inicio
            // 
            this.Dp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_inicio.Location = new System.Drawing.Point(235, 133);
            this.Dp_inicio.Name = "Dp_inicio";
            this.Dp_inicio.Size = new System.Drawing.Size(149, 26);
            this.Dp_inicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(130, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha inicio:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(130, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Fin:";
            // 
            // Dp_Fin
            // 
            this.Dp_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_Fin.Location = new System.Drawing.Point(235, 184);
            this.Dp_Fin.Name = "Dp_Fin";
            this.Dp_Fin.Size = new System.Drawing.Size(149, 26);
            this.Dp_Fin.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vista Previa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_Reporte_ingreso_ComprasxProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dp_Fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dp_inicio);
            this.Name = "Frm_Reporte_ingreso_ComprasxProductos";
            this.Text = "Frm_Reporte_ingreso_ComprasxProductos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dp_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dp_Fin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}