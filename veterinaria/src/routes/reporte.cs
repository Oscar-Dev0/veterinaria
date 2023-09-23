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
using veterinaria.src.functions;
using veterinaria.src.itf;
using veterinaria.src.ITF;

namespace veterinaria
{
    public partial class report : Form
    {
        Database database;
        ITF_Reporte data;
        public report(object s, object d)
        {
            InitializeComponent();
            database = (Database)s;
            data = (ITF_Reporte)d;
            lbl_doctor_text.Text = data.doctor;
            rtb_diagnostico.Text = data.diagnosis;
            CB_dead.Checked = data.is_dead;
            CB_cremacion.Visible = data.is_dead;
            lbl_day_text.Text = data.stay_days.ToString();
            lbl_estancia_txt.Text = "₡ " + data.internship_money.ToString();
            lbl_txt_total.Text = "₡ 0";
        }

        private double Money()
        {
            return data.internship_money + MultiAnimal() + cremacion();
        }

        private double cremacion()
        {
            var total = 0;

            var cre = CB_cremacion.Checked;
            switch (data.raza)
            {
                case "conejo":
                    if (cre) total = total + 75000;
                    break;
                case "perro":
                    if (cre) total = total + 100000;
                    break;
                case "gato":
                    if (cre) total = total + 75000;
                    break;
                case "perico":
                    if (cre) total = total + 75000;
                    break;
                case "caballo":
                    if (cre) total = total + 300000;
                    break;
            };

            return total;
        }
        private double MultiAnimal()
        {
            var money = MoneyAnimal();

            if (data.stay_days == 0) return money;

            double total = money * data.stay_days;

            return total;
        }

        private int MoneyAnimal()
        {
            var total = 0;
            var vac = equals("Vacunacion");
            var ali = equals("Alimentacion");
            var ace = equals("Aceo");
            var cre = CB_cremacion.Checked;
            switch (data.raza)
            {
                case "conejo":
                    total = total + 2500;
                    if (vac) total = total + 2500;
                    if (ali) total = total + 1500;
                    if (ace) total = total + 5000;
                    break;
                case "perro":
                    total = total + 3200;
                    if (vac) total = total + 3200;
                    if (ali) total = total + 2000;
                    if (ace) total = total + 2000;
                    break;
                case "gato":
                    total = total + 3200;
                    if (vac) total = total + 3200;
                    if (ali) total = total + 2000;
                    if (ace) total = total + 2000;
                    break;
                case "perico":
                    total = total + 2500;
                    if (vac) total = total + 2500;
                    if (ali) total = total + 1500;
                    if (ace) total = total + 2000;
                    break;
                case "caballo":
                    total = total + 4800;
                    if (vac) total = total + 4800;
                    if (ali) total = total + 4000;
                    if (ace) total = total + 15000;
                    break;
            };

            return total;
        }

        private bool equals(string key)
        {
            try
            {
                var k = key.ToLower();
                var tratamientosSeleccionados = CLBx_tratamiento.CheckedItems.Cast<string>().ToList();
                return tratamientosSeleccionados.Select(x => x.ToString()).Any(x => x.ToLower() == k);
            }
            catch
            {
                return false;
            };
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            double money = this.Money();

            lbl_txt_total.Text = "₡ " + money;
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            var dis = new ITF_home
            {
                doctor = data.doctor_user,
            };

            var home = new home(database, dis);
            this.Hide();
            home.ShowDialog();
            this.Dispose(true);
        }

        private void CB_dead_CheckedChanged(object sender, EventArgs e)
        {
            CB_cremacion.Visible = CB_dead.Checked;
            if(!CB_dead.Checked) CB_cremacion.Checked = false;
        }
    }
}
