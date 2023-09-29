using veterinaria.src.ITF;

namespace veterinaria.src.itf
{
    // La clase ITF_Reporte define las propiedades de un informe veterinario.
    public class ITF_Reporte: ITF_Consulta
    {

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
    }

    public class ITF_Totals
    {
        // total de la vacunacion
        public int Vacunacion { set; get; } = 0;
        // total final 
        public double Total { set; get; } = 0;
        // total Aceo
        public int Aceo { set; get;} = 0;
        // total de la alimentacion
        public int Alimentacion { set; get; } = 0;
        // total de la cremacion
        public double Cremacion { set; get; } = 0;
    }
}
