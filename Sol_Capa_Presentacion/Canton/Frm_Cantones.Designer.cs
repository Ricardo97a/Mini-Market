
namespace Sol_Capa_Presentacion.Canto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cantones));
            this.Tb_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label19 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtBuscar_Canton = new System.Windows.Forms.TextBox();
            this.Dgv_Principal = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlListadoProvincias = new System.Windows.Forms.Panel();
            this.btnRetornar2PO = new FontAwesome.Sharp.IconButton();
            this.btnLupa2PO = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBuscar2P = new System.Windows.Forms.TextBox();
            this.lblListadoMarcas = new System.Windows.Forms.Label();
            this.Dgv_Provincias = new System.Windows.Forms.DataGridView();
            this.btnLupa_provincia = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripcion_co = new System.Windows.Forms.TextBox();
            this.Pnl_datos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescripcion_pr = new System.Windows.Forms.TextBox();
            this.btnretornar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnnuevo = new System.Windows.Forms.Button();
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
            this.pnlListadoProvincias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Provincias)).BeginInit();
            this.Pnl_datos.SuspendLayout();
            this.Pnl_SubOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Principal
            // 
            this.Tb_Principal.Controls.Add(this.tabPage1);
            this.Tb_Principal.Controls.Add(this.tabPage2);
            this.Tb_Principal.Location = new System.Drawing.Point(8, 88);
            this.Tb_Principal.Name = "Tb_Principal";
            this.Tb_Principal.SelectedIndex = 0;
            this.Tb_Principal.Size = new System.Drawing.Size(919, 371);
            this.Tb_Principal.TabIndex = 0;
            this.Tb_Principal.Selected += new System.Windows.Forms.TabControlEventHandler(this.Tb_Principal_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.iconButton1);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.panel17);
            this.tabPage1.Controls.Add(this.txtBuscar_Canton);
            this.tabPage1.Controls.Add(this.Dgv_Principal);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(508, 29);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(51, 40);
            this.iconButton1.TabIndex = 108;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(142, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 30);
            this.label19.TabIndex = 92;
            this.label19.Text = "Buscar:";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Black;
            this.panel17.Location = new System.Drawing.Point(259, 50);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(240, 1);
            this.panel17.TabIndex = 91;
            // 
            // txtBuscar_Canton
            // 
            this.txtBuscar_Canton.BackColor = System.Drawing.Color.White;
            this.txtBuscar_Canton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Canton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_Canton.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar_Canton.Location = new System.Drawing.Point(259, 20);
            this.txtBuscar_Canton.Multiline = true;
            this.txtBuscar_Canton.Name = "txtBuscar_Canton";
            this.txtBuscar_Canton.Size = new System.Drawing.Size(240, 35);
            this.txtBuscar_Canton.TabIndex = 90;
            this.txtBuscar_Canton.Enter += new System.EventHandler(this.txtBuscar_Canton_Enter);
            // 
            // Dgv_Principal
            // 
            this.Dgv_Principal.AllowUserToAddRows = false;
            this.Dgv_Principal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Olive;
            this.Dgv_Principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Dgv_Principal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Dgv_Principal.ColumnHeadersHeight = 55;
            this.Dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Principal.EnableHeadersVisualStyles = false;
            this.Dgv_Principal.Location = new System.Drawing.Point(31, 77);
            this.Dgv_Principal.Name = "Dgv_Principal";
            this.Dgv_Principal.ReadOnly = true;
            this.Dgv_Principal.RowHeadersWidth = 62;
            this.Dgv_Principal.RowTemplate.Height = 50;
            this.Dgv_Principal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Principal.Size = new System.Drawing.Size(750, 234);
            this.Dgv_Principal.TabIndex = 3;
            this.Dgv_Principal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Principal_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pnlListadoProvincias);
            this.tabPage2.Controls.Add(this.btnLupa_provincia);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.txtDescripcion_co);
            this.tabPage2.Controls.Add(this.Pnl_datos);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.txtDescripcion_pr);
            this.tabPage2.Controls.Add(this.btnretornar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // pnlListadoProvincias
            // 
            this.pnlListadoProvincias.BackColor = System.Drawing.Color.White;
            this.pnlListadoProvincias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListadoProvincias.Controls.Add(this.btnRetornar2PO);
            this.pnlListadoProvincias.Controls.Add(this.btnLupa2PO);
            this.pnlListadoProvincias.Controls.Add(this.panel7);
            this.pnlListadoProvincias.Controls.Add(this.txtBuscar2P);
            this.pnlListadoProvincias.Controls.Add(this.lblListadoMarcas);
            this.pnlListadoProvincias.Controls.Add(this.Dgv_Provincias);
            this.pnlListadoProvincias.Location = new System.Drawing.Point(490, 308);
            this.pnlListadoProvincias.Name = "pnlListadoProvincias";
            this.pnlListadoProvincias.Size = new System.Drawing.Size(437, 318);
            this.pnlListadoProvincias.TabIndex = 36;
            this.pnlListadoProvincias.Visible = false;
            // 
            // btnRetornar2PO
            // 
            this.btnRetornar2PO.BackColor = System.Drawing.Color.Orange;
            this.btnRetornar2PO.FlatAppearance.BorderSize = 0;
            this.btnRetornar2PO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar2PO.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnRetornar2PO.IconColor = System.Drawing.Color.Black;
            this.btnRetornar2PO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRetornar2PO.Location = new System.Drawing.Point(350, 2);
            this.btnRetornar2PO.Name = "btnRetornar2PO";
            this.btnRetornar2PO.Size = new System.Drawing.Size(51, 35);
            this.btnRetornar2PO.TabIndex = 99;
            this.btnRetornar2PO.UseVisualStyleBackColor = false;
            this.btnRetornar2PO.Click += new System.EventHandler(this.btnRetornar2PO_Click);
            // 
            // btnLupa2PO
            // 
            this.btnLupa2PO.BackColor = System.Drawing.Color.White;
            this.btnLupa2PO.FlatAppearance.BorderSize = 0;
            this.btnLupa2PO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupa2PO.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnLupa2PO.IconColor = System.Drawing.Color.Black;
            this.btnLupa2PO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLupa2PO.Location = new System.Drawing.Point(251, 74);
            this.btnLupa2PO.Name = "btnLupa2PO";
            this.btnLupa2PO.Size = new System.Drawing.Size(51, 40);
            this.btnLupa2PO.TabIndex = 98;
            this.btnLupa2PO.UseVisualStyleBackColor = false;
            this.btnLupa2PO.Click += new System.EventHandler(this.btnLupa2PO_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(20, 97);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 2);
            this.panel7.TabIndex = 39;
            // 
            // txtBuscar2P
            // 
            this.txtBuscar2P.BackColor = System.Drawing.Color.White;
            this.txtBuscar2P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar2P.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar2P.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar2P.Location = new System.Drawing.Point(25, 55);
            this.txtBuscar2P.Multiline = true;
            this.txtBuscar2P.Name = "txtBuscar2P";
            this.txtBuscar2P.Size = new System.Drawing.Size(217, 45);
            this.txtBuscar2P.TabIndex = 38;
            this.txtBuscar2P.Text = "Buscar";
            this.txtBuscar2P.Click += new System.EventHandler(this.txtBuscar2P_Click);
            // 
            // lblListadoMarcas
            // 
            this.lblListadoMarcas.BackColor = System.Drawing.Color.Orange;
            this.lblListadoMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListadoMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoMarcas.Location = new System.Drawing.Point(0, 0);
            this.lblListadoMarcas.Name = "lblListadoMarcas";
            this.lblListadoMarcas.Size = new System.Drawing.Size(435, 39);
            this.lblListadoMarcas.TabIndex = 11;
            this.lblListadoMarcas.Text = "Listado de Provincias";
            this.lblListadoMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dgv_Provincias
            // 
            this.Dgv_Provincias.AllowUserToAddRows = false;
            this.Dgv_Provincias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Olive;
            this.Dgv_Provincias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Dgv_Provincias.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Provincias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Dgv_Provincias.ColumnHeadersHeight = 55;
            this.Dgv_Provincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Provincias.EnableHeadersVisualStyles = false;
            this.Dgv_Provincias.Location = new System.Drawing.Point(18, 120);
            this.Dgv_Provincias.Name = "Dgv_Provincias";
            this.Dgv_Provincias.ReadOnly = true;
            this.Dgv_Provincias.RowHeadersWidth = 62;
            this.Dgv_Provincias.RowTemplate.Height = 50;
            this.Dgv_Provincias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Provincias.Size = new System.Drawing.Size(383, 173);
            this.Dgv_Provincias.TabIndex = 10;
            this.Dgv_Provincias.DoubleClick += new System.EventHandler(this.Dgv_Provincias_DoubleClick);
            // 
            // btnLupa_provincia
            // 
            this.btnLupa_provincia.BackColor = System.Drawing.Color.White;
            this.btnLupa_provincia.FlatAppearance.BorderSize = 0;
            this.btnLupa_provincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupa_provincia.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnLupa_provincia.IconColor = System.Drawing.Color.Black;
            this.btnLupa_provincia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLupa_provincia.Location = new System.Drawing.Point(464, 71);
            this.btnLupa_provincia.Name = "btnLupa_provincia";
            this.btnLupa_provincia.Size = new System.Drawing.Size(51, 40);
            this.btnLupa_provincia.TabIndex = 97;
            this.btnLupa_provincia.UseVisualStyleBackColor = false;
            this.btnLupa_provincia.Click += new System.EventHandler(this.btnLupa_provincia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(240, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 1);
            this.panel1.TabIndex = 96;
            // 
            // txtDescripcion_co
            // 
            this.txtDescripcion_co.BackColor = System.Drawing.Color.White;
            this.txtDescripcion_co.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion_co.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion_co.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion_co.Location = new System.Drawing.Point(240, 112);
            this.txtDescripcion_co.Multiline = true;
            this.txtDescripcion_co.Name = "txtDescripcion_co";
            this.txtDescripcion_co.Size = new System.Drawing.Size(218, 35);
            this.txtDescripcion_co.TabIndex = 95;
            // 
            // Pnl_datos
            // 
            this.Pnl_datos.BackColor = System.Drawing.Color.White;
            this.Pnl_datos.Controls.Add(this.label2);
            this.Pnl_datos.Controls.Add(this.label1);
            this.Pnl_datos.Location = new System.Drawing.Point(44, 63);
            this.Pnl_datos.Name = "Pnl_datos";
            this.Pnl_datos.Size = new System.Drawing.Size(190, 79);
            this.Pnl_datos.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 60);
            this.label2.TabIndex = 90;
            this.label2.Text = "Canton (*):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 89;
            this.label1.Text = "Provincia (*):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(240, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 1);
            this.panel2.TabIndex = 94;
            // 
            // txtDescripcion_pr
            // 
            this.txtDescripcion_pr.BackColor = System.Drawing.Color.White;
            this.txtDescripcion_pr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion_pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion_pr.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion_pr.Location = new System.Drawing.Point(240, 65);
            this.txtDescripcion_pr.Multiline = true;
            this.txtDescripcion_pr.Name = "txtDescripcion_pr";
            this.txtDescripcion_pr.Size = new System.Drawing.Size(218, 35);
            this.txtDescripcion_pr.TabIndex = 93;
            // 
            // btnretornar
            // 
            this.btnretornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnretornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnretornar.ForeColor = System.Drawing.Color.Black;
            this.btnretornar.Location = new System.Drawing.Point(326, 206);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.Size = new System.Drawing.Size(115, 39);
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
            this.btnGuardar.Location = new System.Drawing.Point(196, 206);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 39);
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
            this.btnCancelar.Location = new System.Drawing.Point(70, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 39);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.Black;
            this.btnnuevo.ImageKey = "newfile_85903.png";
            this.btnnuevo.ImageList = this.imageList1;
            this.btnnuevo.Location = new System.Drawing.Point(9, 465);
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
            this.btnactualizar.Location = new System.Drawing.Point(101, 465);
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
            this.btneliminar.Location = new System.Drawing.Point(204, 465);
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
            this.btnreporte.Location = new System.Drawing.Point(292, 465);
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
            this.btnsalir.Location = new System.Drawing.Point(384, 465);
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
            this.Pnl_SubOpcion.Size = new System.Drawing.Size(939, 72);
            this.Pnl_SubOpcion.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 72);
            this.label10.TabIndex = 0;
            this.label10.Text = "CANTONES";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Cantones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 567);
            this.Controls.Add(this.Pnl_SubOpcion);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.Tb_Principal);
            this.Name = "Frm_Cantones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CANTONES";
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
            this.Pnl_datos.ResumeLayout(false);
            this.Pnl_SubOpcion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tb_Principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgv_Principal;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnretornar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlListadoProvincias;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBuscar2P;
        private System.Windows.Forms.Label lblListadoMarcas;
        private System.Windows.Forms.DataGridView Dgv_Provincias;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtBuscar_Canton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescripcion_co;
        private System.Windows.Forms.Panel Pnl_datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescripcion_pr;
        private FontAwesome.Sharp.IconButton btnLupa_provincia;
        private System.Windows.Forms.Panel Pnl_SubOpcion;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnLupa2PO;
        private FontAwesome.Sharp.IconButton btnRetornar2PO;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}