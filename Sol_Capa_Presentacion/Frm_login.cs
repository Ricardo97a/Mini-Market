using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_Capa_Negocio;
using Sol_Capa_Datos;
using Sol_Capa_Entidades;

namespace Sol_Capa_Presentacion
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }
        #region "Mis Métodos"
        
        private void Login_us(string cLogin,string cPassword)
        {
            Frm_DashBoard das = new Frm_DashBoard();
            try
            {
                DataTable data_login = new DataTable();
                data_login =    N_Usuario.Login_us(cLogin, cPassword);
                if (data_login.Rows.Count>0)
                {
                    string cNombres="";
                    string cCargo = "";
                    bool bAdmin = false;

                    cNombres =Convert.ToString(data_login.Rows[0][3]);
                    cCargo= Convert.ToString(data_login.Rows[0][4]);
                    bAdmin = Convert.ToBoolean(data_login.Rows[0][5]);

                    Frm_DashBoard oDashBoard = new Frm_DashBoard();
                    oDashBoard.Lbl_nombres_us.Text = "Nombres: " + cNombres;
                    oDashBoard.Lbl_cargo.Text = "Cargo: " + cCargo;
                    oDashBoard.Chk_admin.Checked = bAdmin;

                    if (bAdmin==true) //Administrador
                    {
                        oDashBoard.Btn_procesos.Enabled = true;
                        oDashBoard.Btn_reportes.Enabled = true;
                        oDashBoard.Btn_datosmaestros.Enabled = true;
                        oDashBoard.Btn_sistemas.Enabled = true;
                    }
                    else // Usuario normal
                    {
                        oDashBoard.Btn_procesos.Enabled = true;
                        oDashBoard.Btn_reportes.Enabled = true;
                        oDashBoard.Btn_datosmaestros.Enabled = false;
                        oDashBoard.Btn_sistemas.Enabled = false;
                    }

                    oDashBoard.Show();
                    oDashBoard.FormClosed += Logout;
                    das.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Password o Usuario incorrecto", "Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            Txt_login_us.Text = "";
            Txt_password_us.Text = "";
            this.Show();
            Txt_login_us.Focus();
        }

        #endregion

        private void Btn_iniciar_Click(object sender, EventArgs e)
        {
            this.Login_us(Txt_login_us.Text,Txt_password_us.Text);
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
