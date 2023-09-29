using veterinaria.src.functions;
using veterinaria.src.itf;
using veterinaria.src.ITF;

namespace veterinaria
{
    // La clase home representa la ventana principal de la aplicación de la veterinaria.
    public partial class consulta : Form
    {
        // Variables miembro para almacenar la base de datos y datos de inicio de sesión.
        Database database;
        ITF_Consulta data;

        // Constructor de la clase Consulta.
        public consulta(object db, object dt)
        {
            InitializeComponent();

            // Inicialización de variables miembro.
            database = (Database)db;
            data = (ITF_Consulta)dt;

            // Configuración del nombre del doctor en el formulario.
            lbl_doctor.Text = data.Doctor.DisplayName;
        }

        // Evento que se dispara cuando se selecciona un elemento en el ComboBox de mascotas.
        private void CB_pet_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_tipo_raza.Enabled = true;
            CB_tipo_raza.Items.Clear();

            var pet = CB_pet.Text.ToString().ToLower();

            // Agregar opciones de razas en función del tipo de mascota seleccionada.
            switch (pet)
            {
                case "conejo":
                    CB_tipo_raza.Items.Add("Belier");
                    CB_tipo_raza.Items.Add("Holanda enano");
                    CB_tipo_raza.Items.Add("Teddy");
                    CB_tipo_raza.Items.Add("Mini Lop");
                    CB_tipo_raza.Items.Add("Flandes");
                    break;
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
        /// <remarks>
        /// Este método obtiene la fecha y hora actual y la fecha de ingreso de la mascota desde el control DateTimePicker.
        /// Luego, calcula la diferencia en días entre las dos fechas y redondea el resultado al número entero más cercano.
        /// El resultado representa el número de días que ha estado la mascota ingresada.
        /// </remarks>
        /// <returns>El número de días entre la fecha y hora actual y la fecha de ingreso de la mascota.</returns>
        public int CalculateNumberOfDays()
        {
            // Obtiene la fecha y hora actual.
            DateTime currentDate = DateTime.Now;

            // Obtiene la fecha de ingreso de la mascota desde el control DateTimePicker.
            DateTime petAdmissionDate = DTP_pet_ingreso.Value;

            // Calcula la diferencia en días entre las dos fechas.
            TimeSpan dateDifference = currentDate - petAdmissionDate;

            // Redondea el resultado al número entero más cercano.
            int roundedDays = dateDifference.Days;

            return roundedDays;
        }



        // Evento que se dispara al cargar el formulario.
        private void home_Load(object sender, EventArgs e)
        {
            lbl_total_text.Text = "₡ 0";
            DTP_pet_ingreso.MaxDate = DateTime.Today;
        }

        // Evento que se dispara al hacer clic en el botón "Limpiar".
        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario.
            txt_Owner.Text = string.Empty;
            txt_Name_Pet.Text = string.Empty;
            CB_pet.SelectedIndex = -1;
            CB_tipo_raza.Enabled = false;
            CB_tipo_raza.Items.Clear();
            CB_tipo_raza.SelectedIndex = -1;
            Rbtn_dead_not.Checked = true;
            Rbtn_internar_not.Checked = true;
            num_year.Value = 0;
            txt_direccion.Text = string.Empty;
            rtb_diagnostico.Text = string.Empty;
            DTP_pet_ingreso.Value = DateTime.Today;
            lbl_total_text.Text = "₡ 0";
        }

        // Evento que se dispara al hacer clic en el botón "Salir".
        private void btn_leave_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de inicio de sesión y ocultar el formulario actual.
            var login = new Veterinaria_login(database);
            this.Hide();

            // Mostrar el formulario de inicio de sesión y liberar recursos del formulario actual.
            login.ShowDialog();
            this.Dispose(true);
        }

        // Evento que se dispara al hacer clic en el botón "Guardar".
        private void btn_save_Click(object sender, EventArgs e)
        {
            // Crear un objeto ITF_Reporte y guardar los datos ingresados en un nuevo informe.
            var dis = new ITF_Reporte
            {
                diagnosis = rtb_diagnostico.Text,
                stay_days = CalculateNumberOfDays(),
                Doctor = data.Doctor,
                is_dead = Rbtn_dead_yes.Checked,
                internship_money = Money(),
                raza = CB_pet.Text.ToString().ToLower()
            };
            var reporte = new report(database, dis);
            this.Hide();

            // Mostrar el formulario de informe y liberar recursos del formulario actual.
            reporte.ShowDialog();
            this.Dispose(true);
        }

        /// <summary>
        /// Calcula el costo total del internamiento de la mascota.
        /// </summary>
        /// <remarks>
        /// Este método calcula el costo total del internamiento de la mascota en función del número de días
        /// que ha estado internada. El costo se calcula de acuerdo con una tarifa diaria de $7,000 durante los
        /// primeros 3 días y $15,000 por cada día adicional.
        /// </remarks>
        /// <returns>El costo total del internamiento de la mascota.</returns>
        private int Money()
        {
            // Obtener el número de días de internamiento de la mascota.
            var dias = CalculateNumberOfDays();

            // Inicializar el costo total en cero.
            var total = 0;

            // Calcular el costo total del internamiento.
            if (dias > 3)
                total = 15000 * (dias - 3) + 7000; // Tarifa diaria de $15,000 por cada día adicional y $7,000 para los primeros 3 días.
            else
                total = 7000; // Tarifa diaria de $7,000 para los primeros 3 días.

            return total;
        }

    }
}
