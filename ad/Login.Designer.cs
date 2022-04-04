namespace ad
{
    partial class Login
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
            this.login_btn = new System.Windows.Forms.Button();
            this.registration_btn = new System.Windows.Forms.Button();
            this.back_to_menu = new System.Windows.Forms.Button();
            this.login_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.to_registrate_btn = new System.Windows.Forms.Button();
            this.to_login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(72, 105);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(112, 34);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Вход";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // registration_btn
            // 
            this.registration_btn.Location = new System.Drawing.Point(290, 105);
            this.registration_btn.Name = "registration_btn";
            this.registration_btn.Size = new System.Drawing.Size(163, 34);
            this.registration_btn.TabIndex = 1;
            this.registration_btn.Text = "Регистрация";
            this.registration_btn.UseVisualStyleBackColor = true;
            this.registration_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // back_to_menu
            // 
            this.back_to_menu.Location = new System.Drawing.Point(186, 232);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(142, 34);
            this.back_to_menu.TabIndex = 9;
            this.back_to_menu.Text = "Назад";
            this.back_to_menu.UseVisualStyleBackColor = true;
            this.back_to_menu.Click += new System.EventHandler(this.back_to_menu_Click);
            // 
            // login_box
            // 
            this.login_box.Location = new System.Drawing.Point(162, 14);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(150, 31);
            this.login_box.TabIndex = 10;
            this.login_box.Text = "Логин";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(162, 68);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(150, 31);
            this.password_box.TabIndex = 11;
            this.password_box.Text = "Пароль";
            // 
            // to_registrate_btn
            // 
            this.to_registrate_btn.Location = new System.Drawing.Point(162, 174);
            this.to_registrate_btn.Name = "to_registrate_btn";
            this.to_registrate_btn.Size = new System.Drawing.Size(184, 34);
            this.to_registrate_btn.TabIndex = 12;
            this.to_registrate_btn.Text = "Зарегистрировать";
            this.to_registrate_btn.UseVisualStyleBackColor = true;
            this.to_registrate_btn.Click += new System.EventHandler(this.registration_btn_Click);
            // 
            // to_login_btn
            // 
            this.to_login_btn.Location = new System.Drawing.Point(170, 119);
            this.to_login_btn.Name = "to_login_btn";
            this.to_login_btn.Size = new System.Drawing.Size(142, 34);
            this.to_login_btn.TabIndex = 13;
            this.to_login_btn.Text = "Войти";
            this.to_login_btn.UseVisualStyleBackColor = true;
            this.to_login_btn.Click += new System.EventHandler(this.to_login_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 278);
            this.Controls.Add(this.to_login_btn);
            this.Controls.Add(this.to_registrate_btn);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.back_to_menu);
            this.Controls.Add(this.registration_btn);
            this.Controls.Add(this.login_btn);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button login_btn;
        private Button registration_btn;
        private Button back_to_menu;
        private TextBox login_box;
        private TextBox password_box;
        private Button to_registrate_btn;
        private Button to_login_btn;
    }
}