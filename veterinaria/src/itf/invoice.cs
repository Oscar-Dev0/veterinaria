

namespace veterinaria.src.itf
{
    /// <summary>
    /// La clase ITF_invoice hereda propiedades de ITF_Reporte y representa una factura de veterinaria.
    /// </summary>
    public class ITF_invoice : ITF_Reporte
    {
        /// <summary>
        /// Obtiene o establece el objeto ITF_Totals que contiene información sobre los totales de la factura.
        /// </summary>
        public ITF_Totals Totals { get; set; } = new();

        /// <summary>
        /// Obtiene o establece un valor que indica si se incluyó el servicio de aseo en la factura.
        /// </summary>
        public bool Is_aseo { get; set; } = false;

        /// <summary>
        /// Obtiene o establece un valor que indica si se incluyó el servicio de alimentación en la factura.
        /// </summary>
        public bool Is_Alimentacion { get; set; } = false;

        /// <summary>
        /// Obtiene o establece un valor que indica si se incluyó el servicio de cremación en la factura.
        /// </summary>
        public bool Is_Cremacion { get; set; } = false;

        /// <summary>
        /// Obtiene o establece un valor que indica si se incluyó el servicio de vacunación en la factura.
        /// </summary>
        public bool Is_Vacunacion { get; set; } = false;

        /// <summary>
        /// Constructor de la clase ITF_invoice que toma un objeto ITF_Reporte como parámetro y copia sus propiedades.
        /// </summary>
        /// <param name="data">El objeto ITF_Reporte del cual se copian las propiedades.</param>
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
            Internship_money = data.Internship_money;
            Diagnosis = data.Diagnosis;
            Date_of_admission = data.Date_of_admission;
            Doctor = data.Doctor;
            Stay_days = data.Stay_days;
            DB = data.DB;
        }
    }

}
