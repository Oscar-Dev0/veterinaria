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
            CB_tipo_raza.Visible = true;
            lbl_tipo_raza.Visible = true;
            var date_now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var date_pet = new DateTimeOffset(DTP_pet_ingreso.Value).ToUnixTimeMilliseconds();

            var date_unix = date_pet - date_now;

            MessageBox.Show("" + date_unix);
        }
    }
}
