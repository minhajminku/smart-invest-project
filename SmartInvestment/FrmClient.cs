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
        public List<GenderSelect> ClientGenders { get; set; }
        private readonly DataAceess oAccess = new DataAceess();
        public FrmClient()
        {
            Clients = Getclients();
            ClientGenders = GetGenderList();
            InitializeComponent();
            fillGenderCombo();
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
            var list = this.ClientGenders.Select(x => new 
            {
                GenderId = x.GenderId,
                Gender_Name = x.Gender_Name
            }).ToList();

            comboBox_gender.DataSource = list.OrderBy(x => x.GenderId).ToList();
            comboBox_gender.DisplayMember = "Gender_Name";
            comboBox_gender.ValueMember = "GenderId";
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            var Clients = this.Clients;
            dataGrid_clients.DataSource = Clients;
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

        private void AddOrUpdateClient()
        {

            var client = new Client
            {
                Client_First_Name = txtBx_FN.Text,
                Client_Last_Name = txtBx_LN.Text,
                Dmat_Number = txtBx_Dmat_Num.Text,
                Mobile_Number = txtBx_Mob_Num.Text,
                Client_Gender = comboBox_gender.Text
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

        private List<GenderSelect> GetGenderList()
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
            return genderlist;
        }

        private void dataGrid_clients_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGrid_clients.SelectedRows.Count > 1)
                {
                    var selectedClient = dataGrid_clients.SelectedRows[0].DataBoundItem as Client;
                    txtBx_ClientId.Text = selectedClient.ClientId.ToString();
                    txtBx_FN.Text = selectedClient.Client_First_Name;
                    txtBx_LN.Text = selectedClient.Client_Last_Name;
                    txtBx_Dmat_Num.Text = selectedClient.Dmat_Number;
                    txtBx_Mob_Num.Text = selectedClient.Mobile_Number;
                    var genderIndex = 0;
                    var genderValue = selectedClient.Client_Gender;
                    if (genderValue == "Male")
                        genderIndex = 1;
                    else
                        genderIndex = 2; 
                    comboBox_gender.SelectedIndex = genderIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }


        }

        private void dataGrid_clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGrid_clients.SelectedRows.Count > 0)
                {
                    var selectedClient = dataGrid_clients.SelectedRows[0].DataBoundItem as Client;
                    txtBx_ClientId.Text = selectedClient.ClientId.ToString();
                    txtBx_FN.Text = selectedClient.Client_First_Name;
                    txtBx_LN.Text = selectedClient.Client_Last_Name;
                    txtBx_Dmat_Num.Text = selectedClient.Dmat_Number;
                    txtBx_Mob_Num.Text = selectedClient.Mobile_Number;
                    var genderIndex = 0;
                    var genderValue = selectedClient.Client_Gender;
                    if (genderValue == "Male")
                        genderIndex = 1;
                    else
                        genderIndex = 2;
                    comboBox_gender.SelectedIndex = genderIndex;
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

        private void btn_add_client_inv_preference_Click(object sender, EventArgs e)
        {
            frm_client_preference frm = new frm_client_preference();
            frm.Show();
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBx_ClientId.Text))
            {
                DeleteClient(Convert.ToInt32(txtBx_ClientId.Text));
                this.Clients = Getclients();
                dataGrid_clients.DataSource = this.Clients;
                MessageBox.Show("Deleted Success!");
            }
            else
                MessageBox.Show("Please select valid client!");
        }
        private void DeleteClient(int id)
        {
            try
            {
                var result = oAccess.executeSql(SqlQueries.DeleteClient(id));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            EnableDisableClearForm(false);
            AddOrUpdateClient();
        }

        private void bttnAddNew_Click_1(object sender, EventArgs e)
        {
            EnableDisableClearForm(true);
        }

        private void bttnSave_Click_1(object sender, EventArgs e)
        {
            AddOrUpdateClient();
            EnableDisableClearForm(true);
        }
    }
}
