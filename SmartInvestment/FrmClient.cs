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
    public partial class FrmClient : Form
    {
        public List<Client> Clients { get; set; }
        private readonly DataAceess oAccess = new DataAceess();
        public FrmClient()
        {
            InitializeComponent();
            fillGenderCombo();
            Clients = Getclients();
        }

    private List<Client> Getclients()
        {
            var list = new List<Client>();
            DataSet dtDs = oAccess.getDataSet(SqlQueries.GetClients(), false);
            if (dtDs.Tables.Count > 0)
            {

                for (int i = 0; i < dtDs.Tables[0].Rows.Count; i++)
                {
                    Client client = new Client();
                    client.ClientId = Convert.ToInt32(dtDs.Tables[0].Rows[i]["Client_Id"]);
                    client.Client_First_Name = dtDs.Tables[0].Rows[i]["Client_First_Name"].ToString();
                    client.Client_Last_Name = dtDs.Tables[0].Rows[i]["Client_Last_Name"].ToString();
                    client.Client_Gender = dtDs.Tables[0].Rows[i]["Client_Gender"].ToString();
                    client.Dmat_Number = dtDs.Tables[0].Rows[i]["Dmat_Number"].ToString();
                    client.Mobile_Number = dtDs.Tables[0].Rows[i]["Mobile_Number"].ToString();
                    client.CreatedDate = Convert.ToDateTime(dtDs.Tables[0].Rows[i]["Created_Date"]);
                    list.Add(client);

                }

            }

            return list;
        }
        private void fillGenderCombo()
        {
            var genderlist = new List<GenderSelect>();
            genderlist.Add(new GenderSelect
            {
                GenderId = 0,
                Gender_Name = "Select"
            });
            genderlist.Add(new GenderSelect
            {
                GenderId = 1,
                Gender_Name = "Male"
            });
            genderlist.Add(new GenderSelect
            {
                GenderId = 2,
                Gender_Name = "Female"
            });

            comboBox_gender.DataSource = genderlist.ToList();
            comboBox_gender.DisplayMember = "Gender_Name";
            comboBox_gender.ValueMember = "GenderId";
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            var Clients = this.Clients;
            dataGrid_clients.DataSource = Clients;
        }

        private void bttnAddNew_Click(object sender, EventArgs e)
        {
            EnableDisableClearForm(true);
        }
        private void EnableDisableClearForm(bool isSave)
        {
            bttnSave.Visible = isSave;
            bttn_Update.Visible = !isSave;
            bttnDelete.Visible = !isSave;

            if (isSave)
            {
                txtBx_ClientId.Text = "";
                txtBx_FN.Text = "";
                txtBx_LN.Text = "";
                txtBx_Dmat_Num.Text = "";
                txtBx_Mob_Num.Text = "";
            }
            dataGrid_clients.Focus();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            AddOrUpdateClient();
            EnableDisableClearForm(true);
        }
        private void AddOrUpdateClient()
        {

            var client = new Client
            {
                Client_First_Name = txtBx_FN.Text,
                Client_Last_Name = txtBx_LN.Text,
                Dmat_Number = txtBx_Dmat_Num.Text,
                Mobile_Number = txtBx_Mob_Num.Text,
                Client_Gender = comboBox_gender.SelectedValue.ToString(),
                

            };
            if (!string.IsNullOrEmpty(txtBx_ClientId.Text))
            {
                client.ClientId = Convert.ToInt32(txtBx_ClientId.Text);
            }

            try
            {
                var result = oAccess.executeSql(SqlQueries.AddOrUpdateclient(client));
                this.Clients = Getclients();
                dataGrid_clients.DataSource = this.Clients;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }
    }
}
