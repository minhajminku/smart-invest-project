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
    public partial class frm_Investment : Form
    {
        public List<ClientSelect> ClientSelectList { get; set; }
        public List<InvestmentIdeaSelect> InvestmentIdeasList { get; set; }
        public List<Company> CompanyList { get; set; }

        private readonly DataAceess oAccess;
        public frm_Investment()
        {
            oAccess = new DataAceess();
            InitializeComponent();
        }
        private void bttnSearch_Click(object sender, EventArgs e)
        {
            loadInvestmentCompanyList();
        }
        private void loadInvestmentCompanyList()
        {
            if (cmbxSearchBy.SelectedIndex == 0)
            {
                this.CompanyList = getCompanyListByIdea();
            }
            else if (cmbxSearchBy.SelectedIndex == 1)
            {
                this.CompanyList = getCompanyListByClient();
            }
            datagrdInvestmentData.DataSource = CompanyList;
        }
        private List<Company> getCompanyListByIdea()
        {
            var list = new List<Company>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetCompanyListSearchByIdeaId(Convert.ToInt32(cmbxSearchBySub.SelectedValue)), false);
            if (dtDs.Tables.Count > 0)
            {

                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    Company company = new Company();
                    company.Company_Id = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Company_Id"]);
                    company.Company_Name = dtDs.Tables[0].Rows[i]["Company_Name"].ToString();
                    company.Current_Stock_Value = Convert.ToDecimal(dtDs.Tables[0].Rows[i]["Stock_Value"]);
                    company.Prev_Month_Stock_Value = Convert.ToDecimal(dtDs.Tables[0].Rows[i]["Previous_Month_Stock_Value"]);
                    company.RiskName = dtDs.Tables[0].Rows[i]["Risk_Name"].ToString();
                    company.CategoryName = dtDs.Tables[0].Rows[i]["Investment_Category_Name"].ToString();
                    company.SectorName = dtDs.Tables[0].Rows[i]["Sector_Name"].ToString();
                    company.CountryName = dtDs.Tables[0].Rows[i]["Country_Name"].ToString();
                    //company.IsSelected = Convert.ToBoolean(dtDs.Tables[0].Rows[i]["IsSelected"]);
                    list.Add(company);

                }

            }

            return list;
        }
        private List<Company> getCompanyListByClient()
        {
            var list = new List<Company>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetCompanyListSearchByClientId(Convert.ToInt32(cmbxSearchBySub.SelectedValue)), false);
            if (dtDs.Tables.Count > 0)
            {

                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    Company company = new Company();
                    company.Company_Id = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Company_Id"]);
                    company.Company_Name = dtDs.Tables[0].Rows[i]["Company_Name"].ToString();
                    company.Current_Stock_Value = Convert.ToDecimal(dtDs.Tables[0].Rows[i]["Stock_Value"]);
                    company.Prev_Month_Stock_Value = Convert.ToDecimal(dtDs.Tables[0].Rows[i]["Previous_Month_Stock_Value"]);
                    company.RiskName = dtDs.Tables[0].Rows[i]["Risk_Name"].ToString();
                    company.CategoryName = dtDs.Tables[0].Rows[i]["Investment_Category_Name"].ToString();
                    company.SectorName = dtDs.Tables[0].Rows[i]["Sector_Name"].ToString();
                    company.CountryName = dtDs.Tables[0].Rows[i]["Country_Name"].ToString();
                    //company.IsSelected = Convert.ToBoolean(dtDs.Tables[0].Rows[i]["IsSelected"]);
                    list.Add(company);

                }

            }

            return list;
        }
        private List<ClientSelect> loadClientList()
        {
            var list = new List<ClientSelect>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetClients(), false);
            if (dtDs.Tables.Count > 0)
            {

                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    ClientSelect client = new ClientSelect();
                    client.ClientId = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Client_Id"]);
                    client.Client_Name = dtDs.Tables[0].Rows[i]["Client_First_Name"].ToString()+" "+
                        dtDs.Tables[0].Rows[i]["Client_Last_Name"].ToString();
                    list.Add(client);
                }

            }

            return list;
        }
        private List<InvestmentIdeaSelect> loadIdeaList()
        {
            var list = new List<InvestmentIdeaSelect>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetInvestmentIdeas(), false);
            if (dtDs.Tables.Count > 0)
            {
                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    InvestmentIdeaSelect idea = new InvestmentIdeaSelect();
                    idea.IdeaId = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Investment_Idea_Id"]);
                    idea.Idea_Name = dtDs.Tables[0].Rows[i]["Investment_Idea_Name"].ToString();
                    
                    list.Add(idea);

                }

            }
            return list;
        }
        private void cmbxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagrdInvestmentData.DataSource = null;
            if(cmbxSearchBy.SelectedIndex == 0)
            {
                this.InvestmentIdeasList = loadIdeaList();
                cmbxSearchBySub.DataSource = this.InvestmentIdeasList;
                cmbxSearchBySub.DisplayMember = "Idea_Name";
                cmbxSearchBySub.ValueMember = "IdeaId";
            }
            else if(cmbxSearchBy.SelectedIndex == 1)
            {
                this.ClientSelectList = loadClientList();
                cmbxSearchBySub.DataSource = this.ClientSelectList;
                cmbxSearchBySub.DisplayMember = "Client_Name";
                cmbxSearchBySub.ValueMember = "ClientId";
            }
        }
    }
}
