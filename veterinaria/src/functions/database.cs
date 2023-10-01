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
        public Database Conection()
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
            return this;
        }



        /// <summary>
        /// Recupera la lista de usuarios almacenados en la base de datos.
        /// </summary>
        /// <remarks>
        /// Este método se utiliza para obtener la lista de usuarios registrados en la base de datos del sistema. Verifica si la lista de usuarios ya ha sido cargada
        /// y si la conexión a la base de datos está activa antes de realizar la consulta. Si la lista de usuarios ya ha sido cargada, devuelve la lista existente,
        /// evitando una nueva consulta a la base de datos. Si la conexión a la base de datos no está activa o si ocurre un error durante la consulta, se devuelve
        /// una lista vacía.
        /// </remarks>
        /// <returns>Una lista de objetos Usuario que representa a los usuarios almacenados en la base de datos o una lista vacía en caso de error.</returns>
        public List<Usuario> Users()
        {
            // Verificar si la lista de usuarios ya ha sido cargada y si la conexión a la base de datos está activa.
            if (status_user)
                return usuarios;

            if (!status)
                return usuarios;

            try
            {
                // Consultar la base de datos para obtener la lista de usuarios.
                string query = "SELECT * FROM public.users;";
                using (var command = new NpgsqlCommand(query, data))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Crear objetos Usuario a partir de los datos de la base de datos y agregarlos a la lista.
                            var usuario = new Usuario
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                DisplayName = reader.GetString(reader.GetOrdinal("display_name")),
                                Password = reader.GetString(reader.GetOrdinal("password")),
                            };

                            usuarios.Add(usuario);
                        }
                        if (status) data.Close();
                    }
                }

                // Marcar que la lista de usuarios ha sido cargada.
                status_user = true;

                return usuarios;
            }
            catch
            {
                // En caso de error, retornar la lista de usuarios vacía.
                return usuarios;
            }
        }


        /// <summary>
        /// Busca un usuario por su nombre de usuario y devuelve un objeto Usuario correspondiente.
        /// </summary>
        /// <remarks>
        /// Este método busca un usuario por su nombre de usuario en la lista de usuarios y devuelve un objeto Usuario correspondiente.
        /// Si el usuario buscado no existe, se devuelve un usuario especial con nombre de usuario "root" y contraseña "root" para fines de administración.
        /// </remarks>
        /// <param name="Nuser">El nombre de usuario que se va a buscar.</param>
        /// <returns>Un objeto Usuario correspondiente al nombre de usuario buscado o un usuario especial "root" para administración.</returns>
        public Usuario FindUser(string Nuser)
        {
            // Obtener la lista de usuarios.
            var users_ = Users();

            // Buscar el usuario por nombre de usuario y devolverlo si se encuentra, de lo contrario, devolver un usuario especial para administración.
            return users_.FirstOrDefault(user => user.Name == Nuser) ?? new Usuario { DisplayName = "Administracion", Name = "root", Password = "root" };
        }




        /// <summary>
        /// Verifica si un usuario con el nombre de usuario especificado existe en la lista de usuarios.
        /// </summary>
        /// <param name="Nuser">El nombre de usuario que se va a verificar.</param>
        /// <returns>True si el usuario con el nombre de usuario especificado existe en la lista de usuarios, de lo contrario, False.</returns>
        public bool HasUser(string Nuser)
        {
            // Obtener la lista de usuarios y verificar si existe un usuario con el nombre de usuario especificado.
            var users = Users();
            return users.Any(user => user.Name == Nuser);
        }


    }




}
