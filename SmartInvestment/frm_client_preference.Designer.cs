
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
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_client_name = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.lbl_Categories = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_Risk = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label_Sector = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.txtbx_clientid = new System.Windows.Forms.TextBox();
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
            // label_client_name
            // 
            this.label_client_name.AutoSize = true;
            this.label_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_client_name.Location = new System.Drawing.Point(256, 4);
            this.label_client_name.Name = "label_client_name";
            this.label_client_name.Size = new System.Drawing.Size(172, 32);
            this.label_client_name.TabIndex = 0;
            this.label_client_name.Text = "client name";
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.Controls.Add(this.listBox4);
            this.panel_body.Controls.Add(this.lbl_Country);
            this.panel_body.Controls.Add(this.listBox3);
            this.panel_body.Controls.Add(this.label_Sector);
            this.panel_body.Controls.Add(this.listBox2);
            this.panel_body.Controls.Add(this.label_Risk);
            this.panel_body.Controls.Add(this.listBox1);
            this.panel_body.Controls.Add(this.lbl_Categories);
            this.panel_body.Location = new System.Drawing.Point(0, 56);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(736, 466);
            this.panel_body.TabIndex = 1;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3"});
            this.listBox1.Location = new System.Drawing.Point(16, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(105, 404);
            this.listBox1.TabIndex = 1;
            // 
            // label_Risk
            // 
            this.label_Risk.AutoSize = true;
            this.label_Risk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Risk.Location = new System.Drawing.Point(176, 15);
            this.label_Risk.Name = "label_Risk";
            this.label_Risk.Size = new System.Drawing.Size(45, 22);
            this.label_Risk.TabIndex = 2;
            this.label_Risk.Text = "Risk";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3"});
            this.listBox2.Location = new System.Drawing.Point(180, 40);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(105, 404);
            this.listBox2.TabIndex = 3;
            // 
            // label_Sector
            // 
            this.label_Sector.AutoSize = true;
            this.label_Sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sector.Location = new System.Drawing.Point(335, 15);
            this.label_Sector.Name = "label_Sector";
            this.label_Sector.Size = new System.Drawing.Size(71, 22);
            this.label_Sector.TabIndex = 4;
            this.label_Sector.Text = "Sectors";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3"});
            this.listBox3.Location = new System.Drawing.Point(339, 40);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox3.Size = new System.Drawing.Size(105, 404);
            this.listBox3.TabIndex = 5;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3"});
            this.listBox4.Location = new System.Drawing.Point(504, 40);
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox4.Size = new System.Drawing.Size(105, 404);
            this.listBox4.TabIndex = 7;
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.Location = new System.Drawing.Point(500, 15);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(73, 22);
            this.lbl_Country.TabIndex = 6;
            this.lbl_Country.Text = "Country";
            // 
            // txtbx_clientid
            // 
            this.txtbx_clientid.Location = new System.Drawing.Point(12, 11);
            this.txtbx_clientid.Name = "txtbx_clientid";
            this.txtbx_clientid.Size = new System.Drawing.Size(100, 26);
            this.txtbx_clientid.TabIndex = 1;
            this.txtbx_clientid.Visible = false;
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_Categories;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label_Risk;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label_Sector;
        private System.Windows.Forms.TextBox txtbx_clientid;
    }
}