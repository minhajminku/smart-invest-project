
namespace SmartInvestment
{
    partial class frm_Registration
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
            this.txtBx_User_Name = new System.Windows.Forms.TextBox();
            this.txtBx_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.txtBx_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.text_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_LastName = new System.Windows.Forms.TextBox();
            this.txtBx_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.label_sucess = new System.Windows.Forms.Label();
            this.btn_goLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBx_User_Name
            // 
            this.txtBx_User_Name.Location = new System.Drawing.Point(297, 134);
            this.txtBx_User_Name.Name = "txtBx_User_Name";
            this.txtBx_User_Name.Size = new System.Drawing.Size(186, 26);
            this.txtBx_User_Name.TabIndex = 0;
            // 
            // txtBx_Password
            // 
            this.txtBx_Password.Location = new System.Drawing.Point(297, 227);
            this.txtBx_Password.Name = "txtBx_Password";
            this.txtBx_Password.Size = new System.Drawing.Size(186, 26);
            this.txtBx_Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(339, 325);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(89, 34);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txtBx_ConfirmPassword
            // 
            this.txtBx_ConfirmPassword.Location = new System.Drawing.Point(297, 276);
            this.txtBx_ConfirmPassword.Name = "txtBx_ConfirmPassword";
            this.txtBx_ConfirmPassword.Size = new System.Drawing.Size(186, 26);
            this.txtBx_ConfirmPassword.TabIndex = 8;
            // 
            // text_FirstName
            // 
            this.text_FirstName.Location = new System.Drawing.Point(297, 41);
            this.text_FirstName.Name = "text_FirstName";
            this.text_FirstName.Size = new System.Drawing.Size(186, 26);
            this.text_FirstName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirm password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "First name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last name";
            // 
            // text_LastName
            // 
            this.text_LastName.Location = new System.Drawing.Point(297, 85);
            this.text_LastName.Name = "text_LastName";
            this.text_LastName.Size = new System.Drawing.Size(186, 26);
            this.text_LastName.TabIndex = 13;
            // 
            // txtBx_Email
            // 
            this.txtBx_Email.Location = new System.Drawing.Point(297, 178);
            this.txtBx_Email.Name = "txtBx_Email";
            this.txtBx_Email.Size = new System.Drawing.Size(186, 26);
            this.txtBx_Email.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(321, 378);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 20);
            this.label_error.TabIndex = 16;
            this.label_error.Visible = false;
            // 
            // label_sucess
            // 
            this.label_sucess.AutoSize = true;
            this.label_sucess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_sucess.Location = new System.Drawing.Point(469, 332);
            this.label_sucess.Name = "label_sucess";
            this.label_sucess.Size = new System.Drawing.Size(96, 20);
            this.label_sucess.TabIndex = 17;
            this.label_sucess.Text = "User added.";
            this.label_sucess.Visible = false;
            // 
            // btn_goLogin
            // 
            this.btn_goLogin.Location = new System.Drawing.Point(183, 325);
            this.btn_goLogin.Name = "btn_goLogin";
            this.btn_goLogin.Size = new System.Drawing.Size(126, 34);
            this.btn_goLogin.TabIndex = 18;
            this.btn_goLogin.Text = "Go to login";
            this.btn_goLogin.UseVisualStyleBackColor = true;
            this.btn_goLogin.Visible = false;
            this.btn_goLogin.Click += new System.EventHandler(this.btn_goLogin_Click);
            // 
            // frm_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_goLogin);
            this.Controls.Add(this.label_sucess);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBx_Email);
            this.Controls.Add(this.text_LastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_FirstName);
            this.Controls.Add(this.txtBx_ConfirmPassword);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_Password);
            this.Controls.Add(this.txtBx_User_Name);
            this.Name = "frm_Registration";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_User_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txtBx_ConfirmPassword;
        private System.Windows.Forms.TextBox text_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_LastName;
        private System.Windows.Forms.TextBox txtBx_Password;
        private System.Windows.Forms.TextBox txtBx_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label_sucess;
        private System.Windows.Forms.Button btn_goLogin;
    }
}

