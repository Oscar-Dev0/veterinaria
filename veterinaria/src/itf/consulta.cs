using veterinaria.src.functions;
using veterinaria.src.itf;

namespace veterinaria.src.ITF
{
    /// <summary>
    /// Representa la información del usuario o médico que ha iniciado sesión.
    /// </summary>
    public class ITF_Consulta
    {
        /// <summary>
        /// Obtiene o establece el usuario o médico que ha iniciado sesión.
        /// </summary>
        public Usuario Doctor { get; set; } = new Usuario();

        /// <summary>
        /// Obtiene o establece la base de datos utilizada para consultas.
        /// </summary>
        public Database DB { get; set; } = new Database();
    }
}
