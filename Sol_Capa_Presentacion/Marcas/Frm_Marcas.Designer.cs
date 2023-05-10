
namespace Sol_Capa_Presentacion.Marcas
{
    partial class Frm_Marcas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Marcas));
            this.Tb_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Linea = new System.Windows.Forms.Panel();
            this.txtMarcas = new System.Windows.Forms.TextBox();
            this.Dgv_Principal = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescripcion_ma = new System.Windows.Forms.TextBox();
            this.btnretornar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.Pnl_SubOpcion = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Tb_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Principal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Pnl_SubOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Principal
            // 
            this.Tb_Principal.Controls.Add(this.tabPage1);
            this.Tb_Principal.Controls.Add(this.tabPage2);
            this.Tb_Principal.Location = new System.Drawing.Point(12, 88);
            this.Tb_Principal.Name = "Tb_Principal";
            this.Tb_Principal.SelectedIndex = 0;
            this.Tb_Principal.Size = new System.Drawing.Size(814, 375);
            this.Tb_Principal.TabIndex = 0;
            this.Tb_Principal.Selected += new System.Windows.Forms.TabControlEventHandler(this.Tb_Principal_Selected);
            this.Tb_Principal.Click += new System.EventHandler(this.Tb_Principal_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.iconButton1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Linea);
            this.tabPage1.Controls.Add(this.txtMarcas);
            this.tabPage1.Controls.Add(this.Dgv_Principal);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(806, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(478, 49);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(51, 40);
            this.iconButton1.TabIndex = 109;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar:";
            // 
            // Linea
            // 
            this.Linea.BackColor = System.Drawing.Color.Black;
            this.Linea.Location = new System.Drawing.Point(230, 68);
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(240, 1);
            this.Linea.TabIndex = 8;
            // 
            // txtMarcas
            // 
            this.txtMarcas.BackColor = System.Drawing.Color.White;
            this.txtMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcas.ForeColor = System.Drawing.Color.Black;
            this.txtMarcas.Location = new System.Drawing.Point(230, 37);
            this.txtMarcas.Multiline = true;
            this.txtMarcas.Name = "txtMarcas";
            this.txtMarcas.Size = new System.Drawing.Size(240, 35);
            this.txtMarcas.TabIndex = 5;
            this.txtMarcas.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtMarcas.Leave += new System.EventHandler(this.txtMarcas_Leave);
            // 
            // Dgv_Principal
            // 
            this.Dgv_Principal.AllowUserToAddRows = false;
            this.Dgv_Principal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Olive;
            this.Dgv_Principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Principal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Principal.ColumnHeadersHeight = 55;
            this.Dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Principal.EnableHeadersVisualStyles = false;
            this.Dgv_Principal.Location = new System.Drawing.Point(114, 100);
            this.Dgv_Principal.Name = "Dgv_Principal";
            this.Dgv_Principal.ReadOnly = true;
            this.Dgv_Principal.RowHeadersWidth = 62;
            this.Dgv_Principal.RowTemplate.Height = 50;
            this.Dgv_Principal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Principal.Size = new System.Drawing.Size(572, 212);
            this.Dgv_Principal.TabIndex = 3;
            this.Dgv_Principal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Principal_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.txtDescripcion_ma);
            this.tabPage2.Controls.Add(this.btnretornar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Marca:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(354, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 1);
            this.panel2.TabIndex = 15;
            // 
            // txtDescripcion_ma
            // 
            this.txtDescripcion_ma.BackColor = System.Drawing.Color.White;
            this.txtDescripcion_ma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion_ma.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion_ma.Location = new System.Drawing.Point(354, 42);
            this.txtDescripcion_ma.Multiline = true;
            this.txtDescripcion_ma.Name = "txtDescripcion_ma";
            this.txtDescripcion_ma.Size = new System.Drawing.Size(206, 35);
            this.txtDescripcion_ma.TabIndex = 14;
            // 
            // btnretornar
            // 
            this.btnretornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnretornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnretornar.ForeColor = System.Drawing.Color.Black;
            this.btnretornar.Location = new System.Drawing.Point(520, 94);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.Size = new System.Drawing.Size(109, 39);
            this.btnretornar.TabIndex = 13;
            this.btnretornar.Text = "Retornar";
            this.btnretornar.UseVisualStyleBackColor = false;
            this.btnretornar.Click += new System.EventHandler(this.btnretornar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(393, 94);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 39);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(267, 94);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 39);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.Black;
            this.btnnuevo.ImageKey = "newfile_85903.png";
            this.btnnuevo.ImageList = this.imageList1;
            this.btnnuevo.Location = new System.Drawing.Point(16, 481);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(95, 90);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "newfile_85903.png");
            this.imageList1.Images.SetKeyName(1, "edit_modify_icon_149489.png");
            this.imageList1.Images.SetKeyName(2, "removetheproperty_theapplication_eliminar_2965.png");
            this.imageList1.Images.SetKeyName(3, "file_spreadsheet_icon_143779.png");
            this.imageList1.Images.SetKeyName(4, "mbrilogout_99583 (1).png");
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.ImageKey = "edit_modify_icon_149489.png";
            this.btnactualizar.ImageList = this.imageList1;
            this.btnactualizar.Location = new System.Drawing.Point(108, 481);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(109, 90);
            this.btnactualizar.TabIndex = 2;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.ImageKey = "removetheproperty_theapplication_eliminar_2965.png";
            this.btneliminar.ImageList = this.imageList1;
            this.btneliminar.Location = new System.Drawing.Point(211, 481);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(95, 90);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnreporte
            // 
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporte.ForeColor = System.Drawing.Color.Black;
            this.btnreporte.ImageKey = "file_spreadsheet_icon_143779.png";
            this.btnreporte.ImageList = this.imageList1;
            this.btnreporte.Location = new System.Drawing.Point(299, 481);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(95, 90);
            this.btnreporte.TabIndex = 4;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.ImageKey = "mbrilogout_99583 (1).png";
            this.btnsalir.ImageList = this.imageList1;
            this.btnsalir.Location = new System.Drawing.Point(391, 481);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(95, 90);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Pnl_SubOpcion
            // 
            this.Pnl_SubOpcion.BackColor = System.Drawing.Color.Orange;
            this.Pnl_SubOpcion.Controls.Add(this.label10);
            this.Pnl_SubOpcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_SubOpcion.Location = new System.Drawing.Point(0, 0);
            this.Pnl_SubOpcion.Name = "Pnl_SubOpcion";
            this.Pnl_SubOpcion.Size = new System.Drawing.Size(846, 72);
            this.Pnl_SubOpcion.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 72);
            this.label10.TabIndex = 0;
            this.label10.Text = "MARCAS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 588);
            this.Controls.Add(this.Pnl_SubOpcion);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.Tb_Principal);
            this.Name = "Frm_Marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Frm_Marcas_Load);
            this.Tb_Principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Principal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Pnl_SubOpcion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tb_Principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgv_Principal;
        private System.Windows.Forms.TextBox txtMarcas;
        private System.Windows.Forms.Panel Linea;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnretornar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_SubOpcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescripcion_ma;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}