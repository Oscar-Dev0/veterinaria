using veterinaria.src.functions;
using veterinaria.src.itf;

namespace veterinaria
{
    public partial class invoice : Form
    {

        ITF_invoice data;
        public invoice(ITF_invoice Data)
        {
            InitializeComponent();
            data = Data;

            lbl_name_pet.Text = data.Pet_name;
            lbl_dead.Text = data.Is_dead ? "Si" : "No";
            lbl_alimentacion.Text = data.Is_Alimentacion ? "Si" : "No";
            lbl_aseo.Text = data.Is_aseo ? "Si" : "No";
            lbl_vacunacion.Text = data.Is_Vacunacion ? "Si" : "No";
            lbl_owner_pet.Text = data.Pet_owner;
            lbl_type_pet.Text = data.Pet_type;
            lbl_rece_pet.Text = data.Pet_race;
            lbl_doctor.Text = data.Doctor.DisplayName;
            lbl_days_stay.Text = data.Stay_days.ToString();
            lbl_year_pet.Text = data.Pet_year.ToString();
            lbl_date_pet.Text = data.Date_of_admission.ToShortDateString();


        }
            
        
    }
}
