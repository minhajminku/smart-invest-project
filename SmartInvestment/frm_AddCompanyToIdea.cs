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
    public partial class frm_AddCompanyToIdea : Form
    {
        public List<Company> CompanyList { get; set; }
        private readonly DataAceess oAccess;
        private int IdeaId { get; set; }
        public frm_AddCompanyToIdea(int IdeaId)
        {
            oAccess = new DataAceess();
            this.IdeaId = IdeaId;
            InitializeComponent();
            loadCompanyList();
        }
        private void loadCompanyList()
        {
            this.CompanyList = getCompanyList();
            datagrid_Companies.DataSource = CompanyList;
        }
        private List<Company> getCompanyList()
        {
            var list = new List<Company>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetCompanyList(null, this.IdeaId), false);
            if (dtDs.Tables.Count > 0)
            {

                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    Company company = new Company();
                    company.Company_Id = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Company_Id"]);
                    company.Company_Name = dtDs.Tables[0].Rows[i]["Company_Name"].ToString();
                    company.Current_Stock_Value =Convert.ToDecimal(dtDs.Tables[0].Rows[i]["Stock_Value"]);
                    company.Prev_Month_Stock_Value = Convert.ToDecimal(dtDs.Tables[0].Rows[i]["Previous_Month_Stock_Value"]);
                    company.RiskName = dtDs.Tables[0].Rows[i]["Risk_Name"].ToString();
                    company.CategoryName = dtDs.Tables[0].Rows[i]["Investment_Category_Name"].ToString();
                    company.SectorName = dtDs.Tables[0].Rows[i]["Sector_Name"].ToString();
                    company.CountryName = dtDs.Tables[0].Rows[i]["Country_Name"].ToString();
                    company.IsSelected = Convert.ToBoolean(dtDs.Tables[0].Rows[i]["IsSelected"]);
                    list.Add(company);

                }

            }

            return list;
        }

        private void bttnSaveToIdea_Click(object sender, EventArgs e)
        {
            SaveCompaniesToIdea();
        }
        private void SaveCompaniesToIdea()
        {
            var ideaCompany = new IdeaCompany();
            ideaCompany.IdeaId = this.IdeaId;
            ideaCompany.CompanyIds = new List<int>();
            try
            {
                foreach (DataGridViewRow row in datagrid_Companies.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[8].Value))
                    {
                        ideaCompany.CompanyIds.Add(Convert.ToInt32(row.Cells[0].Value));

                    }
                }
                oAccess.executeSql(SqlQueries.DeleteCompaniesFromIdea(IdeaId));
                oAccess.executeSql(SqlQueries.AddCompaniesToIdea(ideaCompany));
                MessageBox.Show("Companies Added to Idea");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
