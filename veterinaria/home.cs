using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                    CB_tipo_raza.Items.Add("ssd");
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



    }
}
