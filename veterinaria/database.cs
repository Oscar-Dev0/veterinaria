
using Npgsql;


namespace veterinaria
{
    internal class database
    {

        //Datos de coneccion
        private static string Host = "postgresql-oscargamer.alwaysdata.net";
        private static string User = "oscargamer_veterinaria";
        private static string DBname = "oscargamer_veterinaria";
        private static string Password = "50gS0uLvDWYVP2jZPULCbDyV25esEEbu";
        private static string Port = "5432";

        // String de Coneccion
        private static string connString = String.Format( "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=Prefer", Host, User, DBname, Port, Password);

        public void Conection()
        {
            using (var conn = new NpgsqlConnection(connString)){
                conn.Open();
                return;
            }
        }

    }
}
