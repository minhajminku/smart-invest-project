using PresentationControls;
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
    public partial class frm_client_preference : Form
    {

        private readonly DataAceess oAccess = new DataAceess();
        private DataSet ds = new DataSet();
        private List<InvestmentCategorySelect> categoryList = new List<InvestmentCategorySelect>();
        private List<SectorsSelect> sectorsList = new List<SectorsSelect>();
        private List<RiskSelect> riskList = new List<RiskSelect>();
        private List<CountrySelect> countryList = new List<CountrySelect>();

        private ListSelectionWrapper<InvestmentCategorySelect> CategorySelections;
        private ListSelectionWrapper<SectorsSelect> SectorsListSelections;
        private ListSelectionWrapper<RiskSelect> RiskListSelections;
        private ListSelectionWrapper<CountrySelect> CountryListSelections;
        public frm_client_preference()
        {
            InitializeComponent();
            loadComboboxes();
        }
        private void loadComboboxes()
        {
            loadCategoryList();
            loadSectorsList();
            loadCountryList();
            loadRiskList();

            
            
        }
        private void loadCategoryList()
        {
            ds = oAccess.getDataSet(SqlQueries.GetClientPreferenceDropDownData(1), false);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                InvestmentCategorySelect newRow = new InvestmentCategorySelect()
                {
                    CategoryId = Convert.ToInt32(dr["Investment_Category_Id"]),
                    Category_Name = dr["Investment_Category_Name"].ToString()
                };
                this.categoryList.Add(newRow);
            }

            CategorySelections = new ListSelectionWrapper<InvestmentCategorySelect>(categoryList, "Category_Name");

            chckCmBx_Category.DataSource = CategorySelections;
            chckCmBx_Category.DisplayMemberSingleItem = "Name";
            chckCmBx_Category.DisplayMember = "NameConcatenated";
            chckCmBx_Category.ValueMember = "Selected";
        }
        private void loadSectorsList()
        {

        }
        private void loadCountryList()
        {

        }
        private void loadRiskList()
        {

        }
        private void bttnSave_Click(object sender, EventArgs e)
        {
            foreach(var item in CategorySelections)
            {
               if(item.Selected)
               {
                    MessageBox.Show(item.Item.CategoryId.ToString());
               }
            }
          
        }
    }
}
