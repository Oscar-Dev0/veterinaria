

namespace veterinaria.src.itf
{
    public class ITF_invoice : ITF_Reporte
    {
        public ITF_Totals Totals { get; set; } = new();
        public bool Is_aseo { get; set; } = false;
        public bool Is_Alimentacion { get; set; } = false;
        public bool Is_Cremacion { get; set; } = false;
        public bool Is_Vacunacion { get; set; } = false;

        public ITF_invoice(ITF_Reporte data)
        {
            Pet_address = data.Pet_address;
            Pet_name = data.Pet_name;
            Pet_owner = data.Pet_owner;
            Pet_race = data.Pet_race;
            Pet_type = data.Pet_type;
            Pet_year = data.Pet_year;
            Is_dead = data.Is_dead;
            Is_internship = data.Is_internship;
            Date_of_admission = data.Date_of_admission;
            Doctor = data.Doctor;
            Stay_days = data.Stay_days;
            DB = data.DB;
        }
    }
}
