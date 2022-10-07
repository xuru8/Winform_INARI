
namespace prj禾悅烘焙訂購
{
    partial class prjLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prjLogin));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBoxLOGO = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnResetpassword = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(124, 171);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(279, 29);
            this.txtPassword.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(64, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "密碼:";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(124, 118);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(279, 29);
            this.txtAccount.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(64, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 42);
            this.label5.TabIndex = 13;
            this.label5.Text = "帳號:\r\n(Email)";
            // 
            // picBoxLOGO
            // 
            this.picBoxLOGO.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLOGO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxLOGO.BackgroundImage")));
            this.picBoxLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxLOGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxLOGO.Location = new System.Drawing.Point(-1, 2);
            this.picBoxLOGO.Name = "picBoxLOGO";
            this.picBoxLOGO.Size = new System.Drawing.Size(463, 99);
            this.picBoxLOGO.TabIndex = 17;
            this.picBoxLOGO.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.Location = new System.Drawing.Point(145, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 27);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnResetpassword
            // 
            this.btnResetpassword.BackColor = System.Drawing.Color.Transparent;
            this.btnResetpassword.FlatAppearance.BorderSize = 0;
            this.btnResetpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetpassword.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnResetpassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnResetpassword.Location = new System.Drawing.Point(319, 222);
            this.btnResetpassword.Name = "btnResetpassword";
            this.btnResetpassword.Size = new System.Drawing.Size(75, 27);
            this.btnResetpassword.TabIndex = 19;
            this.btnResetpassword.Text = "忘記密碼?";
            this.btnResetpassword.UseVisualStyleBackColor = false;
            this.btnResetpassword.Click += new System.EventHandler(this.btnResetpassword_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRegister.Location = new System.Drawing.Point(230, 222);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(79, 27);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "尚未註冊";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // prjLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prj禾悅烘焙訂購.Resource1.背景3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 261);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnResetpassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picBoxLOGO);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label5);
            this.Name = "prjLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "prjLogin";
            this.Load += new System.EventHandler(this.prjLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBoxLOGO;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnResetpassword;
        private System.Windows.Forms.Button btnRegister;
    }
}