namespace veterinaria
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            lbl_Dueno = new Label();
            txt_Dueno = new TextBox();
            lbl_Name_pet = new Label();
            txt_Name_Pet = new TextBox();
            lbl_date = new Label();
            lbl_year_animal = new Label();
            txt_Raza = new TextBox();
            lbl_raza = new Label();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            txt_direccion = new TextBox();
            lbl_direccion = new Label();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            lbl_diagnostico = new Label();
            lbl_inter = new Label();
            lbl_dead = new Label();
            gb_dead = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gb_dead.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Dueno
            // 
            lbl_Dueno.AutoSize = true;
            lbl_Dueno.BackColor = SystemColors.ControlDarkDark;
            lbl_Dueno.BorderStyle = BorderStyle.FixedSingle;
            lbl_Dueno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Dueno.ForeColor = SystemColors.ButtonFace;
            lbl_Dueno.Location = new Point(12, 9);
            lbl_Dueno.Name = "lbl_Dueno";
            lbl_Dueno.Size = new Size(185, 27);
            lbl_Dueno.TabIndex = 0;
            lbl_Dueno.Text = "Nombre del Dueño";
            // 
            // txt_Dueno
            // 
            txt_Dueno.ForeColor = SystemColors.InfoText;
            txt_Dueno.Location = new Point(12, 39);
            txt_Dueno.Name = "txt_Dueno";
            txt_Dueno.Size = new Size(184, 23);
            txt_Dueno.TabIndex = 1;
            // 
            // lbl_Name_pet
            // 
            lbl_Name_pet.AutoSize = true;
            lbl_Name_pet.BackColor = SystemColors.ControlDarkDark;
            lbl_Name_pet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Name_pet.ForeColor = SystemColors.Control;
            lbl_Name_pet.Location = new Point(12, 104);
            lbl_Name_pet.Name = "lbl_Name_pet";
            lbl_Name_pet.Size = new Size(177, 25);
            lbl_Name_pet.TabIndex = 2;
            lbl_Name_pet.Text = "Nombre de animal";
            // 
            // txt_Name_Pet
            // 
            txt_Name_Pet.Location = new Point(12, 132);
            txt_Name_Pet.Name = "txt_Name_Pet";
            txt_Name_Pet.Size = new Size(177, 23);
            txt_Name_Pet.TabIndex = 3;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.BackColor = SystemColors.ControlDarkDark;
            lbl_date.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_date.ForeColor = SystemColors.Control;
            lbl_date.Location = new Point(12, 348);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(161, 25);
            lbl_date.TabIndex = 4;
            lbl_date.Text = "Fecha de ingreso";
            // 
            // lbl_year_animal
            // 
            lbl_year_animal.AutoSize = true;
            lbl_year_animal.BackColor = SystemColors.ControlDarkDark;
            lbl_year_animal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_year_animal.ForeColor = SystemColors.Control;
            lbl_year_animal.Location = new Point(12, 263);
            lbl_year_animal.Name = "lbl_year_animal";
            lbl_year_animal.Size = new Size(152, 25);
            lbl_year_animal.TabIndex = 6;
            lbl_year_animal.Text = "Edad del animal";
            // 
            // txt_Raza
            // 
            txt_Raza.Location = new Point(12, 214);
            txt_Raza.Name = "txt_Raza";
            txt_Raza.Size = new Size(177, 23);
            txt_Raza.TabIndex = 9;
            // 
            // lbl_raza
            // 
            lbl_raza.AutoSize = true;
            lbl_raza.BackColor = SystemColors.ControlDarkDark;
            lbl_raza.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_raza.ForeColor = SystemColors.Control;
            lbl_raza.Location = new Point(12, 186);
            lbl_raza.Name = "lbl_raza";
            lbl_raza.Size = new Size(149, 25);
            lbl_raza.TabIndex = 8;
            lbl_raza.Text = "Raza del animal";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 291);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.On;
            dateTimePicker1.Location = new Point(12, 376);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(84, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(12, 481);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(208, 23);
            txt_direccion.TabIndex = 13;
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.BackColor = SystemColors.ControlDarkDark;
            lbl_direccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_direccion.ForeColor = SystemColors.Control;
            lbl_direccion.Location = new Point(12, 453);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(208, 25);
            lbl_direccion.TabIndex = 12;
            lbl_direccion.Text = "Direccion del paciente";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Red;
            radioButton1.Location = new Point(3, -1);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(34, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Si";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(531, 368);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(208, 197);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // lbl_diagnostico
            // 
            lbl_diagnostico.AutoSize = true;
            lbl_diagnostico.BackColor = SystemColors.ControlDarkDark;
            lbl_diagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_diagnostico.ForeColor = SystemColors.Control;
            lbl_diagnostico.Location = new Point(531, 331);
            lbl_diagnostico.Name = "lbl_diagnostico";
            lbl_diagnostico.Size = new Size(118, 25);
            lbl_diagnostico.TabIndex = 16;
            lbl_diagnostico.Text = "Diagnostico";
            // 
            // lbl_inter
            // 
            lbl_inter.AutoSize = true;
            lbl_inter.BackColor = SystemColors.ControlDarkDark;
            lbl_inter.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_inter.ForeColor = SystemColors.Control;
            lbl_inter.Location = new Point(383, 11);
            lbl_inter.Name = "lbl_inter";
            lbl_inter.Size = new Size(85, 25);
            lbl_inter.TabIndex = 17;
            lbl_inter.Text = "Internar";
            // 
            // lbl_dead
            // 
            lbl_dead.AutoSize = true;
            lbl_dead.BackColor = SystemColors.ControlDarkDark;
            lbl_dead.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dead.ForeColor = SystemColors.Control;
            lbl_dead.Location = new Point(383, 104);
            lbl_dead.Name = "lbl_dead";
            lbl_dead.Size = new Size(78, 25);
            lbl_dead.TabIndex = 18;
            lbl_dead.Text = "Muerte";
            // 
            // gb_dead
            // 
            gb_dead.Anchor = AnchorStyles.None;
            gb_dead.BackColor = Color.Transparent;
            gb_dead.BackgroundImageLayout = ImageLayout.None;
            gb_dead.Controls.Add(radioButton1);
            gb_dead.FlatStyle = FlatStyle.Flat;
            gb_dead.ForeColor = Color.Transparent;
            gb_dead.ImeMode = ImeMode.Off;
            gb_dead.Location = new Point(484, 104);
            gb_dead.Margin = new Padding(0);
            gb_dead.Name = "gb_dead";
            gb_dead.Padding = new Padding(0);
            gb_dead.Size = new Size(196, 27);
            gb_dead.TabIndex = 0;
            gb_dead.TabStop = false;
            gb_dead.Visible = false;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(751, 577);
            Controls.Add(gb_dead);
            Controls.Add(lbl_dead);
            Controls.Add(lbl_inter);
            Controls.Add(lbl_diagnostico);
            Controls.Add(richTextBox1);
            Controls.Add(txt_direccion);
            Controls.Add(lbl_direccion);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(txt_Raza);
            Controls.Add(lbl_raza);
            Controls.Add(lbl_year_animal);
            Controls.Add(lbl_date);
            Controls.Add(txt_Name_Pet);
            Controls.Add(lbl_Name_pet);
            Controls.Add(txt_Dueno);
            Controls.Add(lbl_Dueno);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "home";
            Text = "home";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gb_dead.ResumeLayout(false);
            gb_dead.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Dueno;
        private TextBox txt_Dueno;
        private Label lbl_Name_pet;
        private TextBox txt_Name_Pet;
        private Label lbl_date;
        private Label lbl_year_animal;
        private TextBox txt_Raza;
        private Label lbl_raza;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_direccion;
        private Label lbl_direccion;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private Label lbl_diagnostico;
        private Label lbl_inter;
        private Label lbl_dead;
        private GroupBox gb_dead;
    }
}