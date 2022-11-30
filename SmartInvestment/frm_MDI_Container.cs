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
    public partial class frm_MDI_Container : Form
    {
        public frm_MDI_Container()
        {
            InitializeComponent();
        }

        private void bttn_Client_Click(object sender, EventArgs e)
        {
            FrmClient frm = new FrmClient();
            frm.MdiParent = frm_MDI_Container.ActiveForm;
            frm.Show();
        }

        private void bttn_investmentCategories_Click(object sender, EventArgs e)
        {
            FrmInvestmentCategory frm = new FrmInvestmentCategory();
            frm.MdiParent = frm_MDI_Container.ActiveForm;
            frm.Show();
        }

        private void bttn_Ideas_Click(object sender, EventArgs e)
        {
            FrmInvestmentIdea frm = new FrmInvestmentIdea();
            frm.MdiParent = frm_MDI_Container.ActiveForm;
            frm.Show();
        }

        private void bttnInvestment_Click(object sender, EventArgs e)
        {
            frm_Investment frm = new frm_Investment();
            frm.Show();
        }
    }
}
