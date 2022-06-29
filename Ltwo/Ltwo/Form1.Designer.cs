namespace Ltwo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.userpassword = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.upassword = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.şifreleme = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(27, 50);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 16);
            this.username.TabIndex = 2;
            this.username.Text = "user name:";
            // 
            // userpassword
            // 
            this.userpassword.AutoSize = true;
            this.userpassword.Location = new System.Drawing.Point(2, 99);
            this.userpassword.Name = "userpassword";
            this.userpassword.Size = new System.Drawing.Size(98, 16);
            this.userpassword.TabIndex = 3;
            this.userpassword.Text = "user password:";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(106, 47);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(133, 22);
            this.uname.TabIndex = 4;
            // 
            // upassword
            // 
            this.upassword.Location = new System.Drawing.Point(106, 99);
            this.upassword.Name = "upassword";
            this.upassword.Size = new System.Drawing.Size(133, 22);
            this.upassword.TabIndex = 5;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(72, 153);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(139, 38);
            this.login.TabIndex = 6;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(226, 153);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(139, 38);
            this.logout.TabIndex = 7;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // şifreleme
            // 
            this.şifreleme.AutoSize = true;
            this.şifreleme.Location = new System.Drawing.Point(270, 101);
            this.şifreleme.Name = "şifreleme";
            this.şifreleme.Size = new System.Drawing.Size(95, 20);
            this.şifreleme.TabIndex = 8;
            this.şifreleme.Text = "şifreyi gizle";
            this.şifreleme.UseVisualStyleBackColor = true;
            this.şifreleme.CheckedChanged += new System.EventHandler(this.şifreleme_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.şifreleme);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.login);
            this.Controls.Add(this.upassword);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.userpassword);
            this.Controls.Add(this.username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label userpassword;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox upassword;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.CheckBox şifreleme;
    }
}

