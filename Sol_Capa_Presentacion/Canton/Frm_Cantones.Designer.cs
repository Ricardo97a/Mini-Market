
namespace Sol_Capa_Presentacion.Cantones
{
    partial class Frm_Cantones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cantones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tb_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Linea = new System.Windows.Forms.Panel();
            this.txtCantones = new System.Windows.Forms.TextBox();
            this.Dgv_Principal = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlListadoProvincias = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBuscar2P = new System.Windows.Forms.TextBox();
            this.btnRetornar2PO = new System.Windows.Forms.Button();
            this.btnLupa2PO = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblListadoMarcas = new System.Windows.Forms.Label();
            this.Dgv_Provincias = new System.Windows.Forms.DataGridView();
            this.btnLupaPO = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDescripcion_po = new System.Windows.Forms.TextBox();
            this.btnretornar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripcion_co = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.Tb_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Principal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnlListadoProvincias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Provincias)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Principal
            // 
            this.Tb_Principal.Controls.Add(this.tabPage1);
            this.Tb_Principal.Controls.Add(this.tabPage2);
            this.Tb_Principal.Location = new System.Drawing.Point(12, 12);
            this.Tb_Principal.Name = "Tb_Principal";
            this.Tb_Principal.SelectedIndex = 0;
            this.Tb_Principal.Size = new System.Drawing.Size(1115, 395);
            this.Tb_Principal.TabIndex = 0;
            this.Tb_Principal.Selected += new System.Windows.Forms.TabControlEventHandler(this.Tb_Principal_Selected);
            this.Tb_Principal.Click += new System.EventHandler(this.Tb_Principal_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.Linea);
            this.tabPage1.Controls.Add(this.txtCantones);
            this.tabPage1.Controls.Add(this.Dgv_Principal);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Linea
            // 
            this.Linea.BackColor = System.Drawing.Color.Black;
            this.Linea.Location = new System.Drawing.Point(222, 63);
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(363, 1);
            this.Linea.TabIndex = 8;
            // 
            // txtCantones
            // 
            this.txtCantones.BackColor = System.Drawing.Color.White;
            this.txtCantones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantones.ForeColor = System.Drawing.Color.Black;
            this.txtCantones.Location = new System.Drawing.Point(222, 42);
            this.txtCantones.Name = "txtCantones";
            this.txtCantones.Size = new System.Drawing.Size(365, 19);
            this.txtCantones.TabIndex = 5;
            this.txtCantones.Text = "Buscar Cantones:";
            this.txtCantones.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtCantones.Leave += new System.EventHandler(this.txtMarcas_Leave);
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
            this.Dgv_Principal.ColumnHeadersHeight = 35;
            this.Dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Principal.EnableHeadersVisualStyles = false;
            this.Dgv_Principal.Location = new System.Drawing.Point(114, 100);
            this.Dgv_Principal.Name = "Dgv_Principal";
            this.Dgv_Principal.ReadOnly = true;
            this.Dgv_Principal.RowHeadersWidth = 62;
            this.Dgv_Principal.RowTemplate.Height = 28;
            this.Dgv_Principal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Principal.Size = new System.Drawing.Size(858, 234);
            this.Dgv_Principal.TabIndex = 3;
            this.Dgv_Principal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Principal_CellDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(607, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 39);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pnlListadoProvincias);
            this.tabPage2.Controls.Add(this.btnLupaPO);
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.txtDescripcion_po);
            this.tabPage2.Controls.Add(this.btnretornar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.txtDescripcion_co);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pnlListadoProvincias
            // 
            this.pnlListadoProvincias.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlListadoProvincias.Controls.Add(this.panel7);
            this.pnlListadoProvincias.Controls.Add(this.txtBuscar2P);
            this.pnlListadoProvincias.Controls.Add(this.btnRetornar2PO);
            this.pnlListadoProvincias.Controls.Add(this.btnLupa2PO);
            this.pnlListadoProvincias.Controls.Add(this.lblListadoMarcas);
            this.pnlListadoProvincias.Controls.Add(this.Dgv_Provincias);
            this.pnlListadoProvincias.Location = new System.Drawing.Point(565, 48);
            this.pnlListadoProvincias.Name = "pnlListadoProvincias";
            this.pnlListadoProvincias.Size = new System.Drawing.Size(404, 269);
            this.pnlListadoProvincias.TabIndex = 36;
            this.pnlListadoProvincias.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(20, 112);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 2);
            this.panel7.TabIndex = 39;
            // 
            // txtBuscar2P
            // 
            this.txtBuscar2P.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBuscar2P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar2P.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar2P.Location = new System.Drawing.Point(24, 78);
            this.txtBuscar2P.Name = "txtBuscar2P";
            this.txtBuscar2P.Size = new System.Drawing.Size(202, 19);
            this.txtBuscar2P.TabIndex = 38;
            this.txtBuscar2P.Text = "Buscar Provincias:";
            // 
            // btnRetornar2PO
            // 
            this.btnRetornar2PO.BackColor = System.Drawing.Color.White;
            this.btnRetornar2PO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRetornar2PO.FlatAppearance.BorderSize = 0;
            this.btnRetornar2PO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar2PO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornar2PO.ImageKey = "(ninguno)";
            this.btnRetornar2PO.Location = new System.Drawing.Point(344, 78);
            this.btnRetornar2PO.Name = "btnRetornar2PO";
            this.btnRetornar2PO.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.btnRetornar2PO.Size = new System.Drawing.Size(38, 32);
            this.btnRetornar2PO.TabIndex = 34;
            this.btnRetornar2PO.Tag = "";
            this.btnRetornar2PO.Text = "<=";
            this.btnRetornar2PO.UseVisualStyleBackColor = false;
            this.btnRetornar2PO.Click += new System.EventHandler(this.btnRetornar2PO_Click_1);
            // 
            // btnLupa2PO
            // 
            this.btnLupa2PO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLupa2PO.FlatAppearance.BorderSize = 0;
            this.btnLupa2PO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupa2PO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLupa2PO.ImageKey = "puntos3.png";
            this.btnLupa2PO.ImageList = this.imageList1;
            this.btnLupa2PO.Location = new System.Drawing.Point(270, 82);
            this.btnLupa2PO.Name = "btnLupa2PO";
            this.btnLupa2PO.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.btnLupa2PO.Size = new System.Drawing.Size(38, 32);
            this.btnLupa2PO.TabIndex = 33;
            this.btnLupa2PO.UseVisualStyleBackColor = true;
            this.btnLupa2PO.Click += new System.EventHandler(this.btnLupa2PO_Click);
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
            this.imageList1.Images.SetKeyName(5, "puntos3.png");
            // 
            // lblListadoMarcas
            // 
            this.lblListadoMarcas.AutoSize = true;
            this.lblListadoMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoMarcas.Location = new System.Drawing.Point(140, 18);
            this.lblListadoMarcas.Name = "lblListadoMarcas";
            this.lblListadoMarcas.Size = new System.Drawing.Size(179, 20);
            this.lblListadoMarcas.TabIndex = 11;
            this.lblListadoMarcas.Text = "Listado de Provincias";
            // 
            // Dgv_Provincias
            // 
            this.Dgv_Provincias.AllowUserToAddRows = false;
            this.Dgv_Provincias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive;
            this.Dgv_Provincias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Provincias.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Provincias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Provincias.ColumnHeadersHeight = 35;
            this.Dgv_Provincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Provincias.EnableHeadersVisualStyles = false;
            this.Dgv_Provincias.Location = new System.Drawing.Point(18, 120);
            this.Dgv_Provincias.Name = "Dgv_Provincias";
            this.Dgv_Provincias.ReadOnly = true;
            this.Dgv_Provincias.RowHeadersWidth = 62;
            this.Dgv_Provincias.RowTemplate.Height = 28;
            this.Dgv_Provincias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Provincias.Size = new System.Drawing.Size(364, 128);
            this.Dgv_Provincias.TabIndex = 10;
            this.Dgv_Provincias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Provincias_CellDoubleClick);
            this.Dgv_Provincias.DoubleClick += new System.EventHandler(this.Dgv_Provincias_DoubleClick);
            // 
            // btnLupaPO
            // 
            this.btnLupaPO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLupaPO.FlatAppearance.BorderSize = 0;
            this.btnLupaPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupaPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLupaPO.ImageKey = "puntos3.png";
            this.btnLupaPO.ImageList = this.imageList1;
            this.btnLupaPO.Location = new System.Drawing.Point(497, 89);
            this.btnLupaPO.Name = "btnLupaPO";
            this.btnLupaPO.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.btnLupaPO.Size = new System.Drawing.Size(38, 32);
            this.btnLupaPO.TabIndex = 35;
            this.btnLupaPO.UseVisualStyleBackColor = true;
            this.btnLupaPO.Click += new System.EventHandler(this.btnLupaPO_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(130, 110);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(350, 2);
            this.panel9.TabIndex = 34;
            // 
            // txtDescripcion_po
            // 
            this.txtDescripcion_po.BackColor = System.Drawing.Color.White;
            this.txtDescripcion_po.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion_po.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion_po.Location = new System.Drawing.Point(130, 89);
            this.txtDescripcion_po.MaxLength = 30;
            this.txtDescripcion_po.Name = "txtDescripcion_po";
            this.txtDescripcion_po.ReadOnly = true;
            this.txtDescripcion_po.Size = new System.Drawing.Size(364, 19);
            this.txtDescripcion_po.TabIndex = 33;
            this.txtDescripcion_po.Text = "Procincia (*)";
            // 
            // btnretornar
            // 
            this.btnretornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnretornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnretornar.ForeColor = System.Drawing.Color.Black;
            this.btnretornar.Location = new System.Drawing.Point(356, 209);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.Size = new System.Drawing.Size(87, 39);
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
            this.btnGuardar.Location = new System.Drawing.Point(249, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 39);
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
            this.btnCancelar.Location = new System.Drawing.Point(136, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 39);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(126, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 1);
            this.panel1.TabIndex = 10;
            // 
            // txtDescripcion_co
            // 
            this.txtDescripcion_co.BackColor = System.Drawing.Color.White;
            this.txtDescripcion_co.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion_co.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion_co.Location = new System.Drawing.Point(126, 136);
            this.txtDescripcion_co.Name = "txtDescripcion_co";
            this.txtDescripcion_co.ReadOnly = true;
            this.txtDescripcion_co.Size = new System.Drawing.Size(365, 19);
            this.txtDescripcion_co.TabIndex = 9;
            this.txtDescripcion_co.Text = "Cantones (*)";
            this.txtDescripcion_co.Enter += new System.EventHandler(this.txtDescripcion_ma_Enter);
            this.txtDescripcion_co.Leave += new System.EventHandler(this.txtDescripcion_ma_Leave);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.Black;
            this.btnnuevo.ImageKey = "newfile_85903.png";
            this.btnnuevo.ImageList = this.imageList1;
            this.btnnuevo.Location = new System.Drawing.Point(16, 436);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(95, 90);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.ImageKey = "edit_modify_icon_149489.png";
            this.btnactualizar.ImageList = this.imageList1;
            this.btnactualizar.Location = new System.Drawing.Point(108, 436);
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
            this.btneliminar.Location = new System.Drawing.Point(211, 436);
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
            this.btnreporte.Location = new System.Drawing.Point(299, 436);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(95, 90);
            this.btnreporte.TabIndex = 4;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreporte.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.ImageKey = "mbrilogout_99583 (1).png";
            this.btnsalir.ImageList = this.imageList1;
            this.btnsalir.Location = new System.Drawing.Point(391, 436);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(95, 90);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Frm_Cantones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(55)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1147, 679);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.Tb_Principal);
            this.Name = "Frm_Cantones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Frm_Cantones_Load_1);
            this.Tb_Principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Principal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlListadoProvincias.ResumeLayout(false);
            this.pnlListadoProvincias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Provincias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tb_Principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgv_Principal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCantones;
        private System.Windows.Forms.Panel Linea;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescripcion_co;
        private System.Windows.Forms.Button btnretornar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnLupaPO;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDescripcion_po;
        private System.Windows.Forms.Panel pnlListadoProvincias;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBuscar2P;
        private System.Windows.Forms.Button btnRetornar2PO;
        private System.Windows.Forms.Button btnLupa2PO;
        private System.Windows.Forms.Label lblListadoMarcas;
        private System.Windows.Forms.DataGridView Dgv_Provincias;
    }
}