using veterinaria.src.functions;
using veterinaria.src.itf;
using veterinaria.src.ITF;

namespace veterinaria
{
    // La clase home representa la ventana principal de la aplicación de la veterinaria.
    public partial class consulta : Form
    {
        //datos de inicio de sesión.
        ITF_Consulta data;

        // Constructor de la clase Consulta.
        public consulta(ITF_Consulta dt)
        {
            InitializeComponent();

            // Inicialización de variables miembro.
            data = dt;

            lbl_total_text.Text = "₡ 0";
            DTP_pet_ingreso.MaxDate = DateTime.Today;

            // Configuración del nombre del doctor en el formulario.
            lbl_doctor.Text = data.Doctor.DisplayName;
        }

        // Evento que se dispara cuando se selecciona un elemento en el ComboBox de mascotas.
        private void CB_pet_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_tipo_raza.Enabled = true;
            CB_tipo_raza.Items.Clear();

            var pet = CB_pet.Text.ToLower();

            // Definir un diccionario que almacena las razas por tipo de mascota.
            Dictionary<string, List<string>> razasPorMascota = new Dictionary<string, List<string>>
    {
        { "conejo", new List<string> { "Belier", "Holanda enano", "Teddy", "Mini Lop", "Flandes" } },
        { "perro", new List<string> { "Doberman", "Labrador Retriever", "Bulldog", "Poodle", "Golden Retriever" } },
        { "gato", new List<string> { "Siamés", "Persa", "Maine Coon", "Bengala", "Ragdoll" } },
        { "perico", new List<string> { "Cotorra Argentina", "Cacatúa", "Agapornis", "Ninfas", "Periquito Australiano" } },
        { "caballo", new List<string> { "Cuarto de Milla", "Pura Sangre Inglés", "Árabe", "Frisón", "Appaloosa" } }
    };
            // Verificar si el tipo de mascota seleccionado existe en el diccionario.
            if (razasPorMascota.TryGetValue(pet, out var razas))
            {
                // Agregar las razas al ComboBox.
                foreach (var raza in razas)
                {
                    CB_tipo_raza.Items.Add(raza);
                }
            }
            else
            {
                // Manejar el caso de una mascota desconocida o sin razas.
                // Puedes lanzar una excepción, mostrar un mensaje de error o tomar la acción apropiada según tu lógica.
                CB_tipo_raza.Enabled = false;
                CB_tipo_raza.SelectedIndex = -1;
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

        // Evento que se dispara al hacer clic en el botón "Limpiar".
        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario estableciendo los valores predeterminados.
            txt_Owner.Clear();
            txt_Name_Pet.Clear();
            CB_pet.SelectedIndex = -1;
            CB_tipo_raza.Items.Clear();
            CB_tipo_raza.Enabled = false;
            CB_tipo_raza.SelectedIndex = -1;
            Rbtn_dead_not.Checked = true;
            Rbtn_internar_not.Checked = true;
            num_year.Value = 0;
            txt_direccion.Clear();
            rtb_diagnostico.Clear();
            DTP_pet_ingreso.Value = DateTime.Today;
            lbl_total_text.Text = "₡ 0";
        }


        // Evento que se dispara al hacer clic en el botón "Salir".
        private void btn_leave_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de inicio de sesión y ocultar el formulario actual.
            var login = new Veterinaria_login(data.DB);
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
                Diagnosis = rtb_diagnostico.Text,
                Stay_days = CalculateNumberOfDays(),
                Doctor = data.Doctor,
                Is_dead = Rbtn_dead_yes.Checked,
                Internship_money = Money(),
                Pet_type = CB_pet.SelectedIndex == -1 ? "undefined" : CB_pet.Text.ToLower(),
                Pet_address = txt_direccion.Text,
                Pet_name = txt_Name_Pet.Text,
                Pet_owner = txt_Owner.Text,
                Pet_year = num_year.Value,
                Pet_race = CB_tipo_raza.SelectedIndex == -1 ? "undefined" :CB_tipo_raza.Text.ToLower(),
                Date_of_admission = DTP_pet_ingreso.Value,
                Is_internship = Rbtn_internar_yes.Checked,
                DB = data.DB,
            };
            var reporte = new report(dis);
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
