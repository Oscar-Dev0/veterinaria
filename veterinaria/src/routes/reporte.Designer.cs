namespace veterinaria
{
    partial class report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            lbl_titulo = new Label();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(215, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(169, 23);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Reporte al Cliente";
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(689, 571);
            Controls.Add(lbl_titulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "report";
            Text = "report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
    }
}