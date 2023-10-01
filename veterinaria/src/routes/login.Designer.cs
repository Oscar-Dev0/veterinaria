namespace veterinaria
{
    partial class Veterinaria_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veterinaria_login));
            text_user = new TextBox();
            text_passwort = new TextBox();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // text_user
            // 
            text_user.BackColor = SystemColors.ScrollBar;
            text_user.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            text_user.Location = new Point(131, 182);
            text_user.Name = "text_user";
            text_user.Size = new Size(189, 26);
            text_user.TabIndex = 0;
            // 
            // text_passwort
            // 
            text_passwort.BackColor = SystemColors.ScrollBar;
            text_passwort.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            text_passwort.Location = new Point(131, 257);
            text_passwort.Name = "text_passwort";
            text_passwort.PasswordChar = '*';
            text_passwort.Size = new Size(189, 26);
            text_passwort.TabIndex = 1;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Transparent;
            btn_Login.BackgroundImage = (Image)resources.GetObject("btn_Login.BackgroundImage");
            btn_Login.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.FlatStyle = FlatStyle.Popup;
            btn_Login.ForeColor = Color.Transparent;
            btn_Login.Location = new Point(178, 328);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(72, 83);
            btn_Login.TabIndex = 2;
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += button1_Click;
            // 
            // Veterinaria_login
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(458, 451);
            Controls.Add(btn_Login);
            Controls.Add(text_passwort);
            Controls.Add(text_user);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Veterinaria_login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_user;
        private TextBox text_passwort;
        private Button btn_Login;
    }
}