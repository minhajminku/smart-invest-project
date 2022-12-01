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
        private readonly DataAceess oAccess;
        public FrmInvestmentCategory()
        {
            oAccess = new DataAceess();
            InvestmentCategorys = GetInvestmentCategories();
            InitializeComponent();
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
        private void FrmInvestmentCategory_Load(object sender, EventArgs e)
        {
            var InvestCategories = this.InvestmentCategorys;
            dataGridView1.DataSource = InvestCategories;
        }

        private void bttnAddNew_Click(object sender, EventArgs e)
        {
            EnableDisableClearForm(true);
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            AddOrUpdateEventCategory();
            EnableDisableClearForm(true);
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    var selectedCategory = dataGridView1.SelectedRows[0].DataBoundItem as InvestmentCategory;
                    txtBx_CategoryId.Text = selectedCategory.CategoryId.ToString();
                    txtBx_Category_Name.Text = selectedCategory.Category_Name;
                    txtBx_CategoryCreatedDate.Text = selectedCategory.CreatedDate.ToString();
                }
            }
            catch (Exception ex)
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
                    var selectedCategory = dataGridView1.SelectedRows[0].DataBoundItem as InvestmentCategory;
                    txtBx_CategoryId.Text = selectedCategory.CategoryId.ToString();
                    txtBx_Category_Name.Text = selectedCategory.Category_Name;
                    txtBx_CategoryCreatedDate.Text = selectedCategory.CreatedDate.ToString();
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
        private void EnableDisableClearForm(bool isSave)
        {
            bttnSave.Visible = isSave;
            bttn_Update.Visible = !isSave;
            bttnDelete.Visible = !isSave;

            if (isSave)
            {
                txtBx_CategoryId.Text = "";
                txtBx_CategoryCreatedDate.Text = "";
                txtBx_Category_Name.Text = "";
                txtBx_CategoryCreatedDate.Text = DateTime.Now.ToString();
            }
            dataGridView1.Focus();
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            EnableDisableClearForm(false);
            AddOrUpdateEventCategory();
        }
        private void AddOrUpdateEventCategory()
        {

            var category = new InvestmentCategory
            {
                Category_Name = txtBx_Category_Name.Text,
            };
            if (!string.IsNullOrEmpty(txtBx_CategoryId.Text))
            {
                category.CategoryId = Convert.ToInt32(txtBx_CategoryId.Text);
            }

            try
            {
                var result = oAccess.executeSql(SqlQueries.AddOrUpdateInvestmentCategory(category));
                this.InvestmentCategorys = GetInvestmentCategories();
                dataGridView1.DataSource = this.InvestmentCategorys;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }
        private void DeleteCategory(int id)
        {
            try
            {
                var result = oAccess.executeSql(SqlQueries.DeleteCategory(id));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void bttnDelete_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBx_CategoryId.Text))
            {
                DeleteCategory(Convert.ToInt32(txtBx_CategoryId.Text));
                this.InvestmentCategorys = GetInvestmentCategories();
                dataGridView1.DataSource = this.InvestmentCategorys;
                MessageBox.Show("Deleted Success!");
            }
            else
                MessageBox.Show("Please select valid category!");
        }
    }
}
