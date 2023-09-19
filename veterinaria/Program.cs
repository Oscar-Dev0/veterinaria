using veterinaria.src.functions;

namespace veterinaria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var data = new Database();
            data.Conection();
            Application.Run(new Veterinaria_login(data));
        }
    }
}