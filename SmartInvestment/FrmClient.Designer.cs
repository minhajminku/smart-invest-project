
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
            this.txtBx_FN = new System.Windows.Forms.TextBox();
            this.txtBx_LN = new System.Windows.Forms.MaskedTextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_Last_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Mobile_no = new System.Windows.Forms.Label();
            this.txtBx_Mob_Num = new System.Windows.Forms.TextBox();
            this.lbl_dmat = new System.Windows.Forms.Label();
            this.txtBx_Dmat_Num = new System.Windows.Forms.TextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.dataGrid_clients = new System.Windows.Forms.DataGridView();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttnAddNew = new System.Windows.Forms.Button();
            this.lbl_Client_Id = new System.Windows.Forms.Label();
            this.txtBx_ClientId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBx_FN
            // 
            this.txtBx_FN.Location = new System.Drawing.Point(85, 123);
            this.txtBx_FN.Name = "txtBx_FN";
            this.txtBx_FN.Size = new System.Drawing.Size(100, 26);
            this.txtBx_FN.TabIndex = 0;
            // 
            // txtBx_LN
            // 
            this.txtBx_LN.Location = new System.Drawing.Point(243, 56);
            this.txtBx_LN.Name = "txtBx_LN";
            this.txtBx_LN.Size = new System.Drawing.Size(100, 26);
            this.txtBx_LN.TabIndex = 1;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(81, 98);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(107, 22);
            this.lbl_FirstName.TabIndex = 2;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_Last_Name
            // 
            this.lbl_Last_Name.AutoSize = true;
            this.lbl_Last_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Last_Name.Location = new System.Drawing.Point(239, 33);
            this.lbl_Last_Name.Name = "lbl_Last_Name";
            this.lbl_Last_Name.Size = new System.Drawing.Size(105, 22);
            this.lbl_Last_Name.TabIndex = 3;
            this.lbl_Last_Name.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gender";
            // 
            // lbl_Mobile_no
            // 
            this.lbl_Mobile_no.AutoSize = true;
            this.lbl_Mobile_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_no.Location = new System.Drawing.Point(392, 100);
            this.lbl_Mobile_no.Name = "lbl_Mobile_no";
            this.lbl_Mobile_no.Size = new System.Drawing.Size(143, 22);
            this.lbl_Mobile_no.TabIndex = 7;
            this.lbl_Mobile_no.Text = "Mobile Number";
            // 
            // txtBx_Mob_Num
            // 
            this.txtBx_Mob_Num.Location = new System.Drawing.Point(396, 123);
            this.txtBx_Mob_Num.Name = "txtBx_Mob_Num";
            this.txtBx_Mob_Num.Size = new System.Drawing.Size(100, 26);
            this.txtBx_Mob_Num.TabIndex = 6;
            // 
            // lbl_dmat
            // 
            this.lbl_dmat.AutoSize = true;
            this.lbl_dmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dmat.Location = new System.Drawing.Point(392, 33);
            this.lbl_dmat.Name = "lbl_dmat";
            this.lbl_dmat.Size = new System.Drawing.Size(131, 22);
            this.lbl_dmat.TabIndex = 9;
            this.lbl_dmat.Text = "Dmat Number";
            // 
            // txtBx_Dmat_Num
            // 
            this.txtBx_Dmat_Num.Location = new System.Drawing.Point(396, 56);
            this.txtBx_Dmat_Num.Name = "txtBx_Dmat_Num";
            this.txtBx_Dmat_Num.Size = new System.Drawing.Size(100, 26);
            this.txtBx_Dmat_Num.TabIndex = 8;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Location = new System.Drawing.Point(243, 121);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(121, 28);
            this.comboBox_gender.TabIndex = 10;
            // 
            // dataGrid_clients
            // 
            this.dataGrid_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_clients.Location = new System.Drawing.Point(85, 240);
            this.dataGrid_clients.Name = "dataGrid_clients";
            this.dataGrid_clients.RowHeadersWidth = 62;
            this.dataGrid_clients.RowTemplate.Height = 28;
            this.dataGrid_clients.Size = new System.Drawing.Size(788, 188);
            this.dataGrid_clients.TabIndex = 11;
            // 
            // bttnDelete
            // 
            this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.Location = new System.Drawing.Point(577, 136);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(95, 59);
            this.bttnDelete.TabIndex = 16;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Visible = false;
            // 
            // bttnSave
            // 
            this.bttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.Location = new System.Drawing.Point(577, 81);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(95, 59);
            this.bttnSave.TabIndex = 15;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Visible = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttn_Update
            // 
            this.bttn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Update.Location = new System.Drawing.Point(577, 29);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(95, 59);
            this.bttn_Update.TabIndex = 14;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Visible = false;
            // 
            // bttnAddNew
            // 
            this.bttnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddNew.Location = new System.Drawing.Point(725, 81);
            this.bttnAddNew.Name = "bttnAddNew";
            this.bttnAddNew.Size = new System.Drawing.Size(136, 59);
            this.bttnAddNew.TabIndex = 17;
            this.bttnAddNew.Text = "Add New";
            this.bttnAddNew.UseVisualStyleBackColor = true;
            this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
            // 
            // lbl_Client_Id
            // 
            this.lbl_Client_Id.AutoSize = true;
            this.lbl_Client_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Client_Id.Location = new System.Drawing.Point(83, 38);
            this.lbl_Client_Id.Name = "lbl_Client_Id";
            this.lbl_Client_Id.Size = new System.Drawing.Size(84, 22);
            this.lbl_Client_Id.TabIndex = 19;
            this.lbl_Client_Id.Text = "Client Id";
            // 
            // txtBx_ClientId
            // 
            this.txtBx_ClientId.Location = new System.Drawing.Point(85, 63);
            this.txtBx_ClientId.Name = "txtBx_ClientId";
            this.txtBx_ClientId.ReadOnly = true;
            this.txtBx_ClientId.Size = new System.Drawing.Size(100, 26);
            this.txtBx_ClientId.TabIndex = 18;
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 457);
            this.Controls.Add(this.lbl_Client_Id);
            this.Controls.Add(this.txtBx_ClientId);
            this.Controls.Add(this.bttnAddNew);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttn_Update);
            this.Controls.Add(this.dataGrid_clients);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.lbl_dmat);
            this.Controls.Add(this.txtBx_Dmat_Num);
            this.Controls.Add(this.lbl_Mobile_no);
            this.Controls.Add(this.txtBx_Mob_Num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Last_Name);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.txtBx_LN);
            this.Controls.Add(this.txtBx_FN);
            this.Name = "FrmClient";
            this.Text = "FrmClient";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_FN;
        private System.Windows.Forms.MaskedTextBox txtBx_LN;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_Last_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Mobile_no;
        private System.Windows.Forms.TextBox txtBx_Mob_Num;
        private System.Windows.Forms.Label lbl_dmat;
        private System.Windows.Forms.TextBox txtBx_Dmat_Num;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.DataGridView dataGrid_clients;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Button bttnAddNew;
        private System.Windows.Forms.Label lbl_Client_Id;
        private System.Windows.Forms.TextBox txtBx_ClientId;
    }
}