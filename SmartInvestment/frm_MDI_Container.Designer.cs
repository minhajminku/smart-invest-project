
namespace SmartInvestment
{
    partial class frm_MDI_Container
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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Footer = new System.Windows.Forms.Panel();
            this.panel_Headerbtn_Container = new System.Windows.Forms.Panel();
            this.bttn_Ideas = new System.Windows.Forms.Button();
            this.bttn_investmentCategories = new System.Windows.Forms.Button();
            this.bttn_Client = new System.Windows.Forms.Button();
            this.bttnInvestment = new System.Windows.Forms.Button();
            this.panel_Top.SuspendLayout();
            this.panel_Headerbtn_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_left.AutoSize = true;
            this.pnl_left.Location = new System.Drawing.Point(1, 2);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(103, 532);
            this.pnl_left.TabIndex = 1;
            // 
            // panel_Top
            // 
            this.panel_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Top.Controls.Add(this.lbl_Title);
            this.panel_Top.Location = new System.Drawing.Point(103, 2);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1196, 44);
            this.panel_Top.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(344, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(333, 41);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Investment Solutions";
            // 
            // panel_Footer
            // 
            this.panel_Footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Footer.Location = new System.Drawing.Point(103, 484);
            this.panel_Footer.Name = "panel_Footer";
            this.panel_Footer.Size = new System.Drawing.Size(1196, 47);
            this.panel_Footer.TabIndex = 3;
            // 
            // panel_Headerbtn_Container
            // 
            this.panel_Headerbtn_Container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Headerbtn_Container.Controls.Add(this.bttnInvestment);
            this.panel_Headerbtn_Container.Controls.Add(this.bttn_Ideas);
            this.panel_Headerbtn_Container.Controls.Add(this.bttn_investmentCategories);
            this.panel_Headerbtn_Container.Controls.Add(this.bttn_Client);
            this.panel_Headerbtn_Container.Location = new System.Drawing.Point(103, 47);
            this.panel_Headerbtn_Container.Name = "panel_Headerbtn_Container";
            this.panel_Headerbtn_Container.Size = new System.Drawing.Size(1196, 66);
            this.panel_Headerbtn_Container.TabIndex = 4;
            // 
            // bttn_Ideas
            // 
            this.bttn_Ideas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bttn_Ideas.Location = new System.Drawing.Point(241, 3);
            this.bttn_Ideas.Name = "bttn_Ideas";
            this.bttn_Ideas.Size = new System.Drawing.Size(113, 57);
            this.bttn_Ideas.TabIndex = 2;
            this.bttn_Ideas.Text = "Ideas";
            this.bttn_Ideas.UseVisualStyleBackColor = true;
            this.bttn_Ideas.Click += new System.EventHandler(this.bttn_Ideas_Click);
            // 
            // bttn_investmentCategories
            // 
            this.bttn_investmentCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bttn_investmentCategories.Location = new System.Drawing.Point(122, 3);
            this.bttn_investmentCategories.Name = "bttn_investmentCategories";
            this.bttn_investmentCategories.Size = new System.Drawing.Size(113, 57);
            this.bttn_investmentCategories.TabIndex = 1;
            this.bttn_investmentCategories.Text = "Investment Categories";
            this.bttn_investmentCategories.UseVisualStyleBackColor = true;
            this.bttn_investmentCategories.Click += new System.EventHandler(this.bttn_investmentCategories_Click);
            // 
            // bttn_Client
            // 
            this.bttn_Client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bttn_Client.Location = new System.Drawing.Point(3, 3);
            this.bttn_Client.Name = "bttn_Client";
            this.bttn_Client.Size = new System.Drawing.Size(113, 57);
            this.bttn_Client.TabIndex = 0;
            this.bttn_Client.Text = "Clients";
            this.bttn_Client.UseVisualStyleBackColor = true;
            this.bttn_Client.Click += new System.EventHandler(this.bttn_Client_Click);
            // 
            // bttnInvestment
            // 
            this.bttnInvestment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnInvestment.Location = new System.Drawing.Point(360, 3);
            this.bttnInvestment.Name = "bttnInvestment";
            this.bttnInvestment.Size = new System.Drawing.Size(113, 57);
            this.bttnInvestment.TabIndex = 3;
            this.bttnInvestment.Text = "Investment";
            this.bttnInvestment.UseVisualStyleBackColor = true;
            this.bttnInvestment.Click += new System.EventHandler(this.bttnInvestment_Click);
            // 
            // frm_MDI_Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 534);
            this.Controls.Add(this.panel_Headerbtn_Container);
            this.Controls.Add(this.panel_Footer);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.pnl_left);
            this.IsMdiContainer = true;
            this.Name = "frm_MDI_Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Investment ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Headerbtn_Container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Footer;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_Headerbtn_Container;
        private System.Windows.Forms.Button bttn_Client;
        private System.Windows.Forms.Button bttn_investmentCategories;
        private System.Windows.Forms.Button bttn_Ideas;
        private System.Windows.Forms.Button bttnInvestment;
    }
}