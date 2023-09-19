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
            TB_days.Text = data.stay_days.ToString();
            lbl_txt_total.Text = "0";

        }
    }
}
