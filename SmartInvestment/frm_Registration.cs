using SmartInvestment.Database;
using SmartInvestment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SmartInvestment
{
    public partial class frm_Registration : Form
    {
        private readonly DataAceess oAccess;
        public frm_Registration()
        {
            oAccess = new DataAceess();
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetUserByName_Password(this.txtBx_User_Name.Text,this.txtBx_Password.Text), false);
            if (dtDs.Tables[0].Rows.Count > 0 )
            {
                frm_MDI_Container frm = new frm_MDI_Container();
                frm.ShowDialog();
                Close();

            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetUserBy_UserName(this.txtBx_User_Name.Text), false);
            if (dtDs.Tables[0].Rows.Count > 0)
            {
                label_error.Text = "User name already exist!";
                label_error.Visible = true;
            }
            else if (String.IsNullOrEmpty(txtBx_Password.Text) || String.IsNullOrEmpty(txtBx_ConfirmPassword.Text) || String.IsNullOrEmpty(txtBx_User_Name.Text)
                || String.IsNullOrEmpty(text_FirstName.Text) || String.IsNullOrEmpty(text_LastName.Text))
            {
                label_error.Text = "Any of the feilds cannot be empty!";
                label_error.Visible = true;
            }
            else if (txtBx_Password.Text.ToLower() != txtBx_ConfirmPassword.Text.ToLower())
            {
                label_error.Text = "Passwords are not matching!";
                label_error.Visible = true;
            }
            else
            {
                AddUser();
                label_sucess.Visible = true;
                btn_goLogin.Visible = true;
                btn_register.Visible = false;
            }
        }
        private void AddUser()
        {

            var user = new Users
            {
                First_Name = text_FirstName.Text,
                Last_Name = text_LastName.Text,
                User_Name = txtBx_User_Name.Text,
                Email = txtBx_Email.Text,
                Password = txtBx_Password.Text
            };
            try
            {
                var result = oAccess.executeSql(SqlQueries.Adduser(user));
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btn_goLogin_Click(object sender, EventArgs e)
        {
            AdminLogin frm = new AdminLogin();
            frm.Show();
            this.Hide();
        }
    }
}
