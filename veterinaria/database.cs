
using Npgsql;
using System.Xml.Linq;


namespace veterinaria
{
    internal class Database
    {

        //Datos de coneccion
        private static string Host = "postgresql-oscargamer.alwaysdata.net";
        private static string User = "oscargamer_veterinaria";
        private static string DBname = "oscargamer_veterinaria";
        private static string Password = "50gS0uLvDWYVP2jZPULCbDyV25esEEbu";
        private static string Port = "5432";

        //Base de datos estatico
        private static string connString = String.Format( "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=Prefer", Host, User, DBname, Port, Password);
        private NpgsqlConnection data = new NpgsqlConnection(connString);
        private bool status = false;

        // Cache
        private List<Usuario> usuarios = new List<Usuario>();
        private bool status_user = false;
        public void Conection()
        {
            try {
                data.Open();
                status = true;
            } catch {
                status = false;
            };
        }

        public List<Usuario> users()
        {
            if(!status) return usuarios;
            if(status_user) return usuarios;
            var command = new NpgsqlCommand("SELECT * FROM \"public\".\"users\";", data);
            using(NpgsqlDataReader reader = command.ExecuteReader())
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

    class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
    }
}
