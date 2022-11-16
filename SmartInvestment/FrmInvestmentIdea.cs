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
        private readonly DataAceess oAccess = new DataAceess();
        public FrmInvestmentIdea()
        {
            InvestmentIdeas = GetInvestmentIdeas();
            InitializeComponent();
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

        private void FrmInvestmentIdea_Load(object sender, EventArgs e)
        {
            var InvestIdeas = this.InvestmentIdeas;
            dataGridView1.DataSource = InvestIdeas;
        }
    }
}
