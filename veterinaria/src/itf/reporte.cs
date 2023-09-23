namespace veterinaria.src.itf
{
    // La clase ITF_Reporte define las propiedades de un informe veterinario.
    internal class ITF_Reporte
    {
        // Nombre del doctor que realiza el informe.
        public string doctor { set; get; } = string.Empty;

        // Número de días de estancia de la mascota.
        public int stay_days { set; get; } = 0;

        // Diagnóstico del estado de la mascota.
        public string diagnosis { set; get; } = string.Empty;

        // Indica si la mascota está muerta.
        public bool is_dead { set; get; } = false;

        // Indica si la mascota está en internamiento.
        public bool is_internship { set; get; } = false;

        // Costo del internamiento.
        public int internship_money { set; get; } = 0;

        // Tipo de raza de la mascota.
        public string raza { set; get; } = string.Empty;

        // Nombre de usuario del doctor que realiza el informe.
        public string doctor_user { set; get; } = string.Empty;
    }
}
