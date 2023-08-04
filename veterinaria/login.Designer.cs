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
            text_user.Font = new Font("Fredoka One", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            text_user.Location = new Point(76, 96);
            text_user.Name = "text_user";
            text_user.Size = new Size(100, 27);
            text_user.TabIndex = 0;
            // 
            // text_passwort
            // 
            text_passwort.BackColor = SystemColors.ScrollBar;
            text_passwort.Font = new Font("Fredoka One", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            text_passwort.Location = new Point(137, 163);
            text_passwort.Name = "text_passwort";
            text_passwort.Size = new Size(100, 27);
            text_passwort.TabIndex = 1;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Transparent;
            btn_Login.BackgroundImage = (Image)resources.GetObject("btn_Login.BackgroundImage");
            btn_Login.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Login.FlatStyle = FlatStyle.Popup;
            btn_Login.ForeColor = Color.Transparent;
            btn_Login.Location = new Point(242, 212);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(67, 104);
            btn_Login.TabIndex = 2;
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += button1_Click;
            // 
            // Veterinaria_login
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(321, 328);
            Controls.Add(btn_Login);
            Controls.Add(text_passwort);
            Controls.Add(text_user);
            Font = new Font("Fredoka One", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Veterinaria_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_user;
        private TextBox text_passwort;
        private Button btn_Login;
    }
}