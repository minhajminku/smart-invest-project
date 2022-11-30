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
            this.bttnSearch = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbxClient = new System.Windows.Forms.ComboBox();
            this.cmbxIdea = new System.Windows.Forms.ComboBox();
            this.lblIdea = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.datagrdInvestmentData = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdInvestmentData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.cmbxIdea);
            this.pnlHeader.Controls.Add(this.lblIdea);
            this.pnlHeader.Controls.Add(this.cmbxClient);
            this.pnlHeader.Controls.Add(this.lblClient);
            this.pnlHeader.Controls.Add(this.bttnSearch);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1111, 89);
            this.pnlHeader.TabIndex = 0;
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(628, 28);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(118, 36);
            this.bttnSearch.TabIndex = 0;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(12, 10);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(49, 20);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client";
            // 
            // cmbxClient
            // 
            this.cmbxClient.FormattingEnabled = true;
            this.cmbxClient.Location = new System.Drawing.Point(16, 33);
            this.cmbxClient.Name = "cmbxClient";
            this.cmbxClient.Size = new System.Drawing.Size(284, 28);
            this.cmbxClient.TabIndex = 3;
            // 
            // cmbxIdea
            // 
            this.cmbxIdea.FormattingEnabled = true;
            this.cmbxIdea.Location = new System.Drawing.Point(325, 33);
            this.cmbxIdea.Name = "cmbxIdea";
            this.cmbxIdea.Size = new System.Drawing.Size(284, 28);
            this.cmbxIdea.TabIndex = 5;
            // 
            // lblIdea
            // 
            this.lblIdea.AutoSize = true;
            this.lblIdea.Location = new System.Drawing.Point(321, 10);
            this.lblIdea.Name = "lblIdea";
            this.lblIdea.Size = new System.Drawing.Size(41, 20);
            this.lblIdea.TabIndex = 4;
            this.lblIdea.Text = "Idea";
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.datagrdInvestmentData.Location = new System.Drawing.Point(3, 3);
            this.datagrdInvestmentData.Name = "datagrdInvestmentData";
            this.datagrdInvestmentData.RowHeadersWidth = 62;
            this.datagrdInvestmentData.RowTemplate.Height = 28;
            this.datagrdInvestmentData.Size = new System.Drawing.Size(1104, 500);
            this.datagrdInvestmentData.TabIndex = 0;
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
        private System.Windows.Forms.ComboBox cmbxClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbxIdea;
        private System.Windows.Forms.Label lblIdea;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.DataGridView datagrdInvestmentData;
    }
}