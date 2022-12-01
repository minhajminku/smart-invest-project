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
using static SmartInvestment.Enums.Enums;

namespace SmartInvestment
{
    public partial class frm_client_preference : Form
    {

        private readonly DataAceess oAccess ;
        private DataSet ds = new DataSet();
        private List<InvestmentCategorySelect> categoryList = new List<InvestmentCategorySelect>();
        private List<SectorsSelect> sectorsList = new List<SectorsSelect>();
        private List<RiskSelect> riskList = new List<RiskSelect>();
        private List<CountrySelect> countryList = new List<CountrySelect>();

        private ListSelectionWrapper<InvestmentCategorySelect> CategorySelections;
        private ListSelectionWrapper<SectorsSelect> SectorsListSelections;
        private ListSelectionWrapper<RiskSelect> RiskListSelections;
        private ListSelectionWrapper<CountrySelect> CountryListSelections;
        private int ClientID;
        private List<ClientInvestmentPreference> clientPreferenceList; 
        public frm_client_preference(string clientId)
        {
            oAccess = new DataAceess();
            ClientID = Convert.ToInt32(clientId);
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
            //fetch category list to fill
            ds = oAccess.getDataSet(SqlQueries.GetClientPreferenceDropDownData(ClientPreferenceType.Categeries.GetHashCode(), Convert.ToInt32(ClientID)), false);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                InvestmentCategorySelect newRow = new InvestmentCategorySelect()
                {
                    CategoryId = Convert.ToInt32(dr["Investment_Category_Id"]),
                    Category_Name = dr["Investment_Category_Name"].ToString(),
                    IsSelected = Convert.ToBoolean(dr["IsSelected"])
                };
                this.categoryList.Add(newRow);
            }
            // muliti combo box object creation
            CategorySelections = new ListSelectionWrapper<InvestmentCategorySelect>(categoryList, "Category_Name");
            //set selected items
            foreach (var item in CategorySelections)
            {
                item.Selected = item.Item.IsSelected;
            }
            chckCmBx_Category.DataSource = CategorySelections;
            chckCmBx_Category.DisplayMemberSingleItem = "Name";
            chckCmBx_Category.DisplayMember = "NameConcatenated";
            chckCmBx_Category.ValueMember = "Selected";
        }
        private void loadSectorsList()
        {
            ds = oAccess.getDataSet(SqlQueries.GetClientPreferenceDropDownData(ClientPreferenceType.Sectors.GetHashCode(), Convert.ToInt32(ClientID)), false);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                SectorsSelect newRow = new SectorsSelect()
                {
                    Sector_Id = Convert.ToInt32(dr["Sector_Id"]),
                    Sector_Name = dr["Sector_Name"].ToString(),
                    IsSelected = Convert.ToBoolean(dr["IsSelected"])
                };
                this.sectorsList.Add(newRow);
            }

            SectorsListSelections = new ListSelectionWrapper<SectorsSelect>(this.sectorsList, "Sector_Name");
            //set selected items
            foreach (var item in SectorsListSelections)
            {
                item.Selected = item.Item.IsSelected;
            }
            chckCmBx_Sectors.DataSource = SectorsListSelections;
            chckCmBx_Sectors.DisplayMemberSingleItem = "Name";
            chckCmBx_Sectors.DisplayMember = "NameConcatenated";
            chckCmBx_Sectors.ValueMember = "Selected";
        }
        private void loadCountryList()
        {
            ds = oAccess.getDataSet(SqlQueries.GetClientPreferenceDropDownData(ClientPreferenceType.Country.GetHashCode(), Convert.ToInt32(ClientID)), false);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                CountrySelect newRow = new CountrySelect()
                {
                    Country_Id = Convert.ToInt32(dr["Country_Id"]),
                    Country_Name = dr["Country_Name"].ToString(),
                    IsSelected = Convert.ToBoolean(dr["IsSelected"])
                };
                this.countryList.Add(newRow);
            }

            CountryListSelections = new ListSelectionWrapper<CountrySelect>(this.countryList, "Country_Name");
            //set selected items
            foreach (var item in CountryListSelections)
            {
                item.Selected = item.Item.IsSelected;
            }
            chckCmBx_Country.DataSource = CountryListSelections;
            chckCmBx_Country.DisplayMemberSingleItem = "Name";
            chckCmBx_Country.DisplayMember = "NameConcatenated";
            chckCmBx_Country.ValueMember = "Selected";
        }
        private void loadRiskList()
        {
            ds = oAccess.getDataSet(SqlQueries.GetClientPreferenceDropDownData(ClientPreferenceType.Risk.GetHashCode(), Convert.ToInt32(ClientID)), false);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                RiskSelect newRow = new RiskSelect()
                {
                    Risk_Id = Convert.ToInt32(dr["Risk_Id"]),
                    Risk_Name = dr["Risk_Name"].ToString(),
                    IsSelected = Convert.ToBoolean(dr["IsSelected"])
                };
                this.riskList.Add(newRow);
            }

            RiskListSelections = new ListSelectionWrapper<RiskSelect>(this.riskList, "Risk_Name");
            //set selected items
            foreach (var item in RiskListSelections)
            {
                item.Selected = item.Item.IsSelected;
            }
            chckCmBx_Risk.DataSource = RiskListSelections;
            chckCmBx_Risk.DisplayMemberSingleItem = "Name";
            chckCmBx_Risk.DisplayMember = "NameConcatenated";
            chckCmBx_Risk.ValueMember = "Selected";
        }
        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                createClientPreferenceList();
                saveClientPreferenceList();
                MessageBox.Show("Preference saved Succesfully. ");
            }
            catch
            {
                MessageBox.Show("Something went wrong. ");
            }
        }
        private void createClientPreferenceList()
        {
            clientPreferenceList = new List<ClientInvestmentPreference>();
            // add category preference se,lected
            foreach (var item in CategorySelections)
            {
                if (item.Selected)
                {
                    ClientInvestmentPreference newClientPreference = new ClientInvestmentPreference()
                    {
                        ClientId = ClientID,
                        PreferenceTypeId = Enums.Enums.ClientPreferenceType.Categeries.GetHashCode(),
                        PreferenceTypeSubId = item.Item.CategoryId
                    };
                    clientPreferenceList.Add(newClientPreference);
                }
            }
            // add sectors preference selected
            foreach (var item in SectorsListSelections)
            {
                if (item.Selected)
                {
                    ClientInvestmentPreference newClientPreference = new ClientInvestmentPreference()
                    {
                        ClientId = ClientID,
                        PreferenceTypeId = Enums.Enums.ClientPreferenceType.Sectors.GetHashCode(),
                        PreferenceTypeSubId = item.Item.Sector_Id
                    };
                    clientPreferenceList.Add(newClientPreference);
                }
            }
            // add country preference selected
            foreach (var item in CountryListSelections)
            {
                if (item.Selected)
                {
                    ClientInvestmentPreference newClientPreference = new ClientInvestmentPreference()
                    {
                        ClientId = ClientID,
                        PreferenceTypeId = Enums.Enums.ClientPreferenceType.Country.GetHashCode(),
                        PreferenceTypeSubId = item.Item.Country_Id
                    };
                    clientPreferenceList.Add(newClientPreference);
                }
            }
            // add risk preference selected
            foreach (var item in RiskListSelections)
            {
                if (item.Selected)
                {
                    ClientInvestmentPreference newClientPreference = new ClientInvestmentPreference()
                    {
                        ClientId = ClientID,
                        PreferenceTypeId = Enums.Enums.ClientPreferenceType.Risk.GetHashCode(),
                        PreferenceTypeSubId = item.Item.Risk_Id
                    };
                    clientPreferenceList.Add(newClientPreference);
                }
            }
        }
        private void saveClientPreferenceList()
        {
            //Delete already existing client preferences
            oAccess.executeSql(SqlQueries.DeleteAllClientPreference(ClientID));
            //Add all client preferences
            foreach (var item in clientPreferenceList)
            {
                oAccess.executeSql(SqlQueries.SaveClientPreference(item.ClientId,item.PreferenceTypeId,item.PreferenceTypeSubId,"username"));
            }
        }
    }
}
