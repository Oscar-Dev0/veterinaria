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
            lbl_dias_de_estancia = new Label();
            lbl_costo = new Label();
            lbl_ = new Label();
            CLBx_tratamiento = new CheckedListBox();
            lbl_resultado = new Label();
            lbl_diagnostico = new Label();
            rtb_diagnostico = new RichTextBox();
            CB_dead = new CheckBox();
            CB_cremacion = new CheckBox();
            lbl_title_total = new Label();
            lbl_txt_total = new Label();
            lbl_doctor = new Label();
            lbl_doctor_text = new Label();
            lbl_day_text = new Label();
            lbl_estancia_txt = new Label();
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
            // lbl_dias_de_estancia
            // 
            lbl_dias_de_estancia.AutoSize = true;
            lbl_dias_de_estancia.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dias_de_estancia.Location = new Point(12, 56);
            lbl_dias_de_estancia.Name = "lbl_dias_de_estancia";
            lbl_dias_de_estancia.Size = new Size(162, 23);
            lbl_dias_de_estancia.TabIndex = 1;
            lbl_dias_de_estancia.Text = "Dias de estancia:";
            // 
            // lbl_costo
            // 
            lbl_costo.AutoSize = true;
            lbl_costo.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_costo.Location = new Point(12, 79);
            lbl_costo.Name = "lbl_costo";
            lbl_costo.Size = new Size(175, 23);
            lbl_costo.TabIndex = 2;
            lbl_costo.Text = "Costo de estancia:";
            // 
            // lbl_
            // 
            lbl_.AutoSize = true;
            lbl_.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_.Location = new Point(12, 125);
            lbl_.Name = "lbl_";
            lbl_.Size = new Size(118, 23);
            lbl_.TabIndex = 3;
            lbl_.Text = "Tratamiento";
            // 
            // CLBx_tratamiento
            // 
            CLBx_tratamiento.BackColor = SystemColors.ActiveBorder;
            CLBx_tratamiento.BorderStyle = BorderStyle.None;
            CLBx_tratamiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CLBx_tratamiento.FormattingEnabled = true;
            CLBx_tratamiento.Items.AddRange(new object[] { "Vacunacion", "Alimentacion", "Aceo" });
            CLBx_tratamiento.Location = new Point(12, 151);
            CLBx_tratamiento.Name = "CLBx_tratamiento";
            CLBx_tratamiento.Size = new Size(118, 54);
            CLBx_tratamiento.TabIndex = 4;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_resultado.Location = new Point(12, 229);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(99, 23);
            lbl_resultado.TabIndex = 5;
            lbl_resultado.Text = "Resultado";
            // 
            // lbl_diagnostico
            // 
            lbl_diagnostico.AutoSize = true;
            lbl_diagnostico.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_diagnostico.Location = new Point(12, 266);
            lbl_diagnostico.Name = "lbl_diagnostico";
            lbl_diagnostico.Size = new Size(120, 23);
            lbl_diagnostico.TabIndex = 6;
            lbl_diagnostico.Text = "Diagnostico:";
            // 
            // rtb_diagnostico
            // 
            rtb_diagnostico.Location = new Point(12, 292);
            rtb_diagnostico.Name = "rtb_diagnostico";
            rtb_diagnostico.Size = new Size(208, 61);
            rtb_diagnostico.TabIndex = 16;
            rtb_diagnostico.Text = "";
            // 
            // CB_dead
            // 
            CB_dead.AutoSize = true;
            CB_dead.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CB_dead.Location = new Point(247, 294);
            CB_dead.Name = "CB_dead";
            CB_dead.Size = new Size(82, 21);
            CB_dead.TabIndex = 17;
            CB_dead.Text = "Fallecido";
            CB_dead.UseVisualStyleBackColor = true;
            // 
            // CB_cremacion
            // 
            CB_cremacion.AutoSize = true;
            CB_cremacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CB_cremacion.Location = new Point(247, 332);
            CB_cremacion.Name = "CB_cremacion";
            CB_cremacion.Size = new Size(92, 21);
            CB_cremacion.TabIndex = 18;
            CB_cremacion.Text = "Cremacion";
            CB_cremacion.UseVisualStyleBackColor = true;
            // 
            // lbl_title_total
            // 
            lbl_title_total.AutoSize = true;
            lbl_title_total.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title_total.Location = new Point(372, 310);
            lbl_title_total.Name = "lbl_title_total";
            lbl_title_total.Size = new Size(60, 23);
            lbl_title_total.TabIndex = 19;
            lbl_title_total.Text = "Total:";
            // 
            // lbl_txt_total
            // 
            lbl_txt_total.AutoSize = true;
            lbl_txt_total.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_txt_total.Location = new Point(438, 310);
            lbl_txt_total.Name = "lbl_txt_total";
            lbl_txt_total.Size = new Size(53, 23);
            lbl_txt_total.TabIndex = 20;
            lbl_txt_total.Text = "%$%";
            // 
            // lbl_doctor
            // 
            lbl_doctor.AutoSize = true;
            lbl_doctor.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_doctor.Location = new Point(515, 50);
            lbl_doctor.Name = "lbl_doctor";
            lbl_doctor.Size = new Size(69, 23);
            lbl_doctor.TabIndex = 23;
            lbl_doctor.Text = "Doctor";
            // 
            // lbl_doctor_text
            // 
            lbl_doctor_text.AutoSize = true;
            lbl_doctor_text.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_doctor_text.Location = new Point(515, 79);
            lbl_doctor_text.Name = "lbl_doctor_text";
            lbl_doctor_text.Size = new Size(50, 22);
            lbl_doctor_text.TabIndex = 24;
            lbl_doctor_text.Text = "%$%";
            // 
            // lbl_day_text
            // 
            lbl_day_text.AutoSize = true;
            lbl_day_text.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_day_text.Location = new Point(180, 57);
            lbl_day_text.Name = "lbl_day_text";
            lbl_day_text.Size = new Size(50, 22);
            lbl_day_text.TabIndex = 25;
            lbl_day_text.Text = "%$%";
            // 
            // lbl_estancia_txt
            // 
            lbl_estancia_txt.AutoSize = true;
            lbl_estancia_txt.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_estancia_txt.Location = new Point(193, 80);
            lbl_estancia_txt.Name = "lbl_estancia_txt";
            lbl_estancia_txt.Size = new Size(50, 22);
            lbl_estancia_txt.TabIndex = 26;
            lbl_estancia_txt.Text = "%$%";
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(689, 387);
            Controls.Add(lbl_estancia_txt);
            Controls.Add(lbl_day_text);
            Controls.Add(lbl_doctor_text);
            Controls.Add(lbl_doctor);
            Controls.Add(lbl_txt_total);
            Controls.Add(lbl_title_total);
            Controls.Add(CB_cremacion);
            Controls.Add(CB_dead);
            Controls.Add(rtb_diagnostico);
            Controls.Add(lbl_diagnostico);
            Controls.Add(lbl_resultado);
            Controls.Add(CLBx_tratamiento);
            Controls.Add(lbl_);
            Controls.Add(lbl_costo);
            Controls.Add(lbl_dias_de_estancia);
            Controls.Add(lbl_titulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "report";
            Text = "report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_dias_de_estancia;
        private Label lbl_costo;
        private Label lbl_;
        private CheckedListBox CLBx_tratamiento;
        private Label lbl_resultado;
        private Label lbl_diagnostico;
        private RichTextBox rtb_diagnostico;
        private CheckBox CB_dead;
        private CheckBox CB_cremacion;
        private Label lbl_title_total;
        private Label lbl_txt_total;
        private Label lbl_doctor;
        private Label lbl_doctor_text;
        private Label lbl_day_text;
        private Label lbl_estancia_txt;
    }
}