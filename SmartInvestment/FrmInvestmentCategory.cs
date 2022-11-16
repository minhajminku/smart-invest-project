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
    public partial class FrmInvestmentCategory : Form
    {
        public List<InvestmentCategory> InvestmentCategorys { get; set; }
        public FrmInvestmentCategory()
        {
            InvestmentCategorys = GetInvestmentCategories();
            InitializeComponent();
        }

        private List<InvestmentCategory> GetInvestmentCategories()
        {
            var list = new List<InvestmentCategory>();
            DataAceess oAccess = new DataAceess();//sfirm_is is db name
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetInvestmentCategories(), false);
            if (dtDs.Tables.Count > 0)
            {
                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    InvestmentCategory category = new InvestmentCategory();
                    category.CategoryId = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Investment_Category_Id"]);
                    category.Category_Name = dtDs.Tables[0].Rows[i]["Investment_Category_Name"].ToString();
                    category.CreatedDate = Convert.ToDateTime(dtDs.Tables[0].Rows[i]["Created_Date"]);
                    list.Add(category);

                }
                
            }
            return list;
        }
        private void FrmInvestmentCategory_Load(object sender, EventArgs e)
        {
            var InvestCategories = this.InvestmentCategorys;
            dataGridView1.DataSource = InvestCategories;
        }
    }
}
