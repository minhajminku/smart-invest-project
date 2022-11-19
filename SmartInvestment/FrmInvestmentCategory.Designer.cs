
namespace SmartInvestment
{
    partial class FrmInvestmentCategory
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
            this.txtBx_CategoryId = new System.Windows.Forms.TextBox();
            this.lbl_Idea_Id = new System.Windows.Forms.Label();
            this.lbl_Idea_Name = new System.Windows.Forms.Label();
            this.txtBx_Category_Name = new System.Windows.Forms.TextBox();
            this.txtBx_CategoryCreatedDate = new System.Windows.Forms.TextBox();
            this.lbl_category_CreatedDate = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 273);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txtBx_CategoryId
            // 
            this.txtBx_CategoryId.Location = new System.Drawing.Point(41, 72);
            this.txtBx_CategoryId.Name = "txtBx_CategoryId";
            this.txtBx_CategoryId.ReadOnly = true;
            this.txtBx_CategoryId.Size = new System.Drawing.Size(69, 26);
            this.txtBx_CategoryId.TabIndex = 3;
            // 
            // lbl_Idea_Id
            // 
            this.lbl_Idea_Id.AutoSize = true;
            this.lbl_Idea_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idea_Id.Location = new System.Drawing.Point(37, 32);
            this.lbl_Idea_Id.Name = "lbl_Idea_Id";
            this.lbl_Idea_Id.Size = new System.Drawing.Size(116, 22);
            this.lbl_Idea_Id.TabIndex = 7;
            this.lbl_Idea_Id.Text = "Category ID";
            // 
            // lbl_Idea_Name
            // 
            this.lbl_Idea_Name.AutoSize = true;
            this.lbl_Idea_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idea_Name.Location = new System.Drawing.Point(163, 32);
            this.lbl_Idea_Name.Name = "lbl_Idea_Name";
            this.lbl_Idea_Name.Size = new System.Drawing.Size(148, 22);
            this.lbl_Idea_Name.TabIndex = 9;
            this.lbl_Idea_Name.Text = "Category Name";
            // 
            // txtBx_Category_Name
            // 
            this.txtBx_Category_Name.Location = new System.Drawing.Point(167, 72);
            this.txtBx_Category_Name.Name = "txtBx_Category_Name";
            this.txtBx_Category_Name.Size = new System.Drawing.Size(142, 26);
            this.txtBx_Category_Name.TabIndex = 10;
            // 
            // txtBx_CategoryCreatedDate
            // 
            this.txtBx_CategoryCreatedDate.Location = new System.Drawing.Point(358, 72);
            this.txtBx_CategoryCreatedDate.Name = "txtBx_CategoryCreatedDate";
            this.txtBx_CategoryCreatedDate.Size = new System.Drawing.Size(142, 26);
            this.txtBx_CategoryCreatedDate.TabIndex = 11;
            // 
            // lbl_category_CreatedDate
            // 
            this.lbl_category_CreatedDate.AutoSize = true;
            this.lbl_category_CreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category_CreatedDate.Location = new System.Drawing.Point(354, 32);
            this.lbl_category_CreatedDate.Name = "lbl_category_CreatedDate";
            this.lbl_category_CreatedDate.Size = new System.Drawing.Size(113, 22);
            this.lbl_category_CreatedDate.TabIndex = 12;
            this.lbl_category_CreatedDate.Text = "Created On";
            // 
            // bttnDelete
            // 
            this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.Location = new System.Drawing.Point(545, 118);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(95, 59);
            this.bttnDelete.TabIndex = 16;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Visible = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click_1);
            // 
            // bttnSave
            // 
            this.bttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.Location = new System.Drawing.Point(545, 63);
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
            this.bttn_Update.Location = new System.Drawing.Point(545, 13);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(95, 59);
            this.bttn_Update.TabIndex = 14;
            this.bttn_Update.Text = "Update";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Visible = false;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // bttnAddNew
            // 
            this.bttnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddNew.Location = new System.Drawing.Point(672, 54);
            this.bttnAddNew.Name = "bttnAddNew";
            this.bttnAddNew.Size = new System.Drawing.Size(136, 59);
            this.bttnAddNew.TabIndex = 17;
            this.bttnAddNew.Text = "Add New";
            this.bttnAddNew.UseVisualStyleBackColor = true;
            this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
            // 
            // FrmInvestmentCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 557);
            this.Controls.Add(this.bttnAddNew);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttn_Update);
            this.Controls.Add(this.lbl_category_CreatedDate);
            this.Controls.Add(this.txtBx_CategoryCreatedDate);
            this.Controls.Add(this.txtBx_Category_Name);
            this.Controls.Add(this.lbl_Idea_Name);
            this.Controls.Add(this.lbl_Idea_Id);
            this.Controls.Add(this.txtBx_CategoryId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmInvestmentCategory";
            this.Text = "FrmInvestmentCategory";
            this.Load += new System.EventHandler(this.FrmInvestmentCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBx_CategoryId;
        private System.Windows.Forms.Label lbl_Idea_Id;
        private System.Windows.Forms.Label lbl_Idea_Name;
        private System.Windows.Forms.TextBox txtBx_Category_Name;
        private System.Windows.Forms.TextBox txtBx_CategoryCreatedDate;
        private System.Windows.Forms.Label lbl_category_CreatedDate;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Button bttnAddNew;
    }
}