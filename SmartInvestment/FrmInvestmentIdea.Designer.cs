
namespace SmartInvestment
{
    partial class FrmInvestmentIdea
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
            this.txtBx_IdeaId = new System.Windows.Forms.TextBox();
            this.txtBx_Idea_Name = new System.Windows.Forms.TextBox();
            this.txtBx_IdeaCreatedDate = new System.Windows.Forms.TextBox();
            this.cmbBx_InvestmentCategories = new System.Windows.Forms.ComboBox();
            this.lbl_Idea_Id = new System.Windows.Forms.Label();
            this.lbl_Idea_Category = new System.Windows.Forms.Label();
            this.lbl_Idea_Name = new System.Windows.Forms.Label();
            this.lbl_idea_CreatedDate = new System.Windows.Forms.Label();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttnAddNew = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(601, 293);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txtBx_IdeaId
            // 
            this.txtBx_IdeaId.Location = new System.Drawing.Point(68, 70);
            this.txtBx_IdeaId.Name = "txtBx_IdeaId";
            this.txtBx_IdeaId.ReadOnly = true;
            this.txtBx_IdeaId.Size = new System.Drawing.Size(69, 26);
            this.txtBx_IdeaId.TabIndex = 2;
            // 
            // txtBx_Idea_Name
            // 
            this.txtBx_Idea_Name.Location = new System.Drawing.Point(68, 144);
            this.txtBx_Idea_Name.Name = "txtBx_Idea_Name";
            this.txtBx_Idea_Name.Size = new System.Drawing.Size(142, 26);
            this.txtBx_Idea_Name.TabIndex = 3;
            // 
            // txtBx_IdeaCreatedDate
            // 
            this.txtBx_IdeaCreatedDate.Location = new System.Drawing.Point(233, 144);
            this.txtBx_IdeaCreatedDate.Name = "txtBx_IdeaCreatedDate";
            this.txtBx_IdeaCreatedDate.Size = new System.Drawing.Size(142, 26);
            this.txtBx_IdeaCreatedDate.TabIndex = 4;
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
            // lbl_Idea_Id
            // 
            this.lbl_Idea_Id.AutoSize = true;
            this.lbl_Idea_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idea_Id.Location = new System.Drawing.Point(64, 44);
            this.lbl_Idea_Id.Name = "lbl_Idea_Id";
            this.lbl_Idea_Id.Size = new System.Drawing.Size(73, 22);
            this.lbl_Idea_Id.TabIndex = 6;
            this.lbl_Idea_Id.Text = "Idea ID";
            this.lbl_Idea_Id.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Idea_Category
            // 
            this.lbl_Idea_Category.AutoSize = true;
            this.lbl_Idea_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idea_Category.Location = new System.Drawing.Point(229, 44);
            this.lbl_Idea_Category.Name = "lbl_Idea_Category";
            this.lbl_Idea_Category.Size = new System.Drawing.Size(135, 22);
            this.lbl_Idea_Category.TabIndex = 7;
            this.lbl_Idea_Category.Text = "Idea Category";
            // 
            // lbl_Idea_Name
            // 
            this.lbl_Idea_Name.AutoSize = true;
            this.lbl_Idea_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idea_Name.Location = new System.Drawing.Point(64, 119);
            this.lbl_Idea_Name.Name = "lbl_Idea_Name";
            this.lbl_Idea_Name.Size = new System.Drawing.Size(105, 22);
            this.lbl_Idea_Name.TabIndex = 8;
            this.lbl_Idea_Name.Text = "Idea Name";
            // 
            // lbl_idea_CreatedDate
            // 
            this.lbl_idea_CreatedDate.AutoSize = true;
            this.lbl_idea_CreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idea_CreatedDate.Location = new System.Drawing.Point(229, 119);
            this.lbl_idea_CreatedDate.Name = "lbl_idea_CreatedDate";
            this.lbl_idea_CreatedDate.Size = new System.Drawing.Size(113, 22);
            this.lbl_idea_CreatedDate.TabIndex = 9;
            this.lbl_idea_CreatedDate.Text = "Created On";
            // 
            // bttn_Update
            // 
            this.bttn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Update.Location = new System.Drawing.Point(445, 25);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(95, 59);
            this.bttn_Update.TabIndex = 10;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Visible = false;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // bttnAddNew
            // 
            this.bttnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddNew.Location = new System.Drawing.Point(582, 70);
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
            this.bttnSave.Location = new System.Drawing.Point(445, 81);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(95, 59);
            this.bttnSave.TabIndex = 12;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Visible = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.Location = new System.Drawing.Point(445, 139);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(95, 59);
            this.bttnDelete.TabIndex = 13;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Visible = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // FrmInvestmentIdea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 521);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnAddNew);
            this.Controls.Add(this.bttn_Update);
            this.Controls.Add(this.lbl_idea_CreatedDate);
            this.Controls.Add(this.lbl_Idea_Name);
            this.Controls.Add(this.lbl_Idea_Category);
            this.Controls.Add(this.lbl_Idea_Id);
            this.Controls.Add(this.cmbBx_InvestmentCategories);
            this.Controls.Add(this.txtBx_IdeaCreatedDate);
            this.Controls.Add(this.txtBx_Idea_Name);
            this.Controls.Add(this.txtBx_IdeaId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmInvestmentIdea";
            this.Text = "FrmInvestmentIdea";
            this.Load += new System.EventHandler(this.FrmInvestmentIdea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBx_IdeaId;
        private System.Windows.Forms.TextBox txtBx_Idea_Name;
        private System.Windows.Forms.TextBox txtBx_IdeaCreatedDate;
        private System.Windows.Forms.ComboBox cmbBx_InvestmentCategories;
        private System.Windows.Forms.Label lbl_Idea_Id;
        private System.Windows.Forms.Label lbl_Idea_Category;
        private System.Windows.Forms.Label lbl_Idea_Name;
        private System.Windows.Forms.Label lbl_idea_CreatedDate;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Button bttnAddNew;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnDelete;
    }
}