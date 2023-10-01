using veterinaria.src.functions;
using veterinaria.src.itf;

namespace veterinaria
{
    /// <summary>
    /// La clase invoice representa el formulario de una factura veterinaria.
    /// </summary>
    public partial class invoice : Form
    {
        private ITF_invoice data;

        /// <summary>
        /// Constructor de la clase invoice que toma un objeto ITF_invoice como parámetro.
        /// </summary>
        /// <param name="Data">El objeto ITF_invoice que contiene los datos de la factura.</param>
        public invoice(ITF_invoice Data)
        {
            InitializeComponent();
            data = Data;

            // Configuración de los elementos del formulario con los datos de la factura.

            // Boleanos de valor true o false para que diga si o no
            lbl_dead.Text = data.Is_dead ? "Si" : "No";
            lbl_alimentacion.Text = data.Is_Alimentacion ? "Si" : "No";
            lbl_aseo.Text = data.Is_aseo ? "Si" : "No";
            lbl_vacunacion.Text = data.Is_Vacunacion ? "Si" : "No";

            // Información de la Mascota
            lbl_name_pet.Text = data.Pet_name;
            lbl_owner_pet.Text = data.Pet_owner;
            lbl_type_pet.Text = data.Pet_type;
            lbl_rece_pet.Text = data.Pet_race;
            lbl_doctor.Text = data.Doctor.DisplayName;
            lbl_days_stay.Text = data.Stay_days.ToString();
            lbl_year_pet.Text = data.Pet_year.ToString();
            lbl_date_pet.Text = data.Date_of_admission.ToShortDateString();

            // Fecha
            lbl_date_now.Text = DateTime.Now.ToShortDateString();

            // Costos
            lbl_costo_cremacion.Text = "₡ " + data.Totals.Cremacion;
            lbl_costo_alimentacion.Text = "₡ " + data.Totals.Alimentacion;
            lbl_costo_aseo.Text = "₡ " + data.Totals.Aceo;
            lbl_costo_stay.Text = "₡ " + data.Internship_money;
            lbl_costo_total.Text = "₡ " + data.Totals.Total;
            lbl_costo_vacunacion.Text = "₡ " + data.Totals.Vacunacion;

            // Diagnóstico
            rtb_Diagnosis.Text = data.Diagnosis;

        }
    }

}
