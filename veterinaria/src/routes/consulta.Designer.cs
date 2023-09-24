namespace veterinaria
{
    partial class consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consulta));
            txt_Owner = new TextBox();
            txt_Name_Pet = new TextBox();
            num_year = new NumericUpDown();
            DTP_pet_ingreso = new DateTimePicker();
            txt_direccion = new TextBox();
            rtb_diagnostico = new RichTextBox();
            gb_dead = new GroupBox();
            Rbtn_dead_yes = new RadioButton();
            Rbtn_dead_not = new RadioButton();
            lbl_doctor = new Label();
            gb_internar = new GroupBox();
            Rbtn_internar_not = new RadioButton();
            Rbtn_internar_yes = new RadioButton();
            CB_pet = new ComboBox();
            CB_tipo_raza = new ComboBox();
            btn_next = new Button();
            btn_leave = new Button();
            btn_delete = new Button();
            lbl_total_text = new Label();
            ((System.ComponentModel.ISupportInitialize)num_year).BeginInit();
            gb_dead.SuspendLayout();
            gb_internar.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Owner
            // 
            txt_Owner.ForeColor = SystemColors.InfoText;
            txt_Owner.Location = new Point(93, 44);
            txt_Owner.Name = "txt_Owner";
            txt_Owner.Size = new Size(266, 23);
            txt_Owner.TabIndex = 1;
            // 
            // txt_Name_Pet
            // 
            txt_Name_Pet.Location = new Point(93, 118);
            txt_Name_Pet.Name = "txt_Name_Pet";
            txt_Name_Pet.Size = new Size(266, 23);
            txt_Name_Pet.TabIndex = 3;
            // 
            // num_year
            // 
            num_year.Location = new Point(93, 273);
            num_year.Name = "num_year";
            num_year.Size = new Size(266, 23);
            num_year.TabIndex = 10;
            // 
            // DTP_pet_ingreso
            // 
            DTP_pet_ingreso.CustomFormat = "";
            DTP_pet_ingreso.ImeMode = ImeMode.On;
            DTP_pet_ingreso.Location = new Point(93, 345);
            DTP_pet_ingreso.Name = "DTP_pet_ingreso";
            DTP_pet_ingreso.Size = new Size(266, 23);
            DTP_pet_ingreso.TabIndex = 11;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(93, 433);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(266, 23);
            txt_direccion.TabIndex = 13;
            // 
            // rtb_diagnostico
            // 
            rtb_diagnostico.Location = new Point(592, 433);
            rtb_diagnostico.Name = "rtb_diagnostico";
            rtb_diagnostico.Size = new Size(210, 148);
            rtb_diagnostico.TabIndex = 15;
            rtb_diagnostico.Text = "";
            // 
            // gb_dead
            // 
            gb_dead.Anchor = AnchorStyles.None;
            gb_dead.BackColor = Color.Transparent;
            gb_dead.BackgroundImageLayout = ImageLayout.None;
            gb_dead.Controls.Add(Rbtn_dead_yes);
            gb_dead.Controls.Add(Rbtn_dead_not);
            gb_dead.FlatStyle = FlatStyle.Flat;
            gb_dead.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gb_dead.ForeColor = Color.Transparent;
            gb_dead.ImeMode = ImeMode.Off;
            gb_dead.Location = new Point(700, 114);
            gb_dead.Margin = new Padding(0);
            gb_dead.Name = "gb_dead";
            gb_dead.Padding = new Padding(0);
            gb_dead.Size = new Size(88, 27);
            gb_dead.TabIndex = 0;
            gb_dead.TabStop = false;
            // 
            // Rbtn_dead_yes
            // 
            Rbtn_dead_yes.AutoSize = true;
            Rbtn_dead_yes.BackColor = Color.Green;
            Rbtn_dead_yes.Cursor = Cursors.Hand;
            Rbtn_dead_yes.Location = new Point(3, 3);
            Rbtn_dead_yes.Name = "Rbtn_dead_yes";
            Rbtn_dead_yes.Size = new Size(36, 21);
            Rbtn_dead_yes.TabIndex = 16;
            Rbtn_dead_yes.Text = "Si";
            Rbtn_dead_yes.UseVisualStyleBackColor = false;
            // 
            // Rbtn_dead_not
            // 
            Rbtn_dead_not.AutoSize = true;
            Rbtn_dead_not.BackColor = Color.Red;
            Rbtn_dead_not.Checked = true;
            Rbtn_dead_not.Cursor = Cursors.Hand;
            Rbtn_dead_not.Location = new Point(45, 3);
            Rbtn_dead_not.Name = "Rbtn_dead_not";
            Rbtn_dead_not.Size = new Size(44, 21);
            Rbtn_dead_not.TabIndex = 15;
            Rbtn_dead_not.TabStop = true;
            Rbtn_dead_not.Text = "No";
            Rbtn_dead_not.UseVisualStyleBackColor = false;
            // 
            // lbl_doctor
            // 
            lbl_doctor.AutoSize = true;
            lbl_doctor.BackColor = Color.Transparent;
            lbl_doctor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_doctor.ForeColor = SystemColors.Control;
            lbl_doctor.Location = new Point(539, 290);
            lbl_doctor.Name = "lbl_doctor";
            lbl_doctor.Size = new Size(96, 25);
            lbl_doctor.TabIndex = 20;
            lbl_doctor.Text = "%Name%";
            lbl_doctor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gb_internar
            // 
            gb_internar.Anchor = AnchorStyles.None;
            gb_internar.BackColor = Color.Transparent;
            gb_internar.BackgroundImageLayout = ImageLayout.None;
            gb_internar.Controls.Add(Rbtn_internar_not);
            gb_internar.Controls.Add(Rbtn_internar_yes);
            gb_internar.FlatStyle = FlatStyle.Flat;
            gb_internar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gb_internar.ForeColor = Color.Transparent;
            gb_internar.ImeMode = ImeMode.Off;
            gb_internar.Location = new Point(700, 40);
            gb_internar.Margin = new Padding(0);
            gb_internar.Name = "gb_internar";
            gb_internar.Padding = new Padding(0);
            gb_internar.Size = new Size(86, 27);
            gb_internar.TabIndex = 21;
            gb_internar.TabStop = false;
            // 
            // Rbtn_internar_not
            // 
            Rbtn_internar_not.AutoSize = true;
            Rbtn_internar_not.BackColor = Color.Red;
            Rbtn_internar_not.Checked = true;
            Rbtn_internar_not.Cursor = Cursors.Hand;
            Rbtn_internar_not.Location = new Point(47, 4);
            Rbtn_internar_not.Name = "Rbtn_internar_not";
            Rbtn_internar_not.Size = new Size(44, 21);
            Rbtn_internar_not.TabIndex = 17;
            Rbtn_internar_not.TabStop = true;
            Rbtn_internar_not.Text = "No";
            Rbtn_internar_not.UseVisualStyleBackColor = false;
            // 
            // Rbtn_internar_yes
            // 
            Rbtn_internar_yes.AutoSize = true;
            Rbtn_internar_yes.BackColor = Color.Green;
            Rbtn_internar_yes.Cursor = Cursors.Hand;
            Rbtn_internar_yes.Location = new Point(3, 3);
            Rbtn_internar_yes.Name = "Rbtn_internar_yes";
            Rbtn_internar_yes.Size = new Size(36, 21);
            Rbtn_internar_yes.TabIndex = 14;
            Rbtn_internar_yes.Text = "Si";
            Rbtn_internar_yes.UseVisualStyleBackColor = false;
            // 
            // CB_pet
            // 
            CB_pet.BackColor = SystemColors.HighlightText;
            CB_pet.FlatStyle = FlatStyle.Flat;
            CB_pet.ForeColor = SystemColors.InfoText;
            CB_pet.FormattingEnabled = true;
            CB_pet.Items.AddRange(new object[] { "Perro", "Gato", "Perico", "Caballo", "Conejo" });
            CB_pet.Location = new Point(93, 197);
            CB_pet.Name = "CB_pet";
            CB_pet.Size = new Size(266, 23);
            CB_pet.TabIndex = 22;
            CB_pet.Text = "Seleccionar tipo";
            CB_pet.SelectedIndexChanged += CB_pet_SelectedIndexChanged;
            // 
            // CB_tipo_raza
            // 
            CB_tipo_raza.BackColor = SystemColors.HighlightText;
            CB_tipo_raza.Enabled = false;
            CB_tipo_raza.FlatStyle = FlatStyle.Flat;
            CB_tipo_raza.ForeColor = SystemColors.MenuText;
            CB_tipo_raza.FormattingEnabled = true;
            CB_tipo_raza.Location = new Point(539, 197);
            CB_tipo_raza.Name = "CB_tipo_raza";
            CB_tipo_raza.Size = new Size(249, 23);
            CB_tipo_raza.TabIndex = 24;
            CB_tipo_raza.Text = "Seleccionar raza";
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.Transparent;
            btn_next.BackgroundImage = (Image)resources.GetObject("btn_next.BackgroundImage");
            btn_next.BackgroundImageLayout = ImageLayout.Zoom;
            btn_next.Cursor = Cursors.Hand;
            btn_next.Location = new Point(-5, 4);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(92, 60);
            btn_next.TabIndex = 25;
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_save_Click;
            // 
            // btn_leave
            // 
            btn_leave.BackColor = Color.Transparent;
            btn_leave.BackgroundImage = (Image)resources.GetObject("btn_leave.BackgroundImage");
            btn_leave.BackgroundImageLayout = ImageLayout.Zoom;
            btn_leave.Cursor = Cursors.Hand;
            btn_leave.Location = new Point(-5, 136);
            btn_leave.Name = "btn_leave";
            btn_leave.Size = new Size(92, 60);
            btn_leave.TabIndex = 26;
            btn_leave.UseVisualStyleBackColor = false;
            btn_leave.Click += btn_leave_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Transparent;
            btn_delete.BackgroundImage = (Image)resources.GetObject("btn_delete.BackgroundImage");
            btn_delete.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Location = new Point(-5, 70);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(92, 60);
            btn_delete.TabIndex = 27;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // lbl_total_text
            // 
            lbl_total_text.AutoSize = true;
            lbl_total_text.BackColor = Color.Transparent;
            lbl_total_text.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_total_text.ForeColor = SystemColors.ButtonFace;
            lbl_total_text.ImageAlign = ContentAlignment.TopRight;
            lbl_total_text.Location = new Point(702, 365);
            lbl_total_text.Name = "lbl_total_text";
            lbl_total_text.Size = new Size(87, 25);
            lbl_total_text.TabIndex = 28;
            lbl_total_text.Text = "%Total%";
            lbl_total_text.TextAlign = ContentAlignment.MiddleRight;
            // 
            // consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 577);
            Controls.Add(lbl_total_text);
            Controls.Add(btn_delete);
            Controls.Add(btn_leave);
            Controls.Add(btn_next);
            Controls.Add(CB_tipo_raza);
            Controls.Add(CB_pet);
            Controls.Add(gb_internar);
            Controls.Add(lbl_doctor);
            Controls.Add(gb_dead);
            Controls.Add(rtb_diagnostico);
            Controls.Add(txt_direccion);
            Controls.Add(DTP_pet_ingreso);
            Controls.Add(num_year);
            Controls.Add(txt_Name_Pet);
            Controls.Add(txt_Owner);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "consulta";
            Text = "consulta";
            Load += home_Load;
            ((System.ComponentModel.ISupportInitialize)num_year).EndInit();
            gb_dead.ResumeLayout(false);
            gb_dead.PerformLayout();
            gb_internar.ResumeLayout(false);
            gb_internar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Owner;
        private TextBox txt_Name_Pet;
        private NumericUpDown num_year;
        private DateTimePicker DTP_pet_ingreso;
        private TextBox txt_direccion;
        private RichTextBox rtb_diagnostico;
        private Label lbl_doctor;
        public GroupBox gb_dead;
        public RadioButton Rbtn_dead_not;
        public GroupBox gb_internar;
        private ComboBox CB_pet;
        private ComboBox CB_tipo_raza;
        public RadioButton Rbtn_internar_yes;
        public RadioButton Rbtn_dead_yes;
        private Button btn_next;
        private Button btn_leave;
        private Button btn_delete;
        private Label lbl_total_text;
        public RadioButton Rbtn_internar_not;
    }
}