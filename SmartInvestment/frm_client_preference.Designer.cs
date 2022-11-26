
namespace SmartInvestment
{
    partial class frm_client_preference
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
            PresentationControls.CheckBoxProperties checkBoxProperties3 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties5 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties2 = new PresentationControls.CheckBoxProperties();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.txtbx_clientid = new System.Windows.Forms.TextBox();
            this.label_client_name = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.label_Sector = new System.Windows.Forms.Label();
            this.lbl_Categories = new System.Windows.Forms.Label();
            this.chckCmBx_Category = new PresentationControls.CheckBoxComboBox();
            this.chckCmBx_Sectors = new PresentationControls.CheckBoxComboBox();
            this.chckCmBx_Country = new PresentationControls.CheckBoxComboBox();
            this.label_Risk = new System.Windows.Forms.Label();
            this.chckCmBx_Risk = new PresentationControls.CheckBoxComboBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.panel_Top.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Top.Controls.Add(this.txtbx_clientid);
            this.panel_Top.Controls.Add(this.label_client_name);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(736, 50);
            this.panel_Top.TabIndex = 0;
            // 
            // txtbx_clientid
            // 
            this.txtbx_clientid.Location = new System.Drawing.Point(12, 11);
            this.txtbx_clientid.Name = "txtbx_clientid";
            this.txtbx_clientid.Size = new System.Drawing.Size(100, 26);
            this.txtbx_clientid.TabIndex = 1;
            this.txtbx_clientid.Visible = false;
            // 
            // label_client_name
            // 
            this.label_client_name.AutoSize = true;
            this.label_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_client_name.Location = new System.Drawing.Point(256, 4);
            this.label_client_name.Name = "label_client_name";
            this.label_client_name.Size = new System.Drawing.Size(171, 32);
            this.label_client_name.TabIndex = 0;
            this.label_client_name.Text = "client name";
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.Controls.Add(this.bttnSave);
            this.panel_body.Controls.Add(this.chckCmBx_Country);
            this.panel_body.Controls.Add(this.chckCmBx_Sectors);
            this.panel_body.Controls.Add(this.chckCmBx_Risk);
            this.panel_body.Controls.Add(this.chckCmBx_Category);
            this.panel_body.Controls.Add(this.lbl_Country);
            this.panel_body.Controls.Add(this.label_Sector);
            this.panel_body.Controls.Add(this.label_Risk);
            this.panel_body.Controls.Add(this.lbl_Categories);
            this.panel_body.Location = new System.Drawing.Point(0, 56);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(736, 466);
            this.panel_body.TabIndex = 1;
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.Location = new System.Drawing.Point(303, 93);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(73, 22);
            this.lbl_Country.TabIndex = 6;
            this.lbl_Country.Text = "Country";
            // 
            // label_Sector
            // 
            this.label_Sector.AutoSize = true;
            this.label_Sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sector.Location = new System.Drawing.Point(303, 15);
            this.label_Sector.Name = "label_Sector";
            this.label_Sector.Size = new System.Drawing.Size(71, 22);
            this.label_Sector.TabIndex = 4;
            this.label_Sector.Text = "Sectors";
            // 
            // lbl_Categories
            // 
            this.lbl_Categories.AutoSize = true;
            this.lbl_Categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categories.Location = new System.Drawing.Point(12, 15);
            this.lbl_Categories.Name = "lbl_Categories";
            this.lbl_Categories.Size = new System.Drawing.Size(83, 22);
            this.lbl_Categories.TabIndex = 0;
            this.lbl_Categories.Text = "Categery";
            // 
            // chckCmBx_Category
            // 
            checkBoxProperties3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chckCmBx_Category.CheckBoxProperties = checkBoxProperties3;
            this.chckCmBx_Category.DisplayMemberSingleItem = "";
            this.chckCmBx_Category.FormattingEnabled = true;
            this.chckCmBx_Category.Location = new System.Drawing.Point(12, 40);
            this.chckCmBx_Category.Name = "chckCmBx_Category";
            this.chckCmBx_Category.Size = new System.Drawing.Size(245, 28);
            this.chckCmBx_Category.TabIndex = 8;
            // 
            // chckCmBx_Sectors
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chckCmBx_Sectors.CheckBoxProperties = checkBoxProperties1;
            this.chckCmBx_Sectors.DisplayMemberSingleItem = "";
            this.chckCmBx_Sectors.FormattingEnabled = true;
            this.chckCmBx_Sectors.Location = new System.Drawing.Point(307, 40);
            this.chckCmBx_Sectors.Name = "chckCmBx_Sectors";
            this.chckCmBx_Sectors.Size = new System.Drawing.Size(273, 28);
            this.chckCmBx_Sectors.TabIndex = 10;
            // 
            // chckCmBx_Country
            // 
            checkBoxProperties5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chckCmBx_Country.CheckBoxProperties = checkBoxProperties5;
            this.chckCmBx_Country.DisplayMemberSingleItem = "";
            this.chckCmBx_Country.FormattingEnabled = true;
            this.chckCmBx_Country.Location = new System.Drawing.Point(310, 118);
            this.chckCmBx_Country.Name = "chckCmBx_Country";
            this.chckCmBx_Country.Size = new System.Drawing.Size(270, 28);
            this.chckCmBx_Country.TabIndex = 11;
            // 
            // label_Risk
            // 
            this.label_Risk.AutoSize = true;
            this.label_Risk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Risk.Location = new System.Drawing.Point(12, 93);
            this.label_Risk.Name = "label_Risk";
            this.label_Risk.Size = new System.Drawing.Size(45, 22);
            this.label_Risk.TabIndex = 2;
            this.label_Risk.Text = "Risk";
            // 
            // chckCmBx_Risk
            // 
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chckCmBx_Risk.CheckBoxProperties = checkBoxProperties2;
            this.chckCmBx_Risk.DisplayMemberSingleItem = "";
            this.chckCmBx_Risk.FormattingEnabled = true;
            this.chckCmBx_Risk.Location = new System.Drawing.Point(16, 118);
            this.chckCmBx_Risk.Name = "chckCmBx_Risk";
            this.chckCmBx_Risk.Size = new System.Drawing.Size(241, 28);
            this.chckCmBx_Risk.TabIndex = 9;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(458, 171);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(121, 36);
            this.bttnSave.TabIndex = 12;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // frm_client_preference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 523);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_Top);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_client_preference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_client_preference";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_client_name;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Label lbl_Categories;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label label_Sector;
        private System.Windows.Forms.TextBox txtbx_clientid;
        private PresentationControls.CheckBoxComboBox chckCmBx_Country;
        private PresentationControls.CheckBoxComboBox chckCmBx_Sectors;
        private PresentationControls.CheckBoxComboBox chckCmBx_Risk;
        private PresentationControls.CheckBoxComboBox chckCmBx_Category;
        private System.Windows.Forms.Label label_Risk;
        private System.Windows.Forms.Button bttnSave;
    }
}