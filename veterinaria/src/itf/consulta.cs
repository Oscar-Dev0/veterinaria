using veterinaria.src.itf;

namespace veterinaria.src.ITF
{
    // La clase ITF_Consulta representa la información del usuario o médico que ha iniciado sesión.
    public class ITF_Consulta
    {
        // Nombre del doctor o usuario.
        public Usuario Doctor { set; get; } = new();
    }
}
