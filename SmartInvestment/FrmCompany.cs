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
    public partial class FrmCompany : Form
    {
        public List<Company> companies { get; set; }
        public List<InvestmentCategory> InvestmentCategorys { get; set; }
        public List<Risk> Risks { get; set; }
        public List<Country> Countries { get; set; }
        public List<SectorsClass> Sectors { get; set; }

        private readonly DataAceess oAccess = new DataAceess();
        public FrmCompany()
        {
            companies = GetCompanies();
            InvestmentCategorys = GetInvestmentCategories();
            Risks = GetRisks();
            Countries = GetCountries();
            Sectors = GetSectors();
            InitializeComponent();
            fillCategoryCombo();
            fillRiskCombo();
            fillCountryCombo();
            fillSectorCombo();
        }
        private void fillCategoryCombo()
        {

            var list = this.InvestmentCategorys.Select(x => new //InvestmentCategorySelect
            {
                CategoryId = x.CategoryId,
                Category_Name = x.Category_Name
            }).ToList();

            list.Add(new //InvestmentCategorySelect
            {
                CategoryId = 0,
                Category_Name = "Select"
            });
            cmbBx_InvestmentCategories.DataSource = list.OrderBy(x => x.CategoryId).ToList();

            cmbBx_InvestmentCategories.DisplayMember = "Category_Name";
            cmbBx_InvestmentCategories.ValueMember = "CategoryId";
        }
        private void fillRiskCombo()
        {

            var list = this.Risks.Select(x => new 
            {
                Risk_Id = x.Risk_Id,
                Risk_Name = x.Risk_Name
            }).ToList();

            list.Add(new 
            {
                Risk_Id = 0,
                Risk_Name = "Select"
            });
            cmbBx_Risk.DataSource = list.OrderBy(x => x.Risk_Id).ToList();

            cmbBx_Risk.DisplayMember = "Risk_Name";
            cmbBx_Risk.ValueMember = "Risk_Id";
        }
        private void fillCountryCombo()
        {

            var list = this.Countries.Select(x => new
            {
                Country_Id = x.Country_Id,
                Country_Name = x.Country_Name
            }).ToList();

            list.Add(new
            {
                Country_Id = 0,
                Country_Name = "Select"
            });
            cmbBx_Country.DataSource = list.OrderBy(x => x.Country_Id).ToList();

            cmbBx_Country.DisplayMember = "Country_Name";
            cmbBx_Country.ValueMember = "Country_Id";
        }
        private void fillSectorCombo()
        {

            var list = this.Sectors.Select(x => new
            {
                Sector_Id = x.Sector_Id,
                Sector_Name = x.Sector_Name
            }).ToList();

            list.Add(new
            {
                Sector_Id = 0,
                Sector_Name = "Select"
            });
            cmbBx_Sector.DataSource = list.OrderBy(x => x.Sector_Id).ToList();

            cmbBx_Sector.DisplayMember = "Sector_Name";
            cmbBx_Sector.ValueMember = "Sector_Id";
        }
        private List<Company> GetCompanies()
        {
            var list = new List<Company>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetCompanies(), false);
            if (dtDs.Tables.Count > 0)
            {
                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    Company company = new Company();
                    company.Company_Id = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Company_Id"]);
                    company.Company_Name = dtDs.Tables[0].Rows[i]["Company_Name"].ToString();
                    company.Current_Stock_Value = Convert.ToDecimal(dtDs.Tables[0].Rows[i]["Stock_Value"]);
                    company.Prev_Month_Stock_Value = Convert.ToDecimal(dtDs.Tables[0].Rows[i]["Previous_Month_Stock_Value"]);
                    company.SectorName = dtDs.Tables[0].Rows[i]["Sector_Name"].ToString();
                    company.RiskName = dtDs.Tables[0].Rows[i]["Risk_Name"].ToString();
                    company.CountryName = dtDs.Tables[0].Rows[i]["Country_Name"].ToString();
                    company.CategoryName = dtDs.Tables[0].Rows[i]["Investment_Category_Name"].ToString();
                    company.CategoryId = Convert.ToInt32(dtDs.Tables[0].Rows[i]["CategoryId"]);
                    company.CountryId = Convert.ToInt32(dtDs.Tables[0].Rows[i]["CountryId"]);
                    company.SectorId = Convert.ToInt32(dtDs.Tables[0].Rows[i]["SectorId"]);
                    company.RiskId = Convert.ToInt32(dtDs.Tables[0].Rows[i]["RiskId"]);
                    list.Add(company);

                }

            }
            return list;
        }
        private List<InvestmentCategory> GetInvestmentCategories()
        {
            var list = new List<InvestmentCategory>();
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
        private List<Risk> GetRisks()
        {
            var list = new List<Risk>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetRisks(), false);
            if (dtDs.Tables.Count > 0)
            {
                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    Risk risk = new Risk();
                    risk.Risk_Id = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Risk_Id"]);
                    risk.Risk_Name = dtDs.Tables[0].Rows[i]["Risk_Name"].ToString();
                    risk.CreatedDate = Convert.ToDateTime(dtDs.Tables[0].Rows[i]["Created_Date"]);
                    list.Add(risk);

                }

            }

            return list;
        }
        private List<Country> GetCountries()
        {
            var list = new List<Country>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetCountries(), false);
            if (dtDs.Tables.Count > 0)
            {
                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    Country country = new Country();
                    country.Country_Id = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Country_Id"]);
                    country.Country_Name = dtDs.Tables[0].Rows[i]["Country_Name"].ToString();
                    country.Created_Date = Convert.ToDateTime(dtDs.Tables[0].Rows[i]["Created_Date"]);
                    list.Add(country);

                }

            }

            return list;
        }
        private List<SectorsClass> GetSectors()
        {
            var list = new List<SectorsClass>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetSectors(), false);
            if (dtDs.Tables.Count > 0)
            {
                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    SectorsClass sectors = new SectorsClass();
                    sectors.Sector_Id = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Sector_Id"]);
                    sectors.Sector_Name = dtDs.Tables[0].Rows[i]["Sector_Name"].ToString();
                    sectors.CreatedDate = Convert.ToDateTime(dtDs.Tables[0].Rows[i]["Created_Date"]);
                    list.Add(sectors);

                }

            }

            return list;
        }
        private void FrmCompany_Load(object sender, EventArgs e)
        {
            var companies = this.companies;
            dataGridView1.DataSource = companies;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    var selectedCompany = dataGridView1.SelectedRows[0].DataBoundItem as Company;
                    txtBx_CompanyId.Text = selectedCompany.Company_Id.ToString();
                    txtBx_Company_Name.Text = selectedCompany.Company_Name;
                    txtBx_Stock_Value.Text = selectedCompany.Current_Stock_Value.ToString();
                    txtBx_Previous_Stock_Value.Text = selectedCompany.Prev_Month_Stock_Value.ToString();
                    cmbBx_InvestmentCategories.SelectedItem = InvestmentCategorys.Find(x => x.CategoryId == selectedCompany.CategoryId);
                    cmbBx_Country.SelectedItem = Countries.Find(x => x.Country_Id == selectedCompany.CountryId);
                    cmbBx_Sector.SelectedItem = Sectors.Find(x => x.Sector_Id == selectedCompany.SectorId);
                    cmbBx_Risk.SelectedItem = Risks.Find(x => x.Risk_Id == selectedCompany.RiskId);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedCompany = dataGridView1.SelectedRows[0].DataBoundItem as Company;
                    txtBx_CompanyId.Text = selectedCompany.Company_Id.ToString();
                    txtBx_Company_Name.Text = selectedCompany.Company_Name;
                    txtBx_Stock_Value.Text = selectedCompany.Current_Stock_Value.ToString();
                    txtBx_Previous_Stock_Value.Text = selectedCompany.Prev_Month_Stock_Value.ToString();
                    cmbBx_InvestmentCategories.SelectedItem = new
                    {
                        CategoryId = selectedCompany.CategoryId,
                        Category_Name = InvestmentCategorys.Find(x=>x.CategoryId == selectedCompany.CategoryId).Category_Name
                    };
                    cmbBx_Country.SelectedItem = new
                    {
                        Country_Id = selectedCompany.CountryId,
                        Country_Name = Countries.Find(x => x.Country_Id == selectedCompany.CountryId).Country_Name
                    };
                    cmbBx_Sector.SelectedItem = new
                    {
                        Sector_Id = selectedCompany.SectorId,
                        Sector_Name = Sectors.Find(x => x.Sector_Id == selectedCompany.SectorId).Sector_Name
                    };
                    cmbBx_Risk.SelectedItem = new
                    {
                        Risk_Id = selectedCompany.RiskId,
                        Risk_Name = Risks.Find(x => x.Risk_Id == selectedCompany.RiskId).Risk_Name
                    };
                    bttn_Update.Visible = true;
                    bttnDelete.Visible = true;
                    bttnSave.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            EnableDisableClearForm(false);
            AddOrUpdateCompany();
        }
        private void AddOrUpdateCompany()
        {

            var company = new Company
            {
                Company_Name = txtBx_Company_Name.Text,
                Current_Stock_Value = Convert.ToDecimal(txtBx_Stock_Value.Text),
                Prev_Month_Stock_Value = Convert.ToDecimal(txtBx_Previous_Stock_Value.Text),
                CategoryId = Convert.ToInt32(cmbBx_InvestmentCategories.SelectedValue),
                SectorId = Convert.ToInt32(cmbBx_Sector.SelectedValue),
                CountryId = Convert.ToInt32(cmbBx_Country.SelectedValue),
                RiskId = Convert.ToInt32(cmbBx_Risk.SelectedValue)
            };
            if (!string.IsNullOrEmpty(txtBx_CompanyId.Text))
            {
                company.Company_Id = Convert.ToInt32(txtBx_CompanyId.Text);
            }
            
            try
            {
                var result = oAccess.executeSql(SqlQueries.AddOrUpdateCompany(company));
                this.companies = GetCompanies();
                dataGridView1.DataSource = this.companies;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void bttnAddNew_Click(object sender, EventArgs e)
        {
            EnableDisableClearForm(true);
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            AddOrUpdateCompany();
            EnableDisableClearForm(true);


        }
        private void EnableDisableClearForm(bool isSave)
        {
            bttnSave.Visible = isSave;
            bttn_Update.Visible = !isSave;
            bttnDelete.Visible = !isSave;

            if (isSave) 
            {
                txtBx_CompanyId.Text = "";
                txtBx_Company_Name.Text = "";
                txtBx_Stock_Value.Text = "";
                txtBx_Previous_Stock_Value.Text = "";
            }
            dataGridView1.Focus();
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBx_CompanyId.Text))
            {
                DeleteCompany(Convert.ToInt32(txtBx_CompanyId.Text));
                this.companies = GetCompanies();
                dataGridView1.DataSource = this.companies;
                MessageBox.Show("Deleted Success!");
            }
            else
                MessageBox.Show("Please select valid company!");
        }
        private void DeleteCompany(int id)
        {
            try
            {
               var result = oAccess.executeSql(SqlQueries.DeleteCompany(id));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
