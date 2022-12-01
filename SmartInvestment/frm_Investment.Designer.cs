namespace SmartInvestment
{
    partial class frm_Investment
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
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.datagrdInvestmentData = new System.Windows.Forms.DataGridView();
            this.cmbxSearchBy = new System.Windows.Forms.ComboBox();
            this.cmbxSearchBySub = new System.Windows.Forms.ComboBox();
            this.pnlHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdInvestmentData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.Controls.Add(this.cmbxSearchBySub);
            this.pnlHeader.Controls.Add(this.cmbxSearchBy);
            this.pnlHeader.Controls.Add(this.lblSearchBy);
            this.pnlHeader.Controls.Add(this.bttnSearch);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1111, 89);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(12, 10);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(82, 20);
            this.lblSearchBy.TabIndex = 2;
            this.lblSearchBy.Text = "Search By";
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(462, 36);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(125, 35);
            this.bttnSearch.TabIndex = 0;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBody.Controls.Add(this.datagrdInvestmentData);
            this.panelBody.Location = new System.Drawing.Point(1, 90);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1110, 506);
            this.panelBody.TabIndex = 1;
            // 
            // datagrdInvestmentData
            // 
            this.datagrdInvestmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdInvestmentData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrdInvestmentData.Location = new System.Drawing.Point(0, 0);
            this.datagrdInvestmentData.Name = "datagrdInvestmentData";
            this.datagrdInvestmentData.RowHeadersWidth = 62;
            this.datagrdInvestmentData.RowTemplate.Height = 28;
            this.datagrdInvestmentData.Size = new System.Drawing.Size(1110, 506);
            this.datagrdInvestmentData.TabIndex = 0;
            // 
            // cmbxSearchBy
            // 
            this.cmbxSearchBy.FormattingEnabled = true;
            this.cmbxSearchBy.Items.AddRange(new object[] {
            "Idea",
            "Client"});
            this.cmbxSearchBy.Location = new System.Drawing.Point(16, 36);
            this.cmbxSearchBy.Name = "cmbxSearchBy";
            this.cmbxSearchBy.Size = new System.Drawing.Size(144, 28);
            this.cmbxSearchBy.TabIndex = 3;
            this.cmbxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbxSearchBy_SelectedIndexChanged);
            // 
            // cmbxSearchBySub
            // 
            this.cmbxSearchBySub.FormattingEnabled = true;
            this.cmbxSearchBySub.Location = new System.Drawing.Point(167, 36);
            this.cmbxSearchBySub.Name = "cmbxSearchBySub";
            this.cmbxSearchBySub.Size = new System.Drawing.Size(289, 28);
            this.cmbxSearchBySub.TabIndex = 4;
            // 
            // frm_Investment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 596);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frm_Investment";
            this.Text = "frm_Investment";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrdInvestmentData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.DataGridView datagrdInvestmentData;
        private System.Windows.Forms.ComboBox cmbxSearchBy;
        private System.Windows.Forms.ComboBox cmbxSearchBySub;
    }
}