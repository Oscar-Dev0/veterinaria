using Npgsql;
using veterinaria.src.itf;

namespace veterinaria.src.functions
{
    // La clase Database proporciona métodos para conectarse y acceder a la base de datos PostgreSQL.
    public class Database
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
        private List<Usuario> usuarios = new();
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
        public List<Usuario> Users()
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
                    var usuario = new Usuario
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

        /// <summary>
        /// Busca un usuario por su nombre de usuario y devuelve un objeto Usuario correspondiente.
        /// </summary>
        /// <remarks>
        /// Este método busca un usuario por su nombre de usuario en la lista de usuarios y devuelve un objeto Usuario correspondiente.
        /// Si el usuario "root" se busca, se devuelve un usuario especial con nombre de usuario "root" y contraseña "root" para fines de administración.
        /// </remarks>
        /// <param name="user">El nombre de usuario que se va a buscar.</param>
        /// <returns>
        /// Un objeto Usuario correspondiente al nombre de usuario buscado o un usuario especial "root" para administración.
        /// Si no se encuentra un usuario con el nombre especificado, se devuelve un usuario especial "root" como valor predeterminado.
        /// </returns>
        /// <seealso cref="Usuario"/>
        public Usuario FindUser(string user)
        {
            // Obtener la lista de usuarios.
            var users_ = Users();

            // Buscar el usuario por nombre de usuario.
            var user_db = users_.Find((s) => s.Name == user);

            // Verificar si el usuario existe.
            var userExists = user_db != null ? true : false;

            // Devolver el usuario encontrado o un usuario especial "root" como valor predeterminado.
            return user_db ?? new Usuario { DisplayName = "Administracion", Name = "root", Password = "root" };
        }



        /// <summary>
        /// Verifica si un usuario con el nombre de usuario dado existe en la lista de usuarios.
        /// </summary>
        /// <remarks>
        /// Este método busca un usuario por su nombre de usuario en la lista de usuarios y devuelve true si se encuentra, o false si no se encuentra.
        /// </remarks>
        /// <param name="user">El nombre de usuario que se va a verificar.</param>
        /// <returns>true si el usuario con el nombre de usuario dado existe, false en caso contrario.</returns>
        public bool HasUser(string user)
        {
            // Obtener la lista de usuarios.
            var users_ = Users();

            // Buscar el usuario por nombre de usuario.
            var user_db = users_.Find((s) => s.Name == user);

            // Verificar si el usuario existe.
            var userExists = user_db != null ? true : false;

            // Devolver true si el usuario existe, false en caso contrario.
            return userExists;
        }

    }




}
