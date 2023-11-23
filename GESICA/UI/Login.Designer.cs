namespace GESICA.UI
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
            PanelLogin = new Panel();
            ButtonCancel = new Button();
            ButtonLogin = new Button();
            GroupLogin = new GroupBox();
            TextPassword = new TextBox();
            TextUser = new TextBox();
            LabelPassword = new Label();
            LabelUser = new Label();
            PanelLogin.SuspendLayout();
            GroupLogin.SuspendLayout();
            SuspendLayout();
            // 
            // PanelLogin
            // 
            PanelLogin.BorderStyle = BorderStyle.FixedSingle;
            PanelLogin.Controls.Add(ButtonCancel);
            PanelLogin.Controls.Add(ButtonLogin);
            PanelLogin.Controls.Add(GroupLogin);
            PanelLogin.Dock = DockStyle.Fill;
            PanelLogin.Location = new Point(0, 0);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(600, 350);
            PanelLogin.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.ForeColor = Color.White;
            ButtonCancel.Location = new Point(385, 270);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(130, 32);
            ButtonCancel.TabIndex = 4;
            ButtonCancel.Text = "&Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonLogin
            // 
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.ForeColor = Color.White;
            ButtonLogin.Location = new Point(70, 270);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(130, 32);
            ButtonLogin.TabIndex = 3;
            ButtonLogin.Text = "&Ingresar";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // GroupLogin
            // 
            GroupLogin.Controls.Add(TextPassword);
            GroupLogin.Controls.Add(TextUser);
            GroupLogin.Controls.Add(LabelPassword);
            GroupLogin.Controls.Add(LabelUser);
            GroupLogin.ForeColor = Color.White;
            GroupLogin.Location = new Point(30, 40);
            GroupLogin.Name = "GroupLogin";
            GroupLogin.Size = new Size(530, 175);
            GroupLogin.TabIndex = 0;
            GroupLogin.TabStop = false;
            GroupLogin.Text = "Ingreso";
            // 
            // TextPassword
            // 
            TextPassword.Location = new Point(185, 104);
            TextPassword.Name = "TextPassword";
            TextPassword.PasswordChar = '*';
            TextPassword.Size = new Size(300, 26);
            TextPassword.TabIndex = 2;
            TextPassword.KeyPress += TextPassword_KeyPress;
            // 
            // TextUser
            // 
            TextUser.AutoCompleteMode = AutoCompleteMode.Suggest;
            TextUser.Location = new Point(185, 45);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(300, 26);
            TextUser.TabIndex = 1;
            TextUser.KeyPress += TextUser_KeyPress;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(42, 107);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(108, 19);
            LabelPassword.TabIndex = 0;
            LabelPassword.Text = "Contraseña:";
            // 
            // LabelUser
            // 
            LabelUser.AutoSize = true;
            LabelUser.Location = new Point(42, 48);
            LabelUser.Name = "LabelUser";
            LabelUser.Size = new Size(81, 19);
            LabelUser.TabIndex = 0;
            LabelUser.Text = "Usuario:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(600, 350);
            Controls.Add(PanelLogin);
            Font = new Font("MesloLGS NF", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            Load += Login_Load;
            PanelLogin.ResumeLayout(false);
            GroupLogin.ResumeLayout(false);
            GroupLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLogin;
        private GroupBox GBLogin;
        private GroupBox GroupLogin;
        private Label label1;
        private Label LabelUser;
        private Label LabelPassword;
        private TextBox TextUser;
        private TextBox TextPassword;
        private Button ButtonLogin;
        private Button ButtonCancel;
    }
}