using veterinaria.src.functions;
using veterinaria.src.ITF;

namespace veterinaria
{
    // La clase Veterinaria_login representa la ventana de inicio de sesión de la aplicación.
    public partial class Veterinaria_login : Form
    {
        Database database;

        // Constructor de la clase Veterinaria_login.
        public Veterinaria_login(object s)
        {
            InitializeComponent();
            database = (Database)s;
        }

        // Evento que se dispara al cargar el formulario.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Código de inicialización (si lo hubiera).
        }

        // Evento que se dispara al hacer clic en el botón "Iniciar Sesión".
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los datos de usuario y contraseña ingresados por el usuario.
            var user = text_user.Text;
            var password = text_passwort.Text;

            // Obtener la lista de usuarios registrados en la base de datos.
            var user_db = database.FindUser(user);

            // Verificar las credenciales del usuario.
            if (user_db.Name == user && user_db.Password == password)
            {
                // Crear una instancia de la ventana principal y mostrarla.
                var data = new ITF_Consulta
                {
                    Doctor = user_db
                };

                var home = new consulta(database, data);
                this.Hide();
                home.ShowDialog();
                this.Dispose(true);
            }
            else
            {
                // Mostrar un mensaje de error si las credenciales son incorrectas.
                MessageBox.Show("Uno de los datos está mal ingresado.", "Error", 0, MessageBoxIcon.Error);
                return;

            }
        }
    }
}
