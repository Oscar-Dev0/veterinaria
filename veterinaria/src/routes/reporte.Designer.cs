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
            CLBx_tratamiento = new CheckedListBox();
            rtb_diagnostico = new RichTextBox();
            CB_dead = new CheckBox();
            CB_cremacion = new CheckBox();
            lbl_txt_total = new Label();
            lbl_doctor_text = new Label();
            lbl_day_text = new Label();
            lbl_estancia_txt = new Label();
            btn_save = new Button();
            btn_leave = new Button();
            SuspendLayout();
            // 
            // CLBx_tratamiento
            // 
            CLBx_tratamiento.BackColor = SystemColors.ActiveBorder;
            CLBx_tratamiento.BorderStyle = BorderStyle.None;
            CLBx_tratamiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CLBx_tratamiento.FormattingEnabled = true;
            CLBx_tratamiento.Items.AddRange(new object[] { "Vacunacion", "Alimentacion", "Aseo" });
            CLBx_tratamiento.Location = new Point(61, 195);
            CLBx_tratamiento.Name = "CLBx_tratamiento";
            CLBx_tratamiento.Size = new Size(142, 60);
            CLBx_tratamiento.TabIndex = 4;
            // 
            // rtb_diagnostico
            // 
            rtb_diagnostico.Location = new Point(61, 321);
            rtb_diagnostico.Name = "rtb_diagnostico";
            rtb_diagnostico.Size = new Size(208, 61);
            rtb_diagnostico.TabIndex = 16;
            rtb_diagnostico.Text = "";
            // 
            // CB_dead
            // 
            CB_dead.AutoSize = true;
            CB_dead.BackColor = Color.Transparent;
            CB_dead.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CB_dead.ForeColor = Color.White;
            CB_dead.Location = new Point(324, 321);
            CB_dead.Name = "CB_dead";
            CB_dead.Size = new Size(98, 25);
            CB_dead.TabIndex = 17;
            CB_dead.Text = "Fallecido";
            CB_dead.UseVisualStyleBackColor = false;
            CB_dead.CheckedChanged += CB_dead_CheckedChanged;
            // 
            // CB_cremacion
            // 
            CB_cremacion.AutoSize = true;
            CB_cremacion.BackColor = Color.Transparent;
            CB_cremacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CB_cremacion.ForeColor = Color.White;
            CB_cremacion.Location = new Point(324, 354);
            CB_cremacion.Name = "CB_cremacion";
            CB_cremacion.Size = new Size(111, 25);
            CB_cremacion.TabIndex = 18;
            CB_cremacion.Text = "Cremacion";
            CB_cremacion.UseVisualStyleBackColor = false;
            // 
            // lbl_txt_total
            // 
            lbl_txt_total.AutoSize = true;
            lbl_txt_total.BackColor = Color.Transparent;
            lbl_txt_total.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_txt_total.ForeColor = Color.White;
            lbl_txt_total.Location = new Point(495, 329);
            lbl_txt_total.Name = "lbl_txt_total";
            lbl_txt_total.Size = new Size(53, 23);
            lbl_txt_total.TabIndex = 20;
            lbl_txt_total.Text = "%$%";
            // 
            // lbl_doctor_text
            // 
            lbl_doctor_text.AutoSize = true;
            lbl_doctor_text.BackColor = Color.Transparent;
            lbl_doctor_text.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_doctor_text.ForeColor = Color.White;
            lbl_doctor_text.Location = new Point(494, 80);
            lbl_doctor_text.Name = "lbl_doctor_text";
            lbl_doctor_text.Size = new Size(50, 22);
            lbl_doctor_text.TabIndex = 24;
            lbl_doctor_text.Text = "%$%";
            // 
            // lbl_day_text
            // 
            lbl_day_text.AutoSize = true;
            lbl_day_text.BackColor = Color.Transparent;
            lbl_day_text.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_day_text.ForeColor = SystemColors.ButtonHighlight;
            lbl_day_text.Location = new Point(61, 80);
            lbl_day_text.Name = "lbl_day_text";
            lbl_day_text.Size = new Size(50, 22);
            lbl_day_text.TabIndex = 25;
            lbl_day_text.Text = "%$%";
            // 
            // lbl_estancia_txt
            // 
            lbl_estancia_txt.AutoSize = true;
            lbl_estancia_txt.BackColor = Color.Transparent;
            lbl_estancia_txt.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_estancia_txt.ForeColor = Color.White;
            lbl_estancia_txt.Location = new Point(61, 138);
            lbl_estancia_txt.Name = "lbl_estancia_txt";
            lbl_estancia_txt.Size = new Size(50, 22);
            lbl_estancia_txt.TabIndex = 26;
            lbl_estancia_txt.Text = "%$%";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Transparent;
            btn_save.BackgroundImage = (Image)resources.GetObject("btn_save.BackgroundImage");
            btn_save.BackgroundImageLayout = ImageLayout.Zoom;
            btn_save.Cursor = Cursors.Hand;
            btn_save.Location = new Point(-1, 1);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(49, 44);
            btn_save.TabIndex = 29;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_leave
            // 
            btn_leave.BackColor = Color.Transparent;
            btn_leave.BackgroundImage = (Image)resources.GetObject("btn_leave.BackgroundImage");
            btn_leave.BackgroundImageLayout = ImageLayout.Zoom;
            btn_leave.Cursor = Cursors.Hand;
            btn_leave.Location = new Point(0, 51);
            btn_leave.Name = "btn_leave";
            btn_leave.Size = new Size(48, 44);
            btn_leave.TabIndex = 30;
            btn_leave.UseVisualStyleBackColor = false;
            btn_leave.Click += btn_leave_Click;
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(689, 387);
            Controls.Add(btn_leave);
            Controls.Add(btn_save);
            Controls.Add(lbl_estancia_txt);
            Controls.Add(lbl_day_text);
            Controls.Add(lbl_doctor_text);
            Controls.Add(lbl_txt_total);
            Controls.Add(CB_cremacion);
            Controls.Add(CB_dead);
            Controls.Add(rtb_diagnostico);
            Controls.Add(CLBx_tratamiento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "report";
            Text = "report";
            Load += report_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox CLBx_tratamiento;
        private RichTextBox rtb_diagnostico;
        private CheckBox CB_dead;
        private CheckBox CB_cremacion;
        private Label lbl_txt_total;
        private Label lbl_doctor_text;
        private Label lbl_day_text;
        private Label lbl_estancia_txt;
        private Button btn_save;
        private Button btn_leave;
    }
}