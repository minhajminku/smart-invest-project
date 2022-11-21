
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_Last_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Mobile_no = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_dmat = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.dataGrid_clients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(228, 56);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(47, 33);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(86, 20);
            this.lbl_FirstName.TabIndex = 2;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_Last_Name
            // 
            this.lbl_Last_Name.AutoSize = true;
            this.lbl_Last_Name.Location = new System.Drawing.Point(224, 33);
            this.lbl_Last_Name.Name = "lbl_Last_Name";
            this.lbl_Last_Name.Size = new System.Drawing.Size(86, 20);
            this.lbl_Last_Name.TabIndex = 3;
            this.lbl_Last_Name.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gender";
            // 
            // lbl_Mobile_no
            // 
            this.lbl_Mobile_no.AutoSize = true;
            this.lbl_Mobile_no.Location = new System.Drawing.Point(545, 33);
            this.lbl_Mobile_no.Name = "lbl_Mobile_no";
            this.lbl_Mobile_no.Size = new System.Drawing.Size(115, 20);
            this.lbl_Mobile_no.TabIndex = 7;
            this.lbl_Mobile_no.Text = "Mobile Number";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(549, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // lbl_dmat
            // 
            this.lbl_dmat.AutoSize = true;
            this.lbl_dmat.Location = new System.Drawing.Point(731, 33);
            this.lbl_dmat.Name = "lbl_dmat";
            this.lbl_dmat.Size = new System.Drawing.Size(108, 20);
            this.lbl_dmat.TabIndex = 9;
            this.lbl_dmat.Text = "Dmat Number";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(735, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 8;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Location = new System.Drawing.Point(385, 53);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(121, 28);
            this.comboBox_gender.TabIndex = 10;
            // 
            // dataGrid_clients
            // 
            this.dataGrid_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_clients.Location = new System.Drawing.Point(104, 194);
            this.dataGrid_clients.Name = "dataGrid_clients";
            this.dataGrid_clients.RowHeadersWidth = 62;
            this.dataGrid_clients.RowTemplate.Height = 28;
            this.dataGrid_clients.Size = new System.Drawing.Size(788, 188);
            this.dataGrid_clients.TabIndex = 11;
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 457);
            this.Controls.Add(this.dataGrid_clients);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.lbl_dmat);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbl_Mobile_no);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Last_Name);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmClient";
            this.Text = "FrmClient";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_Last_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Mobile_no;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_dmat;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.DataGridView dataGrid_clients;
    }
}