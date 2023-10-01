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
        ITF_Reporte data;

        // Constructor de la clase report.
        public report(ITF_Reporte Data)
        {
            InitializeComponent();

            // Inicialización de variables miembro.
            data = Data;

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


        /// <summary>
        /// Calcula y devuelve los costos relacionados con el cuidado de la mascota, incluyendo alimentación, aseo, vacunación, cremación y estancia.
        /// </summary>
        /// <remarks>
        /// Este método realiza cálculos detallados para determinar los costos asociados al cuidado de una mascota en función de varios factores, incluida la raza de la mascota,
        /// la duración de su estancia y los tratamientos seleccionados, como vacunación, alimentación y aseo. Los costos específicos para cada raza se almacenan en un diccionario
        /// predefinido, lo que permite una fácil actualización y expansión de los datos de costos según sea necesario.
        /// </remarks>
        /// <returns>Un objeto ITF_Totals que contiene los costos calculados para alimentación, aseo, vacunación, cremación, estancia y el costo total.</returns>
        private ITF_Totals Moneys()
        {
            // Diccionario que almacena los costos predefinidos para diferentes razas de mascotas.
            Dictionary<string, (int Stay, int Vac, int Ali, int Ace, int Cre)> razaCosts = new Dictionary<string, (int, int, int, int, int)>
    {
        { "conejo", (2500, 2500, 1500, 5000, 75000) },
        { "perro", (3200, 3200, 2000, 2000, 100000) },
        { "gato", (3200, 3200, 2000, 2000, 75000) },
        { "perico", (2500, 2500, 1500, 2000, 75000) },
        { "caballo", (4800, 4800, 4000, 15000, 300000) }
    };

            // Verificar si la raza de la mascota está en el diccionario de costos.
            if (razaCosts.TryGetValue(data.Pet_type.ToLower(), out var razaCost))
            {
                int Total_stay = razaCost.Stay;
                int Total_vac = Equals("Vacunacion") ? razaCost.Vac : 0;
                int Total_Ali = Equals("Alimentacion") ? razaCost.Ali : 0;
                int Total_Ace = Equals("Aseo") ? razaCost.Ace : 0;
                int Total_Cre = CB_cremacion.Checked ? razaCost.Cre : 0;

                // Aplicar multiplicador de días de estancia (si aplica).
                int stayDaysMultiplier = data.Stay_days == 0 ? 1 : data.Stay_days;

                Total_stay *= stayDaysMultiplier;
                Total_Ace *= stayDaysMultiplier;
                Total_Ali *= stayDaysMultiplier;
                Total_vac *= stayDaysMultiplier;

                // Calcular el costo total.
                int total = Total_stay + Total_Ace + Total_Ali + Total_vac + data.Internship_money;
                data.Internship_money += Total_stay;

                // Agregar el costo de cremación (si aplica).
                total += Total_Cre;

                // Devolver un objeto ITF_Totals con los costos calculados.
                return new ITF_Totals
                {
                    Total = total,
                    Vacunacion = Total_vac,
                    Aceo = Total_Ace,
                    Alimentacion = Total_Ali,
                    Cremacion = Total_Cre
                };
            }
            else
            {
                // Si la raza no está en el diccionario, devolver un objeto ITF_Totals vacío.
                return new ITF_Totals();
            }
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
                // Convertir la clave a minúsculas una sola vez.
                var k = key.ToLower();

                // Obtener la lista de tratamientos seleccionados como una lista de cadenas en minúsculas.
                var tratamientosSeleccionados = CLBx_tratamiento.CheckedItems.Cast<string>().Select(x => x.ToLower()).ToList();

                // Verificar si la clave está presente en la lista en minúsculas.
                return tratamientosSeleccionados.Contains(k);
            }
            catch
            {
                // Manejar cualquier excepción y registrarla o lanzar una excepción personalizada si lo deseas.
                // En este ejemplo, se devuelve false en caso de error.
                return false;
            }
        }



        // Evento que se dispara al hacer clic en el botón "Calcular Total".
        private void btn_save_Click(object sender, EventArgs e)
        {
            var totals = Moneys();

            var Invoice = new ITF_invoice(data);
            Invoice.Totals = totals;
            Invoice.Is_Vacunacion = Equals("Vacunacion");
            Invoice.Is_Alimentacion = Equals("Alimentacion");
            Invoice.Is_aseo = Equals("Aseo");
            Invoice.Is_Cremacion = CB_cremacion.Checked;

            invoice form = new(Invoice);
            Hide();
            form.ShowDialog();
            Dispose();

        }

        // Evento que se dispara al hacer clic en el botón "Salir".
        private void btn_leave_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de inicio y volver a la ventana de inicio.
            var dis = new ITF_Consulta
            {
                Doctor = data.Doctor,
            };

            var home = new consulta(dis);
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
