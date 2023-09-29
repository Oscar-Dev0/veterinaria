using veterinaria.src.ITF;

namespace veterinaria.src.itf
{

    /// <summary>
    /// La clase ITF_Reporte define las propiedades de un informe veterinario.
    /// </summary>
    public partial class ITF_Reporte : ITF_Consulta
    {
        /// <summary>
        /// Obtiene o establece el número de días de estancia de la mascota.
        /// </summary>
        public int Stay_days { get; set; } = 0;

        /// <summary>
        /// Obtiene o establece el diagnóstico del estado de la mascota.
        /// </summary>
        public string Diagnosis { get; set; } = string.Empty;

        /// <summary>
        /// Obtiene o establece un valor que indica si la mascota está muerta.
        /// </summary>
        public bool Is_dead { get; set; } = false;

        /// <summary>
        /// Obtiene o establece un valor que indica si la mascota está en internamiento.
        /// </summary>
        public bool Is_internship { get; set; } = false;

        /// <summary>
        /// Obtiene o establece el costo del internamiento.
        /// </summary>
        public int Internship_money { get; set; } = 0;

        /// <summary>
        /// Obtiene o establece el tipo de raza de la mascota.
        /// </summary>
        public string Pet_type { get; set; } = string.Empty;

        /// <summary>
        /// Obtiene o establece la raza de la mascota.
        /// </summary>
        public string Pet_race { get; set; } = string.Empty;

        /// <summary>
        /// Obtiene o establece la fecha de ingreso de la mascota.
        /// </summary>
        public DateTime Date_of_admission { get; set; } = DateTime.Now;

        /// <summary>
        /// Obtiene o establece el nombre de la mascota.
        /// </summary>
        public string Pet_name { get; set; } = string.Empty;

        /// <summary>
        /// Obtiene o establece la edad de la mascota en años.
        /// </summary>
        public decimal Pet_year { get; set; } = 0;

        /// <summary>
        /// Obtiene o establece el propietario de la mascota.
        /// </summary>
        public string Pet_owner { get; set; } = string.Empty;

        /// <summary>
        /// Obtiene o establece la dirección del propietario de la mascota.
        /// </summary>
        public string Pet_address { get; set; } = string.Empty;
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
