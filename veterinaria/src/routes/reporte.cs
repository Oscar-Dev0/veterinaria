using System.Data;
using veterinaria.src.functions;
using veterinaria.src.itf;
using veterinaria.src.ITF;

namespace veterinaria
{
    // La clase report representa la ventana para generar informes veterinarios.
    public partial class report : Form
    {
        Database database;
        ITF_Reporte data;

        // Constructor de la clase report.
        public report(object s, object d)
        {
            InitializeComponent();

            // Inicialización de variables miembro.
            database = (Database)s;
            data = (ITF_Reporte)d;

            // Configuración de los elementos del formulario con los datos del informe.
            lbl_doctor_text.Text = data.doctor;
            rtb_diagnostico.Text = data.diagnosis;
            CB_dead.Checked = data.is_dead;
            CB_cremacion.Visible = data.is_dead;
            lbl_day_text.Text = data.stay_days.ToString();
            lbl_estancia_txt.Text = "₡ " + data.internship_money.ToString();
            lbl_txt_total.Text = "₡ 0";
        }

        // Método para calcular el costo total, incluyendo internamiento, cremación y tratamientos.
        private double Money()
        {
            return data.internship_money + MultiAnimal() + cremacion();
        }

        // Método para calcular el costo de cremación.
        private double cremacion()
        {
            var total = 0;
            var cre = CB_cremacion.Checked;

            // Calcular el costo de cremación en función del tipo de mascota.
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

        // Método para calcular el costo total de tratamientos múltiples.
        private double MultiAnimal()
        {
            var money = MoneyAnimal();

            if (data.stay_days == 0) return money;

            double total = money * data.stay_days;

            return total;
        }

        // Método para calcular el costo de tratamientos específicos según el tipo de mascota.
        private int MoneyAnimal()
        {
            var total = 0;
            var vac = equals("Vacunacion");
            var ali = equals("Alimentacion");
            var ace = equals("Aceo");
            var cre = CB_cremacion.Checked;

            // Calcular el costo de tratamientos según el tipo de mascota y tratamientos seleccionados.
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

        // Método para verificar si un tratamiento está seleccionado.
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

        // Evento que se dispara al hacer clic en el botón "Calcular Total".
        private void btn_save_Click(object sender, EventArgs e)
        {
            double money = this.Money();

            lbl_txt_total.Text = "₡ " + money;
        }

        // Evento que se dispara al hacer clic en el botón "Salir".
        private void btn_leave_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de inicio y volver a la ventana de inicio.
            var dis = new ITF_home
            {
                doctor = data.doctor_user,
            };

            var home = new home(database, dis);
            this.Hide();
            home.ShowDialog();
            this.Dispose(true);
        }

        // Evento que se dispara cuando se cambia el estado del CheckBox "Muerto".
        private void CB_dead_CheckedChanged(object sender, EventArgs e)
        {
            CB_cremacion.Visible = CB_dead.Checked;
            if (!CB_dead.Checked) CB_cremacion.Checked = false;
        }
    }
}
