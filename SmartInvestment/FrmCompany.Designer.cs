
namespace SmartInvestment
{
    partial class FrmCompany
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBx_CompanyId = new System.Windows.Forms.TextBox();
            this.txtBx_Company_Name = new System.Windows.Forms.TextBox();
            this.cmbBx_InvestmentCategories = new System.Windows.Forms.ComboBox();
            this.lbl_Company_Id = new System.Windows.Forms.Label();
            this.lbl_Company_Category = new System.Windows.Forms.Label();
            this.lbl_Company_Name = new System.Windows.Forms.Label();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttnAddNew = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBx_Sector = new System.Windows.Forms.ComboBox();
            this.cmbBx_Country = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBx_Risk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_Stock_Value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBx_Previous_Stock_Value = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(846, 288);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txtBx_CompanyId
            // 
            this.txtBx_CompanyId.Location = new System.Drawing.Point(68, 70);
            this.txtBx_CompanyId.Name = "txtBx_CompanyId";
            this.txtBx_CompanyId.ReadOnly = true;
            this.txtBx_CompanyId.Size = new System.Drawing.Size(69, 26);
            this.txtBx_CompanyId.TabIndex = 2;
            // 
            // txtBx_Company_Name
            // 
            this.txtBx_Company_Name.Location = new System.Drawing.Point(68, 144);
            this.txtBx_Company_Name.Name = "txtBx_Company_Name";
            this.txtBx_Company_Name.Size = new System.Drawing.Size(142, 26);
            this.txtBx_Company_Name.TabIndex = 3;
            // 
            // cmbBx_InvestmentCategories
            // 
            this.cmbBx_InvestmentCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_InvestmentCategories.FormattingEnabled = true;
            this.cmbBx_InvestmentCategories.Location = new System.Drawing.Point(233, 70);
            this.cmbBx_InvestmentCategories.Name = "cmbBx_InvestmentCategories";
            this.cmbBx_InvestmentCategories.Size = new System.Drawing.Size(142, 28);
            this.cmbBx_InvestmentCategories.TabIndex = 5;
            // 
            // lbl_Company_Id
            // 
            this.lbl_Company_Id.AutoSize = true;
            this.lbl_Company_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company_Id.Location = new System.Drawing.Point(64, 44);
            this.lbl_Company_Id.Name = "lbl_Company_Id";
            this.lbl_Company_Id.Size = new System.Drawing.Size(118, 22);
            this.lbl_Company_Id.TabIndex = 6;
            this.lbl_Company_Id.Text = "Company ID";
            // 
            // lbl_Company_Category
            // 
            this.lbl_Company_Category.AutoSize = true;
            this.lbl_Company_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company_Category.Location = new System.Drawing.Point(229, 44);
            this.lbl_Company_Category.Name = "lbl_Company_Category";
            this.lbl_Company_Category.Size = new System.Drawing.Size(91, 22);
            this.lbl_Company_Category.TabIndex = 7;
            this.lbl_Company_Category.Text = "Category";
            // 
            // lbl_Company_Name
            // 
            this.lbl_Company_Name.AutoSize = true;
            this.lbl_Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company_Name.Location = new System.Drawing.Point(64, 119);
            this.lbl_Company_Name.Name = "lbl_Company_Name";
            this.lbl_Company_Name.Size = new System.Drawing.Size(150, 22);
            this.lbl_Company_Name.TabIndex = 8;
            this.lbl_Company_Name.Text = "Company Name";
            // 
            // bttn_Update
            // 
            this.bttn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Update.Location = new System.Drawing.Point(638, 25);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(106, 59);
            this.bttn_Update.TabIndex = 10;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Visible = false;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // bttnAddNew
            // 
            this.bttnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddNew.Location = new System.Drawing.Point(767, 37);
            this.bttnAddNew.Name = "bttnAddNew";
            this.bttnAddNew.Size = new System.Drawing.Size(136, 59);
            this.bttnAddNew.TabIndex = 11;
            this.bttnAddNew.Text = "Add New";
            this.bttnAddNew.UseVisualStyleBackColor = true;
            this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
            // 
            // bttnSave
            // 
            this.bttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.Location = new System.Drawing.Point(638, 82);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(106, 59);
            this.bttnSave.TabIndex = 12;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Visible = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.Location = new System.Drawing.Point(638, 133);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(106, 59);
            this.bttnDelete.TabIndex = 13;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Visible = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sector";
            // 
            // cmbBx_Sector
            // 
            this.cmbBx_Sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_Sector.FormattingEnabled = true;
            this.cmbBx_Sector.Location = new System.Drawing.Point(233, 144);
            this.cmbBx_Sector.Name = "cmbBx_Sector";
            this.cmbBx_Sector.Size = new System.Drawing.Size(142, 28);
            this.cmbBx_Sector.TabIndex = 14;
            // 
            // cmbBx_Country
            // 
            this.cmbBx_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_Country.FormattingEnabled = true;
            this.cmbBx_Country.Location = new System.Drawing.Point(428, 70);
            this.cmbBx_Country.Name = "cmbBx_Country";
            this.cmbBx_Country.Size = new System.Drawing.Size(142, 28);
            this.cmbBx_Country.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Risk";
            // 
            // cmbBx_Risk
            // 
            this.cmbBx_Risk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_Risk.FormattingEnabled = true;
            this.cmbBx_Risk.Location = new System.Drawing.Point(428, 151);
            this.cmbBx_Risk.Name = "cmbBx_Risk";
            this.cmbBx_Risk.Size = new System.Drawing.Size(142, 28);
            this.cmbBx_Risk.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Stock Value";
            // 
            // txtBx_Stock_Value
            // 
            this.txtBx_Stock_Value.Location = new System.Drawing.Point(68, 220);
            this.txtBx_Stock_Value.Name = "txtBx_Stock_Value";
            this.txtBx_Stock_Value.Size = new System.Drawing.Size(142, 26);
            this.txtBx_Stock_Value.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Previous Stock Value";
            // 
            // txtBx_Previous_Stock_Value
            // 
            this.txtBx_Previous_Stock_Value.Location = new System.Drawing.Point(233, 220);
            this.txtBx_Previous_Stock_Value.Name = "txtBx_Previous_Stock_Value";
            this.txtBx_Previous_Stock_Value.Size = new System.Drawing.Size(142, 26);
            this.txtBx_Previous_Stock_Value.TabIndex = 18;
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 556);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBx_Previous_Stock_Value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBx_Stock_Value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBx_Country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBx_Risk);
            this.Controls.Add(this.cmbBx_Sector);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnAddNew);
            this.Controls.Add(this.bttn_Update);
            this.Controls.Add(this.lbl_Company_Name);
            this.Controls.Add(this.lbl_Company_Category);
            this.Controls.Add(this.lbl_Company_Id);
            this.Controls.Add(this.cmbBx_InvestmentCategories);
            this.Controls.Add(this.txtBx_Company_Name);
            this.Controls.Add(this.txtBx_CompanyId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCompany";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBx_CompanyId;
        private System.Windows.Forms.TextBox txtBx_Company_Name;
        private System.Windows.Forms.ComboBox cmbBx_InvestmentCategories;
        private System.Windows.Forms.Label lbl_Company_Id;
        private System.Windows.Forms.Label lbl_Company_Category;
        private System.Windows.Forms.Label lbl_Company_Name;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Button bttnAddNew;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBx_Sector;
        private System.Windows.Forms.ComboBox cmbBx_Country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBx_Risk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBx_Stock_Value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBx_Previous_Stock_Value;
    }
}