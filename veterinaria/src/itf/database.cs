namespace veterinaria.src.itf
{
    /// <summary>
    /// Representa un usuario en la base de datos.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Obtiene o establece el ID único del usuario.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de usuario.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Obtiene o establece la contraseña del usuario.
        /// </summary>
        public string Password { get; set; } = "";

        /// <summary>
        /// Obtiene o establece el nombre de visualización del usuario.
        /// </summary>
        public string DisplayName { get; set; } = "";
    }

}
