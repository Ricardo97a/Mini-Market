
namespace Sol_Capa_Presentacion.Usuarios
{
    partial class Frm_Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            this.Tb_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_buscar_um = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_buscar_um = new System.Windows.Forms.TextBox();
            this.Dgv_Principal = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ckb_adm = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Pnl_datos = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_login_us = new System.Windows.Forms.TextBox();
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
            this.Pnl_datos.SuspendLayout();
            this.Pnl_SubOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Principal
            // 
            this.Tb_Principal.Controls.Add(this.tabPage1);
            this.Tb_Principal.Controls.Add(this.tabPage2);
            this.Tb_Principal.Location = new System.Drawing.Point(13, 82);
            this.Tb_Principal.Name = "Tb_Principal";
            this.Tb_Principal.SelectedIndex = 0;
            this.Tb_Principal.Size = new System.Drawing.Size(1059, 424);
            this.Tb_Principal.TabIndex = 0;
            this.Tb_Principal.Selected += new System.Windows.Forms.TabControlEventHandler(this.Tb_Principal_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btn_buscar_um);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txt_buscar_um);
            this.tabPage1.Controls.Add(this.Dgv_Principal);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // btn_buscar_um
            // 
            this.btn_buscar_um.BackColor = System.Drawing.Color.White;
            this.btn_buscar_um.FlatAppearance.BorderSize = 0;
            this.btn_buscar_um.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_um.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_buscar_um.IconColor = System.Drawing.Color.Black;
            this.btn_buscar_um.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscar_um.Location = new System.Drawing.Point(506, 57);
            this.btn_buscar_um.Name = "btn_buscar_um";
            this.btn_buscar_um.Size = new System.Drawing.Size(51, 40);
            this.btn_buscar_um.TabIndex = 109;
            this.btn_buscar_um.UseVisualStyleBackColor = false;
            this.btn_buscar_um.Click += new System.EventHandler(this.btn_buscar_um_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Buscar:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(257, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 1);
            this.panel1.TabIndex = 12;
            // 
            // txt_buscar_um
            // 
            this.txt_buscar_um.BackColor = System.Drawing.Color.White;
            this.txt_buscar_um.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar_um.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_um.ForeColor = System.Drawing.Color.Black;
            this.txt_buscar_um.Location = new System.Drawing.Point(257, 48);
            this.txt_buscar_um.Multiline = true;
            this.txt_buscar_um.Name = "txt_buscar_um";
            this.txt_buscar_um.Size = new System.Drawing.Size(237, 35);
            this.txt_buscar_um.TabIndex = 11;
            // 
            // Dgv_Principal
            // 
            this.Dgv_Principal.AllowUserToAddRows = false;
            this.Dgv_Principal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive;
            this.Dgv_Principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Principal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Principal.ColumnHeadersHeight = 35;
            this.Dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Principal.EnableHeadersVisualStyles = false;
            this.Dgv_Principal.Location = new System.Drawing.Point(114, 100);
            this.Dgv_Principal.Name = "Dgv_Principal";
            this.Dgv_Principal.ReadOnly = true;
            this.Dgv_Principal.RowHeadersWidth = 62;
            this.Dgv_Principal.RowTemplate.Height = 28;
            this.Dgv_Principal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Principal.Size = new System.Drawing.Size(572, 212);
            this.Dgv_Principal.TabIndex = 3;
            this.Dgv_Principal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Principal_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.ckb_adm);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.txt_cargo);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.txt_nombre);
            this.tabPage2.Controls.Add(this.Pnl_datos);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.txt_password);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.txt_login_us);
            this.tabPage2.Controls.Add(this.btnretornar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // ckb_adm
            // 
            this.ckb_adm.AutoSize = true;
            this.ckb_adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_adm.Location = new System.Drawing.Point(358, 234);
            this.ckb_adm.Name = "ckb_adm";
            this.ckb_adm.Size = new System.Drawing.Size(217, 36);
            this.ckb_adm.TabIndex = 27;
            this.ckb_adm.Text = "Administrador";
            this.ckb_adm.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(414, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 1);
            this.panel2.TabIndex = 26;
            // 
            // txt_cargo
            // 
            this.txt_cargo.BackColor = System.Drawing.Color.White;
            this.txt_cargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo.ForeColor = System.Drawing.Color.Black;
            this.txt_cargo.Location = new System.Drawing.Point(409, 173);
            this.txt_cargo.Multiline = true;
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(262, 35);
            this.txt_cargo.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(413, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 1);
            this.panel5.TabIndex = 24;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(413, 131);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(267, 35);
            this.txt_nombre.TabIndex = 23;
            // 
            // Pnl_datos
            // 
            this.Pnl_datos.BackColor = System.Drawing.Color.White;
            this.Pnl_datos.Controls.Add(this.label5);
            this.Pnl_datos.Controls.Add(this.label4);
            this.Pnl_datos.Controls.Add(this.label1);
            this.Pnl_datos.Controls.Add(this.label2);
            this.Pnl_datos.Location = new System.Drawing.Point(96, 25);
            this.Pnl_datos.Name = "Pnl_datos";
            this.Pnl_datos.Size = new System.Drawing.Size(305, 199);
            this.Pnl_datos.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 46);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cargo(*):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 46);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nombre (*):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "Password (*):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 44);
            this.label2.TabIndex = 23;
            this.label2.Text = "Login (*):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(409, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 1);
            this.panel4.TabIndex = 21;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(404, 79);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(262, 35);
            this.txt_password.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(405, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 1);
            this.panel3.TabIndex = 18;
            // 
            // txt_login_us
            // 
            this.txt_login_us.BackColor = System.Drawing.Color.White;
            this.txt_login_us.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_login_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_us.ForeColor = System.Drawing.Color.Black;
            this.txt_login_us.Location = new System.Drawing.Point(405, 34);
            this.txt_login_us.Multiline = true;
            this.txt_login_us.Name = "txt_login_us";
            this.txt_login_us.Size = new System.Drawing.Size(267, 35);
            this.txt_login_us.TabIndex = 17;
            // 
            // btnretornar
            // 
            this.btnretornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnretornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnretornar.ForeColor = System.Drawing.Color.Black;
            this.btnretornar.Location = new System.Drawing.Point(469, 307);
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
            this.btnGuardar.Location = new System.Drawing.Point(340, 307);
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
            this.btnCancelar.Location = new System.Drawing.Point(214, 307);
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
            this.btnnuevo.Location = new System.Drawing.Point(12, 528);
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
            this.btnactualizar.Location = new System.Drawing.Point(104, 528);
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
            this.btneliminar.Location = new System.Drawing.Point(211, 528);
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
            this.btnreporte.Location = new System.Drawing.Point(304, 528);
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
            this.btnsalir.Location = new System.Drawing.Point(396, 528);
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
            this.Pnl_SubOpcion.Size = new System.Drawing.Size(1127, 72);
            this.Pnl_SubOpcion.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(337, 66);
            this.label10.TabIndex = 0;
            this.label10.Text = "USUARIOS DE SISTEMAS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 629);
            this.Controls.Add(this.Pnl_SubOpcion);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.Tb_Principal);
            this.Name = "Frm_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.Frm_Unidades_Medidas_Load);
            this.Tb_Principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Principal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_login_us;
        private System.Windows.Forms.Panel Pnl_datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_buscar_um;
        private System.Windows.Forms.Panel Pnl_SubOpcion;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btn_buscar_um;
        private System.Windows.Forms.CheckBox ckb_adm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}