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
    public partial class FrmInvestmentIdea : Form
    {
        public List<InvestmentIdea> InvestmentIdeas { get; set; }
        public List<InvestmentCategory> InvestmentCategorys { get; set; }
        private readonly DataAceess oAccess = new DataAceess();
        public FrmInvestmentIdea()
        {
            InvestmentIdeas = GetInvestmentIdeas();
            InvestmentCategorys = GetInvestmentCategories();
            InitializeComponent();
            fillCategoryCombo();
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

            ////var bindingSource1 = new BindingSource();
            ////bindingSource1.DataSource = list.OrderBy(x=>x.CategoryId);
            ////cmbBx_InvestmentCategories = new ComboBox();
            cmbBx_InvestmentCategories.DataSource = list.OrderBy(x => x.CategoryId).ToList();

            cmbBx_InvestmentCategories.DisplayMember = "Category_Name";
            cmbBx_InvestmentCategories.ValueMember = "CategoryId";
        }
        private List<InvestmentIdea> GetInvestmentIdeas()
        {
            var list = new List<InvestmentIdea>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetInvestmentIdeas(), false);
            if (dtDs.Tables.Count > 0)
            {
                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    InvestmentIdea idea = new InvestmentIdea();
                    idea.IdeaId = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Investment_Idea_Id"]);
                    idea.Idea_Name = dtDs.Tables[0].Rows[i]["Investment_Idea_Name"].ToString();
                    idea.CategoryID = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Investment_Category_Id"]);
                    idea.CreatedDate = Convert.ToDateTime(dtDs.Tables[0].Rows[i]["Created_Date"]);
                    list.Add(idea);

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
        private void FrmInvestmentIdea_Load(object sender, EventArgs e)
        {
            var InvestIdeas = this.InvestmentIdeas;
            dataGridView1.DataSource = InvestIdeas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    var selectedIdea = dataGridView1.SelectedRows[0].DataBoundItem as InvestmentIdea;
                    txtBx_IdeaId.Text = selectedIdea.IdeaId.ToString();
                    txtBx_Idea_Name.Text = selectedIdea.Idea_Name;
                    txtBx_IdeaCreatedDate.Text = selectedIdea.CreatedDate.ToString();
                    cmbBx_InvestmentCategories.SelectedItem = InvestmentCategorys.Find(x => x.CategoryId == selectedIdea.CategoryID);
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
                    var selectedIdea = dataGridView1.SelectedRows[0].DataBoundItem as InvestmentIdea;
                    txtBx_IdeaId.Text = selectedIdea.IdeaId.ToString();
                    txtBx_Idea_Name.Text = selectedIdea.Idea_Name;
                    txtBx_IdeaCreatedDate.Text = selectedIdea.CreatedDate.ToString();
                    cmbBx_InvestmentCategories.SelectedItem = new
                    {
                        CategoryId = selectedIdea.CategoryID,
                        Category_Name = InvestmentCategorys.Find(x=>x.CategoryId == selectedIdea.CategoryID).Category_Name
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
            AddOrUpdateIdea();
        }
        private void AddOrUpdateIdea()
        {

            var Idea = new InvestmentIdea
            {
                Idea_Name = txtBx_Idea_Name.Text,
                CategoryID = Convert.ToInt32(cmbBx_InvestmentCategories.SelectedValue)
            };
            if (!string.IsNullOrEmpty(txtBx_IdeaId.Text))
            {
                Idea.IdeaId = Convert.ToInt32(txtBx_IdeaId.Text);
            }
            
            try
            {
                var result = oAccess.executeSql(SqlQueries.AddOrUpdateInvestmentIdea(Idea));
                this.InvestmentIdeas = GetInvestmentIdeas();
                dataGridView1.DataSource = this.InvestmentIdeas;

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
            AddOrUpdateIdea();
            EnableDisableClearForm(true);


        }
        private void EnableDisableClearForm(bool isSave)
        {
            bttnSave.Visible = isSave;
            bttn_Update.Visible = !isSave;
            bttnDelete.Visible = !isSave;

            if (isSave) 
            {
                txtBx_IdeaId.Text = "";
                txtBx_IdeaCreatedDate.Text = "";
                txtBx_Idea_Name.Text = "";
                txtBx_IdeaCreatedDate.Text = DateTime.Now.ToString(); 
            }
            dataGridView1.Focus();
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBx_IdeaId.Text))
            {
                DeleteIdea(Convert.ToInt32(txtBx_IdeaId.Text));
                this.InvestmentIdeas = GetInvestmentIdeas();
                dataGridView1.DataSource = this.InvestmentIdeas;
                MessageBox.Show("Deleted Success!");
            }
            else
                MessageBox.Show("Please select valid idea!");
        }
        private void DeleteIdea(int id)
        {
            try
            {
               var result = oAccess.executeSql(SqlQueries.DeleteIdea(id));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void bttnAddStocksToIdea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBx_IdeaId.Text))
            {
                frm_AddCompanyToIdea frm = new frm_AddCompanyToIdea(Convert.ToInt32(txtBx_IdeaId.Text));
                frm.Show();
            }
            else
                MessageBox.Show("Choose a valid Idea");
        }
    }
}
