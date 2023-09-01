using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veterinaria
{
    public partial class home : Form
    {

        public home(string doctor)
        {
            InitializeComponent();
            if (doctor == "root")
            {
                lbl_doctor.Text = "Administración";
            }
            else if (doctor == "doctor_1")
            {
                lbl_doctor.Text = "Oscar Pérez";
            }
            else
            {
                lbl_doctor.Text = doctor;
            };

        }

        private void CB_pet_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_tipo_raza.Visible = true;
            lbl_tipo_raza.Visible = true;
            CB_tipo_raza.Items.Clear();

            var pet = CB_pet.Text.ToString().ToLower();
            switch (pet)
            {
                case "perro":
                    CB_tipo_raza.Items.Add("Doberman");
                    CB_tipo_raza.Items.Add("Labrador Retriever");
                    CB_tipo_raza.Items.Add("Bulldog");
                    CB_tipo_raza.Items.Add("Poodle");
                    CB_tipo_raza.Items.Add("Golden Retriever");
                    break;
                case "gato":
                    CB_tipo_raza.Items.Add("Siamés");
                    CB_tipo_raza.Items.Add("Persa");
                    CB_tipo_raza.Items.Add("Maine Coon");
                    CB_tipo_raza.Items.Add("Bengala");
                    CB_tipo_raza.Items.Add("Ragdoll");
                    break;
                case "perico":
                    CB_tipo_raza.Items.Add("Cotorra Argentina");
                    CB_tipo_raza.Items.Add("Cacatúa");
                    CB_tipo_raza.Items.Add("Agapornis");
                    CB_tipo_raza.Items.Add("Ninfas");
                    CB_tipo_raza.Items.Add("Periquito Australiano");
                    break;
                case "caballo":
                    CB_tipo_raza.Items.Add("Cuarto de Milla");
                    CB_tipo_raza.Items.Add("Pura Sangre Inglés");
                    CB_tipo_raza.Items.Add("Árabe");
                    CB_tipo_raza.Items.Add("Frisón");
                    CB_tipo_raza.Items.Add("Appaloosa");
                    break;
            }



        }

        /// <summary>
        /// Calcula el número de días entre la fecha y hora actual y una fecha de ingreso de mascota especificada.
        /// </summary>
        /// <returns>El número de días entre la fecha y hora actual y la fecha de ingreso de la mascota.</returns>
        public int CalcularNumeroDias()
        {
            // Obtener la fecha y hora actual y fecha Ingreso de la Mascota.
            DateTime actual = DateTime.Now;
            DateTime fechaIngresoMascota = DTP_pet_ingreso.Value;

            // Calcular la diferencia en días entre las dos fechas.
            TimeSpan diferenciaFechas = actual - fechaIngresoMascota;

            int diasRedondeados = diferenciaFechas.Days;

            return diasRedondeados;
        }

        private void home_Load(object sender, EventArgs e)
        {
            lbl_total_text.Text = "0";
            DTP_pet_ingreso.MaxDate = DateTime.Today;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txt_Owner.Text = string.Empty;
            txt_Name_Pet.Text = string.Empty;
            CB_pet.SelectedIndex = -1;
            CB_tipo_raza.Visible = false;
            lbl_tipo_raza.Visible = false;
            CB_tipo_raza.Items.Clear();
            num_year.Value = 0;
            txt_direccion.Text = string.Empty;
            rtb_diagnostico.Text = string.Empty;
            DTP_pet_ingreso.Value = DateTime.Today;
            lbl_total_text.Text = 0.ToString();
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            var login = new Veterinaria_login();
            this.Hide();

            login.ShowDialog();
            this.Dispose(true);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            lbl_total_text.Text = Money();
        }

        private string Money()
        {
            var dias = CalcularNumeroDias();
           
            var total = 0;

            if (dias < 2)
            {
                total = 5000;
            }
            else
            {
                total = 6000 * dias;
            };

            return total.ToString();
        }

    }
}
