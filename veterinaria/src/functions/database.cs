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

        // Método para establecer la conexión a la base de datos.
        public void Conection()
        {
            try
            {
                data.Open();
                status = true;
            }
            catch
            {
                status = false;
            };
        }

        // Método para obtener la lista de usuarios desde la base de datos.
        public List<Usuario> users()
        {
            if (!status) return usuarios;
            if (status_user) return usuarios;
            var command = new NpgsqlCommand("SELECT * FROM \"public\".\"users\";", data);
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        DisplayName = reader.GetString(reader.GetOrdinal("display_name")),
                        Password = reader.GetString(reader.GetOrdinal("password")),
                    };

                    usuarios.Add(usuario);
                }
            }
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
