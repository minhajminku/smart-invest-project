﻿using SmartInvestment.Database;
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

        public AdminLogin()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            DataAceess oAccess = new DataAceess();//sfirm_is is db name
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetUserByName_Password(this.txtBx_User_Name.Text,this.txtBx_Password.Text), false);

        }
    }
}
