using veterinaria.src.ITF;

namespace veterinaria.src.itf
{
    // La clase ITF_Reporte define las propiedades de un informe veterinario.
    public partial class ITF_Reporte: ITF_Consulta
    {

        // Número de días de estancia de la mascota.
        public int Stay_days { set; get; } = 0;

        // Diagnóstico del estado de la mascota.
        public string diagnosis { set; get; } = string.Empty;

        // Indica si la mascota está muerta.
        public bool is_dead { set; get; } = false;

        // Indica si la mascota está en internamiento.
        public bool is_internship { set; get; } = false;

        // Costo del internamiento.
        public int internship_money { set; get; } = 0;

        // Tipo de raza de la mascota.
        public string pet_type { set; get; } = string.Empty;
        
        public string pet_name { set; get;} = string.Empty;

        public int pet_year { set; get; } = 0;
        public string pet_owner { set; get;}  = string.Empty;
        public string pet_address { set; get; } = string.Empty;
        public DateTime date { set; get; } = DateTime.Now;

    }

    /// <summary>
    /// Representa los totales relacionados con los costos de tratamiento para una mascota.
    /// </summary>
    public class ITF_Totals
    {
        /// <summary>
        /// Obtiene o establece el total de costo de vacunación.
        /// </summary>
        public int Vacunacion { get; set; } = 0;

        /// <summary>
        /// Obtiene o establece el costo total final, que incluye todos los costos relacionados con el tratamiento.
        /// </summary>
        public double Total { get; set; } = 0;

        /// <summary>
        /// Obtiene o establece el total de costo de aseo.
        /// </summary>
        public int Aceo { get; set; } = 0;

        /// <summary>
        /// Obtiene o establece el total de costo de alimentación.
        /// </summary>
        public int Alimentacion { get; set; } = 0;

        /// <summary>
        /// Obtiene o establece el total de costo de cremación.
        /// </summary>
        public double Cremacion { get; set; } = 0;
    }

}
