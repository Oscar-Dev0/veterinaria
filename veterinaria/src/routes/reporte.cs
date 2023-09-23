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

        /// <summary>
        /// Calcula el costo total del tratamiento y servicios para la mascota, incluyendo internamiento, tratamientos adicionales y cremación (si aplica).
        /// </summary>
        /// <remarks>
        /// Este método calcula el costo total de todos los servicios relacionados con la mascota, incluyendo el internamiento, los tratamientos adicionales
        /// y la cremación si está seleccionada. Suma los costos de internamiento, tratamientos adicionales y cremación (si aplica) para obtener el costo
        /// total del tratamiento de la mascota.
        /// </remarks>
        /// <returns>El costo total del tratamiento y servicios para la mascota.</returns>
        private double Money()
        {
            // Obtener el costo del internamiento de la mascota.
            var internmentCost = data.internship_money;

            // Obtener el costo de tratamientos adicionales y servicios múltiples.
            var additionalCost = MultiAnimal();

            // Obtener el costo de cremación (si aplica).
            var cremationCost = cremacion();

            // Calcular el costo total sumando los componentes individuales.
            return internmentCost + additionalCost + cremationCost;
        }


        /// <summary>
        /// Calcula el costo de cremación de la mascota en función de su tipo de raza y si se ha seleccionado la opción de cremación.
        /// </summary>
        /// <remarks>
        /// Este método calcula el costo de cremación de la mascota en base a su tipo de raza y si se ha seleccionado la opción de cremación.
        /// El costo de cremación varía según el tipo de mascota, y se agrega al costo total si la opción de cremación está marcada.
        /// </remarks>
        /// <returns>El costo de cremación de la mascota.</returns>
        private double cremacion()
        {
            // Inicializar el costo de cremación en cero.
            var total = 0;

            // Verificar si la opción de cremación está marcada.
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


        /// <summary>
        /// Calcula el costo total de servicios adicionales para la mascota en función del costo diario y el número de días de internamiento.
        /// </summary>
        /// <remarks>
        /// Este método calcula el costo total de servicios adicionales para la mascota en función del costo diario y el número de días de internamiento.
        /// Si el número de días de internamiento es igual a cero, se devuelve el costo diario único. De lo contrario, se calcula el costo total
        /// multiplicando el costo diario por el número de días de internamiento.
        /// </remarks>
        /// <returns>El costo total de servicios adicionales para la mascota.</returns>
        private double MultiAnimal()
        {
            // Obtener el costo diario de servicios adicionales.
            var money = MoneyAnimal();

            // Verificar si el número de días de internamiento es igual a cero.
            if (data.stay_days == 0) return money;

            // Calcular el costo total multiplicando el costo diario por el número de días de internamiento.
            double total = money * data.stay_days;

            return total;
        }


        /// <summary>
        /// Calcula el costo total de tratamientos y servicios adicionales para la mascota en función de su tipo de raza y tratamientos seleccionados.
        /// </summary>
        /// <remarks>
        /// Este método calcula el costo total de tratamientos y servicios adicionales para la mascota en función de su tipo de raza y los tratamientos
        /// seleccionados. El costo varía según el tipo de mascota y los tratamientos elegidos. Se suman los costos de los tratamientos seleccionados
        /// al costo base de acuerdo con el tipo de mascota.
        /// </remarks>
        /// <returns>El costo total de tratamientos y servicios adicionales para la mascota.</returns>
        private int MoneyAnimal()
        {
            // Inicializar el costo total en cero.
            var total = 0;

            // Verificar si se han seleccionado tratamientos específicos.
            var vac = equals("Vacunacion");
            var ali = equals("Alimentacion");
            var ace = equals("Aceo");

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
        private bool equals(string key)
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
