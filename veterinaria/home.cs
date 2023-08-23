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
            lbl_doctor.Text = doctor;
        }

        private void CB_pet_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show(CalculateDaysNumber().ToString());
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

        public int CalculateDaysNumber(){

            // Obtenemos los valores de la fecha y hora en milisegundos desde el inicio del tiempo Unix.
            var current = DateTime.Now;
            var petDate = DTP_pet_ingreso.Value;

            // Calculamos la diferencia en milisegundos entre las dos fechas.
            var dateDifference = current - petDate;


            var roundedDays = dateDifference.Days;

            return roundedDays;
        }





    }
}
