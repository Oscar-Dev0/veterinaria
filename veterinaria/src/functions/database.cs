using Npgsql;

namespace veterinaria.src.functions
{
    // La clase Database proporciona métodos para conectarse y acceder a la base de datos PostgreSQL.
    internal class Database
    {
        // Datos de conexión a la base de datos PostgreSQL.
        private static string Host = "postgresql-oscargamer.alwaysdata.net";
        private static string User = "oscargamer_veterinaria";
        private static string DBname = "oscargamer_veterinaria";
        private static string Password = "50gS0uLvDWYVP2jZPULCbDyV25esEEbu";
        private static string Port = "5432";

        // Cadena de conexión formateada.
        private static string connString = string.Format("Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=Prefer", Host, User, DBname, Port, Password);

        // Objeto de conexión NpgsqlConnection.
        private NpgsqlConnection data = new(connString);
        private bool status = false;

        // Cache para almacenar los usuarios.
        private List<Usuario> usuarios = new List<Usuario>();
        private bool status_user = false;

        /// <summary>
        /// Establece una conexión a la base de datos PostgreSQL.
        /// </summary>
        /// <remarks>
        /// Este método intenta abrir una conexión a la base de datos PostgreSQL utilizando los datos de conexión
        /// especificados en la cadena de conexión. Si la conexión se establece correctamente, se marca el estado
        /// como "activo" (status = true), lo que indica que la conexión está disponible para su uso. Si se produce
        /// algún error durante la conexión, se marca el estado como "inactivo" (status = false).
        /// </remarks>
        public void Conection()
        {
            try
            {
                // Intentar abrir la conexión a la base de datos.
                data.Open();

                // Marcar el estado como "activo" si la conexión se establece correctamente.
                status = true;
            }
            catch
            {
                // Marcar el estado como "inactivo" si se produce un error durante la conexión.
                status = false;
            };
        }


        /// <summary>
        /// Recupera la lista de usuarios desde la base de datos PostgreSQL.
        /// </summary>
        /// <remarks>
        /// Este método realiza una consulta a la tabla de usuarios en la base de datos PostgreSQL
        /// y devuelve una lista de objetos Usuario que representan a los usuarios registrados.
        /// Si ya se ha cargado la lista de usuarios previamente, se devuelve la lista en caché para
        /// evitar consultas adicionales a la base de datos.
        /// </remarks>
        /// <returns>Una lista de objetos Usuario que representan a los usuarios registrados.</returns>
        public List<Usuario> users()
        {
            // Verificar si la conexión a la base de datos está activa.
            if (!status) return usuarios;

            // Verificar si la lista de usuarios ya está en caché y devolverla si es así.
            if (status_user) return usuarios;

            // Crear un comando SQL para seleccionar todos los usuarios de la tabla "users".
            var command = new NpgsqlCommand("SELECT * FROM \"public\".\"users\";", data);

            // Ejecutar el comando SQL y obtener los resultados.
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Crear un objeto Usuario a partir de los datos obtenidos de la base de datos.
                    Usuario usuario = new Usuario
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        DisplayName = reader.GetString(reader.GetOrdinal("display_name")),
                        Password = reader.GetString(reader.GetOrdinal("password")),
                    };

                    // Agregar el usuario a la lista de usuarios.
                    usuarios.Add(usuario);
                }
            }

            // Marcar que la lista de usuarios está en caché para futuras consultas.
            status_user = true;

            // Devolver la lista de usuarios.
            return usuarios;
        }
    }


        // Clase que representa un usuario en la base de datos.
        class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Password { get; set; } = "";
        public string DisplayName { get; set; } = "";
    }
}
