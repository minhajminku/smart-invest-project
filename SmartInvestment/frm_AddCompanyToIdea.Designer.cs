namespace SmartInvestment
{
    partial class frm_AddCompanyToIdea
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtbxSearchByName = new System.Windows.Forms.TextBox();
            this.lblIdeaName = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.datagrid_Companies = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.bttnSaveToIdea = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Companies)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.bttnSearch);
            this.pnlHeader.Controls.Add(this.lblSearchName);
            this.pnlHeader.Controls.Add(this.txtbxSearchByName);
            this.pnlHeader.Controls.Add(this.lblIdeaName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1411, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(265, 23);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(123, 40);
            this.bttnSearch.TabIndex = 3;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(23, 8);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(51, 20);
            this.lblSearchName.TabIndex = 2;
            this.lblSearchName.Text = "Name";
            // 
            // txtbxSearchByName
            // 
            this.txtbxSearchByName.Location = new System.Drawing.Point(27, 30);
            this.txtbxSearchByName.Name = "txtbxSearchByName";
            this.txtbxSearchByName.Size = new System.Drawing.Size(199, 26);
            this.txtbxSearchByName.TabIndex = 1;
            // 
            // lblIdeaName
            // 
            this.lblIdeaName.AutoSize = true;
            this.lblIdeaName.Location = new System.Drawing.Point(531, 30);
            this.lblIdeaName.Name = "lblIdeaName";
            this.lblIdeaName.Size = new System.Drawing.Size(41, 20);
            this.lblIdeaName.TabIndex = 0;
            this.lblIdeaName.Text = "Idea";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.Controls.Add(this.datagrid_Companies);
            this.pnlBody.Location = new System.Drawing.Point(2, 83);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1405, 440);
            this.pnlBody.TabIndex = 1;
            // 
            // datagrid_Companies
            // 
            this.datagrid_Companies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_Companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Companies.Location = new System.Drawing.Point(10, 3);
            this.datagrid_Companies.Name = "datagrid_Companies";
            this.datagrid_Companies.RowHeadersWidth = 62;
            this.datagrid_Companies.RowTemplate.Height = 28;
            this.datagrid_Companies.Size = new System.Drawing.Size(1370, 368);
            this.datagrid_Companies.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.Controls.Add(this.bttnSaveToIdea);
            this.pnlFooter.Location = new System.Drawing.Point(0, 529);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1407, 58);
            this.pnlFooter.TabIndex = 2;
            // 
            // bttnSaveToIdea
            // 
            this.bttnSaveToIdea.Location = new System.Drawing.Point(1233, 15);
            this.bttnSaveToIdea.Name = "bttnSaveToIdea";
            this.bttnSaveToIdea.Size = new System.Drawing.Size(149, 40);
            this.bttnSaveToIdea.TabIndex = 5;
            this.bttnSaveToIdea.Text = "Save To Idea";
            this.bttnSaveToIdea.UseVisualStyleBackColor = true;
            this.bttnSaveToIdea.Click += new System.EventHandler(this.bttnSaveToIdea_Click);
            // 
            // frm_AddCompanyToIdea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 599);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frm_AddCompanyToIdea";
            this.Text = "frm_AddCompanyToIdea";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Companies)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DataGridView datagrid_Companies;
        private System.Windows.Forms.Label lblIdeaName;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtbxSearchByName;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button bttnSaveToIdea;
    }
}