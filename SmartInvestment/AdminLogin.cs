using SmartInvestment.Database;
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
    public partial class AdminLogin : Form
    {
        private readonly DataAceess oAccess = new DataAceess();
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetUserByName_Password(this.txtBx_User_Name.Text,this.txtBx_Password.Text), false);
            if (dtDs.Tables[0].Rows.Count > 0 )
            {
                frm_MDI_Container frm = new frm_MDI_Container();
                frm.ShowDialog();
                label_wrong_cred.Visible = false;
                Close();

            }
            else
                label_wrong_cred.Visible = true;

           
        }
    }
}
