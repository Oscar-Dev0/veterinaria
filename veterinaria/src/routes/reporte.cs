using System.Data;
using System.Runtime.ConstrainedExecution;
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
        }

        /// <summary>
        /// Calcula los costos relacionados con el tratamiento de la mascota, incluido el costo total, costo de vacunación, costo de alimentación,
        /// costo de aseo y costo de cremación.
        /// </summary>
        /// <remarks>
        /// Este método realiza cálculos detallados de los costos basados en la raza de la mascota, la presencia de tratamientos (vacunación, alimentación, aseo)
        /// y el período de estancia. Calcula el costo total de tratamiento, el costo de vacunación, el costo de alimentación, el costo de aseo y el costo de cremación (si corresponde).
        /// </remarks>
        /// <returns>Un objeto ITF_Totals que contiene los costos calculados.</returns>
        private ITF_Totals Moneys()
        {
            int total = 0, Total_vac = 0, Total_Ali = 0, Total_Ace = 0, Total_Cre = 0;

            // Función para verificar si la raza de la mascota coincide.
            var raza = (string Raza) => data.Pet_type == Raza;
            // Hacer los bool para verificar si pasan las diferentes cosas
            var vac = Equals("Vacunacion");
            var ali = Equals("Alimentacion");
            var ace = Equals("Aseo");
            var cre = CB_cremacion.Checked;

            // Verificar la raza de la mascota y realizar cálculos específicos.
            if (raza("conejo"))
            {
                total = total + 2500;
                if (vac) Total_vac = 2500;
                if (ali) Total_Ali = 1500;
                if (ace) Total_Ace = 5000;
                if (cre) Total_Cre = 75000;
            }
            else if (raza("perro"))
            {
                total = total + 3200;
                if (vac) Total_vac = 3200;
                if (ali) Total_Ali = 2000;
                if (ace) Total_Ace = 2000;
                if (cre) Total_Cre = 100000;
            }
            else if (raza("gato"))
            {
                total = total + 3200;
                if (vac) Total_vac = 3200;
                if (ali) Total_Ali = 2000;
                if (ace) Total_Ace = 2000;
                if (cre) Total_Cre = 75000;
            }
            else if (raza("perico"))
            {
                total = total + 2500;
                if (vac) Total_vac = 2500;
                if (ali) Total_Ali = 1500;
                if (ace) Total_Ace = 2000;
                if (cre) Total_Cre = 75000;
            }
            else if (raza("caballo"))
            {
                total = total + 4800;
                if (vac) Total_vac = 4800;
                if (ali) Total_Ali = 4000;
                if (ace) Total_Ace = 15000;
                if (cre) Total_Cre = 300000;
            }

            // Calcular el costo total.
            total = total + Total_Ace + Total_Ali + Total_vac;

            // Aplicar el costo total para un período de estancia (si aplica).
            total = data.Stay_days == 0 ? total : total * data.Stay_days;

            // Agregar el costo de cremación (si aplica).
            total = total + Total_Cre + data.Internship_money;

            // Devolver un objeto ITF_Totals con los costos calculados.
            return new ITF_Totals
            {
                Total = total,
                Vacunacion = Total_vac,
                Aceo = Total_Ace,
                Alimentacion = Total_Ali,
                Cremacion = Total_Cre,
            };
        }

        /// <summary>
        /// Verifica si una clave dada está presente en la lista de tratamientos seleccionados.
        /// </summary>
        /// <remarks>
        /// Este método verifica si una clave dada está presente en la lista de tratamientos seleccionados. La clave se compara
        /// con cada elemento de la lista de tratamientos seleccionados después de convertirlos a minúsculas. Si se encuentra
        /// una coincidencia, el método devuelve `true`; de lo contrario, devuelve `false`.
        /// </remarks>
        /// <param name="key">La clave que se va a buscar en la lista de tratamientos seleccionados.</param>
        /// <returns>True si la clave está presente en la lista de tratamientos seleccionados, de lo contrario, False.</returns>
        private bool Equals(string key)
        {
            try
            {
                // Convertir la clave a minúsculas.
                var k = key.ToLower();

                // Obtener la lista de tratamientos seleccionados.
                var tratamientosSeleccionados = CLBx_tratamiento.CheckedItems.Cast<string>().ToList();

                // Verificar si la clave está presente en la lista después de convertirla a minúsculas.
                return tratamientosSeleccionados.Select(x => x.ToString()).Any(x => x.ToLower() == k);
            }
            catch
            {
                // Manejar cualquier excepción y devolver false en caso de error.
                return false;
            };
        }


        // Evento que se dispara al hacer clic en el botón "Calcular Total".
        private void btn_save_Click(object sender, EventArgs e)
        {
            double money = Moneys().Total;

            lbl_txt_total.Text = "₡ " + money;
        }

        // Evento que se dispara al hacer clic en el botón "Salir".
        private void btn_leave_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de inicio y volver a la ventana de inicio.
            var dis = new ITF_Consulta
            {
                Doctor = data.Doctor,
            };

            var home = new consulta(database, dis);
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

        /// <summary>
        /// Manejador de eventos que se ejecuta cuando se carga el formulario de informe.
        /// </summary>
        private void report_Load(object sender, EventArgs e)
        {
            // Configurar el nombre del doctor en el formulario.
            lbl_doctor_text.Text = data.Doctor.DisplayName;

            // Configurar el diagnóstico en el cuadro de texto de diagnóstico.
            rtb_diagnostico.Text = data.Diagnosis;

            // Configurar el estado de vida de la mascota (viva o muerta) en el cuadro de selección.
            CB_dead.Checked = data.Is_dead;

            // Habilitar o deshabilitar la opción de indicar si la mascota está muerta, dependiendo del estado.
            CB_dead.Enabled = !data.Is_dead;

            // Mostrar u ocultar la opción de cremación dependiendo del estado de vida de la mascota.
            CB_cremacion.Visible = data.Is_dead;

            // Configurar el número de días de estancia en el formulario.
            lbl_day_text.Text = data.Stay_days.ToString();

            // Configurar el costo de internamiento en el formulario.
            lbl_estancia_txt.Text = "₡ " + data.Internship_money.ToString();

            // Configurar el costo total del tratamiento en el formulario (inicialmente 0).
            lbl_txt_total.Text = "₡ 0";
        }

    }
}
