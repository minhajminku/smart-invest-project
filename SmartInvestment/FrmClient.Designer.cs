
namespace SmartInvestment
{
    partial class FrmClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Form = new System.Windows.Forms.Panel();
            this.btn_add_client_inv_preference = new System.Windows.Forms.Button();
            this.lbl_Client_Id = new System.Windows.Forms.Label();
            this.txtBx_ClientId = new System.Windows.Forms.TextBox();
            this.bttnAddNew = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.lbl_dmat = new System.Windows.Forms.Label();
            this.txtBx_Dmat_Num = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_no = new System.Windows.Forms.Label();
            this.txtBx_Mob_Num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Last_Name = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txtBx_LN = new System.Windows.Forms.MaskedTextBox();
            this.txtBx_FN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGrid_clients = new System.Windows.Forms.DataGridView();
            this.panel_Form.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Form
            // 
            this.panel_Form.Controls.Add(this.btn_add_client_inv_preference);
            this.panel_Form.Controls.Add(this.lbl_Client_Id);
            this.panel_Form.Controls.Add(this.txtBx_ClientId);
            this.panel_Form.Controls.Add(this.bttnAddNew);
            this.panel_Form.Controls.Add(this.bttnDelete);
            this.panel_Form.Controls.Add(this.bttnSave);
            this.panel_Form.Controls.Add(this.bttn_Update);
            this.panel_Form.Controls.Add(this.comboBox_gender);
            this.panel_Form.Controls.Add(this.lbl_dmat);
            this.panel_Form.Controls.Add(this.txtBx_Dmat_Num);
            this.panel_Form.Controls.Add(this.lbl_Mobile_no);
            this.panel_Form.Controls.Add(this.txtBx_Mob_Num);
            this.panel_Form.Controls.Add(this.label1);
            this.panel_Form.Controls.Add(this.lbl_Last_Name);
            this.panel_Form.Controls.Add(this.lbl_FirstName);
            this.panel_Form.Controls.Add(this.txtBx_LN);
            this.panel_Form.Controls.Add(this.txtBx_FN);
            this.panel_Form.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Form.Location = new System.Drawing.Point(0, 0);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(1333, 182);
            this.panel_Form.TabIndex = 12;
            // 
            // btn_add_client_inv_preference
            // 
            this.btn_add_client_inv_preference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_client_inv_preference.Location = new System.Drawing.Point(15, 140);
            this.btn_add_client_inv_preference.Name = "btn_add_client_inv_preference";
            this.btn_add_client_inv_preference.Size = new System.Drawing.Size(429, 40);
            this.btn_add_client_inv_preference.TabIndex = 36;
            this.btn_add_client_inv_preference.Text = "Add investment preference";
            this.btn_add_client_inv_preference.UseVisualStyleBackColor = true;
            this.btn_add_client_inv_preference.Click += new System.EventHandler(this.btn_add_client_inv_preference_Click);
            // 
            // lbl_Client_Id
            // 
            this.lbl_Client_Id.AutoSize = true;
            this.lbl_Client_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Client_Id.Location = new System.Drawing.Point(13, 17);
            this.lbl_Client_Id.Name = "lbl_Client_Id";
            this.lbl_Client_Id.Size = new System.Drawing.Size(84, 22);
            this.lbl_Client_Id.TabIndex = 35;
            this.lbl_Client_Id.Text = "Client Id";
            // 
            // txtBx_ClientId
            // 
            this.txtBx_ClientId.Location = new System.Drawing.Point(15, 42);
            this.txtBx_ClientId.Name = "txtBx_ClientId";
            this.txtBx_ClientId.ReadOnly = true;
            this.txtBx_ClientId.Size = new System.Drawing.Size(97, 26);
            this.txtBx_ClientId.TabIndex = 34;
            // 
            // bttnAddNew
            // 
            this.bttnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddNew.Location = new System.Drawing.Point(514, 27);
            this.bttnAddNew.Name = "bttnAddNew";
            this.bttnAddNew.Size = new System.Drawing.Size(150, 40);
            this.bttnAddNew.TabIndex = 33;
            this.bttnAddNew.Text = "Add New";
            this.bttnAddNew.UseVisualStyleBackColor = true;
            // 
            // bttnDelete
            // 
            this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.Location = new System.Drawing.Point(809, 119);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(92, 59);
            this.bttnDelete.TabIndex = 32;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Visible = false;
            // 
            // bttnSave
            // 
            this.bttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.Location = new System.Drawing.Point(809, 64);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(92, 59);
            this.bttnSave.TabIndex = 31;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Visible = false;
            // 
            // bttn_Update
            // 
            this.bttn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Update.Location = new System.Drawing.Point(809, 12);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(92, 59);
            this.bttn_Update.TabIndex = 30;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Visible = false;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Location = new System.Drawing.Point(176, 106);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(118, 28);
            this.comboBox_gender.TabIndex = 29;
            // 
            // lbl_dmat
            // 
            this.lbl_dmat.AutoSize = true;
            this.lbl_dmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dmat.Location = new System.Drawing.Point(325, 18);
            this.lbl_dmat.Name = "lbl_dmat";
            this.lbl_dmat.Size = new System.Drawing.Size(131, 22);
            this.lbl_dmat.TabIndex = 28;
            this.lbl_dmat.Text = "Dmat Number";
            // 
            // txtBx_Dmat_Num
            // 
            this.txtBx_Dmat_Num.Location = new System.Drawing.Point(329, 41);
            this.txtBx_Dmat_Num.Name = "txtBx_Dmat_Num";
            this.txtBx_Dmat_Num.Size = new System.Drawing.Size(97, 26);
            this.txtBx_Dmat_Num.TabIndex = 27;
            // 
            // lbl_Mobile_no
            // 
            this.lbl_Mobile_no.AutoSize = true;
            this.lbl_Mobile_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_no.Location = new System.Drawing.Point(325, 85);
            this.lbl_Mobile_no.Name = "lbl_Mobile_no";
            this.lbl_Mobile_no.Size = new System.Drawing.Size(143, 22);
            this.lbl_Mobile_no.TabIndex = 26;
            this.lbl_Mobile_no.Text = "Mobile Number";
            // 
            // txtBx_Mob_Num
            // 
            this.txtBx_Mob_Num.Location = new System.Drawing.Point(329, 108);
            this.txtBx_Mob_Num.Name = "txtBx_Mob_Num";
            this.txtBx_Mob_Num.Size = new System.Drawing.Size(97, 26);
            this.txtBx_Mob_Num.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gender";
            // 
            // lbl_Last_Name
            // 
            this.lbl_Last_Name.AutoSize = true;
            this.lbl_Last_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Last_Name.Location = new System.Drawing.Point(172, 18);
            this.lbl_Last_Name.Name = "lbl_Last_Name";
            this.lbl_Last_Name.Size = new System.Drawing.Size(105, 22);
            this.lbl_Last_Name.TabIndex = 23;
            this.lbl_Last_Name.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(13, 83);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(107, 22);
            this.lbl_FirstName.TabIndex = 22;
            this.lbl_FirstName.Text = "First Name";
            // 
            // txtBx_LN
            // 
            this.txtBx_LN.Location = new System.Drawing.Point(176, 41);
            this.txtBx_LN.Name = "txtBx_LN";
            this.txtBx_LN.Size = new System.Drawing.Size(97, 26);
            this.txtBx_LN.TabIndex = 21;
            // 
            // txtBx_FN
            // 
            this.txtBx_FN.Location = new System.Drawing.Point(17, 108);
            this.txtBx_FN.Name = "txtBx_FN";
            this.txtBx_FN.Size = new System.Drawing.Size(97, 26);
            this.txtBx_FN.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGrid_clients);
            this.panel2.Location = new System.Drawing.Point(1, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1327, 520);
            this.panel2.TabIndex = 13;
            // 
            // dataGrid_clients
            // 
            this.dataGrid_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_clients.Location = new System.Drawing.Point(3, 8);
            this.dataGrid_clients.Name = "dataGrid_clients";
            this.dataGrid_clients.RowHeadersWidth = 62;
            this.dataGrid_clients.RowTemplate.Height = 28;
            this.dataGrid_clients.Size = new System.Drawing.Size(1321, 446);
            this.dataGrid_clients.TabIndex = 12;
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 705);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Form);
            this.Name = "FrmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClient";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            this.panel_Form.ResumeLayout(false);
            this.panel_Form.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Form;
        private System.Windows.Forms.Label lbl_Client_Id;
        private System.Windows.Forms.TextBox txtBx_ClientId;
        private System.Windows.Forms.Button bttnAddNew;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label lbl_dmat;
        private System.Windows.Forms.TextBox txtBx_Dmat_Num;
        private System.Windows.Forms.Label lbl_Mobile_no;
        private System.Windows.Forms.TextBox txtBx_Mob_Num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Last_Name;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.MaskedTextBox txtBx_LN;
        private System.Windows.Forms.TextBox txtBx_FN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGrid_clients;
        private System.Windows.Forms.Button btn_add_client_inv_preference;
    }
}